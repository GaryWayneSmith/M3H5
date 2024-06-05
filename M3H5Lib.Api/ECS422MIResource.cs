/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.ECS422MI;
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
	/// Name: ECS422MI
	/// Component Name: Engineering change order detai
	/// Description: Engineering change order detail
	/// Version Release: 5ea0
	///</summary>
	public partial class ECS422MIResource : M3BaseResourceEndpoint
	{
		public ECS422MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "ECS422MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ECON">ECO number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3ECID">Change ID (Required)</param>
		/// <param name="m3OLSI">Old subidentity (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3NWSI">New subidentity</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3ECEX">Change type</param>
		/// <param name="m3STRT">Structure type</param>
		/// <param name="m3NECV">New revision</param>
		/// <param name="m3OSEQ">Old serial number</param>
		/// <param name="m3OOPN">Old operation number</param>
		/// <param name="m3DWPO">Drawing position</param>
		/// <param name="m3NSEQ">New sequence number</param>
		/// <param name="m3NOPN">New operation number</param>
		/// <param name="m3NCNQ">Neq qty</param>
		/// <param name="m3NPEU">New prod engineering UM</param>
		/// <param name="m3NCCQ">New qty drawing</param>
		/// <param name="m3NDWP">New drawing pos</param>
		/// <param name="m3NWAP">New waste pct</param>
		/// <param name="m3SIDI">Selection identity - comp</param>
		/// <param name="m3SITI">Selection type - comp</param>
		/// <param name="m3SIDQ">Selection identity - quantity</param>
		/// <param name="m3SITQ">Selection type - quantity</param>
		/// <param name="m3FORI">Formula result identity</param>
		/// <param name="m3LGTH">Length</param>
		/// <param name="m3WDTH">Width</param>
		/// <param name="m3LWF1">Qty</param>
		/// <param name="m3LWF2">Factor</param>
		/// <param name="m3FPRJ">From project</param>
		/// <param name="m3FSNO">From serial number</param>
		/// <param name="m3FSQT">From on-hand balance</param>
		/// <param name="m3DSP5">Flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3ECON, 
			int m3PONR, 
			string m3ECID, 
			string m3OLSI, 
			int? m3CONO = null, 
			string m3NWSI = null, 
			string m3FACI = null, 
			string m3ECEX = null, 
			string m3STRT = null, 
			string m3NECV = null, 
			int? m3OSEQ = null, 
			int? m3OOPN = null, 
			string m3DWPO = null, 
			int? m3NSEQ = null, 
			int? m3NOPN = null, 
			decimal? m3NCNQ = null, 
			string m3NPEU = null, 
			decimal? m3NCCQ = null, 
			string m3NDWP = null, 
			int? m3NWAP = null, 
			string m3SIDI = null, 
			int? m3SITI = null, 
			string m3SIDQ = null, 
			int? m3SITQ = null, 
			string m3FORI = null, 
			int? m3LGTH = null, 
			int? m3WDTH = null, 
			int? m3LWF1 = null, 
			int? m3LWF2 = null, 
			string m3FPRJ = null, 
			string m3FSNO = null, 
			decimal? m3FSQT = null, 
			int? m3DSP5 = null, 
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
			if (string.IsNullOrWhiteSpace(m3ECON))
				throw new ArgumentNullException(nameof(m3ECON));
			if (string.IsNullOrWhiteSpace(m3ECID))
				throw new ArgumentNullException(nameof(m3ECID));
			if (string.IsNullOrWhiteSpace(m3OLSI))
				throw new ArgumentNullException(nameof(m3OLSI));

			// Set mandatory parameters
			request
				.WithQueryParameter("ECON", m3ECON.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ECID", m3ECID.Trim())
				.WithQueryParameter("OLSI", m3OLSI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NWSI))
				request.WithQueryParameter("NWSI", m3NWSI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECEX))
				request.WithQueryParameter("ECEX", m3ECEX.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3NECV))
				request.WithQueryParameter("NECV", m3NECV.Trim());
			if (m3OSEQ.HasValue)
				request.WithQueryParameter("OSEQ", m3OSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OOPN.HasValue)
				request.WithQueryParameter("OOPN", m3OOPN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DWPO))
				request.WithQueryParameter("DWPO", m3DWPO.Trim());
			if (m3NSEQ.HasValue)
				request.WithQueryParameter("NSEQ", m3NSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NOPN.HasValue)
				request.WithQueryParameter("NOPN", m3NOPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NCNQ.HasValue)
				request.WithQueryParameter("NCNQ", m3NCNQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NPEU))
				request.WithQueryParameter("NPEU", m3NPEU.Trim());
			if (m3NCCQ.HasValue)
				request.WithQueryParameter("NCCQ", m3NCCQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NDWP))
				request.WithQueryParameter("NDWP", m3NDWP.Trim());
			if (m3NWAP.HasValue)
				request.WithQueryParameter("NWAP", m3NWAP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SIDI))
				request.WithQueryParameter("SIDI", m3SIDI.Trim());
			if (m3SITI.HasValue)
				request.WithQueryParameter("SITI", m3SITI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SIDQ))
				request.WithQueryParameter("SIDQ", m3SIDQ.Trim());
			if (m3SITQ.HasValue)
				request.WithQueryParameter("SITQ", m3SITQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FORI))
				request.WithQueryParameter("FORI", m3FORI.Trim());
			if (m3LGTH.HasValue)
				request.WithQueryParameter("LGTH", m3LGTH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WDTH.HasValue)
				request.WithQueryParameter("WDTH", m3WDTH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LWF1.HasValue)
				request.WithQueryParameter("LWF1", m3LWF1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LWF2.HasValue)
				request.WithQueryParameter("LWF2", m3LWF2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FPRJ))
				request.WithQueryParameter("FPRJ", m3FPRJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSNO))
				request.WithQueryParameter("FSNO", m3FSNO.Trim());
			if (m3FSQT.HasValue)
				request.WithQueryParameter("FSQT", m3FSQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP5.HasValue)
				request.WithQueryParameter("DSP5", m3DSP5.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ECON">ECO no (Required)</param>
		/// <param name="m3PONR">Line no (Required)</param>
		/// <param name="m3CCON">ECO no (Required)</param>
		/// <param name="m3CONR">Line no (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Copy(
			string m3ECON, 
			int m3PONR, 
			string m3CCON, 
			int m3CONR, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Copy",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ECON))
				throw new ArgumentNullException(nameof(m3ECON));
			if (string.IsNullOrWhiteSpace(m3CCON))
				throw new ArgumentNullException(nameof(m3CCON));

			// Set mandatory parameters
			request
				.WithQueryParameter("ECON", m3ECON.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CCON", m3CCON.Trim())
				.WithQueryParameter("CONR", m3CONR.ToString(CultureInfo.CurrentCulture));

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
		/// Name Delete
		/// Description Delete
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ECON">ECO number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			long m3ECON, 
			int m3PONR, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Delete",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("ECON", m3ECON.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture));

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
		/// Name Get
		/// Description Get
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ECON">ECO number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3ECON, 
			int m3PONR, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ECON))
				throw new ArgumentNullException(nameof(m3ECON));

			// Set mandatory parameters
			request
				.WithQueryParameter("ECON", m3ECON.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name List
		/// Description List engineering change orders
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ECON">ECO number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3ECON, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/List",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ECON))
				throw new ArgumentNullException(nameof(m3ECON));

			// Set mandatory parameters
			request
				.WithQueryParameter("ECON", m3ECON.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Update
		/// Description Update
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ECON">ECO number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3NECV">New revision</param>
		/// <param name="m3OLSI">Old subidentity</param>
		/// <param name="m3OSEQ">Old serial number</param>
		/// <param name="m3OOPN">Old operation number</param>
		/// <param name="m3DWPO">Drawing position</param>
		/// <param name="m3NWSI">New subidentity</param>
		/// <param name="m3NSEQ">New sequence number</param>
		/// <param name="m3NOPN">New operation number</param>
		/// <param name="m3NCNQ">Neq qty</param>
		/// <param name="m3NPEU">New prod engineering UM</param>
		/// <param name="m3NCCQ">New qty drawing</param>
		/// <param name="m3NDWP">New drawing pos</param>
		/// <param name="m3NWAP">New waste pct</param>
		/// <param name="m3SIDI">Selection identity - comp</param>
		/// <param name="m3SITI">Selection type - comp</param>
		/// <param name="m3SIDQ">Selection identity - quantity</param>
		/// <param name="m3SITQ">Selection type - quantity</param>
		/// <param name="m3FORI">Formula result identity</param>
		/// <param name="m3LGTH">Length</param>
		/// <param name="m3WDTH">Width</param>
		/// <param name="m3LWF1">Qty</param>
		/// <param name="m3LWF2">Factor</param>
		/// <param name="m3FPRJ">From project</param>
		/// <param name="m3FSNO">From serial number</param>
		/// <param name="m3FSQT">From on-hand balance</param>
		/// <param name="m3DSP5">Flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Update(
			string m3ECON, 
			int m3PONR, 
			int? m3CONO = null, 
			string m3NECV = null, 
			string m3OLSI = null, 
			int? m3OSEQ = null, 
			int? m3OOPN = null, 
			string m3DWPO = null, 
			string m3NWSI = null, 
			int? m3NSEQ = null, 
			int? m3NOPN = null, 
			decimal? m3NCNQ = null, 
			string m3NPEU = null, 
			decimal? m3NCCQ = null, 
			string m3NDWP = null, 
			int? m3NWAP = null, 
			string m3SIDI = null, 
			int? m3SITI = null, 
			string m3SIDQ = null, 
			int? m3SITQ = null, 
			string m3FORI = null, 
			int? m3LGTH = null, 
			int? m3WDTH = null, 
			int? m3LWF1 = null, 
			int? m3LWF2 = null, 
			string m3FPRJ = null, 
			string m3FSNO = null, 
			decimal? m3FSQT = null, 
			int? m3DSP5 = null, 
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
			if (string.IsNullOrWhiteSpace(m3ECON))
				throw new ArgumentNullException(nameof(m3ECON));

			// Set mandatory parameters
			request
				.WithQueryParameter("ECON", m3ECON.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NECV))
				request.WithQueryParameter("NECV", m3NECV.Trim());
			if (!string.IsNullOrWhiteSpace(m3OLSI))
				request.WithQueryParameter("OLSI", m3OLSI.Trim());
			if (m3OSEQ.HasValue)
				request.WithQueryParameter("OSEQ", m3OSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OOPN.HasValue)
				request.WithQueryParameter("OOPN", m3OOPN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DWPO))
				request.WithQueryParameter("DWPO", m3DWPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3NWSI))
				request.WithQueryParameter("NWSI", m3NWSI.Trim());
			if (m3NSEQ.HasValue)
				request.WithQueryParameter("NSEQ", m3NSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NOPN.HasValue)
				request.WithQueryParameter("NOPN", m3NOPN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NCNQ.HasValue)
				request.WithQueryParameter("NCNQ", m3NCNQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NPEU))
				request.WithQueryParameter("NPEU", m3NPEU.Trim());
			if (m3NCCQ.HasValue)
				request.WithQueryParameter("NCCQ", m3NCCQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NDWP))
				request.WithQueryParameter("NDWP", m3NDWP.Trim());
			if (m3NWAP.HasValue)
				request.WithQueryParameter("NWAP", m3NWAP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SIDI))
				request.WithQueryParameter("SIDI", m3SIDI.Trim());
			if (m3SITI.HasValue)
				request.WithQueryParameter("SITI", m3SITI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SIDQ))
				request.WithQueryParameter("SIDQ", m3SIDQ.Trim());
			if (m3SITQ.HasValue)
				request.WithQueryParameter("SITQ", m3SITQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FORI))
				request.WithQueryParameter("FORI", m3FORI.Trim());
			if (m3LGTH.HasValue)
				request.WithQueryParameter("LGTH", m3LGTH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WDTH.HasValue)
				request.WithQueryParameter("WDTH", m3WDTH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LWF1.HasValue)
				request.WithQueryParameter("LWF1", m3LWF1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LWF2.HasValue)
				request.WithQueryParameter("LWF2", m3LWF2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FPRJ))
				request.WithQueryParameter("FPRJ", m3FPRJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSNO))
				request.WithQueryParameter("FSNO", m3FSNO.Trim());
			if (m3FSQT.HasValue)
				request.WithQueryParameter("FSQT", m3FSQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSP5.HasValue)
				request.WithQueryParameter("DSP5", m3DSP5.Value.ToString(CultureInfo.CurrentCulture));

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
