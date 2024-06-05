/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
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
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AbortConfig",
			};

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
		/// Name AnswerDrawing
		/// Description Answer drawing measurement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DMID">Drawing measurement ID (Required)</param>
		/// <param name="m3_MEVA">Measurement value (Required)</param>
		/// <param name="m3_NCLN">Open meausurement (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AnswerDrawingResponse></returns>
		/// <exception cref="M3Exception<AnswerDrawingResponse>"></exception>
		public async Task<M3Response<AnswerDrawingResponse>> AnswerDrawing(
			string m3_DMID, 
			string m3_MEVA, 
			string m3_NCLN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AnswerDrawing",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DMID))
				throw new ArgumentNullException("m3_DMID");
			if (string.IsNullOrWhiteSpace(m3_MEVA))
				throw new ArgumentNullException("m3_MEVA");
			if (string.IsNullOrWhiteSpace(m3_NCLN))
				throw new ArgumentNullException("m3_NCLN");

			// Set mandatory parameters
			request
				.WithQueryParameter("DMID", m3_DMID.Trim())
				.WithQueryParameter("MEVA", m3_MEVA.Trim())
				.WithQueryParameter("NCLN", m3_NCLN.Trim());

			// Execute the request
			var result = await Execute<AnswerDrawingResponse>(
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
		/// Name AnswerFeature
		/// Description Answer to asked question about feature
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FTI1">Feature ID (Required)</param>
		/// <param name="m3_FTTP">Feature type (Required)</param>
		/// <param name="m3_ANS1">Answer (Required)</param>
		/// <param name="m3_DSP1">Flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AnswerFeature(
			string m3_FTI1, 
			string m3_FTTP, 
			string m3_ANS1, 
			int? m3_DSP1 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AnswerFeature",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FTI1))
				throw new ArgumentNullException("m3_FTI1");
			if (string.IsNullOrWhiteSpace(m3_FTTP))
				throw new ArgumentNullException("m3_FTTP");
			if (string.IsNullOrWhiteSpace(m3_ANS1))
				throw new ArgumentNullException("m3_ANS1");

			// Set mandatory parameters
			request
				.WithQueryParameter("FTI1", m3_FTI1.Trim())
				.WithQueryParameter("FTTP", m3_FTTP.Trim())
				.WithQueryParameter("ANS1", m3_ANS1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3_DSP1.Value.ToString());

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
		/// Name AnswerMatrix
		/// Description Answer to matrix questions - Both item and quantity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CFID">Selection id - Quantity and Item (Required)</param>
		/// <param name="m3_ITNO">Answer - Item number (Required)</param>
		/// <param name="m3_CNQT">Answer - Quantity (Required)</param>
		/// <param name="m3_NCLN">Open item matrix/qty matrix (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AnswerMatrix(
			string m3_CFID, 
			string m3_ITNO, 
			string m3_CNQT, 
			string m3_NCLN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AnswerMatrix",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CFID))
				throw new ArgumentNullException("m3_CFID");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_CNQT))
				throw new ArgumentNullException("m3_CNQT");
			if (string.IsNullOrWhiteSpace(m3_NCLN))
				throw new ArgumentNullException("m3_NCLN");

			// Set mandatory parameters
			request
				.WithQueryParameter("CFID", m3_CFID.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("CNQT", m3_CNQT.Trim())
				.WithQueryParameter("NCLN", m3_NCLN.Trim());

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
		/// Name ChangeConfig
		/// Description Initiate conversation with product configurator
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CFXX">Old CFIN</param>
		/// <param name="m3_ECVS">Simulationround</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CFIN">Configurationumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChangeConfig(
			int? m3_CFXX = null, 
			int? m3_ECVS = null, 
			string m3_LNCD = null, 
			int? m3_CONO = null, 
			long? m3_CFIN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChangeConfig",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CFXX.HasValue)
				request.WithQueryParameter("CFXX", m3_CFXX.Value.ToString());
			if (m3_ECVS.HasValue)
				request.WithQueryParameter("ECVS", m3_ECVS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3_CFIN.Value.ToString());

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
		/// Name ChangeRequest
		/// Description Request change to previous answer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ANSW">Answer No. to start from when changing</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChangeRequest(
			string m3_ANSW = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChangeRequest",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ANSW))
				request.WithQueryParameter("ANSW", m3_ANSW.Trim());

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
		/// Name ConfigSKU
		/// Description Configur additonal feature from SKU to other SKU
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CFIN">Configuration number</param>
		/// <param name="m3_VANO">Product variant</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ConfigSKUResponse></returns>
		/// <exception cref="M3Exception<ConfigSKUResponse>"></exception>
		public async Task<M3Response<ConfigSKUResponse>> ConfigSKU(
			long? m3_CFIN = null, 
			string m3_VANO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ConfigSKU",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3_CFIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_VANO))
				request.WithQueryParameter("VANO", m3_VANO.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<ConfigSKUResponse>(
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
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ConfirmConfig",
			};

			// Execute the request
			var result = await Execute<ConfirmConfigResponse>(
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
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetConfigNbr",
			};

			// Execute the request
			var result = await Execute<GetConfigNbrResponse>(
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
		/// Name InitConfig
		/// Description Initiate conversation with product configurator
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_TX30">Configuration description (Required)</param>
		/// <param name="m3_OPT2">Option (Required)</param>
		/// <param name="m3_ORQT">Order quantity (Required)</param>
		/// <param name="m3_STRT">Structure type (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_FIDT">Planned finish date (Required)</param>
		/// <param name="m3_SCVI">Search for variance item (Required)</param>
		/// <param name="m3_CFST">Status configuration</param>
		/// <param name="m3_ORNO">Order number</param>
		/// <param name="m3_PONR">Line Number</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_VANO">Product variant</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> InitConfig(
			string m3_CUNO, 
			string m3_FACI, 
			string m3_TX30, 
			string m3_OPT2, 
			string m3_ORQT, 
			string m3_STRT, 
			string m3_PRNO, 
			DateTime m3_FIDT, 
			string m3_SCVI, 
			string m3_CFST = null, 
			string m3_ORNO = null, 
			string m3_PONR = null, 
			string m3_LNCD = null, 
			int? m3_CONO = null, 
			string m3_VANO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/InitConfig",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_TX30))
				throw new ArgumentNullException("m3_TX30");
			if (string.IsNullOrWhiteSpace(m3_OPT2))
				throw new ArgumentNullException("m3_OPT2");
			if (string.IsNullOrWhiteSpace(m3_ORQT))
				throw new ArgumentNullException("m3_ORQT");
			if (string.IsNullOrWhiteSpace(m3_STRT))
				throw new ArgumentNullException("m3_STRT");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_SCVI))
				throw new ArgumentNullException("m3_SCVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("TX30", m3_TX30.Trim())
				.WithQueryParameter("OPT2", m3_OPT2.Trim())
				.WithQueryParameter("ORQT", m3_ORQT.Trim())
				.WithQueryParameter("STRT", m3_STRT.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("FIDT", m3_FIDT.ToM3String())
				.WithQueryParameter("SCVI", m3_SCVI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CFST))
				request.WithQueryParameter("CFST", m3_CFST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONR))
				request.WithQueryParameter("PONR", m3_PONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_VANO))
				request.WithQueryParameter("VANO", m3_VANO.Trim());

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
		/// Name OptionRequest
		/// Description Request options from product configurator
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_OPTN">Position value for options</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<OptionRequestResponse></returns>
		/// <exception cref="M3Exception<OptionRequestResponse>"></exception>
		public async Task<M3Response<OptionRequestResponse>> OptionRequest(
			string m3_OPTN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/OptionRequest",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OPTN))
				request.WithQueryParameter("OPTN", m3_OPTN.Trim());

			// Execute the request
			var result = await Execute<OptionRequestResponse>(
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
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/QuestRequest",
			};

			// Execute the request
			var result = await Execute<QuestRequestResponse>(
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
