/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3ATMO">Attribute model (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3PINO">GUI picture</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAttrModel(
			string m3ATMO, 
			string m3TX40, 
			string m3TX15 = null, 
			string m3PINO = null, 
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
			if (string.IsNullOrWhiteSpace(m3ATMO))
				throw new ArgumentNullException(nameof(m3ATMO));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATMO", m3ATMO.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3PINO))
				request.WithQueryParameter("PINO", m3PINO.Trim());

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
		/// Name AddAttribute
		/// Description This transaction adds attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATMO">Attribute model (Required)</param>
		/// <param name="m3ATID">Attribute identity (Required)</param>
		/// <param name="m3ANSQ">Attribute sequence number</param>
		/// <param name="m3DEVA">Default value</param>
		/// <param name="m3ORIN">Incl Ln in CO</param>
		/// <param name="m3ORIP">Incl Ln in PO</param>
		/// <param name="m3ORIM">Incl Ln in MO</param>
		/// <param name="m3ORIR">Incl Ln in DO</param>
		/// <param name="m3ORIS">Incl Ln in WO</param>
		/// <param name="m3ORIT">Include model line in MCO</param>
		/// <param name="m3MAAT">Main attribute</param>
		/// <param name="m3AATT">Allocation attribute</param>
		/// <param name="m3OSAK">Stats key</param>
		/// <param name="m3OSAA">Stats accumulator</param>
		/// <param name="m3PLAT">Planning attribute</param>
		/// <param name="m3CATR">Cost attribute</param>
		/// <param name="m3PRII">Prt attr value</param>
		/// <param name="m3PRFI">Prt attr info</param>
		/// <param name="m3PRNL">Prt on new line</param>
		/// <param name="m3PSEP">Prt separator</param>
		/// <param name="m3PSPR">Prt sep prefix</param>
		/// <param name="m3PSES">Prt sep suffix</param>
		/// <param name="m3DSPG">Display group</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3DSPS">Display sequence</param>
		/// <param name="m3DOPT">Display option</param>
		/// <param name="m3SEAT">Default search attribute</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAttribute(
			string m3ATMO, 
			string m3ATID, 
			int? m3ANSQ = null, 
			string m3DEVA = null, 
			int? m3ORIN = null, 
			int? m3ORIP = null, 
			int? m3ORIM = null, 
			int? m3ORIR = null, 
			int? m3ORIS = null, 
			int? m3ORIT = null, 
			int? m3MAAT = null, 
			int? m3AATT = null, 
			int? m3OSAK = null, 
			int? m3OSAA = null, 
			int? m3PLAT = null, 
			int? m3CATR = null, 
			int? m3PRII = null, 
			int? m3PRFI = null, 
			int? m3PRNL = null, 
			string m3PSEP = null, 
			string m3PSPR = null, 
			string m3PSES = null, 
			string m3DSPG = null, 
			decimal? m3TXID = null, 
			int? m3DSPS = null, 
			int? m3DOPT = null, 
			int? m3SEAT = null, 
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
			if (string.IsNullOrWhiteSpace(m3ATMO))
				throw new ArgumentNullException(nameof(m3ATMO));
			if (string.IsNullOrWhiteSpace(m3ATID))
				throw new ArgumentNullException(nameof(m3ATID));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATMO", m3ATMO.Trim())
				.WithQueryParameter("ATID", m3ATID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3ANSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DEVA))
				request.WithQueryParameter("DEVA", m3DEVA.Trim());
			if (m3ORIN.HasValue)
				request.WithQueryParameter("ORIN", m3ORIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORIP.HasValue)
				request.WithQueryParameter("ORIP", m3ORIP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORIM.HasValue)
				request.WithQueryParameter("ORIM", m3ORIM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORIR.HasValue)
				request.WithQueryParameter("ORIR", m3ORIR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORIS.HasValue)
				request.WithQueryParameter("ORIS", m3ORIS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORIT.HasValue)
				request.WithQueryParameter("ORIT", m3ORIT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MAAT.HasValue)
				request.WithQueryParameter("MAAT", m3MAAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AATT.HasValue)
				request.WithQueryParameter("AATT", m3AATT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OSAK.HasValue)
				request.WithQueryParameter("OSAK", m3OSAK.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OSAA.HasValue)
				request.WithQueryParameter("OSAA", m3OSAA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLAT.HasValue)
				request.WithQueryParameter("PLAT", m3PLAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CATR.HasValue)
				request.WithQueryParameter("CATR", m3CATR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRII.HasValue)
				request.WithQueryParameter("PRII", m3PRII.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRFI.HasValue)
				request.WithQueryParameter("PRFI", m3PRFI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNL.HasValue)
				request.WithQueryParameter("PRNL", m3PRNL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PSEP))
				request.WithQueryParameter("PSEP", m3PSEP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PSPR))
				request.WithQueryParameter("PSPR", m3PSPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PSES))
				request.WithQueryParameter("PSES", m3PSES.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSPG))
				request.WithQueryParameter("DSPG", m3DSPG.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSPS.HasValue)
				request.WithQueryParameter("DSPS", m3DSPS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DOPT.HasValue)
				request.WithQueryParameter("DOPT", m3DOPT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEAT.HasValue)
				request.WithQueryParameter("SEAT", m3SEAT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelAttrModel
		/// Description This transaction deletes attribute model
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATMO">Attribute model (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAttrModel(
			string m3ATMO, 
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
			if (string.IsNullOrWhiteSpace(m3ATMO))
				throw new ArgumentNullException(nameof(m3ATMO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATMO", m3ATMO.Trim());

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
		/// Name DelAttribute
		/// Description This transaction deletes attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATMO">Attribute model (Required)</param>
		/// <param name="m3ATID">Attribute identity (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAttribute(
			string m3ATMO, 
			string m3ATID, 
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
			if (string.IsNullOrWhiteSpace(m3ATMO))
				throw new ArgumentNullException(nameof(m3ATMO));
			if (string.IsNullOrWhiteSpace(m3ATID))
				throw new ArgumentNullException(nameof(m3ATID));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATMO", m3ATMO.Trim())
				.WithQueryParameter("ATID", m3ATID.Trim());

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
		/// Name GetAttrModel
		/// Description This transaction displays attribute model
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATMO">Attribute model (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAttrModelResponse></returns>
		/// <exception cref="M3Exception<GetAttrModelResponse>"></exception>
		public async Task<M3Response<GetAttrModelResponse>> GetAttrModel(
			string m3ATMO, 
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
			if (string.IsNullOrWhiteSpace(m3ATMO))
				throw new ArgumentNullException(nameof(m3ATMO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATMO", m3ATMO.Trim());

			// Execute the request
			var result = await Execute<GetAttrModelResponse>(
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
		/// Name GetAttribute
		/// Description This transaction displays attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATMO">Attribute model (Required)</param>
		/// <param name="m3ATID">Attribute identity (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAttributeResponse></returns>
		/// <exception cref="M3Exception<GetAttributeResponse>"></exception>
		public async Task<M3Response<GetAttributeResponse>> GetAttribute(
			string m3ATMO, 
			string m3ATID, 
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
			if (string.IsNullOrWhiteSpace(m3ATMO))
				throw new ArgumentNullException(nameof(m3ATMO));
			if (string.IsNullOrWhiteSpace(m3ATID))
				throw new ArgumentNullException(nameof(m3ATID));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATMO", m3ATMO.Trim())
				.WithQueryParameter("ATID", m3ATID.Trim());

			// Execute the request
			var result = await Execute<GetAttributeResponse>(
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
		/// Name LstAttrBySeq
		/// Description This transaction lists attribute by sequensenumber
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATMO">Attribute model (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrBySeqResponse></returns>
		/// <exception cref="M3Exception<LstAttrBySeqResponse>"></exception>
		public async Task<M3Response<LstAttrBySeqResponse>> LstAttrBySeq(
			string m3ATMO, 
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
			if (string.IsNullOrWhiteSpace(m3ATMO))
				throw new ArgumentNullException(nameof(m3ATMO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATMO", m3ATMO.Trim());

			// Execute the request
			var result = await Execute<LstAttrBySeqResponse>(
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
		/// Name LstAttrModLang
		/// Description This transaction lists attribute model
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATMF">From Attr model</param>
		/// <param name="m3ATMT">To Attr model</param>
		/// <param name="m3LNCF">From Language</param>
		/// <param name="m3LNCT">To Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrModLangResponse></returns>
		/// <exception cref="M3Exception<LstAttrModLangResponse>"></exception>
		public async Task<M3Response<LstAttrModLangResponse>> LstAttrModLang(
			string m3ATMF = null, 
			string m3ATMT = null, 
			string m3LNCF = null, 
			string m3LNCT = null, 
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
			if (!string.IsNullOrWhiteSpace(m3ATMF))
				request.WithQueryParameter("ATMF", m3ATMF.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATMT))
				request.WithQueryParameter("ATMT", m3ATMT.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCF))
				request.WithQueryParameter("LNCF", m3LNCF.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCT))
				request.WithQueryParameter("LNCT", m3LNCT.Trim());

			// Execute the request
			var result = await Execute<LstAttrModLangResponse>(
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
		/// Name LstAttrModel
		/// Description This transaction lists attribute model
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATMO">Attribute model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrModelResponse></returns>
		/// <exception cref="M3Exception<LstAttrModelResponse>"></exception>
		public async Task<M3Response<LstAttrModelResponse>> LstAttrModel(
			string m3ATMO = null, 
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
			if (!string.IsNullOrWhiteSpace(m3ATMO))
				request.WithQueryParameter("ATMO", m3ATMO.Trim());

			// Execute the request
			var result = await Execute<LstAttrModelResponse>(
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
		/// Name LstAttribute
		/// Description This transaction lists attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATMO">Attribute model (Required)</param>
		/// <param name="m3ATID">Attribute identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttributeResponse></returns>
		/// <exception cref="M3Exception<LstAttributeResponse>"></exception>
		public async Task<M3Response<LstAttributeResponse>> LstAttribute(
			string m3ATMO, 
			string m3ATID = null, 
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
			if (string.IsNullOrWhiteSpace(m3ATMO))
				throw new ArgumentNullException(nameof(m3ATMO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATMO", m3ATMO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ATID))
				request.WithQueryParameter("ATID", m3ATID.Trim());

			// Execute the request
			var result = await Execute<LstAttributeResponse>(
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
		/// Name UpdAttrModel
		/// Description This transaction changes attribute model
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATMO">Attribute model (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3PINO">GUI picture</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAttrModel(
			string m3ATMO, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3PINO = null, 
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
			if (string.IsNullOrWhiteSpace(m3ATMO))
				throw new ArgumentNullException(nameof(m3ATMO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATMO", m3ATMO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3PINO))
				request.WithQueryParameter("PINO", m3PINO.Trim());

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
		/// Name UpdAttribute
		/// Description This transaction changes attribute
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATMO">Attribute model (Required)</param>
		/// <param name="m3ATID">Attribute identity (Required)</param>
		/// <param name="m3ANSQ">Attribute sequence number</param>
		/// <param name="m3DEVA">Default value</param>
		/// <param name="m3ORIN">Incl Ln in CO</param>
		/// <param name="m3ORIP">Incl Ln in PO</param>
		/// <param name="m3ORIM">Incl Ln in MO</param>
		/// <param name="m3ORIR">Incl Ln in DO</param>
		/// <param name="m3ORIS">Incl Ln in WO</param>
		/// <param name="m3ORIT">Include model line in MCO</param>
		/// <param name="m3MAAT">Main attribute</param>
		/// <param name="m3AATT">Allocation attribute</param>
		/// <param name="m3OSAK">Stats key</param>
		/// <param name="m3OSAA">Stats accumulator</param>
		/// <param name="m3PLAT">Planning attribute</param>
		/// <param name="m3CATR">Cost attribute</param>
		/// <param name="m3PRII">Prt attr value</param>
		/// <param name="m3PRFI">Prt attr info</param>
		/// <param name="m3PRNL">Prt on new line</param>
		/// <param name="m3PSEP">Prt separator</param>
		/// <param name="m3PSPR">Prt sep prefix</param>
		/// <param name="m3PSES">Prt sep suffix</param>
		/// <param name="m3DSPG">Display group</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3SEAT">Default search attribute</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAttribute(
			string m3ATMO, 
			string m3ATID, 
			int? m3ANSQ = null, 
			string m3DEVA = null, 
			int? m3ORIN = null, 
			int? m3ORIP = null, 
			int? m3ORIM = null, 
			int? m3ORIR = null, 
			int? m3ORIS = null, 
			int? m3ORIT = null, 
			int? m3MAAT = null, 
			int? m3AATT = null, 
			int? m3OSAK = null, 
			int? m3OSAA = null, 
			int? m3PLAT = null, 
			int? m3CATR = null, 
			int? m3PRII = null, 
			int? m3PRFI = null, 
			int? m3PRNL = null, 
			string m3PSEP = null, 
			string m3PSPR = null, 
			string m3PSES = null, 
			string m3DSPG = null, 
			decimal? m3TXID = null, 
			int? m3SEAT = null, 
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
			if (string.IsNullOrWhiteSpace(m3ATMO))
				throw new ArgumentNullException(nameof(m3ATMO));
			if (string.IsNullOrWhiteSpace(m3ATID))
				throw new ArgumentNullException(nameof(m3ATID));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATMO", m3ATMO.Trim())
				.WithQueryParameter("ATID", m3ATID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3ANSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DEVA))
				request.WithQueryParameter("DEVA", m3DEVA.Trim());
			if (m3ORIN.HasValue)
				request.WithQueryParameter("ORIN", m3ORIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORIP.HasValue)
				request.WithQueryParameter("ORIP", m3ORIP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORIM.HasValue)
				request.WithQueryParameter("ORIM", m3ORIM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORIR.HasValue)
				request.WithQueryParameter("ORIR", m3ORIR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORIS.HasValue)
				request.WithQueryParameter("ORIS", m3ORIS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORIT.HasValue)
				request.WithQueryParameter("ORIT", m3ORIT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MAAT.HasValue)
				request.WithQueryParameter("MAAT", m3MAAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AATT.HasValue)
				request.WithQueryParameter("AATT", m3AATT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OSAK.HasValue)
				request.WithQueryParameter("OSAK", m3OSAK.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OSAA.HasValue)
				request.WithQueryParameter("OSAA", m3OSAA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLAT.HasValue)
				request.WithQueryParameter("PLAT", m3PLAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CATR.HasValue)
				request.WithQueryParameter("CATR", m3CATR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRII.HasValue)
				request.WithQueryParameter("PRII", m3PRII.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRFI.HasValue)
				request.WithQueryParameter("PRFI", m3PRFI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNL.HasValue)
				request.WithQueryParameter("PRNL", m3PRNL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PSEP))
				request.WithQueryParameter("PSEP", m3PSEP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PSPR))
				request.WithQueryParameter("PSPR", m3PSPR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PSES))
				request.WithQueryParameter("PSES", m3PSES.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSPG))
				request.WithQueryParameter("DSPG", m3DSPG.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEAT.HasValue)
				request.WithQueryParameter("SEAT", m3SEAT.Value.ToString(CultureInfo.CurrentCulture));

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
