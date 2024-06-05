/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAlphaKPI
		/// Description Add record
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3KPID">KPI ID (Required)</param>
		/// <param name="m3PK01">Primary key 1 (Required)</param>
		/// <param name="m3AL30">Alpha field 30 positions (Required)</param>
		/// <param name="m3PK02">Primary key 2</param>
		/// <param name="m3PK03">Primary key 3</param>
		/// <param name="m3PK04">Primary key 4</param>
		/// <param name="m3PK05">Primary key 5</param>
		/// <param name="m3PK06">Primary key 6</param>
		/// <param name="m3PK07">Primary key 7</param>
		/// <param name="m3PK08">Primary key 8</param>
		/// <param name="m3AL31">Alpha field 30 positions</param>
		/// <param name="m3AL32">Alpha field 30 positions</param>
		/// <param name="m3AL33">Alpha field 30 positions</param>
		/// <param name="m3AL34">Alpha field 30 positions</param>
		/// <param name="m3AL35">Alpha field 30 positions</param>
		/// <param name="m3AL36">Alpha field 30 positions</param>
		/// <param name="m3AL37">Alpha field 30 positions</param>
		/// <param name="m3AL38">Alpha field 30 positions</param>
		/// <param name="m3AL39">Alpha field 30 positions</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAlphaKPI(
			string m3KPID, 
			string m3PK01, 
			string m3AL30, 
			string m3PK02 = null, 
			string m3PK03 = null, 
			string m3PK04 = null, 
			string m3PK05 = null, 
			string m3PK06 = null, 
			string m3PK07 = null, 
			string m3PK08 = null, 
			string m3AL31 = null, 
			string m3AL32 = null, 
			string m3AL33 = null, 
			string m3AL34 = null, 
			string m3AL35 = null, 
			string m3AL36 = null, 
			string m3AL37 = null, 
			string m3AL38 = null, 
			string m3AL39 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddAlphaKPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3KPID))
				throw new ArgumentNullException(nameof(m3KPID));
			if (string.IsNullOrWhiteSpace(m3PK01))
				throw new ArgumentNullException(nameof(m3PK01));
			if (string.IsNullOrWhiteSpace(m3AL30))
				throw new ArgumentNullException(nameof(m3AL30));

			// Set mandatory parameters
			request
				.WithQueryParameter("KPID", m3KPID.Trim())
				.WithQueryParameter("PK01", m3PK01.Trim())
				.WithQueryParameter("AL30", m3AL30.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PK02))
				request.WithQueryParameter("PK02", m3PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK03))
				request.WithQueryParameter("PK03", m3PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK04))
				request.WithQueryParameter("PK04", m3PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK05))
				request.WithQueryParameter("PK05", m3PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK06))
				request.WithQueryParameter("PK06", m3PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK07))
				request.WithQueryParameter("PK07", m3PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK08))
				request.WithQueryParameter("PK08", m3PK08.Trim());
			if (!string.IsNullOrWhiteSpace(m3AL31))
				request.WithQueryParameter("AL31", m3AL31.Trim());
			if (!string.IsNullOrWhiteSpace(m3AL32))
				request.WithQueryParameter("AL32", m3AL32.Trim());
			if (!string.IsNullOrWhiteSpace(m3AL33))
				request.WithQueryParameter("AL33", m3AL33.Trim());
			if (!string.IsNullOrWhiteSpace(m3AL34))
				request.WithQueryParameter("AL34", m3AL34.Trim());
			if (!string.IsNullOrWhiteSpace(m3AL35))
				request.WithQueryParameter("AL35", m3AL35.Trim());
			if (!string.IsNullOrWhiteSpace(m3AL36))
				request.WithQueryParameter("AL36", m3AL36.Trim());
			if (!string.IsNullOrWhiteSpace(m3AL37))
				request.WithQueryParameter("AL37", m3AL37.Trim());
			if (!string.IsNullOrWhiteSpace(m3AL38))
				request.WithQueryParameter("AL38", m3AL38.Trim());
			if (!string.IsNullOrWhiteSpace(m3AL39))
				request.WithQueryParameter("AL39", m3AL39.Trim());

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
		/// Name AddFieldAttr
		/// Description Add field atrributes
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3CTGY">Category (Required)</param>
		/// <param name="m3FLDB">Field length (Required)</param>
		/// <param name="m3FLDP">Number of decimal places (Required)</param>
		/// <param name="m3FLUC">Upper case (Required)</param>
		/// <param name="m3TX15">Name (Required)</param>
		/// <param name="m3CUER">Customer extension reference</param>
		/// <param name="m3FLTE">Field type</param>
		/// <param name="m3TX05">Name</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="m3FHID">Field help ID</param>
		/// <param name="m3FLUL">Field Upper Limit</param>
		/// <param name="m3FLLL">Field Lower Limit</param>
		/// <param name="m3FLLM">Field Limit Multiple</param>
		/// <param name="m3ECDE">Edit code</param>
		/// <param name="m3NBMO">Check digit method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFieldAttr(
			string m3FILE, 
			string m3FLDI, 
			string m3CTGY, 
			int m3FLDB, 
			int m3FLDP, 
			int m3FLUC, 
			string m3TX15, 
			string m3CUER = null, 
			string m3FLTE = null, 
			string m3TX05 = null, 
			string m3TX40 = null, 
			string m3MSID = null, 
			string m3FHID = null, 
			decimal? m3FLUL = null, 
			decimal? m3FLLL = null, 
			decimal? m3FLLM = null, 
			string m3ECDE = null, 
			int? m3NBMO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddFieldAttr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));
			if (string.IsNullOrWhiteSpace(m3CTGY))
				throw new ArgumentNullException(nameof(m3CTGY));
			if (string.IsNullOrWhiteSpace(m3TX15))
				throw new ArgumentNullException(nameof(m3TX15));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim())
				.WithQueryParameter("CTGY", m3CTGY.Trim())
				.WithQueryParameter("FLDB", m3FLDB.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FLDP", m3FLDP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FLUC", m3FLUC.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TX15", m3TX15.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUER))
				request.WithQueryParameter("CUER", m3CUER.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLTE))
				request.WithQueryParameter("FLTE", m3FLTE.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX05))
				request.WithQueryParameter("TX05", m3TX05.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3FHID))
				request.WithQueryParameter("FHID", m3FHID.Trim());
			if (m3FLUL.HasValue)
				request.WithQueryParameter("FLUL", m3FLUL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLLL.HasValue)
				request.WithQueryParameter("FLLL", m3FLLL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLLM.HasValue)
				request.WithQueryParameter("FLLM", m3FLLM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECDE))
				request.WithQueryParameter("ECDE", m3ECDE.Trim());
			if (m3NBMO.HasValue)
				request.WithQueryParameter("NBMO", m3NBMO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddFieldVM
		/// Description Add Field Value Map
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3AL30">Alpha field 30 positions (Required)</param>
		/// <param name="m3TX15">Name (Required)</param>
		/// <param name="m3CUER">Customer extension reference</param>
		/// <param name="m3SEQN">Sequence number</param>
		/// <param name="m3TX05">Name</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFieldVM(
			string m3FILE, 
			string m3FLDI, 
			string m3AL30, 
			string m3TX15, 
			string m3CUER = null, 
			int? m3SEQN = null, 
			string m3TX05 = null, 
			string m3TX40 = null, 
			string m3MSID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddFieldVM",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));
			if (string.IsNullOrWhiteSpace(m3AL30))
				throw new ArgumentNullException(nameof(m3AL30));
			if (string.IsNullOrWhiteSpace(m3TX15))
				throw new ArgumentNullException(nameof(m3TX15));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim())
				.WithQueryParameter("AL30", m3AL30.Trim())
				.WithQueryParameter("TX15", m3TX15.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUER))
				request.WithQueryParameter("CUER", m3CUER.Trim());
			if (m3SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3SEQN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX05))
				request.WithQueryParameter("TX05", m3TX05.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());

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
		/// Name AddFieldValue
		/// Description Add record
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3PK01">Primary key 1 (Required)</param>
		/// <param name="m3PK02">Primary key 2</param>
		/// <param name="m3PK03">Primary key 3</param>
		/// <param name="m3PK04">Primary key 4</param>
		/// <param name="m3PK05">Primary key 5</param>
		/// <param name="m3PK06">Primary key 6</param>
		/// <param name="m3PK07">Primary key 7</param>
		/// <param name="m3PK08">Primary key 8</param>
		/// <param name="m3A030">Alpha field 30 positions</param>
		/// <param name="m3A130">Alpha field 30 positions</param>
		/// <param name="m3A230">Alpha field 30 positions</param>
		/// <param name="m3A330">Alpha field 30 positions</param>
		/// <param name="m3A430">Alpha field 30 positions</param>
		/// <param name="m3A530">Alpha field 30 positions</param>
		/// <param name="m3A630">Alpha field 30 positions</param>
		/// <param name="m3A730">Alpha field 30 positions</param>
		/// <param name="m3A830">Alpha field 30 positions</param>
		/// <param name="m3A930">Alpha field 30 positions</param>
		/// <param name="m3N096">Numeric field 19,6 positions</param>
		/// <param name="m3N196">Numeric field 19,6 positions</param>
		/// <param name="m3N296">Numeric field 19,6 positions</param>
		/// <param name="m3N396">Numeric field 19,6 positions</param>
		/// <param name="m3N496">Numeric field 19,6 positions</param>
		/// <param name="m3N596">Numeric field 19,6 positions</param>
		/// <param name="m3N696">Numeric field 19,6 positions</param>
		/// <param name="m3N796">Numeric field 19,6 positions</param>
		/// <param name="m3N896">Numeric field 19,6 positions</param>
		/// <param name="m3N996">Numeric field 19,6 positions</param>
		/// <param name="m3MIGR">Migrated</param>
		/// <param name="m3A121">Alphanumeric field 120 positions</param>
		/// <param name="m3VEXI">Do not validate if M3 record exist = 1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFieldValue(
			string m3FILE, 
			string m3PK01, 
			string m3PK02 = null, 
			string m3PK03 = null, 
			string m3PK04 = null, 
			string m3PK05 = null, 
			string m3PK06 = null, 
			string m3PK07 = null, 
			string m3PK08 = null, 
			string m3A030 = null, 
			string m3A130 = null, 
			string m3A230 = null, 
			string m3A330 = null, 
			string m3A430 = null, 
			string m3A530 = null, 
			string m3A630 = null, 
			string m3A730 = null, 
			string m3A830 = null, 
			string m3A930 = null, 
			decimal? m3N096 = null, 
			decimal? m3N196 = null, 
			decimal? m3N296 = null, 
			decimal? m3N396 = null, 
			decimal? m3N496 = null, 
			decimal? m3N596 = null, 
			decimal? m3N696 = null, 
			decimal? m3N796 = null, 
			decimal? m3N896 = null, 
			decimal? m3N996 = null, 
			int? m3MIGR = null, 
			string m3A121 = null, 
			int? m3VEXI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddFieldValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3PK01))
				throw new ArgumentNullException(nameof(m3PK01));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("PK01", m3PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PK02))
				request.WithQueryParameter("PK02", m3PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK03))
				request.WithQueryParameter("PK03", m3PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK04))
				request.WithQueryParameter("PK04", m3PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK05))
				request.WithQueryParameter("PK05", m3PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK06))
				request.WithQueryParameter("PK06", m3PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK07))
				request.WithQueryParameter("PK07", m3PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK08))
				request.WithQueryParameter("PK08", m3PK08.Trim());
			if (!string.IsNullOrWhiteSpace(m3A030))
				request.WithQueryParameter("A030", m3A030.Trim());
			if (!string.IsNullOrWhiteSpace(m3A130))
				request.WithQueryParameter("A130", m3A130.Trim());
			if (!string.IsNullOrWhiteSpace(m3A230))
				request.WithQueryParameter("A230", m3A230.Trim());
			if (!string.IsNullOrWhiteSpace(m3A330))
				request.WithQueryParameter("A330", m3A330.Trim());
			if (!string.IsNullOrWhiteSpace(m3A430))
				request.WithQueryParameter("A430", m3A430.Trim());
			if (!string.IsNullOrWhiteSpace(m3A530))
				request.WithQueryParameter("A530", m3A530.Trim());
			if (!string.IsNullOrWhiteSpace(m3A630))
				request.WithQueryParameter("A630", m3A630.Trim());
			if (!string.IsNullOrWhiteSpace(m3A730))
				request.WithQueryParameter("A730", m3A730.Trim());
			if (!string.IsNullOrWhiteSpace(m3A830))
				request.WithQueryParameter("A830", m3A830.Trim());
			if (!string.IsNullOrWhiteSpace(m3A930))
				request.WithQueryParameter("A930", m3A930.Trim());
			if (m3N096.HasValue)
				request.WithQueryParameter("N096", m3N096.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N196.HasValue)
				request.WithQueryParameter("N196", m3N196.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N296.HasValue)
				request.WithQueryParameter("N296", m3N296.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N396.HasValue)
				request.WithQueryParameter("N396", m3N396.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N496.HasValue)
				request.WithQueryParameter("N496", m3N496.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N596.HasValue)
				request.WithQueryParameter("N596", m3N596.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N696.HasValue)
				request.WithQueryParameter("N696", m3N696.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N796.HasValue)
				request.WithQueryParameter("N796", m3N796.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N896.HasValue)
				request.WithQueryParameter("N896", m3N896.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N996.HasValue)
				request.WithQueryParameter("N996", m3N996.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MIGR.HasValue)
				request.WithQueryParameter("MIGR", m3MIGR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3A121))
				request.WithQueryParameter("A121", m3A121.Trim());
			if (m3VEXI.HasValue)
				request.WithQueryParameter("VEXI", m3VEXI.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddNumericKPI
		/// Description Add numerical fields
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3KPID">KPI ID (Required)</param>
		/// <param name="m3PK01">Primary key 1 (Required)</param>
		/// <param name="m3N096">Numeric field 19,6 positions (Required)</param>
		/// <param name="m3PK02">Primary key 2</param>
		/// <param name="m3PK03">Primary key 3</param>
		/// <param name="m3PK04">Primary key 4</param>
		/// <param name="m3PK05">Primary key 5</param>
		/// <param name="m3PK06">Primary key 6</param>
		/// <param name="m3PK07">Primary key 7</param>
		/// <param name="m3PK08">Primary key 8</param>
		/// <param name="m3N196">Numeric field 19,6 positions</param>
		/// <param name="m3N296">Numeric field 19,6 positions</param>
		/// <param name="m3N396">Numeric field 19,6 positions</param>
		/// <param name="m3N496">Numeric field 19,6 positions</param>
		/// <param name="m3N596">Numeric field 19,6 positions</param>
		/// <param name="m3N696">Numeric field 19,6 positions</param>
		/// <param name="m3N796">Numeric field 19,6 positions</param>
		/// <param name="m3N896">Numeric field 19,6 positions</param>
		/// <param name="m3N996">Numeric field 19,6 positions</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddNumericKPI(
			string m3KPID, 
			string m3PK01, 
			decimal m3N096, 
			string m3PK02 = null, 
			string m3PK03 = null, 
			string m3PK04 = null, 
			string m3PK05 = null, 
			string m3PK06 = null, 
			string m3PK07 = null, 
			string m3PK08 = null, 
			decimal? m3N196 = null, 
			decimal? m3N296 = null, 
			decimal? m3N396 = null, 
			decimal? m3N496 = null, 
			decimal? m3N596 = null, 
			decimal? m3N696 = null, 
			decimal? m3N796 = null, 
			decimal? m3N896 = null, 
			decimal? m3N996 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddNumericKPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3KPID))
				throw new ArgumentNullException(nameof(m3KPID));
			if (string.IsNullOrWhiteSpace(m3PK01))
				throw new ArgumentNullException(nameof(m3PK01));

			// Set mandatory parameters
			request
				.WithQueryParameter("KPID", m3KPID.Trim())
				.WithQueryParameter("PK01", m3PK01.Trim())
				.WithQueryParameter("N096", m3N096.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PK02))
				request.WithQueryParameter("PK02", m3PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK03))
				request.WithQueryParameter("PK03", m3PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK04))
				request.WithQueryParameter("PK04", m3PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK05))
				request.WithQueryParameter("PK05", m3PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK06))
				request.WithQueryParameter("PK06", m3PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK07))
				request.WithQueryParameter("PK07", m3PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK08))
				request.WithQueryParameter("PK08", m3PK08.Trim());
			if (m3N196.HasValue)
				request.WithQueryParameter("N196", m3N196.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N296.HasValue)
				request.WithQueryParameter("N296", m3N296.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N396.HasValue)
				request.WithQueryParameter("N396", m3N396.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N496.HasValue)
				request.WithQueryParameter("N496", m3N496.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N596.HasValue)
				request.WithQueryParameter("N596", m3N596.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N696.HasValue)
				request.WithQueryParameter("N696", m3N696.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N796.HasValue)
				request.WithQueryParameter("N796", m3N796.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N896.HasValue)
				request.WithQueryParameter("N896", m3N896.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N996.HasValue)
				request.WithQueryParameter("N996", m3N996.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgAlphaKPI
		/// Description Change existing record
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3KPID">KPI ID (Required)</param>
		/// <param name="m3PK01">Primary key 1 (Required)</param>
		/// <param name="m3PK02">Primary key 2</param>
		/// <param name="m3PK03">Primary key 3</param>
		/// <param name="m3PK04">Primary key 4</param>
		/// <param name="m3PK05">Primary key 5</param>
		/// <param name="m3PK06">Primary key 6</param>
		/// <param name="m3PK07">Primary key 7</param>
		/// <param name="m3PK08">Primary key 8</param>
		/// <param name="m3AL30">Alpha field 30 positions</param>
		/// <param name="m3AL31">Alpha field 30 positions</param>
		/// <param name="m3AL32">Alpha field 30 positions</param>
		/// <param name="m3AL33">Alpha field 30 positions</param>
		/// <param name="m3AL34">Alpha field 30 positions</param>
		/// <param name="m3AL35">Alpha field 30 positions</param>
		/// <param name="m3AL36">Alpha field 30 positions</param>
		/// <param name="m3AL37">Alpha field 30 positions</param>
		/// <param name="m3AL38">Alpha field 30 positions</param>
		/// <param name="m3AL39">Alpha field 30 positions</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgAlphaKPI(
			string m3KPID, 
			string m3PK01, 
			string m3PK02 = null, 
			string m3PK03 = null, 
			string m3PK04 = null, 
			string m3PK05 = null, 
			string m3PK06 = null, 
			string m3PK07 = null, 
			string m3PK08 = null, 
			string m3AL30 = null, 
			string m3AL31 = null, 
			string m3AL32 = null, 
			string m3AL33 = null, 
			string m3AL34 = null, 
			string m3AL35 = null, 
			string m3AL36 = null, 
			string m3AL37 = null, 
			string m3AL38 = null, 
			string m3AL39 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgAlphaKPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3KPID))
				throw new ArgumentNullException(nameof(m3KPID));
			if (string.IsNullOrWhiteSpace(m3PK01))
				throw new ArgumentNullException(nameof(m3PK01));

			// Set mandatory parameters
			request
				.WithQueryParameter("KPID", m3KPID.Trim())
				.WithQueryParameter("PK01", m3PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PK02))
				request.WithQueryParameter("PK02", m3PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK03))
				request.WithQueryParameter("PK03", m3PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK04))
				request.WithQueryParameter("PK04", m3PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK05))
				request.WithQueryParameter("PK05", m3PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK06))
				request.WithQueryParameter("PK06", m3PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK07))
				request.WithQueryParameter("PK07", m3PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK08))
				request.WithQueryParameter("PK08", m3PK08.Trim());
			if (!string.IsNullOrWhiteSpace(m3AL30))
				request.WithQueryParameter("AL30", m3AL30.Trim());
			if (!string.IsNullOrWhiteSpace(m3AL31))
				request.WithQueryParameter("AL31", m3AL31.Trim());
			if (!string.IsNullOrWhiteSpace(m3AL32))
				request.WithQueryParameter("AL32", m3AL32.Trim());
			if (!string.IsNullOrWhiteSpace(m3AL33))
				request.WithQueryParameter("AL33", m3AL33.Trim());
			if (!string.IsNullOrWhiteSpace(m3AL34))
				request.WithQueryParameter("AL34", m3AL34.Trim());
			if (!string.IsNullOrWhiteSpace(m3AL35))
				request.WithQueryParameter("AL35", m3AL35.Trim());
			if (!string.IsNullOrWhiteSpace(m3AL36))
				request.WithQueryParameter("AL36", m3AL36.Trim());
			if (!string.IsNullOrWhiteSpace(m3AL37))
				request.WithQueryParameter("AL37", m3AL37.Trim());
			if (!string.IsNullOrWhiteSpace(m3AL38))
				request.WithQueryParameter("AL38", m3AL38.Trim());
			if (!string.IsNullOrWhiteSpace(m3AL39))
				request.WithQueryParameter("AL39", m3AL39.Trim());

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
		/// Name ChgFieldAttr
		/// Description Change Field Attributes
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3CUER">Customer extension reference</param>
		/// <param name="m3FLTE">Field type</param>
		/// <param name="m3CTGY">Category</param>
		/// <param name="m3FLDB">Field length</param>
		/// <param name="m3FLDP">Number of decimal places</param>
		/// <param name="m3FLUC">Upper Case</param>
		/// <param name="m3TX05">Name</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="m3FHID">Field help ID</param>
		/// <param name="m3FLUL">Field Upper Limit</param>
		/// <param name="m3FLLL">Field Lower Limit</param>
		/// <param name="m3FLLM">Field Limit Multiple</param>
		/// <param name="m3ECDE">Edit code</param>
		/// <param name="m3NBMO">Check digit method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgFieldAttr(
			string m3FILE, 
			string m3FLDI, 
			string m3CUER = null, 
			string m3FLTE = null, 
			string m3CTGY = null, 
			int? m3FLDB = null, 
			int? m3FLDP = null, 
			int? m3FLUC = null, 
			string m3TX05 = null, 
			string m3TX15 = null, 
			string m3TX40 = null, 
			string m3MSID = null, 
			string m3FHID = null, 
			decimal? m3FLUL = null, 
			decimal? m3FLLL = null, 
			decimal? m3FLLM = null, 
			string m3ECDE = null, 
			int? m3NBMO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgFieldAttr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUER))
				request.WithQueryParameter("CUER", m3CUER.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLTE))
				request.WithQueryParameter("FLTE", m3FLTE.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTGY))
				request.WithQueryParameter("CTGY", m3CTGY.Trim());
			if (m3FLDB.HasValue)
				request.WithQueryParameter("FLDB", m3FLDB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLDP.HasValue)
				request.WithQueryParameter("FLDP", m3FLDP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLUC.HasValue)
				request.WithQueryParameter("FLUC", m3FLUC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX05))
				request.WithQueryParameter("TX05", m3TX05.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3FHID))
				request.WithQueryParameter("FHID", m3FHID.Trim());
			if (m3FLUL.HasValue)
				request.WithQueryParameter("FLUL", m3FLUL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLLL.HasValue)
				request.WithQueryParameter("FLLL", m3FLLL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLLM.HasValue)
				request.WithQueryParameter("FLLM", m3FLLM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ECDE))
				request.WithQueryParameter("ECDE", m3ECDE.Trim());
			if (m3NBMO.HasValue)
				request.WithQueryParameter("NBMO", m3NBMO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgFieldVM
		/// Description Change Field Value Map
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3CUER">Customer extension reference (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3AL30">Alpha field 30 positions (Required)</param>
		/// <param name="m3SEQN">Sequence number (Required)</param>
		/// <param name="m3TX05">Name</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgFieldVM(
			string m3FILE, 
			string m3CUER, 
			string m3FLDI, 
			string m3AL30, 
			int m3SEQN, 
			string m3TX05 = null, 
			string m3TX15 = null, 
			string m3TX40 = null, 
			string m3MSID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgFieldVM",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3CUER))
				throw new ArgumentNullException(nameof(m3CUER));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));
			if (string.IsNullOrWhiteSpace(m3AL30))
				throw new ArgumentNullException(nameof(m3AL30));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("CUER", m3CUER.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim())
				.WithQueryParameter("AL30", m3AL30.Trim())
				.WithQueryParameter("SEQN", m3SEQN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX05))
				request.WithQueryParameter("TX05", m3TX05.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());

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
		/// Name ChgFieldValue
		/// Description Change record
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3PK01">Primary key 1 (Required)</param>
		/// <param name="m3PK02">Primary key 2</param>
		/// <param name="m3PK03">Primary key 3</param>
		/// <param name="m3PK04">Primary key 4</param>
		/// <param name="m3PK05">Primary key 5</param>
		/// <param name="m3PK06">Primary key 6</param>
		/// <param name="m3PK07">Primary key 7</param>
		/// <param name="m3PK08">Primary key 8</param>
		/// <param name="m3A030">Alpha field 30 positions</param>
		/// <param name="m3A130">Alpha field 30 positions</param>
		/// <param name="m3A230">Alpha field 30 positions</param>
		/// <param name="m3A330">Alpha field 30 positions</param>
		/// <param name="m3A430">Alpha field 30 positions</param>
		/// <param name="m3A530">Alpha field 30 positions</param>
		/// <param name="m3A630">Alpha field 30 positions</param>
		/// <param name="m3A730">Alpha field 30 positions</param>
		/// <param name="m3A830">Alpha field 30 positions</param>
		/// <param name="m3A930">Alpha field 30 positions</param>
		/// <param name="m3N096">Numeric field 19,6 positions</param>
		/// <param name="m3N196">Numeric field 19,6 positions</param>
		/// <param name="m3N296">Numeric field 19,6 positions</param>
		/// <param name="m3N396">Numeric field 19,6 positions</param>
		/// <param name="m3N496">Numeric field 19,6 positions</param>
		/// <param name="m3N596">Numeric field 19,6 positions</param>
		/// <param name="m3N696">Numeric field 19,6 positions</param>
		/// <param name="m3N796">Numeric field 19,6 positions</param>
		/// <param name="m3N896">Numeric field 19,6 positions</param>
		/// <param name="m3N996">Numeric field 19,6 positions</param>
		/// <param name="m3MIGR">Migrated</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3A121">Alphanumeric field 120 positions</param>
		/// <param name="m3VEXI">Do not validate if M3 record exist = 1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgFieldValue(
			string m3FILE, 
			string m3PK01, 
			string m3PK02 = null, 
			string m3PK03 = null, 
			string m3PK04 = null, 
			string m3PK05 = null, 
			string m3PK06 = null, 
			string m3PK07 = null, 
			string m3PK08 = null, 
			string m3A030 = null, 
			string m3A130 = null, 
			string m3A230 = null, 
			string m3A330 = null, 
			string m3A430 = null, 
			string m3A530 = null, 
			string m3A630 = null, 
			string m3A730 = null, 
			string m3A830 = null, 
			string m3A930 = null, 
			decimal? m3N096 = null, 
			decimal? m3N196 = null, 
			decimal? m3N296 = null, 
			decimal? m3N396 = null, 
			decimal? m3N496 = null, 
			decimal? m3N596 = null, 
			decimal? m3N696 = null, 
			decimal? m3N796 = null, 
			decimal? m3N896 = null, 
			decimal? m3N996 = null, 
			int? m3MIGR = null, 
			decimal? m3TXID = null, 
			string m3A121 = null, 
			int? m3VEXI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgFieldValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3PK01))
				throw new ArgumentNullException(nameof(m3PK01));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("PK01", m3PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PK02))
				request.WithQueryParameter("PK02", m3PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK03))
				request.WithQueryParameter("PK03", m3PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK04))
				request.WithQueryParameter("PK04", m3PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK05))
				request.WithQueryParameter("PK05", m3PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK06))
				request.WithQueryParameter("PK06", m3PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK07))
				request.WithQueryParameter("PK07", m3PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK08))
				request.WithQueryParameter("PK08", m3PK08.Trim());
			if (!string.IsNullOrWhiteSpace(m3A030))
				request.WithQueryParameter("A030", m3A030.Trim());
			if (!string.IsNullOrWhiteSpace(m3A130))
				request.WithQueryParameter("A130", m3A130.Trim());
			if (!string.IsNullOrWhiteSpace(m3A230))
				request.WithQueryParameter("A230", m3A230.Trim());
			if (!string.IsNullOrWhiteSpace(m3A330))
				request.WithQueryParameter("A330", m3A330.Trim());
			if (!string.IsNullOrWhiteSpace(m3A430))
				request.WithQueryParameter("A430", m3A430.Trim());
			if (!string.IsNullOrWhiteSpace(m3A530))
				request.WithQueryParameter("A530", m3A530.Trim());
			if (!string.IsNullOrWhiteSpace(m3A630))
				request.WithQueryParameter("A630", m3A630.Trim());
			if (!string.IsNullOrWhiteSpace(m3A730))
				request.WithQueryParameter("A730", m3A730.Trim());
			if (!string.IsNullOrWhiteSpace(m3A830))
				request.WithQueryParameter("A830", m3A830.Trim());
			if (!string.IsNullOrWhiteSpace(m3A930))
				request.WithQueryParameter("A930", m3A930.Trim());
			if (m3N096.HasValue)
				request.WithQueryParameter("N096", m3N096.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N196.HasValue)
				request.WithQueryParameter("N196", m3N196.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N296.HasValue)
				request.WithQueryParameter("N296", m3N296.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N396.HasValue)
				request.WithQueryParameter("N396", m3N396.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N496.HasValue)
				request.WithQueryParameter("N496", m3N496.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N596.HasValue)
				request.WithQueryParameter("N596", m3N596.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N696.HasValue)
				request.WithQueryParameter("N696", m3N696.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N796.HasValue)
				request.WithQueryParameter("N796", m3N796.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N896.HasValue)
				request.WithQueryParameter("N896", m3N896.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N996.HasValue)
				request.WithQueryParameter("N996", m3N996.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MIGR.HasValue)
				request.WithQueryParameter("MIGR", m3MIGR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3A121))
				request.WithQueryParameter("A121", m3A121.Trim());
			if (m3VEXI.HasValue)
				request.WithQueryParameter("VEXI", m3VEXI.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgFieldValueEx
		/// Description Add and change the extended fields of an existing record
		/// Version Release: 5ea5
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3PK01">Primary key 1 (Required)</param>
		/// <param name="m3PK02">Primary key 2</param>
		/// <param name="m3PK03">Primary key 3</param>
		/// <param name="m3PK04">Primary key 4</param>
		/// <param name="m3PK05">Primary key 5</param>
		/// <param name="m3PK06">Primary key 6</param>
		/// <param name="m3PK07">Primary key 7</param>
		/// <param name="m3PK08">Primary key 8</param>
		/// <param name="m3CHB1">Yes/no</param>
		/// <param name="m3CHB2">Yes/no</param>
		/// <param name="m3CHB3">Yes/no</param>
		/// <param name="m3CHB4">Yes/no</param>
		/// <param name="m3CHB5">Yes/no</param>
		/// <param name="m3CHB6">Yes/no</param>
		/// <param name="m3CHB7">Yes/no</param>
		/// <param name="m3CHB8">Yes/no</param>
		/// <param name="m3CHB9">Yes/no</param>
		/// <param name="m3DAT1">Ref field for date</param>
		/// <param name="m3DAT2">Ref field for date</param>
		/// <param name="m3DAT3">Ref field for date</param>
		/// <param name="m3DAT4">Ref field for date</param>
		/// <param name="m3DAT5">Ref field for date</param>
		/// <param name="m3DAT6">Ref field for date</param>
		/// <param name="m3DAT7">Ref field for date</param>
		/// <param name="m3DAT8">Ref field for date</param>
		/// <param name="m3DAT9">Ref field for date</param>
		/// <param name="m3A122">Alphanumeric field 120 positions</param>
		/// <param name="m3A256">Alphanumeric field 256 positions</param>
		/// <param name="m3VEXI">Do not validate if M3 record exist = 1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgFieldValueEx(
			string m3FILE, 
			string m3PK01, 
			string m3PK02 = null, 
			string m3PK03 = null, 
			string m3PK04 = null, 
			string m3PK05 = null, 
			string m3PK06 = null, 
			string m3PK07 = null, 
			string m3PK08 = null, 
			int? m3CHB1 = null, 
			int? m3CHB2 = null, 
			int? m3CHB3 = null, 
			int? m3CHB4 = null, 
			int? m3CHB5 = null, 
			int? m3CHB6 = null, 
			int? m3CHB7 = null, 
			int? m3CHB8 = null, 
			int? m3CHB9 = null, 
			DateTime? m3DAT1 = null, 
			DateTime? m3DAT2 = null, 
			DateTime? m3DAT3 = null, 
			DateTime? m3DAT4 = null, 
			DateTime? m3DAT5 = null, 
			DateTime? m3DAT6 = null, 
			DateTime? m3DAT7 = null, 
			DateTime? m3DAT8 = null, 
			DateTime? m3DAT9 = null, 
			string m3A122 = null, 
			string m3A256 = null, 
			int? m3VEXI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgFieldValueEx",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3PK01))
				throw new ArgumentNullException(nameof(m3PK01));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("PK01", m3PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PK02))
				request.WithQueryParameter("PK02", m3PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK03))
				request.WithQueryParameter("PK03", m3PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK04))
				request.WithQueryParameter("PK04", m3PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK05))
				request.WithQueryParameter("PK05", m3PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK06))
				request.WithQueryParameter("PK06", m3PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK07))
				request.WithQueryParameter("PK07", m3PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK08))
				request.WithQueryParameter("PK08", m3PK08.Trim());
			if (m3CHB1.HasValue)
				request.WithQueryParameter("CHB1", m3CHB1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHB2.HasValue)
				request.WithQueryParameter("CHB2", m3CHB2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHB3.HasValue)
				request.WithQueryParameter("CHB3", m3CHB3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHB4.HasValue)
				request.WithQueryParameter("CHB4", m3CHB4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHB5.HasValue)
				request.WithQueryParameter("CHB5", m3CHB5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHB6.HasValue)
				request.WithQueryParameter("CHB6", m3CHB6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHB7.HasValue)
				request.WithQueryParameter("CHB7", m3CHB7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHB8.HasValue)
				request.WithQueryParameter("CHB8", m3CHB8.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHB9.HasValue)
				request.WithQueryParameter("CHB9", m3CHB9.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DAT1.HasValue)
				request.WithQueryParameter("DAT1", m3DAT1.Value.ToM3String());
			if (m3DAT2.HasValue)
				request.WithQueryParameter("DAT2", m3DAT2.Value.ToM3String());
			if (m3DAT3.HasValue)
				request.WithQueryParameter("DAT3", m3DAT3.Value.ToM3String());
			if (m3DAT4.HasValue)
				request.WithQueryParameter("DAT4", m3DAT4.Value.ToM3String());
			if (m3DAT5.HasValue)
				request.WithQueryParameter("DAT5", m3DAT5.Value.ToM3String());
			if (m3DAT6.HasValue)
				request.WithQueryParameter("DAT6", m3DAT6.Value.ToM3String());
			if (m3DAT7.HasValue)
				request.WithQueryParameter("DAT7", m3DAT7.Value.ToM3String());
			if (m3DAT8.HasValue)
				request.WithQueryParameter("DAT8", m3DAT8.Value.ToM3String());
			if (m3DAT9.HasValue)
				request.WithQueryParameter("DAT9", m3DAT9.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3A122))
				request.WithQueryParameter("A122", m3A122.Trim());
			if (!string.IsNullOrWhiteSpace(m3A256))
				request.WithQueryParameter("A256", m3A256.Trim());
			if (m3VEXI.HasValue)
				request.WithQueryParameter("VEXI", m3VEXI.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgNumericKPI
		/// Description Change numerical fields
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3KPID">KPI ID (Required)</param>
		/// <param name="m3PK01">Primary key 1 (Required)</param>
		/// <param name="m3PK02">Primary key 2</param>
		/// <param name="m3PK03">Primary key 3</param>
		/// <param name="m3PK04">Primary key 4</param>
		/// <param name="m3PK05">Primary key 5</param>
		/// <param name="m3PK06">Primary key 6</param>
		/// <param name="m3PK07">Primary key 7</param>
		/// <param name="m3PK08">Primary key 8</param>
		/// <param name="m3N096">Numeric field 19,6 positions</param>
		/// <param name="m3N196">Numeric field 19,6 positions</param>
		/// <param name="m3N296">Numeric field 19,6 positions</param>
		/// <param name="m3N396">Numeric field 19,6 positions</param>
		/// <param name="m3N496">Numeric field 19,6 positions</param>
		/// <param name="m3N596">Numeric field 19,6 positions</param>
		/// <param name="m3N696">Numeric field 19,6 positions</param>
		/// <param name="m3N796">Numeric field 19,6 positions</param>
		/// <param name="m3N896">Numeric field 19,6 positions</param>
		/// <param name="m3N996">Numeric field 19,6 positions</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgNumericKPI(
			string m3KPID, 
			string m3PK01, 
			string m3PK02 = null, 
			string m3PK03 = null, 
			string m3PK04 = null, 
			string m3PK05 = null, 
			string m3PK06 = null, 
			string m3PK07 = null, 
			string m3PK08 = null, 
			decimal? m3N096 = null, 
			decimal? m3N196 = null, 
			decimal? m3N296 = null, 
			decimal? m3N396 = null, 
			decimal? m3N496 = null, 
			decimal? m3N596 = null, 
			decimal? m3N696 = null, 
			decimal? m3N796 = null, 
			decimal? m3N896 = null, 
			decimal? m3N996 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgNumericKPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3KPID))
				throw new ArgumentNullException(nameof(m3KPID));
			if (string.IsNullOrWhiteSpace(m3PK01))
				throw new ArgumentNullException(nameof(m3PK01));

			// Set mandatory parameters
			request
				.WithQueryParameter("KPID", m3KPID.Trim())
				.WithQueryParameter("PK01", m3PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PK02))
				request.WithQueryParameter("PK02", m3PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK03))
				request.WithQueryParameter("PK03", m3PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK04))
				request.WithQueryParameter("PK04", m3PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK05))
				request.WithQueryParameter("PK05", m3PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK06))
				request.WithQueryParameter("PK06", m3PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK07))
				request.WithQueryParameter("PK07", m3PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK08))
				request.WithQueryParameter("PK08", m3PK08.Trim());
			if (m3N096.HasValue)
				request.WithQueryParameter("N096", m3N096.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N196.HasValue)
				request.WithQueryParameter("N196", m3N196.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N296.HasValue)
				request.WithQueryParameter("N296", m3N296.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N396.HasValue)
				request.WithQueryParameter("N396", m3N396.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N496.HasValue)
				request.WithQueryParameter("N496", m3N496.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N596.HasValue)
				request.WithQueryParameter("N596", m3N596.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N696.HasValue)
				request.WithQueryParameter("N696", m3N696.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N796.HasValue)
				request.WithQueryParameter("N796", m3N796.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N896.HasValue)
				request.WithQueryParameter("N896", m3N896.Value.ToString(CultureInfo.CurrentCulture));
			if (m3N996.HasValue)
				request.WithQueryParameter("N996", m3N996.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name CpyFieldValue
		/// Description Copy record
		/// Version Release: 14
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3PK01">Fr Primary key 1 (Required)</param>
		/// <param name="m3TFIL">To table (Required)</param>
		/// <param name="m3PKT1">To Primary key 1 (Required)</param>
		/// <param name="m3PK02">Fr Primary key 2</param>
		/// <param name="m3PK03">Fr Primary key 3</param>
		/// <param name="m3PK04">Fr Primary key 4</param>
		/// <param name="m3PK05">Fr Primary key 5</param>
		/// <param name="m3PK06">Fr Primary key 6</param>
		/// <param name="m3PK07">Fr Primary key 7</param>
		/// <param name="m3PK08">Fr Primary key 8</param>
		/// <param name="m3PKT2">To Primary key 2</param>
		/// <param name="m3PKT3">To Primary key 3</param>
		/// <param name="m3PKT4">To Primary key 4</param>
		/// <param name="m3PKT5">To Primary key 5</param>
		/// <param name="m3PKT6">To Primary key 6</param>
		/// <param name="m3PKT7">To Primary key 7</param>
		/// <param name="m3PKT8">To Primary key 8</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyFieldValue(
			string m3FILE, 
			string m3PK01, 
			string m3TFIL, 
			string m3PKT1, 
			string m3PK02 = null, 
			string m3PK03 = null, 
			string m3PK04 = null, 
			string m3PK05 = null, 
			string m3PK06 = null, 
			string m3PK07 = null, 
			string m3PK08 = null, 
			string m3PKT2 = null, 
			string m3PKT3 = null, 
			string m3PKT4 = null, 
			string m3PKT5 = null, 
			string m3PKT6 = null, 
			string m3PKT7 = null, 
			string m3PKT8 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CpyFieldValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3PK01))
				throw new ArgumentNullException(nameof(m3PK01));
			if (string.IsNullOrWhiteSpace(m3TFIL))
				throw new ArgumentNullException(nameof(m3TFIL));
			if (string.IsNullOrWhiteSpace(m3PKT1))
				throw new ArgumentNullException(nameof(m3PKT1));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("PK01", m3PK01.Trim())
				.WithQueryParameter("TFIL", m3TFIL.Trim())
				.WithQueryParameter("PKT1", m3PKT1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PK02))
				request.WithQueryParameter("PK02", m3PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK03))
				request.WithQueryParameter("PK03", m3PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK04))
				request.WithQueryParameter("PK04", m3PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK05))
				request.WithQueryParameter("PK05", m3PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK06))
				request.WithQueryParameter("PK06", m3PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK07))
				request.WithQueryParameter("PK07", m3PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK08))
				request.WithQueryParameter("PK08", m3PK08.Trim());
			if (!string.IsNullOrWhiteSpace(m3PKT2))
				request.WithQueryParameter("PKT2", m3PKT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PKT3))
				request.WithQueryParameter("PKT3", m3PKT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3PKT4))
				request.WithQueryParameter("PKT4", m3PKT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3PKT5))
				request.WithQueryParameter("PKT5", m3PKT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3PKT6))
				request.WithQueryParameter("PKT6", m3PKT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3PKT7))
				request.WithQueryParameter("PKT7", m3PKT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3PKT8))
				request.WithQueryParameter("PKT8", m3PKT8.Trim());

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
		/// Name DelAlphaKPI
		/// Description Delete record
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3KPID">KPI ID (Required)</param>
		/// <param name="m3PK01">Primary key 1 (Required)</param>
		/// <param name="m3PK02">Primary key 2</param>
		/// <param name="m3PK03">Primary key 3</param>
		/// <param name="m3PK04">Primary key 4</param>
		/// <param name="m3PK05">Primary key 5</param>
		/// <param name="m3PK06">Primary key 6</param>
		/// <param name="m3PK07">Primary key 7</param>
		/// <param name="m3PK08">Primary key 8</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAlphaKPI(
			string m3KPID, 
			string m3PK01, 
			string m3PK02 = null, 
			string m3PK03 = null, 
			string m3PK04 = null, 
			string m3PK05 = null, 
			string m3PK06 = null, 
			string m3PK07 = null, 
			string m3PK08 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelAlphaKPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3KPID))
				throw new ArgumentNullException(nameof(m3KPID));
			if (string.IsNullOrWhiteSpace(m3PK01))
				throw new ArgumentNullException(nameof(m3PK01));

			// Set mandatory parameters
			request
				.WithQueryParameter("KPID", m3KPID.Trim())
				.WithQueryParameter("PK01", m3PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PK02))
				request.WithQueryParameter("PK02", m3PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK03))
				request.WithQueryParameter("PK03", m3PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK04))
				request.WithQueryParameter("PK04", m3PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK05))
				request.WithQueryParameter("PK05", m3PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK06))
				request.WithQueryParameter("PK06", m3PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK07))
				request.WithQueryParameter("PK07", m3PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK08))
				request.WithQueryParameter("PK08", m3PK08.Trim());

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
		/// Name DelFieldValue
		/// Description Delete record
		/// Version Release: 14
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3PK01">Primary key 1 (Required)</param>
		/// <param name="m3PK02">Primary key 2</param>
		/// <param name="m3PK03">Primary key 3</param>
		/// <param name="m3PK04">Primary key 4</param>
		/// <param name="m3PK05">Primary key 5</param>
		/// <param name="m3PK06">Primary key 6</param>
		/// <param name="m3PK07">Primary key 7</param>
		/// <param name="m3PK08">Primary key 8</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelFieldValue(
			string m3FILE, 
			string m3PK01, 
			string m3PK02 = null, 
			string m3PK03 = null, 
			string m3PK04 = null, 
			string m3PK05 = null, 
			string m3PK06 = null, 
			string m3PK07 = null, 
			string m3PK08 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelFieldValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3PK01))
				throw new ArgumentNullException(nameof(m3PK01));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("PK01", m3PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PK02))
				request.WithQueryParameter("PK02", m3PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK03))
				request.WithQueryParameter("PK03", m3PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK04))
				request.WithQueryParameter("PK04", m3PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK05))
				request.WithQueryParameter("PK05", m3PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK06))
				request.WithQueryParameter("PK06", m3PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK07))
				request.WithQueryParameter("PK07", m3PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK08))
				request.WithQueryParameter("PK08", m3PK08.Trim());

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
		/// Name DelNumericKPI
		/// Description Delete record
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3KPID">KPI ID (Required)</param>
		/// <param name="m3PK01">Primary key 1 (Required)</param>
		/// <param name="m3PK02">Primary key 2</param>
		/// <param name="m3PK03">Primary key 3</param>
		/// <param name="m3PK04">Primary key 4</param>
		/// <param name="m3PK05">Primary key 5</param>
		/// <param name="m3PK06">Primary key 6</param>
		/// <param name="m3PK07">Primary key 7</param>
		/// <param name="m3PK08">Primary key 8</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelNumericKPI(
			string m3KPID, 
			string m3PK01, 
			string m3PK02 = null, 
			string m3PK03 = null, 
			string m3PK04 = null, 
			string m3PK05 = null, 
			string m3PK06 = null, 
			string m3PK07 = null, 
			string m3PK08 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelNumericKPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3KPID))
				throw new ArgumentNullException(nameof(m3KPID));
			if (string.IsNullOrWhiteSpace(m3PK01))
				throw new ArgumentNullException(nameof(m3PK01));

			// Set mandatory parameters
			request
				.WithQueryParameter("KPID", m3KPID.Trim())
				.WithQueryParameter("PK01", m3PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PK02))
				request.WithQueryParameter("PK02", m3PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK03))
				request.WithQueryParameter("PK03", m3PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK04))
				request.WithQueryParameter("PK04", m3PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK05))
				request.WithQueryParameter("PK05", m3PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK06))
				request.WithQueryParameter("PK06", m3PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK07))
				request.WithQueryParameter("PK07", m3PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK08))
				request.WithQueryParameter("PK08", m3PK08.Trim());

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
		/// Name DltFieldAttr
		/// Description Delete Field Attributes
		/// Version Release: 14
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3CUER">Customer extension reference (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltFieldAttr(
			string m3FILE, 
			string m3CUER, 
			string m3FLDI, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltFieldAttr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3CUER))
				throw new ArgumentNullException(nameof(m3CUER));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("CUER", m3CUER.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim());

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
		/// Name DltFieldVM
		/// Description Delete Field Value Map
		/// Version Release: 14
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3CUER">Customer extension reference (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3AL30">Alpha field 30 positions (Required)</param>
		/// <param name="m3SEQN">Sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltFieldVM(
			string m3FILE, 
			string m3CUER, 
			string m3FLDI, 
			string m3AL30, 
			int m3SEQN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltFieldVM",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3CUER))
				throw new ArgumentNullException(nameof(m3CUER));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));
			if (string.IsNullOrWhiteSpace(m3AL30))
				throw new ArgumentNullException(nameof(m3AL30));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("CUER", m3CUER.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim())
				.WithQueryParameter("AL30", m3AL30.Trim())
				.WithQueryParameter("SEQN", m3SEQN.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetAlphaKPI
		/// Description Get single record
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3KPID">KPI ID (Required)</param>
		/// <param name="m3PK01">Primary key 1 (Required)</param>
		/// <param name="m3PK02">Primary key 2</param>
		/// <param name="m3PK03">Primary key 3</param>
		/// <param name="m3PK04">Primary key 4</param>
		/// <param name="m3PK05">Primary key 5</param>
		/// <param name="m3PK06">Primary key 6</param>
		/// <param name="m3PK07">Primary key 7</param>
		/// <param name="m3PK08">Primary key 8</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAlphaKPIResponse></returns>
		/// <exception cref="M3Exception<GetAlphaKPIResponse>"></exception>
		public async Task<M3Response<GetAlphaKPIResponse>> GetAlphaKPI(
			string m3KPID, 
			string m3PK01, 
			string m3PK02 = null, 
			string m3PK03 = null, 
			string m3PK04 = null, 
			string m3PK05 = null, 
			string m3PK06 = null, 
			string m3PK07 = null, 
			string m3PK08 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAlphaKPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3KPID))
				throw new ArgumentNullException(nameof(m3KPID));
			if (string.IsNullOrWhiteSpace(m3PK01))
				throw new ArgumentNullException(nameof(m3PK01));

			// Set mandatory parameters
			request
				.WithQueryParameter("KPID", m3KPID.Trim())
				.WithQueryParameter("PK01", m3PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PK02))
				request.WithQueryParameter("PK02", m3PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK03))
				request.WithQueryParameter("PK03", m3PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK04))
				request.WithQueryParameter("PK04", m3PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK05))
				request.WithQueryParameter("PK05", m3PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK06))
				request.WithQueryParameter("PK06", m3PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK07))
				request.WithQueryParameter("PK07", m3PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK08))
				request.WithQueryParameter("PK08", m3PK08.Trim());

			// Execute the request
			var result = await Execute<GetAlphaKPIResponse>(
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
		/// Name GetFieldAttr
		/// Description Get Field Attributes
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3CUER">Customer extension reference</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFieldAttrResponse></returns>
		/// <exception cref="M3Exception<GetFieldAttrResponse>"></exception>
		public async Task<M3Response<GetFieldAttrResponse>> GetFieldAttr(
			string m3FILE, 
			string m3FLDI, 
			string m3CUER = null, 
			string m3LNCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetFieldAttr",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUER))
				request.WithQueryParameter("CUER", m3CUER.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<GetFieldAttrResponse>(
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
		/// Name GetFieldVM
		/// Description Get Field Value Map
		/// Version Release: 14
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3CUER">Customer extension reference (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3AL30">Alpha field 30 positions (Required)</param>
		/// <param name="m3SEQN">Sequence number (Required)</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFieldVMResponse></returns>
		/// <exception cref="M3Exception<GetFieldVMResponse>"></exception>
		public async Task<M3Response<GetFieldVMResponse>> GetFieldVM(
			string m3FILE, 
			string m3CUER, 
			string m3FLDI, 
			string m3AL30, 
			int m3SEQN, 
			string m3LNCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetFieldVM",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3CUER))
				throw new ArgumentNullException(nameof(m3CUER));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));
			if (string.IsNullOrWhiteSpace(m3AL30))
				throw new ArgumentNullException(nameof(m3AL30));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("CUER", m3CUER.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim())
				.WithQueryParameter("AL30", m3AL30.Trim())
				.WithQueryParameter("SEQN", m3SEQN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<GetFieldVMResponse>(
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
		/// Name GetFieldValue
		/// Description Get record
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3PK01">Primary key 1 (Required)</param>
		/// <param name="m3PK02">Primary key 2</param>
		/// <param name="m3PK03">Primary key 3</param>
		/// <param name="m3PK04">Primary key 4</param>
		/// <param name="m3PK05">Primary key 5</param>
		/// <param name="m3PK06">Primary key 6</param>
		/// <param name="m3PK07">Primary key 7</param>
		/// <param name="m3PK08">Primary key 8</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFieldValueResponse></returns>
		/// <exception cref="M3Exception<GetFieldValueResponse>"></exception>
		public async Task<M3Response<GetFieldValueResponse>> GetFieldValue(
			string m3FILE, 
			string m3PK01, 
			string m3PK02 = null, 
			string m3PK03 = null, 
			string m3PK04 = null, 
			string m3PK05 = null, 
			string m3PK06 = null, 
			string m3PK07 = null, 
			string m3PK08 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetFieldValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3PK01))
				throw new ArgumentNullException(nameof(m3PK01));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("PK01", m3PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PK02))
				request.WithQueryParameter("PK02", m3PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK03))
				request.WithQueryParameter("PK03", m3PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK04))
				request.WithQueryParameter("PK04", m3PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK05))
				request.WithQueryParameter("PK05", m3PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK06))
				request.WithQueryParameter("PK06", m3PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK07))
				request.WithQueryParameter("PK07", m3PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK08))
				request.WithQueryParameter("PK08", m3PK08.Trim());

			// Execute the request
			var result = await Execute<GetFieldValueResponse>(
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
		/// Name GetFieldValueEx
		/// Description Get extended fields
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3PK01">Primary key 1 (Required)</param>
		/// <param name="m3PK02">Primary key 2</param>
		/// <param name="m3PK03">Primary key 3</param>
		/// <param name="m3PK04">Primary key 4</param>
		/// <param name="m3PK05">Primary key 5</param>
		/// <param name="m3PK06">Primary key 6</param>
		/// <param name="m3PK07">Primary key 7</param>
		/// <param name="m3PK08">Primary key 8</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFieldValueExResponse></returns>
		/// <exception cref="M3Exception<GetFieldValueExResponse>"></exception>
		public async Task<M3Response<GetFieldValueExResponse>> GetFieldValueEx(
			string m3FILE, 
			string m3PK01, 
			string m3PK02 = null, 
			string m3PK03 = null, 
			string m3PK04 = null, 
			string m3PK05 = null, 
			string m3PK06 = null, 
			string m3PK07 = null, 
			string m3PK08 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetFieldValueEx",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3PK01))
				throw new ArgumentNullException(nameof(m3PK01));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("PK01", m3PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PK02))
				request.WithQueryParameter("PK02", m3PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK03))
				request.WithQueryParameter("PK03", m3PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK04))
				request.WithQueryParameter("PK04", m3PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK05))
				request.WithQueryParameter("PK05", m3PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK06))
				request.WithQueryParameter("PK06", m3PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK07))
				request.WithQueryParameter("PK07", m3PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK08))
				request.WithQueryParameter("PK08", m3PK08.Trim());

			// Execute the request
			var result = await Execute<GetFieldValueExResponse>(
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
		/// Name GetNumericKPI
		/// Description Get data
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3KPID">KPI ID (Required)</param>
		/// <param name="m3PK01">Primary key 1 (Required)</param>
		/// <param name="m3PK02">Primary key 2</param>
		/// <param name="m3PK03">Primary key 3</param>
		/// <param name="m3PK04">Primary key 4</param>
		/// <param name="m3PK05">Primary key 5</param>
		/// <param name="m3PK06">Primary key 6</param>
		/// <param name="m3PK07">Primary key 7</param>
		/// <param name="m3PK08">Primary key 8</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetNumericKPIResponse></returns>
		/// <exception cref="M3Exception<GetNumericKPIResponse>"></exception>
		public async Task<M3Response<GetNumericKPIResponse>> GetNumericKPI(
			string m3KPID, 
			string m3PK01, 
			string m3PK02 = null, 
			string m3PK03 = null, 
			string m3PK04 = null, 
			string m3PK05 = null, 
			string m3PK06 = null, 
			string m3PK07 = null, 
			string m3PK08 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetNumericKPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3KPID))
				throw new ArgumentNullException(nameof(m3KPID));
			if (string.IsNullOrWhiteSpace(m3PK01))
				throw new ArgumentNullException(nameof(m3PK01));

			// Set mandatory parameters
			request
				.WithQueryParameter("KPID", m3KPID.Trim())
				.WithQueryParameter("PK01", m3PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PK02))
				request.WithQueryParameter("PK02", m3PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK03))
				request.WithQueryParameter("PK03", m3PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK04))
				request.WithQueryParameter("PK04", m3PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK05))
				request.WithQueryParameter("PK05", m3PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK06))
				request.WithQueryParameter("PK06", m3PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK07))
				request.WithQueryParameter("PK07", m3PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK08))
				request.WithQueryParameter("PK08", m3PK08.Trim());

			// Execute the request
			var result = await Execute<GetNumericKPIResponse>(
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
		/// Name LstAlphaKPI
		/// Description List records
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3KPID">KPI ID (Required)</param>
		/// <param name="m3PK01">Primary key 1</param>
		/// <param name="m3PK02">Primary key 2</param>
		/// <param name="m3PK03">Primary key 3</param>
		/// <param name="m3PK04">Primary key 4</param>
		/// <param name="m3PK05">Primary key 5</param>
		/// <param name="m3PK06">Primary key 6</param>
		/// <param name="m3PK07">Primary key 7</param>
		/// <param name="m3PK08">Primary key 8</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAlphaKPIResponse></returns>
		/// <exception cref="M3Exception<LstAlphaKPIResponse>"></exception>
		public async Task<M3Response<LstAlphaKPIResponse>> LstAlphaKPI(
			string m3KPID, 
			string m3PK01 = null, 
			string m3PK02 = null, 
			string m3PK03 = null, 
			string m3PK04 = null, 
			string m3PK05 = null, 
			string m3PK06 = null, 
			string m3PK07 = null, 
			string m3PK08 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAlphaKPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3KPID))
				throw new ArgumentNullException(nameof(m3KPID));

			// Set mandatory parameters
			request
				.WithQueryParameter("KPID", m3KPID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PK01))
				request.WithQueryParameter("PK01", m3PK01.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK02))
				request.WithQueryParameter("PK02", m3PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK03))
				request.WithQueryParameter("PK03", m3PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK04))
				request.WithQueryParameter("PK04", m3PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK05))
				request.WithQueryParameter("PK05", m3PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK06))
				request.WithQueryParameter("PK06", m3PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK07))
				request.WithQueryParameter("PK07", m3PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK08))
				request.WithQueryParameter("PK08", m3PK08.Trim());

			// Execute the request
			var result = await Execute<LstAlphaKPIResponse>(
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
		/// Name LstFieldAttr
		/// Description List Field Attributes
		/// Version Release: 14
		/// </summary>
		/// <param name="m3FILE">Table</param>
		/// <param name="m3CUER">Customer extension reference</param>
		/// <param name="m3FLDI">Field</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFieldAttrResponse></returns>
		/// <exception cref="M3Exception<LstFieldAttrResponse>"></exception>
		public async Task<M3Response<LstFieldAttrResponse>> LstFieldAttr(
			string m3FILE = null, 
			string m3CUER = null, 
			string m3FLDI = null, 
			string m3LNCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstFieldAttr",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUER))
				request.WithQueryParameter("CUER", m3CUER.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<LstFieldAttrResponse>(
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
		/// Name LstFieldVM
		/// Description List Field Value Map
		/// Version Release: 14
		/// </summary>
		/// <param name="m3FILE">Table</param>
		/// <param name="m3CUER">Customer extension reference</param>
		/// <param name="m3FLDI">Field</param>
		/// <param name="m3AL30">Alpha field 30 positions</param>
		/// <param name="m3SEQN">Sequence number</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFieldVMResponse></returns>
		/// <exception cref="M3Exception<LstFieldVMResponse>"></exception>
		public async Task<M3Response<LstFieldVMResponse>> LstFieldVM(
			string m3FILE = null, 
			string m3CUER = null, 
			string m3FLDI = null, 
			string m3AL30 = null, 
			int? m3SEQN = null, 
			string m3LNCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstFieldVM",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUER))
				request.WithQueryParameter("CUER", m3CUER.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3AL30))
				request.WithQueryParameter("AL30", m3AL30.Trim());
			if (m3SEQN.HasValue)
				request.WithQueryParameter("SEQN", m3SEQN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

			// Execute the request
			var result = await Execute<LstFieldVMResponse>(
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
		/// Name LstFieldValue
		/// Description List record
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3PK01">Primary key 1 (Required)</param>
		/// <param name="m3PK02">Primary key 2</param>
		/// <param name="m3PK03">Primary key 3</param>
		/// <param name="m3PK04">Primary key 4</param>
		/// <param name="m3PK05">Primary key 5</param>
		/// <param name="m3PK06">Primary key 6</param>
		/// <param name="m3PK07">Primary key 7</param>
		/// <param name="m3PK08">Primary key 8</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFieldValueResponse></returns>
		/// <exception cref="M3Exception<LstFieldValueResponse>"></exception>
		public async Task<M3Response<LstFieldValueResponse>> LstFieldValue(
			string m3FILE, 
			string m3PK01, 
			string m3PK02 = null, 
			string m3PK03 = null, 
			string m3PK04 = null, 
			string m3PK05 = null, 
			string m3PK06 = null, 
			string m3PK07 = null, 
			string m3PK08 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstFieldValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3PK01))
				throw new ArgumentNullException(nameof(m3PK01));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("PK01", m3PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PK02))
				request.WithQueryParameter("PK02", m3PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK03))
				request.WithQueryParameter("PK03", m3PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK04))
				request.WithQueryParameter("PK04", m3PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK05))
				request.WithQueryParameter("PK05", m3PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK06))
				request.WithQueryParameter("PK06", m3PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK07))
				request.WithQueryParameter("PK07", m3PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK08))
				request.WithQueryParameter("PK08", m3PK08.Trim());

			// Execute the request
			var result = await Execute<LstFieldValueResponse>(
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
		/// Name LstNumericKPI
		/// Description List records
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3KPID">KPI ID (Required)</param>
		/// <param name="m3PK01">Primary key 1</param>
		/// <param name="m3PK02">Primary key 2</param>
		/// <param name="m3PK03">Primary key 3</param>
		/// <param name="m3PK04">Primary key 4</param>
		/// <param name="m3PK05">Primary key 5</param>
		/// <param name="m3PK06">Primary key 6</param>
		/// <param name="m3PK07">Primary key 7</param>
		/// <param name="m3PK08">Primary key 8</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstNumericKPIResponse></returns>
		/// <exception cref="M3Exception<LstNumericKPIResponse>"></exception>
		public async Task<M3Response<LstNumericKPIResponse>> LstNumericKPI(
			string m3KPID, 
			string m3PK01 = null, 
			string m3PK02 = null, 
			string m3PK03 = null, 
			string m3PK04 = null, 
			string m3PK05 = null, 
			string m3PK06 = null, 
			string m3PK07 = null, 
			string m3PK08 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstNumericKPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3KPID))
				throw new ArgumentNullException(nameof(m3KPID));

			// Set mandatory parameters
			request
				.WithQueryParameter("KPID", m3KPID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PK01))
				request.WithQueryParameter("PK01", m3PK01.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK02))
				request.WithQueryParameter("PK02", m3PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK03))
				request.WithQueryParameter("PK03", m3PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK04))
				request.WithQueryParameter("PK04", m3PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK05))
				request.WithQueryParameter("PK05", m3PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK06))
				request.WithQueryParameter("PK06", m3PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK07))
				request.WithQueryParameter("PK07", m3PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK08))
				request.WithQueryParameter("PK08", m3PK08.Trim());

			// Execute the request
			var result = await Execute<LstNumericKPIResponse>(
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
		/// Name MathFieldValue
		/// Description Caclulate numerical fields
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3PK01">Primary key 1 (Required)</param>
		/// <param name="m3PK02">Primary key 2</param>
		/// <param name="m3PK03">Primary key 3</param>
		/// <param name="m3PK04">Primary key 4</param>
		/// <param name="m3PK05">Primary key 5</param>
		/// <param name="m3PK06">Primary key 6</param>
		/// <param name="m3PK07">Primary key 7</param>
		/// <param name="m3PK08">Primary key 8</param>
		/// <param name="m3O096">Operator</param>
		/// <param name="m3N096">Numeric field 19,6 positions</param>
		/// <param name="m3O196">Operator</param>
		/// <param name="m3N196">Numeric field 19,6 positions</param>
		/// <param name="m3O296">Operator</param>
		/// <param name="m3N296">Numeric field 19,6 positions</param>
		/// <param name="m3O396">Operator</param>
		/// <param name="m3N396">Numeric field 19,6 positions</param>
		/// <param name="m3O496">Operator</param>
		/// <param name="m3N496">Numeric field 19,6 positions</param>
		/// <param name="m3O596">Operator</param>
		/// <param name="m3N596">Numeric field 19,6 positions</param>
		/// <param name="m3O696">Operator</param>
		/// <param name="m3N696">Numeric field 19,6 positions</param>
		/// <param name="m3O796">Operator</param>
		/// <param name="m3N796">Numeric field 19,6 positions</param>
		/// <param name="m3O896">Operator</param>
		/// <param name="m3N896">Numeric field 19,6 positions</param>
		/// <param name="m3O996">Operator</param>
		/// <param name="m3N996">Numeric field 19,6 positions</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> MathFieldValue(
			string m3FILE, 
			string m3PK01, 
			string m3PK02 = null, 
			string m3PK03 = null, 
			string m3PK04 = null, 
			string m3PK05 = null, 
			string m3PK06 = null, 
			string m3PK07 = null, 
			string m3PK08 = null, 
			string m3O096 = null, 
			decimal? m3N096 = null, 
			string m3O196 = null, 
			decimal? m3N196 = null, 
			string m3O296 = null, 
			decimal? m3N296 = null, 
			string m3O396 = null, 
			decimal? m3N396 = null, 
			string m3O496 = null, 
			decimal? m3N496 = null, 
			string m3O596 = null, 
			decimal? m3N596 = null, 
			string m3O696 = null, 
			decimal? m3N696 = null, 
			string m3O796 = null, 
			decimal? m3N796 = null, 
			string m3O896 = null, 
			decimal? m3N896 = null, 
			string m3O996 = null, 
			decimal? m3N996 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/MathFieldValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3PK01))
				throw new ArgumentNullException(nameof(m3PK01));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("PK01", m3PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PK02))
				request.WithQueryParameter("PK02", m3PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK03))
				request.WithQueryParameter("PK03", m3PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK04))
				request.WithQueryParameter("PK04", m3PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK05))
				request.WithQueryParameter("PK05", m3PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK06))
				request.WithQueryParameter("PK06", m3PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK07))
				request.WithQueryParameter("PK07", m3PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK08))
				request.WithQueryParameter("PK08", m3PK08.Trim());
			if (!string.IsNullOrWhiteSpace(m3O096))
				request.WithQueryParameter("O096", m3O096.Trim());
			if (m3N096.HasValue)
				request.WithQueryParameter("N096", m3N096.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3O196))
				request.WithQueryParameter("O196", m3O196.Trim());
			if (m3N196.HasValue)
				request.WithQueryParameter("N196", m3N196.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3O296))
				request.WithQueryParameter("O296", m3O296.Trim());
			if (m3N296.HasValue)
				request.WithQueryParameter("N296", m3N296.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3O396))
				request.WithQueryParameter("O396", m3O396.Trim());
			if (m3N396.HasValue)
				request.WithQueryParameter("N396", m3N396.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3O496))
				request.WithQueryParameter("O496", m3O496.Trim());
			if (m3N496.HasValue)
				request.WithQueryParameter("N496", m3N496.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3O596))
				request.WithQueryParameter("O596", m3O596.Trim());
			if (m3N596.HasValue)
				request.WithQueryParameter("N596", m3N596.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3O696))
				request.WithQueryParameter("O696", m3O696.Trim());
			if (m3N696.HasValue)
				request.WithQueryParameter("N696", m3N696.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3O796))
				request.WithQueryParameter("O796", m3O796.Trim());
			if (m3N796.HasValue)
				request.WithQueryParameter("N796", m3N796.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3O896))
				request.WithQueryParameter("O896", m3O896.Trim());
			if (m3N896.HasValue)
				request.WithQueryParameter("N896", m3N896.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3O996))
				request.WithQueryParameter("O996", m3O996.Trim());
			if (m3N996.HasValue)
				request.WithQueryParameter("N996", m3N996.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name MathNumericKPI
		/// Description Caclulate numerical fields
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3KPID">KPI ID (Required)</param>
		/// <param name="m3PK01">Primary key 1 (Required)</param>
		/// <param name="m3PK02">Primary key 2</param>
		/// <param name="m3PK03">Primary key 3</param>
		/// <param name="m3PK04">Primary key 4</param>
		/// <param name="m3PK05">Primary key 5</param>
		/// <param name="m3PK06">Primary key 6</param>
		/// <param name="m3PK07">Primary key 7</param>
		/// <param name="m3PK08">Primary key 8</param>
		/// <param name="m3O096">Operator</param>
		/// <param name="m3N096">Numeric field 19,6 positions</param>
		/// <param name="m3O196">Operator</param>
		/// <param name="m3N196">Numeric field 19,6 positions</param>
		/// <param name="m3O296">Operator</param>
		/// <param name="m3N296">Numeric field 19,6 positions</param>
		/// <param name="m3O396">Operator</param>
		/// <param name="m3N396">Numeric field 19,6 positions</param>
		/// <param name="m3O496">Operator</param>
		/// <param name="m3N496">Numeric field 19,6 positions</param>
		/// <param name="m3O596">Operator</param>
		/// <param name="m3N596">Numeric field 19,6 positions</param>
		/// <param name="m3O696">Operator</param>
		/// <param name="m3N696">Numeric field 19,6 positions</param>
		/// <param name="m3O796">Operator</param>
		/// <param name="m3N796">Numeric field 19,6 positions</param>
		/// <param name="m3O896">Operator</param>
		/// <param name="m3N896">Numeric field 19,6 positions</param>
		/// <param name="m3O996">Operator</param>
		/// <param name="m3N996">Numeric field 19,6 positions</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> MathNumericKPI(
			string m3KPID, 
			string m3PK01, 
			string m3PK02 = null, 
			string m3PK03 = null, 
			string m3PK04 = null, 
			string m3PK05 = null, 
			string m3PK06 = null, 
			string m3PK07 = null, 
			string m3PK08 = null, 
			string m3O096 = null, 
			decimal? m3N096 = null, 
			string m3O196 = null, 
			decimal? m3N196 = null, 
			string m3O296 = null, 
			decimal? m3N296 = null, 
			string m3O396 = null, 
			decimal? m3N396 = null, 
			string m3O496 = null, 
			decimal? m3N496 = null, 
			string m3O596 = null, 
			decimal? m3N596 = null, 
			string m3O696 = null, 
			decimal? m3N696 = null, 
			string m3O796 = null, 
			decimal? m3N796 = null, 
			string m3O896 = null, 
			decimal? m3N896 = null, 
			string m3O996 = null, 
			decimal? m3N996 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/MathNumericKPI",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3KPID))
				throw new ArgumentNullException(nameof(m3KPID));
			if (string.IsNullOrWhiteSpace(m3PK01))
				throw new ArgumentNullException(nameof(m3PK01));

			// Set mandatory parameters
			request
				.WithQueryParameter("KPID", m3KPID.Trim())
				.WithQueryParameter("PK01", m3PK01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PK02))
				request.WithQueryParameter("PK02", m3PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK03))
				request.WithQueryParameter("PK03", m3PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK04))
				request.WithQueryParameter("PK04", m3PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK05))
				request.WithQueryParameter("PK05", m3PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK06))
				request.WithQueryParameter("PK06", m3PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK07))
				request.WithQueryParameter("PK07", m3PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK08))
				request.WithQueryParameter("PK08", m3PK08.Trim());
			if (!string.IsNullOrWhiteSpace(m3O096))
				request.WithQueryParameter("O096", m3O096.Trim());
			if (m3N096.HasValue)
				request.WithQueryParameter("N096", m3N096.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3O196))
				request.WithQueryParameter("O196", m3O196.Trim());
			if (m3N196.HasValue)
				request.WithQueryParameter("N196", m3N196.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3O296))
				request.WithQueryParameter("O296", m3O296.Trim());
			if (m3N296.HasValue)
				request.WithQueryParameter("N296", m3N296.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3O396))
				request.WithQueryParameter("O396", m3O396.Trim());
			if (m3N396.HasValue)
				request.WithQueryParameter("N396", m3N396.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3O496))
				request.WithQueryParameter("O496", m3O496.Trim());
			if (m3N496.HasValue)
				request.WithQueryParameter("N496", m3N496.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3O596))
				request.WithQueryParameter("O596", m3O596.Trim());
			if (m3N596.HasValue)
				request.WithQueryParameter("N596", m3N596.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3O696))
				request.WithQueryParameter("O696", m3O696.Trim());
			if (m3N696.HasValue)
				request.WithQueryParameter("N696", m3N696.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3O796))
				request.WithQueryParameter("O796", m3O796.Trim());
			if (m3N796.HasValue)
				request.WithQueryParameter("N796", m3N796.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3O896))
				request.WithQueryParameter("O896", m3O896.Trim());
			if (m3N896.HasValue)
				request.WithQueryParameter("N896", m3N896.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3O996))
				request.WithQueryParameter("O996", m3O996.Trim());
			if (m3N996.HasValue)
				request.WithQueryParameter("N996", m3N996.Value.ToString(CultureInfo.CurrentCulture));

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
