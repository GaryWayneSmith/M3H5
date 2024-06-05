/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.PDS600MI;
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
	/// Name: PDS600MI
	/// Component Name: ProductConfiguration
	/// Description: Product configuration interface
	/// Version Release: 5ea0
	///</summary>
	public partial class PDS600MIResource : M3BaseResourceEndpoint
	{
		public PDS600MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PDS600MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AbortConfig
		/// Description Abort ongoing configuration
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AbortConfig(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AbortConfig",
			};

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
		/// Name AnswerDrawing
		/// Description Answer drawing measurement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DMID">Drawing measurement ID (Required)</param>
		/// <param name="m3MEVA">Measurement value (Required)</param>
		/// <param name="m3NCLN">Open meausurement (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AnswerDrawingResponse></returns>
		/// <exception cref="M3Exception<AnswerDrawingResponse>"></exception>
		public async Task<M3Response<AnswerDrawingResponse>> AnswerDrawing(
			string m3DMID, 
			string m3MEVA, 
			string m3NCLN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AnswerDrawing",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DMID))
				throw new ArgumentNullException(nameof(m3DMID));
			if (string.IsNullOrWhiteSpace(m3MEVA))
				throw new ArgumentNullException(nameof(m3MEVA));
			if (string.IsNullOrWhiteSpace(m3NCLN))
				throw new ArgumentNullException(nameof(m3NCLN));

			// Set mandatory parameters
			request
				.WithQueryParameter("DMID", m3DMID.Trim())
				.WithQueryParameter("MEVA", m3MEVA.Trim())
				.WithQueryParameter("NCLN", m3NCLN.Trim());

			// Execute the request
			var result = await Execute<AnswerDrawingResponse>(
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
		/// Name AnswerFeature
		/// Description Answer to asked question about feature
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FTI1">Feature ID (Required)</param>
		/// <param name="m3FTTP">Feature type (Required)</param>
		/// <param name="m3ANS1">Answer (Required)</param>
		/// <param name="m3DSP1">Flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AnswerFeature(
			string m3FTI1, 
			string m3FTTP, 
			string m3ANS1, 
			int? m3DSP1 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AnswerFeature",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FTI1))
				throw new ArgumentNullException(nameof(m3FTI1));
			if (string.IsNullOrWhiteSpace(m3FTTP))
				throw new ArgumentNullException(nameof(m3FTTP));
			if (string.IsNullOrWhiteSpace(m3ANS1))
				throw new ArgumentNullException(nameof(m3ANS1));

			// Set mandatory parameters
			request
				.WithQueryParameter("FTI1", m3FTI1.Trim())
				.WithQueryParameter("FTTP", m3FTTP.Trim())
				.WithQueryParameter("ANS1", m3ANS1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3DSP1.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AnswerMatrix
		/// Description Answer to matrix questions - Both item and quantity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CFID">Selection id - Quantity and Item (Required)</param>
		/// <param name="m3ITNO">Answer - Item number (Required)</param>
		/// <param name="m3CNQT">Answer - Quantity (Required)</param>
		/// <param name="m3NCLN">Open item matrix/qty matrix (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AnswerMatrix(
			string m3CFID, 
			string m3ITNO, 
			string m3CNQT, 
			string m3NCLN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AnswerMatrix",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CFID))
				throw new ArgumentNullException(nameof(m3CFID));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3CNQT))
				throw new ArgumentNullException(nameof(m3CNQT));
			if (string.IsNullOrWhiteSpace(m3NCLN))
				throw new ArgumentNullException(nameof(m3NCLN));

			// Set mandatory parameters
			request
				.WithQueryParameter("CFID", m3CFID.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("CNQT", m3CNQT.Trim())
				.WithQueryParameter("NCLN", m3NCLN.Trim());

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
		/// Name ChangeConfig
		/// Description Initiate conversation with product configurator
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CFXX">Old CFIN</param>
		/// <param name="m3ECVS">Simulationround</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CFIN">Configurationumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChangeConfig(
			int? m3CFXX = null, 
			int? m3ECVS = null, 
			string m3LNCD = null, 
			int? m3CONO = null, 
			long? m3CFIN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChangeConfig",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CFXX.HasValue)
				request.WithQueryParameter("CFXX", m3CFXX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ECVS.HasValue)
				request.WithQueryParameter("ECVS", m3ECVS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3CFIN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChangeRequest
		/// Description Request change to previous answer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ANSW">Answer No. to start from when changing</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChangeRequest(
			string m3ANSW = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChangeRequest",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ANSW))
				request.WithQueryParameter("ANSW", m3ANSW.Trim());

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
		/// Name ConfigSKU
		/// Description Configur additonal feature from SKU to other SKU
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CFIN">Configuration number</param>
		/// <param name="m3VANO">Product variant</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ConfigSKUResponse></returns>
		/// <exception cref="M3Exception<ConfigSKUResponse>"></exception>
		public async Task<M3Response<ConfigSKUResponse>> ConfigSKU(
			long? m3CFIN = null, 
			string m3VANO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ConfigSKU",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3CFIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3VANO))
				request.WithQueryParameter("VANO", m3VANO.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ConfigSKUResponse>(
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
		/// Name ConfirmConfig
		/// Description Confirm configuration
		/// Version Release: 14.x
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ConfirmConfigResponse></returns>
		/// <exception cref="M3Exception<ConfirmConfigResponse>"></exception>
		public async Task<M3Response<ConfirmConfigResponse>> ConfirmConfig(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ConfirmConfig",
			};

			// Execute the request
			var result = await Execute<ConfirmConfigResponse>(
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
		/// Name GetConfigNbr
		/// Description Get configuration number
		/// Version Release: 15
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetConfigNbrResponse></returns>
		/// <exception cref="M3Exception<GetConfigNbrResponse>"></exception>
		public async Task<M3Response<GetConfigNbrResponse>> GetConfigNbr(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetConfigNbr",
			};

			// Execute the request
			var result = await Execute<GetConfigNbrResponse>(
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
		/// Name InitConfig
		/// Description Initiate conversation with product configurator
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3TX30">Configuration description (Required)</param>
		/// <param name="m3OPT2">Option (Required)</param>
		/// <param name="m3ORQT">Order quantity (Required)</param>
		/// <param name="m3STRT">Structure type (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3FIDT">Planned finish date (Required)</param>
		/// <param name="m3SCVI">Search for variance item (Required)</param>
		/// <param name="m3CFST">Status configuration</param>
		/// <param name="m3ORNO">Order number</param>
		/// <param name="m3PONR">Line Number</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3VANO">Product variant</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> InitConfig(
			string m3CUNO, 
			string m3FACI, 
			string m3TX30, 
			string m3OPT2, 
			string m3ORQT, 
			string m3STRT, 
			string m3PRNO, 
			DateTime m3FIDT, 
			string m3SCVI, 
			string m3CFST = null, 
			string m3ORNO = null, 
			string m3PONR = null, 
			string m3LNCD = null, 
			int? m3CONO = null, 
			string m3VANO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/InitConfig",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3TX30))
				throw new ArgumentNullException(nameof(m3TX30));
			if (string.IsNullOrWhiteSpace(m3OPT2))
				throw new ArgumentNullException(nameof(m3OPT2));
			if (string.IsNullOrWhiteSpace(m3ORQT))
				throw new ArgumentNullException(nameof(m3ORQT));
			if (string.IsNullOrWhiteSpace(m3STRT))
				throw new ArgumentNullException(nameof(m3STRT));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3SCVI))
				throw new ArgumentNullException(nameof(m3SCVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("TX30", m3TX30.Trim())
				.WithQueryParameter("OPT2", m3OPT2.Trim())
				.WithQueryParameter("ORQT", m3ORQT.Trim())
				.WithQueryParameter("STRT", m3STRT.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("FIDT", m3FIDT.ToM3String())
				.WithQueryParameter("SCVI", m3SCVI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CFST))
				request.WithQueryParameter("CFST", m3CFST.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONR))
				request.WithQueryParameter("PONR", m3PONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3VANO))
				request.WithQueryParameter("VANO", m3VANO.Trim());

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
		/// Name OptionRequest
		/// Description Request options from product configurator
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3OPTN">Position value for options</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<OptionRequestResponse></returns>
		/// <exception cref="M3Exception<OptionRequestResponse>"></exception>
		public async Task<M3Response<OptionRequestResponse>> OptionRequest(
			string m3OPTN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/OptionRequest",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OPTN))
				request.WithQueryParameter("OPTN", m3OPTN.Trim());

			// Execute the request
			var result = await Execute<OptionRequestResponse>(
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
		/// Name QuestRequest
		/// Description Request question from product configurator
		/// Version Release: 14.x
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<QuestRequestResponse></returns>
		/// <exception cref="M3Exception<QuestRequestResponse>"></exception>
		public async Task<M3Response<QuestRequestResponse>> QuestRequest(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/QuestRequest",
			};

			// Execute the request
			var result = await Execute<QuestRequestResponse>(
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
