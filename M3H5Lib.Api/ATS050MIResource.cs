/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.ATS050MI;
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
	/// Name: ATS050MI
	/// Component Name: AttributeModel
	/// Description: Api: Attribute model
	/// Version Release: 14.x
	///</summary>
	public partial class ATS050MIResource : M3BaseResourceEndpoint
	{
		public ATS050MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "ATS050MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAttrModel
		/// Description This transaction adds attribute model
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATMO">Attribute model (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_PINO">GUI picture</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAttrModel(
			string m3_ATMO, 
			string m3_TX40, 
			string m3_TX15 = null, 
			string m3_PINO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAttrModel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATMO))
				throw new ArgumentNullException("m3_ATMO");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATMO", m3_ATMO.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PINO))
				request.WithQueryParameter("PINO", m3_PINO.Trim());

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
		/// Name AddAttribute
		/// Description This transaction adds attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATMO">Attribute model (Required)</param>
		/// <param name="m3_ATID">Attribute identity (Required)</param>
		/// <param name="m3_ANSQ">Attribute sequence number</param>
		/// <param name="m3_DEVA">Default value</param>
		/// <param name="m3_ORIN">Incl Ln in CO</param>
		/// <param name="m3_ORIP">Incl Ln in PO</param>
		/// <param name="m3_ORIM">Incl Ln in MO</param>
		/// <param name="m3_ORIR">Incl Ln in DO</param>
		/// <param name="m3_ORIS">Incl Ln in WO</param>
		/// <param name="m3_ORIT">Include model line in MCO</param>
		/// <param name="m3_MAAT">Main attribute</param>
		/// <param name="m3_AATT">Allocation attribute</param>
		/// <param name="m3_OSAK">Stats key</param>
		/// <param name="m3_OSAA">Stats accumulator</param>
		/// <param name="m3_PLAT">Planning attribute</param>
		/// <param name="m3_CATR">Cost attribute</param>
		/// <param name="m3_PRII">Prt attr value</param>
		/// <param name="m3_PRFI">Prt attr info</param>
		/// <param name="m3_PRNL">Prt on new line</param>
		/// <param name="m3_PSEP">Prt separator</param>
		/// <param name="m3_PSPR">Prt sep prefix</param>
		/// <param name="m3_PSES">Prt sep suffix</param>
		/// <param name="m3_DSPG">Display group</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_DSPS">Display sequence</param>
		/// <param name="m3_DOPT">Display option</param>
		/// <param name="m3_SEAT">Default search attribute</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAttribute(
			string m3_ATMO, 
			string m3_ATID, 
			int? m3_ANSQ = null, 
			string m3_DEVA = null, 
			int? m3_ORIN = null, 
			int? m3_ORIP = null, 
			int? m3_ORIM = null, 
			int? m3_ORIR = null, 
			int? m3_ORIS = null, 
			int? m3_ORIT = null, 
			int? m3_MAAT = null, 
			int? m3_AATT = null, 
			int? m3_OSAK = null, 
			int? m3_OSAA = null, 
			int? m3_PLAT = null, 
			int? m3_CATR = null, 
			int? m3_PRII = null, 
			int? m3_PRFI = null, 
			int? m3_PRNL = null, 
			string m3_PSEP = null, 
			string m3_PSPR = null, 
			string m3_PSES = null, 
			string m3_DSPG = null, 
			decimal? m3_TXID = null, 
			int? m3_DSPS = null, 
			int? m3_DOPT = null, 
			int? m3_SEAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAttribute",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATMO))
				throw new ArgumentNullException("m3_ATMO");
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATMO", m3_ATMO.Trim())
				.WithQueryParameter("ATID", m3_ATID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3_ANSQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DEVA))
				request.WithQueryParameter("DEVA", m3_DEVA.Trim());
			if (m3_ORIN.HasValue)
				request.WithQueryParameter("ORIN", m3_ORIN.Value.ToString());
			if (m3_ORIP.HasValue)
				request.WithQueryParameter("ORIP", m3_ORIP.Value.ToString());
			if (m3_ORIM.HasValue)
				request.WithQueryParameter("ORIM", m3_ORIM.Value.ToString());
			if (m3_ORIR.HasValue)
				request.WithQueryParameter("ORIR", m3_ORIR.Value.ToString());
			if (m3_ORIS.HasValue)
				request.WithQueryParameter("ORIS", m3_ORIS.Value.ToString());
			if (m3_ORIT.HasValue)
				request.WithQueryParameter("ORIT", m3_ORIT.Value.ToString());
			if (m3_MAAT.HasValue)
				request.WithQueryParameter("MAAT", m3_MAAT.Value.ToString());
			if (m3_AATT.HasValue)
				request.WithQueryParameter("AATT", m3_AATT.Value.ToString());
			if (m3_OSAK.HasValue)
				request.WithQueryParameter("OSAK", m3_OSAK.Value.ToString());
			if (m3_OSAA.HasValue)
				request.WithQueryParameter("OSAA", m3_OSAA.Value.ToString());
			if (m3_PLAT.HasValue)
				request.WithQueryParameter("PLAT", m3_PLAT.Value.ToString());
			if (m3_CATR.HasValue)
				request.WithQueryParameter("CATR", m3_CATR.Value.ToString());
			if (m3_PRII.HasValue)
				request.WithQueryParameter("PRII", m3_PRII.Value.ToString());
			if (m3_PRFI.HasValue)
				request.WithQueryParameter("PRFI", m3_PRFI.Value.ToString());
			if (m3_PRNL.HasValue)
				request.WithQueryParameter("PRNL", m3_PRNL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PSEP))
				request.WithQueryParameter("PSEP", m3_PSEP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PSPR))
				request.WithQueryParameter("PSPR", m3_PSPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PSES))
				request.WithQueryParameter("PSES", m3_PSES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSPG))
				request.WithQueryParameter("DSPG", m3_DSPG.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_DSPS.HasValue)
				request.WithQueryParameter("DSPS", m3_DSPS.Value.ToString());
			if (m3_DOPT.HasValue)
				request.WithQueryParameter("DOPT", m3_DOPT.Value.ToString());
			if (m3_SEAT.HasValue)
				request.WithQueryParameter("SEAT", m3_SEAT.Value.ToString());

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
		/// Name DelAttrModel
		/// Description This transaction deletes attribute model
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATMO">Attribute model (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAttrModel(
			string m3_ATMO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelAttrModel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATMO))
				throw new ArgumentNullException("m3_ATMO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATMO", m3_ATMO.Trim());

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
		/// Name DelAttribute
		/// Description This transaction deletes attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATMO">Attribute model (Required)</param>
		/// <param name="m3_ATID">Attribute identity (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAttribute(
			string m3_ATMO, 
			string m3_ATID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelAttribute",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATMO))
				throw new ArgumentNullException("m3_ATMO");
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATMO", m3_ATMO.Trim())
				.WithQueryParameter("ATID", m3_ATID.Trim());

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
		/// Name GetAttrModel
		/// Description This transaction displays attribute model
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATMO">Attribute model (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAttrModelResponse></returns>
		/// <exception cref="M3Exception<GetAttrModelResponse>"></exception>
		public async Task<M3Response<GetAttrModelResponse>> GetAttrModel(
			string m3_ATMO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAttrModel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATMO))
				throw new ArgumentNullException("m3_ATMO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATMO", m3_ATMO.Trim());

			// Execute the request
			var result = await Execute<GetAttrModelResponse>(
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
		/// Name GetAttribute
		/// Description This transaction displays attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATMO">Attribute model (Required)</param>
		/// <param name="m3_ATID">Attribute identity (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAttributeResponse></returns>
		/// <exception cref="M3Exception<GetAttributeResponse>"></exception>
		public async Task<M3Response<GetAttributeResponse>> GetAttribute(
			string m3_ATMO, 
			string m3_ATID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAttribute",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATMO))
				throw new ArgumentNullException("m3_ATMO");
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATMO", m3_ATMO.Trim())
				.WithQueryParameter("ATID", m3_ATID.Trim());

			// Execute the request
			var result = await Execute<GetAttributeResponse>(
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
		/// Name LstAttrBySeq
		/// Description This transaction lists attribute by sequensenumber
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATMO">Attribute model (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrBySeqResponse></returns>
		/// <exception cref="M3Exception<LstAttrBySeqResponse>"></exception>
		public async Task<M3Response<LstAttrBySeqResponse>> LstAttrBySeq(
			string m3_ATMO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAttrBySeq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATMO))
				throw new ArgumentNullException("m3_ATMO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATMO", m3_ATMO.Trim());

			// Execute the request
			var result = await Execute<LstAttrBySeqResponse>(
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
		/// Name LstAttrModLang
		/// Description This transaction lists attribute model
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATMF">From Attr model</param>
		/// <param name="m3_ATMT">To Attr model</param>
		/// <param name="m3_LNCF">From Language</param>
		/// <param name="m3_LNCT">To Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrModLangResponse></returns>
		/// <exception cref="M3Exception<LstAttrModLangResponse>"></exception>
		public async Task<M3Response<LstAttrModLangResponse>> LstAttrModLang(
			string m3_ATMF = null, 
			string m3_ATMT = null, 
			string m3_LNCF = null, 
			string m3_LNCT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAttrModLang",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ATMF))
				request.WithQueryParameter("ATMF", m3_ATMF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATMT))
				request.WithQueryParameter("ATMT", m3_ATMT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCF))
				request.WithQueryParameter("LNCF", m3_LNCF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCT))
				request.WithQueryParameter("LNCT", m3_LNCT.Trim());

			// Execute the request
			var result = await Execute<LstAttrModLangResponse>(
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
		/// Name LstAttrModel
		/// Description This transaction lists attribute model
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATMO">Attribute model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrModelResponse></returns>
		/// <exception cref="M3Exception<LstAttrModelResponse>"></exception>
		public async Task<M3Response<LstAttrModelResponse>> LstAttrModel(
			string m3_ATMO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAttrModel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ATMO))
				request.WithQueryParameter("ATMO", m3_ATMO.Trim());

			// Execute the request
			var result = await Execute<LstAttrModelResponse>(
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
		/// Name LstAttribute
		/// Description This transaction lists attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATMO">Attribute model (Required)</param>
		/// <param name="m3_ATID">Attribute identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttributeResponse></returns>
		/// <exception cref="M3Exception<LstAttributeResponse>"></exception>
		public async Task<M3Response<LstAttributeResponse>> LstAttribute(
			string m3_ATMO, 
			string m3_ATID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAttribute",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATMO))
				throw new ArgumentNullException("m3_ATMO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATMO", m3_ATMO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ATID))
				request.WithQueryParameter("ATID", m3_ATID.Trim());

			// Execute the request
			var result = await Execute<LstAttributeResponse>(
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
		/// Name UpdAttrModel
		/// Description This transaction changes attribute model
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATMO">Attribute model (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_PINO">GUI picture</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAttrModel(
			string m3_ATMO, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_PINO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdAttrModel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATMO))
				throw new ArgumentNullException("m3_ATMO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATMO", m3_ATMO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PINO))
				request.WithQueryParameter("PINO", m3_PINO.Trim());

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
		/// Name UpdAttribute
		/// Description This transaction changes attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATMO">Attribute model (Required)</param>
		/// <param name="m3_ATID">Attribute identity (Required)</param>
		/// <param name="m3_ANSQ">Attribute sequence number</param>
		/// <param name="m3_DEVA">Default value</param>
		/// <param name="m3_ORIN">Incl Ln in CO</param>
		/// <param name="m3_ORIP">Incl Ln in PO</param>
		/// <param name="m3_ORIM">Incl Ln in MO</param>
		/// <param name="m3_ORIR">Incl Ln in DO</param>
		/// <param name="m3_ORIS">Incl Ln in WO</param>
		/// <param name="m3_ORIT">Include model line in MCO</param>
		/// <param name="m3_MAAT">Main attribute</param>
		/// <param name="m3_AATT">Allocation attribute</param>
		/// <param name="m3_OSAK">Stats key</param>
		/// <param name="m3_OSAA">Stats accumulator</param>
		/// <param name="m3_PLAT">Planning attribute</param>
		/// <param name="m3_CATR">Cost attribute</param>
		/// <param name="m3_PRII">Prt attr value</param>
		/// <param name="m3_PRFI">Prt attr info</param>
		/// <param name="m3_PRNL">Prt on new line</param>
		/// <param name="m3_PSEP">Prt separator</param>
		/// <param name="m3_PSPR">Prt sep prefix</param>
		/// <param name="m3_PSES">Prt sep suffix</param>
		/// <param name="m3_DSPG">Display group</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_SEAT">Default search attribute</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAttribute(
			string m3_ATMO, 
			string m3_ATID, 
			int? m3_ANSQ = null, 
			string m3_DEVA = null, 
			int? m3_ORIN = null, 
			int? m3_ORIP = null, 
			int? m3_ORIM = null, 
			int? m3_ORIR = null, 
			int? m3_ORIS = null, 
			int? m3_ORIT = null, 
			int? m3_MAAT = null, 
			int? m3_AATT = null, 
			int? m3_OSAK = null, 
			int? m3_OSAA = null, 
			int? m3_PLAT = null, 
			int? m3_CATR = null, 
			int? m3_PRII = null, 
			int? m3_PRFI = null, 
			int? m3_PRNL = null, 
			string m3_PSEP = null, 
			string m3_PSPR = null, 
			string m3_PSES = null, 
			string m3_DSPG = null, 
			decimal? m3_TXID = null, 
			int? m3_SEAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdAttribute",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATMO))
				throw new ArgumentNullException("m3_ATMO");
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATMO", m3_ATMO.Trim())
				.WithQueryParameter("ATID", m3_ATID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3_ANSQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DEVA))
				request.WithQueryParameter("DEVA", m3_DEVA.Trim());
			if (m3_ORIN.HasValue)
				request.WithQueryParameter("ORIN", m3_ORIN.Value.ToString());
			if (m3_ORIP.HasValue)
				request.WithQueryParameter("ORIP", m3_ORIP.Value.ToString());
			if (m3_ORIM.HasValue)
				request.WithQueryParameter("ORIM", m3_ORIM.Value.ToString());
			if (m3_ORIR.HasValue)
				request.WithQueryParameter("ORIR", m3_ORIR.Value.ToString());
			if (m3_ORIS.HasValue)
				request.WithQueryParameter("ORIS", m3_ORIS.Value.ToString());
			if (m3_ORIT.HasValue)
				request.WithQueryParameter("ORIT", m3_ORIT.Value.ToString());
			if (m3_MAAT.HasValue)
				request.WithQueryParameter("MAAT", m3_MAAT.Value.ToString());
			if (m3_AATT.HasValue)
				request.WithQueryParameter("AATT", m3_AATT.Value.ToString());
			if (m3_OSAK.HasValue)
				request.WithQueryParameter("OSAK", m3_OSAK.Value.ToString());
			if (m3_OSAA.HasValue)
				request.WithQueryParameter("OSAA", m3_OSAA.Value.ToString());
			if (m3_PLAT.HasValue)
				request.WithQueryParameter("PLAT", m3_PLAT.Value.ToString());
			if (m3_CATR.HasValue)
				request.WithQueryParameter("CATR", m3_CATR.Value.ToString());
			if (m3_PRII.HasValue)
				request.WithQueryParameter("PRII", m3_PRII.Value.ToString());
			if (m3_PRFI.HasValue)
				request.WithQueryParameter("PRFI", m3_PRFI.Value.ToString());
			if (m3_PRNL.HasValue)
				request.WithQueryParameter("PRNL", m3_PRNL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PSEP))
				request.WithQueryParameter("PSEP", m3_PSEP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PSPR))
				request.WithQueryParameter("PSPR", m3_PSPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PSES))
				request.WithQueryParameter("PSES", m3_PSES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSPG))
				request.WithQueryParameter("DSPG", m3_DSPG.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_SEAT.HasValue)
				request.WithQueryParameter("SEAT", m3_SEAT.Value.ToString());

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
