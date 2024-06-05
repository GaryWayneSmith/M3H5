/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ECON">ECO number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_ECID">Change ID (Required)</param>
		/// <param name="m3_OLSI">Old subidentity (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_NWSI">New subidentity</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_ECEX">Change type</param>
		/// <param name="m3_STRT">Structure type</param>
		/// <param name="m3_NECV">New revision</param>
		/// <param name="m3_OSEQ">Old serial number</param>
		/// <param name="m3_OOPN">Old operation number</param>
		/// <param name="m3_DWPO">Drawing position</param>
		/// <param name="m3_NSEQ">New sequence number</param>
		/// <param name="m3_NOPN">New operation number</param>
		/// <param name="m3_NCNQ">Neq qty</param>
		/// <param name="m3_NPEU">New prod engineering UM</param>
		/// <param name="m3_NCCQ">New qty drawing</param>
		/// <param name="m3_NDWP">New drawing pos</param>
		/// <param name="m3_NWAP">New waste pct</param>
		/// <param name="m3_SIDI">Selection identity - comp</param>
		/// <param name="m3_SITI">Selection type - comp</param>
		/// <param name="m3_SIDQ">Selection identity - quantity</param>
		/// <param name="m3_SITQ">Selection type - quantity</param>
		/// <param name="m3_FORI">Formula result identity</param>
		/// <param name="m3_LGTH">Length</param>
		/// <param name="m3_WDTH">Width</param>
		/// <param name="m3_LWF1">Qty</param>
		/// <param name="m3_LWF2">Factor</param>
		/// <param name="m3_FPRJ">From project</param>
		/// <param name="m3_FSNO">From serial number</param>
		/// <param name="m3_FSQT">From on-hand balance</param>
		/// <param name="m3_DSP5">Flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_ECON, 
			int m3_PONR, 
			string m3_ECID, 
			string m3_OLSI, 
			int? m3_CONO = null, 
			string m3_NWSI = null, 
			string m3_FACI = null, 
			string m3_ECEX = null, 
			string m3_STRT = null, 
			string m3_NECV = null, 
			int? m3_OSEQ = null, 
			int? m3_OOPN = null, 
			string m3_DWPO = null, 
			int? m3_NSEQ = null, 
			int? m3_NOPN = null, 
			decimal? m3_NCNQ = null, 
			string m3_NPEU = null, 
			decimal? m3_NCCQ = null, 
			string m3_NDWP = null, 
			int? m3_NWAP = null, 
			string m3_SIDI = null, 
			int? m3_SITI = null, 
			string m3_SIDQ = null, 
			int? m3_SITQ = null, 
			string m3_FORI = null, 
			int? m3_LGTH = null, 
			int? m3_WDTH = null, 
			int? m3_LWF1 = null, 
			int? m3_LWF2 = null, 
			string m3_FPRJ = null, 
			string m3_FSNO = null, 
			decimal? m3_FSQT = null, 
			int? m3_DSP5 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ECON))
				throw new ArgumentNullException("m3_ECON");
			if (string.IsNullOrWhiteSpace(m3_ECID))
				throw new ArgumentNullException("m3_ECID");
			if (string.IsNullOrWhiteSpace(m3_OLSI))
				throw new ArgumentNullException("m3_OLSI");

			// Set mandatory parameters
			request
				.WithQueryParameter("ECON", m3_ECON.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("ECID", m3_ECID.Trim())
				.WithQueryParameter("OLSI", m3_OLSI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NWSI))
				request.WithQueryParameter("NWSI", m3_NWSI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECEX))
				request.WithQueryParameter("ECEX", m3_ECEX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NECV))
				request.WithQueryParameter("NECV", m3_NECV.Trim());
			if (m3_OSEQ.HasValue)
				request.WithQueryParameter("OSEQ", m3_OSEQ.Value.ToString());
			if (m3_OOPN.HasValue)
				request.WithQueryParameter("OOPN", m3_OOPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DWPO))
				request.WithQueryParameter("DWPO", m3_DWPO.Trim());
			if (m3_NSEQ.HasValue)
				request.WithQueryParameter("NSEQ", m3_NSEQ.Value.ToString());
			if (m3_NOPN.HasValue)
				request.WithQueryParameter("NOPN", m3_NOPN.Value.ToString());
			if (m3_NCNQ.HasValue)
				request.WithQueryParameter("NCNQ", m3_NCNQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NPEU))
				request.WithQueryParameter("NPEU", m3_NPEU.Trim());
			if (m3_NCCQ.HasValue)
				request.WithQueryParameter("NCCQ", m3_NCCQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NDWP))
				request.WithQueryParameter("NDWP", m3_NDWP.Trim());
			if (m3_NWAP.HasValue)
				request.WithQueryParameter("NWAP", m3_NWAP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SIDI))
				request.WithQueryParameter("SIDI", m3_SIDI.Trim());
			if (m3_SITI.HasValue)
				request.WithQueryParameter("SITI", m3_SITI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SIDQ))
				request.WithQueryParameter("SIDQ", m3_SIDQ.Trim());
			if (m3_SITQ.HasValue)
				request.WithQueryParameter("SITQ", m3_SITQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FORI))
				request.WithQueryParameter("FORI", m3_FORI.Trim());
			if (m3_LGTH.HasValue)
				request.WithQueryParameter("LGTH", m3_LGTH.Value.ToString());
			if (m3_WDTH.HasValue)
				request.WithQueryParameter("WDTH", m3_WDTH.Value.ToString());
			if (m3_LWF1.HasValue)
				request.WithQueryParameter("LWF1", m3_LWF1.Value.ToString());
			if (m3_LWF2.HasValue)
				request.WithQueryParameter("LWF2", m3_LWF2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FPRJ))
				request.WithQueryParameter("FPRJ", m3_FPRJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSNO))
				request.WithQueryParameter("FSNO", m3_FSNO.Trim());
			if (m3_FSQT.HasValue)
				request.WithQueryParameter("FSQT", m3_FSQT.Value.ToString());
			if (m3_DSP5.HasValue)
				request.WithQueryParameter("DSP5", m3_DSP5.Value.ToString());

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
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ECON">ECO no (Required)</param>
		/// <param name="m3_PONR">Line no (Required)</param>
		/// <param name="m3_CCON">ECO no (Required)</param>
		/// <param name="m3_CONR">Line no (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Copy(
			string m3_ECON, 
			int m3_PONR, 
			string m3_CCON, 
			int m3_CONR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Copy",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ECON))
				throw new ArgumentNullException("m3_ECON");
			if (string.IsNullOrWhiteSpace(m3_CCON))
				throw new ArgumentNullException("m3_CCON");

			// Set mandatory parameters
			request
				.WithQueryParameter("ECON", m3_ECON.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("CCON", m3_CCON.Trim())
				.WithQueryParameter("CONR", m3_CONR.ToString());

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
		/// Name Delete
		/// Description Delete
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ECON">ECO number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			long m3_ECON, 
			int m3_PONR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Delete",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("ECON", m3_ECON.ToString())
				.WithQueryParameter("PONR", m3_PONR.ToString());

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
		/// Name Get
		/// Description Get
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ECON">ECO number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_ECON, 
			int m3_PONR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ECON))
				throw new ArgumentNullException("m3_ECON");

			// Set mandatory parameters
			request
				.WithQueryParameter("ECON", m3_ECON.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name List
		/// Description List engineering change orders
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ECON">ECO number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3_ECON, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/List",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ECON))
				throw new ArgumentNullException("m3_ECON");

			// Set mandatory parameters
			request
				.WithQueryParameter("ECON", m3_ECON.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name Update
		/// Description Update
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ECON">ECO number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_NECV">New revision</param>
		/// <param name="m3_OLSI">Old subidentity</param>
		/// <param name="m3_OSEQ">Old serial number</param>
		/// <param name="m3_OOPN">Old operation number</param>
		/// <param name="m3_DWPO">Drawing position</param>
		/// <param name="m3_NWSI">New subidentity</param>
		/// <param name="m3_NSEQ">New sequence number</param>
		/// <param name="m3_NOPN">New operation number</param>
		/// <param name="m3_NCNQ">Neq qty</param>
		/// <param name="m3_NPEU">New prod engineering UM</param>
		/// <param name="m3_NCCQ">New qty drawing</param>
		/// <param name="m3_NDWP">New drawing pos</param>
		/// <param name="m3_NWAP">New waste pct</param>
		/// <param name="m3_SIDI">Selection identity - comp</param>
		/// <param name="m3_SITI">Selection type - comp</param>
		/// <param name="m3_SIDQ">Selection identity - quantity</param>
		/// <param name="m3_SITQ">Selection type - quantity</param>
		/// <param name="m3_FORI">Formula result identity</param>
		/// <param name="m3_LGTH">Length</param>
		/// <param name="m3_WDTH">Width</param>
		/// <param name="m3_LWF1">Qty</param>
		/// <param name="m3_LWF2">Factor</param>
		/// <param name="m3_FPRJ">From project</param>
		/// <param name="m3_FSNO">From serial number</param>
		/// <param name="m3_FSQT">From on-hand balance</param>
		/// <param name="m3_DSP5">Flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Update(
			string m3_ECON, 
			int m3_PONR, 
			int? m3_CONO = null, 
			string m3_NECV = null, 
			string m3_OLSI = null, 
			int? m3_OSEQ = null, 
			int? m3_OOPN = null, 
			string m3_DWPO = null, 
			string m3_NWSI = null, 
			int? m3_NSEQ = null, 
			int? m3_NOPN = null, 
			decimal? m3_NCNQ = null, 
			string m3_NPEU = null, 
			decimal? m3_NCCQ = null, 
			string m3_NDWP = null, 
			int? m3_NWAP = null, 
			string m3_SIDI = null, 
			int? m3_SITI = null, 
			string m3_SIDQ = null, 
			int? m3_SITQ = null, 
			string m3_FORI = null, 
			int? m3_LGTH = null, 
			int? m3_WDTH = null, 
			int? m3_LWF1 = null, 
			int? m3_LWF2 = null, 
			string m3_FPRJ = null, 
			string m3_FSNO = null, 
			decimal? m3_FSQT = null, 
			int? m3_DSP5 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ECON))
				throw new ArgumentNullException("m3_ECON");

			// Set mandatory parameters
			request
				.WithQueryParameter("ECON", m3_ECON.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NECV))
				request.WithQueryParameter("NECV", m3_NECV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OLSI))
				request.WithQueryParameter("OLSI", m3_OLSI.Trim());
			if (m3_OSEQ.HasValue)
				request.WithQueryParameter("OSEQ", m3_OSEQ.Value.ToString());
			if (m3_OOPN.HasValue)
				request.WithQueryParameter("OOPN", m3_OOPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DWPO))
				request.WithQueryParameter("DWPO", m3_DWPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NWSI))
				request.WithQueryParameter("NWSI", m3_NWSI.Trim());
			if (m3_NSEQ.HasValue)
				request.WithQueryParameter("NSEQ", m3_NSEQ.Value.ToString());
			if (m3_NOPN.HasValue)
				request.WithQueryParameter("NOPN", m3_NOPN.Value.ToString());
			if (m3_NCNQ.HasValue)
				request.WithQueryParameter("NCNQ", m3_NCNQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NPEU))
				request.WithQueryParameter("NPEU", m3_NPEU.Trim());
			if (m3_NCCQ.HasValue)
				request.WithQueryParameter("NCCQ", m3_NCCQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NDWP))
				request.WithQueryParameter("NDWP", m3_NDWP.Trim());
			if (m3_NWAP.HasValue)
				request.WithQueryParameter("NWAP", m3_NWAP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SIDI))
				request.WithQueryParameter("SIDI", m3_SIDI.Trim());
			if (m3_SITI.HasValue)
				request.WithQueryParameter("SITI", m3_SITI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SIDQ))
				request.WithQueryParameter("SIDQ", m3_SIDQ.Trim());
			if (m3_SITQ.HasValue)
				request.WithQueryParameter("SITQ", m3_SITQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FORI))
				request.WithQueryParameter("FORI", m3_FORI.Trim());
			if (m3_LGTH.HasValue)
				request.WithQueryParameter("LGTH", m3_LGTH.Value.ToString());
			if (m3_WDTH.HasValue)
				request.WithQueryParameter("WDTH", m3_WDTH.Value.ToString());
			if (m3_LWF1.HasValue)
				request.WithQueryParameter("LWF1", m3_LWF1.Value.ToString());
			if (m3_LWF2.HasValue)
				request.WithQueryParameter("LWF2", m3_LWF2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FPRJ))
				request.WithQueryParameter("FPRJ", m3_FPRJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSNO))
				request.WithQueryParameter("FSNO", m3_FSNO.Trim());
			if (m3_FSQT.HasValue)
				request.WithQueryParameter("FSQT", m3_FSQT.Value.ToString());
			if (m3_DSP5.HasValue)
				request.WithQueryParameter("DSP5", m3_DSP5.Value.ToString());

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
