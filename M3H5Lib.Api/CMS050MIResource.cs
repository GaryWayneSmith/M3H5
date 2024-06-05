/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CMS050MI;
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
	/// Name: CMS050MI
	/// Component Name: Macro orders
	/// Description: Action log
	/// Version Release: 12.4
	///</summary>
	public partial class CMS050MIResource : M3BaseResourceEndpoint
	{
		public CMS050MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS050MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name CloseAction
		/// Description CloseAction
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_LONO">Actionlog number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ACTN">Action sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CloseAction(
			string m3_LONO, 
			int? m3_CONO = null, 
			decimal? m3_ACTN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CloseAction",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_LONO))
				throw new ArgumentNullException("m3_LONO");

			// Set mandatory parameters
			request
				.WithQueryParameter("LONO", m3_LONO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_ACTN.HasValue)
				request.WithQueryParameter("ACTN", m3_ACTN.Value.ToString());

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
		/// Name CreateHeader
		/// Description CreateHeader
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_ORI1">Origin (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_ROLE">Role</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CreateHeaderResponse></returns>
		/// <exception cref="M3Exception<CreateHeaderResponse>"></exception>
		public async Task<M3Response<CreateHeaderResponse>> CreateHeader(
			string m3_ORI1, 
			int? m3_CONO = null, 
			string m3_RESP = null, 
			string m3_ROLE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CreateHeader",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORI1))
				throw new ArgumentNullException("m3_ORI1");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORI1", m3_ORI1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ROLE))
				request.WithQueryParameter("ROLE", m3_ROLE.Trim());

			// Execute the request
			var result = await Execute<CreateHeaderResponse>(
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
		/// Name CreateLine
		/// Description CreateLine
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_LONO">Actionlog number (Required)</param>
		/// <param name="m3_ACT0">Action type (Required)</param>
		/// <param name="m3_DEDT">Decision date (Required)</param>
		/// <param name="m3_DECT">Decision time (Required)</param>
		/// <param name="m3_TMSX">Time suffix (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_KR01">Key/result1</param>
		/// <param name="m3_KR02">Key/result2</param>
		/// <param name="m3_KR03">Key/result3</param>
		/// <param name="m3_KR04">Key/result4</param>
		/// <param name="m3_KR05">Key/result5</param>
		/// <param name="m3_KR06">Key/result6</param>
		/// <param name="m3_KR07">Key/result7</param>
		/// <param name="m3_KR08">Key/result8</param>
		/// <param name="m3_KR09">Key/result9</param>
		/// <param name="m3_KR10">Key/result10</param>
		/// <param name="m3_KR11">Key/result11</param>
		/// <param name="m3_KR12">Key/result12</param>
		/// <param name="m3_KR13">Key/result13</param>
		/// <param name="m3_KR14">Key/result14</param>
		/// <param name="m3_KR15">Key/result15</param>
		/// <param name="m3_KR16">Key/result16</param>
		/// <param name="m3_KR17">Key/result17</param>
		/// <param name="m3_KR18">Key/result18</param>
		/// <param name="m3_KR19">Key/result19</param>
		/// <param name="m3_KR20">Key/result20</param>
		/// <param name="m3_KR21">Key/result21</param>
		/// <param name="m3_KR22">Key/result22</param>
		/// <param name="m3_KR23">Key/result23</param>
		/// <param name="m3_KR24">Key/result24</param>
		/// <param name="m3_KR25">Key/result25</param>
		/// <param name="m3_KR26">Key/result26</param>
		/// <param name="m3_KR27">Key/result27</param>
		/// <param name="m3_KR28">Key/result28</param>
		/// <param name="m3_KR29">Key/result29</param>
		/// <param name="m3_KR30">Key/result30</param>
		/// <param name="m3_KR31">Key/result31</param>
		/// <param name="m3_KR32">Key/result32</param>
		/// <param name="m3_KR33">Key/result33</param>
		/// <param name="m3_KR34">Key/result34</param>
		/// <param name="m3_KR35">Key/result35</param>
		/// <param name="m3_KR36">Key/result36</param>
		/// <param name="m3_KR37">Key/result37</param>
		/// <param name="m3_KR38">Key/result38</param>
		/// <param name="m3_KR39">Key/result39</param>
		/// <param name="m3_KR40">Key/result40</param>
		/// <param name="m3_DCTP">Decision type</param>
		/// <param name="m3_DCRF">Decision reference</param>
		/// <param name="m3_DCRT">Data reference type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CreateLine(
			string m3_LONO, 
			string m3_ACT0, 
			DateTime m3_DEDT, 
			int m3_DECT, 
			int m3_TMSX, 
			int? m3_CONO = null, 
			string m3_RESP = null, 
			string m3_KR01 = null, 
			string m3_KR02 = null, 
			string m3_KR03 = null, 
			string m3_KR04 = null, 
			string m3_KR05 = null, 
			string m3_KR06 = null, 
			string m3_KR07 = null, 
			string m3_KR08 = null, 
			string m3_KR09 = null, 
			string m3_KR10 = null, 
			string m3_KR11 = null, 
			string m3_KR12 = null, 
			string m3_KR13 = null, 
			string m3_KR14 = null, 
			string m3_KR15 = null, 
			string m3_KR16 = null, 
			string m3_KR17 = null, 
			string m3_KR18 = null, 
			string m3_KR19 = null, 
			string m3_KR20 = null, 
			string m3_KR21 = null, 
			string m3_KR22 = null, 
			string m3_KR23 = null, 
			string m3_KR24 = null, 
			string m3_KR25 = null, 
			string m3_KR26 = null, 
			string m3_KR27 = null, 
			string m3_KR28 = null, 
			string m3_KR29 = null, 
			string m3_KR30 = null, 
			string m3_KR31 = null, 
			string m3_KR32 = null, 
			string m3_KR33 = null, 
			string m3_KR34 = null, 
			string m3_KR35 = null, 
			string m3_KR36 = null, 
			string m3_KR37 = null, 
			string m3_KR38 = null, 
			string m3_KR39 = null, 
			string m3_KR40 = null, 
			string m3_DCTP = null, 
			int? m3_DCRF = null, 
			int? m3_DCRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CreateLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_LONO))
				throw new ArgumentNullException("m3_LONO");
			if (string.IsNullOrWhiteSpace(m3_ACT0))
				throw new ArgumentNullException("m3_ACT0");

			// Set mandatory parameters
			request
				.WithQueryParameter("LONO", m3_LONO.Trim())
				.WithQueryParameter("ACT0", m3_ACT0.Trim())
				.WithQueryParameter("DEDT", m3_DEDT.ToM3String())
				.WithQueryParameter("DECT", m3_DECT.ToString())
				.WithQueryParameter("TMSX", m3_TMSX.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR01))
				request.WithQueryParameter("KR01", m3_KR01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR02))
				request.WithQueryParameter("KR02", m3_KR02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR03))
				request.WithQueryParameter("KR03", m3_KR03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR04))
				request.WithQueryParameter("KR04", m3_KR04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR05))
				request.WithQueryParameter("KR05", m3_KR05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR06))
				request.WithQueryParameter("KR06", m3_KR06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR07))
				request.WithQueryParameter("KR07", m3_KR07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR08))
				request.WithQueryParameter("KR08", m3_KR08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR09))
				request.WithQueryParameter("KR09", m3_KR09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR10))
				request.WithQueryParameter("KR10", m3_KR10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR11))
				request.WithQueryParameter("KR11", m3_KR11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR12))
				request.WithQueryParameter("KR12", m3_KR12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR13))
				request.WithQueryParameter("KR13", m3_KR13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR14))
				request.WithQueryParameter("KR14", m3_KR14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR15))
				request.WithQueryParameter("KR15", m3_KR15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR16))
				request.WithQueryParameter("KR16", m3_KR16.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR17))
				request.WithQueryParameter("KR17", m3_KR17.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR18))
				request.WithQueryParameter("KR18", m3_KR18.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR19))
				request.WithQueryParameter("KR19", m3_KR19.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR20))
				request.WithQueryParameter("KR20", m3_KR20.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR21))
				request.WithQueryParameter("KR21", m3_KR21.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR22))
				request.WithQueryParameter("KR22", m3_KR22.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR23))
				request.WithQueryParameter("KR23", m3_KR23.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR24))
				request.WithQueryParameter("KR24", m3_KR24.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR25))
				request.WithQueryParameter("KR25", m3_KR25.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR26))
				request.WithQueryParameter("KR26", m3_KR26.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR27))
				request.WithQueryParameter("KR27", m3_KR27.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR28))
				request.WithQueryParameter("KR28", m3_KR28.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR29))
				request.WithQueryParameter("KR29", m3_KR29.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR30))
				request.WithQueryParameter("KR30", m3_KR30.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR31))
				request.WithQueryParameter("KR31", m3_KR31.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR32))
				request.WithQueryParameter("KR32", m3_KR32.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR33))
				request.WithQueryParameter("KR33", m3_KR33.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR34))
				request.WithQueryParameter("KR34", m3_KR34.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR35))
				request.WithQueryParameter("KR35", m3_KR35.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR36))
				request.WithQueryParameter("KR36", m3_KR36.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR37))
				request.WithQueryParameter("KR37", m3_KR37.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR38))
				request.WithQueryParameter("KR38", m3_KR38.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR39))
				request.WithQueryParameter("KR39", m3_KR39.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR40))
				request.WithQueryParameter("KR40", m3_KR40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DCTP))
				request.WithQueryParameter("DCTP", m3_DCTP.Trim());
			if (m3_DCRF.HasValue)
				request.WithQueryParameter("DCRF", m3_DCRF.Value.ToString());
			if (m3_DCRT.HasValue)
				request.WithQueryParameter("DCRT", m3_DCRT.Value.ToString());

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
		/// Name DeleteHeader
		/// Description DeleteHeader
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_LONO">Actionlog number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteHeader(
			string m3_LONO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeleteHeader",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_LONO))
				throw new ArgumentNullException("m3_LONO");

			// Set mandatory parameters
			request
				.WithQueryParameter("LONO", m3_LONO.Trim());

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
		/// Name DeleteLine
		/// Description DeleteLine
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_LONO">Actionlog number (Required)</param>
		/// <param name="m3_ACTN">Action sequence number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteLine(
			string m3_LONO, 
			int m3_ACTN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeleteLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_LONO))
				throw new ArgumentNullException("m3_LONO");

			// Set mandatory parameters
			request
				.WithQueryParameter("LONO", m3_LONO.Trim())
				.WithQueryParameter("ACTN", m3_ACTN.ToString());

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
		/// Name Implement
		/// Description Implement
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_LONO">Actionlog number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ACTN">Action sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ImplementResponse></returns>
		/// <exception cref="M3Exception<ImplementResponse>"></exception>
		public async Task<M3Response<ImplementResponse>> Implement(
			string m3_LONO, 
			int? m3_CONO = null, 
			decimal? m3_ACTN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Implement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_LONO))
				throw new ArgumentNullException("m3_LONO");

			// Set mandatory parameters
			request
				.WithQueryParameter("LONO", m3_LONO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_ACTN.HasValue)
				request.WithQueryParameter("ACTN", m3_ACTN.Value.ToString());

			// Execute the request
			var result = await Execute<ImplementResponse>(
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
		/// Name ListHeader
		/// Description ListHeader
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LONO">Actionlog number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_ROLE">Role</param>
		/// <param name="m3_FSTS">From status</param>
		/// <param name="m3_TSTS">To status</param>
		/// <param name="m3_ORI1">Origin</param>
		/// <param name="m3_TRD1">Transfer date</param>
		/// <param name="m3_TRT5">Transfer time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListHeaderResponse></returns>
		/// <exception cref="M3Exception<ListHeaderResponse>"></exception>
		public async Task<M3Response<ListHeaderResponse>> ListHeader(
			int? m3_CONO = null, 
			string m3_LONO = null, 
			string m3_RESP = null, 
			string m3_ROLE = null, 
			string m3_FSTS = null, 
			string m3_TSTS = null, 
			string m3_ORI1 = null, 
			DateTime? m3_TRD1 = null, 
			int? m3_TRT5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ListHeader",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LONO))
				request.WithQueryParameter("LONO", m3_LONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ROLE))
				request.WithQueryParameter("ROLE", m3_ROLE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSTS))
				request.WithQueryParameter("FSTS", m3_FSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSTS))
				request.WithQueryParameter("TSTS", m3_TSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORI1))
				request.WithQueryParameter("ORI1", m3_ORI1.Trim());
			if (m3_TRD1.HasValue)
				request.WithQueryParameter("TRD1", m3_TRD1.Value.ToM3String());
			if (m3_TRT5.HasValue)
				request.WithQueryParameter("TRT5", m3_TRT5.Value.ToString());

			// Execute the request
			var result = await Execute<ListHeaderResponse>(
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
		/// Name ListLine
		/// Description ListLine
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LONO">Actionlog number</param>
		/// <param name="m3_DCTP">Decision type</param>
		/// <param name="m3_DCRF">Decision reference</param>
		/// <param name="m3_FSTS">From status</param>
		/// <param name="m3_TSTS">To status</param>
		/// <param name="m3_ACT0">Action type</param>
		/// <param name="m3_RES2">Responsible header</param>
		/// <param name="m3_ROLE">Role</param>
		/// <param name="m3_ORI1">Origin</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListLineResponse></returns>
		/// <exception cref="M3Exception<ListLineResponse>"></exception>
		public async Task<M3Response<ListLineResponse>> ListLine(
			int? m3_CONO = null, 
			string m3_LONO = null, 
			string m3_DCTP = null, 
			int? m3_DCRF = null, 
			string m3_FSTS = null, 
			string m3_TSTS = null, 
			string m3_ACT0 = null, 
			string m3_RES2 = null, 
			string m3_ROLE = null, 
			string m3_ORI1 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ListLine",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LONO))
				request.WithQueryParameter("LONO", m3_LONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DCTP))
				request.WithQueryParameter("DCTP", m3_DCTP.Trim());
			if (m3_DCRF.HasValue)
				request.WithQueryParameter("DCRF", m3_DCRF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FSTS))
				request.WithQueryParameter("FSTS", m3_FSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSTS))
				request.WithQueryParameter("TSTS", m3_TSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACT0))
				request.WithQueryParameter("ACT0", m3_ACT0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RES2))
				request.WithQueryParameter("RES2", m3_RES2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ROLE))
				request.WithQueryParameter("ROLE", m3_ROLE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORI1))
				request.WithQueryParameter("ORI1", m3_ORI1.Trim());

			// Execute the request
			var result = await Execute<ListLineResponse>(
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
		/// Name RtvMessage
		/// Description Retrieve Message
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_RTDA">Message ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RtvMessageResponse></returns>
		/// <exception cref="M3Exception<RtvMessageResponse>"></exception>
		public async Task<M3Response<RtvMessageResponse>> RtvMessage(
			string m3_RTDA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RtvMessage",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RTDA))
				request.WithQueryParameter("RTDA", m3_RTDA.Trim());

			// Execute the request
			var result = await Execute<RtvMessageResponse>(
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
		/// Name SndCreateLine
		/// Description SndCreateLine
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LONO">Actionlog number</param>
		/// <param name="m3_ACT0">Action type</param>
		/// <param name="m3_DEDT">Decision date</param>
		/// <param name="m3_DECT">Decision time</param>
		/// <param name="m3_TMSX">Time suffix</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_KR01">Alpha field 20 positions</param>
		/// <param name="m3_KR02">Alpha field 20 positions</param>
		/// <param name="m3_KR03">Alpha field 20 positions</param>
		/// <param name="m3_KR04">Alpha field 20 positions</param>
		/// <param name="m3_KR05">Alpha field 20 positions</param>
		/// <param name="m3_KR06">Alpha field 20 positions</param>
		/// <param name="m3_KR07">Alpha field 20 positions</param>
		/// <param name="m3_KR08">Alpha field 20 positions</param>
		/// <param name="m3_KR09">Alpha field 20 positions</param>
		/// <param name="m3_KR10">Alpha field 20 positions</param>
		/// <param name="m3_KR11">Alpha field 20 positions</param>
		/// <param name="m3_KR12">Alpha field 20 positions</param>
		/// <param name="m3_KR13">Alpha field 20 positions</param>
		/// <param name="m3_KR14">Alpha field 20 positions</param>
		/// <param name="m3_KR15">Alpha field 20 positions</param>
		/// <param name="m3_KR16">Alpha field 20 positions</param>
		/// <param name="m3_KR17">Alpha field 20 positions</param>
		/// <param name="m3_KR18">Alpha field 20 positions</param>
		/// <param name="m3_KR19">Alpha field 20 positions</param>
		/// <param name="m3_KR20">Alpha field 20 positions</param>
		/// <param name="m3_KR21">Alpha field 20 positions</param>
		/// <param name="m3_KR22">Alpha field 20 positions</param>
		/// <param name="m3_KR23">Alpha field 20 positions</param>
		/// <param name="m3_KR24">Alpha field 20 positions</param>
		/// <param name="m3_KR25">Alpha field 20 positions</param>
		/// <param name="m3_KR26">Alpha field 20 positions</param>
		/// <param name="m3_KR27">Alpha field 20 positions</param>
		/// <param name="m3_KR28">Alpha field 20 positions</param>
		/// <param name="m3_KR29">Alpha field 20 positions</param>
		/// <param name="m3_KR30">Alpha field 20 positions</param>
		/// <param name="m3_KR31">Alpha field 20 positions</param>
		/// <param name="m3_KR32">Alpha field 20 positions</param>
		/// <param name="m3_KR33">Alpha field 20 positions</param>
		/// <param name="m3_KR34">Alpha field 20 positions</param>
		/// <param name="m3_KR35">Alpha field 20 positions</param>
		/// <param name="m3_KR36">Alpha field 20 positions</param>
		/// <param name="m3_KR37">Alpha field 20 positions</param>
		/// <param name="m3_KR38">Alpha field 20 positions</param>
		/// <param name="m3_KR39">Alpha field 20 positions</param>
		/// <param name="m3_KR40">Alpha field 20 positions</param>
		/// <param name="m3_DCTP">Decision type</param>
		/// <param name="m3_DCRF">Decision reference</param>
		/// <param name="m3_DCRT">Decision reference type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndCreateLine(
			int? m3_CONO = null, 
			string m3_LONO = null, 
			string m3_ACT0 = null, 
			DateTime? m3_DEDT = null, 
			int? m3_DECT = null, 
			int? m3_TMSX = null, 
			string m3_RESP = null, 
			string m3_KR01 = null, 
			string m3_KR02 = null, 
			string m3_KR03 = null, 
			string m3_KR04 = null, 
			string m3_KR05 = null, 
			string m3_KR06 = null, 
			string m3_KR07 = null, 
			string m3_KR08 = null, 
			string m3_KR09 = null, 
			string m3_KR10 = null, 
			string m3_KR11 = null, 
			string m3_KR12 = null, 
			string m3_KR13 = null, 
			string m3_KR14 = null, 
			string m3_KR15 = null, 
			string m3_KR16 = null, 
			string m3_KR17 = null, 
			string m3_KR18 = null, 
			string m3_KR19 = null, 
			string m3_KR20 = null, 
			string m3_KR21 = null, 
			string m3_KR22 = null, 
			string m3_KR23 = null, 
			string m3_KR24 = null, 
			string m3_KR25 = null, 
			string m3_KR26 = null, 
			string m3_KR27 = null, 
			string m3_KR28 = null, 
			string m3_KR29 = null, 
			string m3_KR30 = null, 
			string m3_KR31 = null, 
			string m3_KR32 = null, 
			string m3_KR33 = null, 
			string m3_KR34 = null, 
			string m3_KR35 = null, 
			string m3_KR36 = null, 
			string m3_KR37 = null, 
			string m3_KR38 = null, 
			string m3_KR39 = null, 
			string m3_KR40 = null, 
			string m3_DCTP = null, 
			int? m3_DCRF = null, 
			int? m3_DCRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndCreateLine",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LONO))
				request.WithQueryParameter("LONO", m3_LONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACT0))
				request.WithQueryParameter("ACT0", m3_ACT0.Trim());
			if (m3_DEDT.HasValue)
				request.WithQueryParameter("DEDT", m3_DEDT.Value.ToM3String());
			if (m3_DECT.HasValue)
				request.WithQueryParameter("DECT", m3_DECT.Value.ToString());
			if (m3_TMSX.HasValue)
				request.WithQueryParameter("TMSX", m3_TMSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR01))
				request.WithQueryParameter("KR01", m3_KR01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR02))
				request.WithQueryParameter("KR02", m3_KR02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR03))
				request.WithQueryParameter("KR03", m3_KR03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR04))
				request.WithQueryParameter("KR04", m3_KR04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR05))
				request.WithQueryParameter("KR05", m3_KR05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR06))
				request.WithQueryParameter("KR06", m3_KR06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR07))
				request.WithQueryParameter("KR07", m3_KR07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR08))
				request.WithQueryParameter("KR08", m3_KR08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR09))
				request.WithQueryParameter("KR09", m3_KR09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR10))
				request.WithQueryParameter("KR10", m3_KR10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR11))
				request.WithQueryParameter("KR11", m3_KR11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR12))
				request.WithQueryParameter("KR12", m3_KR12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR13))
				request.WithQueryParameter("KR13", m3_KR13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR14))
				request.WithQueryParameter("KR14", m3_KR14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR15))
				request.WithQueryParameter("KR15", m3_KR15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR16))
				request.WithQueryParameter("KR16", m3_KR16.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR17))
				request.WithQueryParameter("KR17", m3_KR17.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR18))
				request.WithQueryParameter("KR18", m3_KR18.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR19))
				request.WithQueryParameter("KR19", m3_KR19.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR20))
				request.WithQueryParameter("KR20", m3_KR20.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR21))
				request.WithQueryParameter("KR21", m3_KR21.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR22))
				request.WithQueryParameter("KR22", m3_KR22.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR23))
				request.WithQueryParameter("KR23", m3_KR23.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR24))
				request.WithQueryParameter("KR24", m3_KR24.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR25))
				request.WithQueryParameter("KR25", m3_KR25.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR26))
				request.WithQueryParameter("KR26", m3_KR26.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR27))
				request.WithQueryParameter("KR27", m3_KR27.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR28))
				request.WithQueryParameter("KR28", m3_KR28.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR29))
				request.WithQueryParameter("KR29", m3_KR29.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR30))
				request.WithQueryParameter("KR30", m3_KR30.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR31))
				request.WithQueryParameter("KR31", m3_KR31.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR32))
				request.WithQueryParameter("KR32", m3_KR32.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR33))
				request.WithQueryParameter("KR33", m3_KR33.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR34))
				request.WithQueryParameter("KR34", m3_KR34.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR35))
				request.WithQueryParameter("KR35", m3_KR35.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR36))
				request.WithQueryParameter("KR36", m3_KR36.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR37))
				request.WithQueryParameter("KR37", m3_KR37.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR38))
				request.WithQueryParameter("KR38", m3_KR38.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR39))
				request.WithQueryParameter("KR39", m3_KR39.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KR40))
				request.WithQueryParameter("KR40", m3_KR40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DCTP))
				request.WithQueryParameter("DCTP", m3_DCTP.Trim());
			if (m3_DCRF.HasValue)
				request.WithQueryParameter("DCRF", m3_DCRF.Value.ToString());
			if (m3_DCRT.HasValue)
				request.WithQueryParameter("DCRT", m3_DCRT.Value.ToString());

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
