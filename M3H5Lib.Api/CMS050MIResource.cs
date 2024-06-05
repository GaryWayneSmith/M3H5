/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3LONO">Actionlog number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ACTN">Action sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CloseAction(
			string m3LONO, 
			int? m3CONO = null, 
			decimal? m3ACTN = null, 
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
			if (string.IsNullOrWhiteSpace(m3LONO))
				throw new ArgumentNullException(nameof(m3LONO));

			// Set mandatory parameters
			request
				.WithQueryParameter("LONO", m3LONO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACTN.HasValue)
				request.WithQueryParameter("ACTN", m3ACTN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name CreateHeader
		/// Description CreateHeader
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3ORI1">Origin (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3ROLE">Role</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<CreateHeaderResponse></returns>
		/// <exception cref="M3Exception<CreateHeaderResponse>"></exception>
		public async Task<M3Response<CreateHeaderResponse>> CreateHeader(
			string m3ORI1, 
			int? m3CONO = null, 
			string m3RESP = null, 
			string m3ROLE = null, 
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
			if (string.IsNullOrWhiteSpace(m3ORI1))
				throw new ArgumentNullException(nameof(m3ORI1));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORI1", m3ORI1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ROLE))
				request.WithQueryParameter("ROLE", m3ROLE.Trim());

			// Execute the request
			var result = await Execute<CreateHeaderResponse>(
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
		/// Name CreateLine
		/// Description CreateLine
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3LONO">Actionlog number (Required)</param>
		/// <param name="m3ACT0">Action type (Required)</param>
		/// <param name="m3DEDT">Decision date (Required)</param>
		/// <param name="m3DECT">Decision time (Required)</param>
		/// <param name="m3TMSX">Time suffix (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3KR01">Key/result1</param>
		/// <param name="m3KR02">Key/result2</param>
		/// <param name="m3KR03">Key/result3</param>
		/// <param name="m3KR04">Key/result4</param>
		/// <param name="m3KR05">Key/result5</param>
		/// <param name="m3KR06">Key/result6</param>
		/// <param name="m3KR07">Key/result7</param>
		/// <param name="m3KR08">Key/result8</param>
		/// <param name="m3KR09">Key/result9</param>
		/// <param name="m3KR10">Key/result10</param>
		/// <param name="m3KR11">Key/result11</param>
		/// <param name="m3KR12">Key/result12</param>
		/// <param name="m3KR13">Key/result13</param>
		/// <param name="m3KR14">Key/result14</param>
		/// <param name="m3KR15">Key/result15</param>
		/// <param name="m3KR16">Key/result16</param>
		/// <param name="m3KR17">Key/result17</param>
		/// <param name="m3KR18">Key/result18</param>
		/// <param name="m3KR19">Key/result19</param>
		/// <param name="m3KR20">Key/result20</param>
		/// <param name="m3KR21">Key/result21</param>
		/// <param name="m3KR22">Key/result22</param>
		/// <param name="m3KR23">Key/result23</param>
		/// <param name="m3KR24">Key/result24</param>
		/// <param name="m3KR25">Key/result25</param>
		/// <param name="m3KR26">Key/result26</param>
		/// <param name="m3KR27">Key/result27</param>
		/// <param name="m3KR28">Key/result28</param>
		/// <param name="m3KR29">Key/result29</param>
		/// <param name="m3KR30">Key/result30</param>
		/// <param name="m3KR31">Key/result31</param>
		/// <param name="m3KR32">Key/result32</param>
		/// <param name="m3KR33">Key/result33</param>
		/// <param name="m3KR34">Key/result34</param>
		/// <param name="m3KR35">Key/result35</param>
		/// <param name="m3KR36">Key/result36</param>
		/// <param name="m3KR37">Key/result37</param>
		/// <param name="m3KR38">Key/result38</param>
		/// <param name="m3KR39">Key/result39</param>
		/// <param name="m3KR40">Key/result40</param>
		/// <param name="m3DCTP">Decision type</param>
		/// <param name="m3DCRF">Decision reference</param>
		/// <param name="m3DCRT">Data reference type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CreateLine(
			string m3LONO, 
			string m3ACT0, 
			DateTime m3DEDT, 
			int m3DECT, 
			int m3TMSX, 
			int? m3CONO = null, 
			string m3RESP = null, 
			string m3KR01 = null, 
			string m3KR02 = null, 
			string m3KR03 = null, 
			string m3KR04 = null, 
			string m3KR05 = null, 
			string m3KR06 = null, 
			string m3KR07 = null, 
			string m3KR08 = null, 
			string m3KR09 = null, 
			string m3KR10 = null, 
			string m3KR11 = null, 
			string m3KR12 = null, 
			string m3KR13 = null, 
			string m3KR14 = null, 
			string m3KR15 = null, 
			string m3KR16 = null, 
			string m3KR17 = null, 
			string m3KR18 = null, 
			string m3KR19 = null, 
			string m3KR20 = null, 
			string m3KR21 = null, 
			string m3KR22 = null, 
			string m3KR23 = null, 
			string m3KR24 = null, 
			string m3KR25 = null, 
			string m3KR26 = null, 
			string m3KR27 = null, 
			string m3KR28 = null, 
			string m3KR29 = null, 
			string m3KR30 = null, 
			string m3KR31 = null, 
			string m3KR32 = null, 
			string m3KR33 = null, 
			string m3KR34 = null, 
			string m3KR35 = null, 
			string m3KR36 = null, 
			string m3KR37 = null, 
			string m3KR38 = null, 
			string m3KR39 = null, 
			string m3KR40 = null, 
			string m3DCTP = null, 
			int? m3DCRF = null, 
			int? m3DCRT = null, 
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
			if (string.IsNullOrWhiteSpace(m3LONO))
				throw new ArgumentNullException(nameof(m3LONO));
			if (string.IsNullOrWhiteSpace(m3ACT0))
				throw new ArgumentNullException(nameof(m3ACT0));

			// Set mandatory parameters
			request
				.WithQueryParameter("LONO", m3LONO.Trim())
				.WithQueryParameter("ACT0", m3ACT0.Trim())
				.WithQueryParameter("DEDT", m3DEDT.ToM3String())
				.WithQueryParameter("DECT", m3DECT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TMSX", m3TMSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR01))
				request.WithQueryParameter("KR01", m3KR01.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR02))
				request.WithQueryParameter("KR02", m3KR02.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR03))
				request.WithQueryParameter("KR03", m3KR03.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR04))
				request.WithQueryParameter("KR04", m3KR04.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR05))
				request.WithQueryParameter("KR05", m3KR05.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR06))
				request.WithQueryParameter("KR06", m3KR06.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR07))
				request.WithQueryParameter("KR07", m3KR07.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR08))
				request.WithQueryParameter("KR08", m3KR08.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR09))
				request.WithQueryParameter("KR09", m3KR09.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR10))
				request.WithQueryParameter("KR10", m3KR10.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR11))
				request.WithQueryParameter("KR11", m3KR11.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR12))
				request.WithQueryParameter("KR12", m3KR12.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR13))
				request.WithQueryParameter("KR13", m3KR13.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR14))
				request.WithQueryParameter("KR14", m3KR14.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR15))
				request.WithQueryParameter("KR15", m3KR15.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR16))
				request.WithQueryParameter("KR16", m3KR16.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR17))
				request.WithQueryParameter("KR17", m3KR17.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR18))
				request.WithQueryParameter("KR18", m3KR18.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR19))
				request.WithQueryParameter("KR19", m3KR19.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR20))
				request.WithQueryParameter("KR20", m3KR20.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR21))
				request.WithQueryParameter("KR21", m3KR21.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR22))
				request.WithQueryParameter("KR22", m3KR22.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR23))
				request.WithQueryParameter("KR23", m3KR23.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR24))
				request.WithQueryParameter("KR24", m3KR24.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR25))
				request.WithQueryParameter("KR25", m3KR25.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR26))
				request.WithQueryParameter("KR26", m3KR26.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR27))
				request.WithQueryParameter("KR27", m3KR27.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR28))
				request.WithQueryParameter("KR28", m3KR28.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR29))
				request.WithQueryParameter("KR29", m3KR29.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR30))
				request.WithQueryParameter("KR30", m3KR30.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR31))
				request.WithQueryParameter("KR31", m3KR31.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR32))
				request.WithQueryParameter("KR32", m3KR32.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR33))
				request.WithQueryParameter("KR33", m3KR33.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR34))
				request.WithQueryParameter("KR34", m3KR34.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR35))
				request.WithQueryParameter("KR35", m3KR35.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR36))
				request.WithQueryParameter("KR36", m3KR36.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR37))
				request.WithQueryParameter("KR37", m3KR37.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR38))
				request.WithQueryParameter("KR38", m3KR38.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR39))
				request.WithQueryParameter("KR39", m3KR39.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR40))
				request.WithQueryParameter("KR40", m3KR40.Trim());
			if (!string.IsNullOrWhiteSpace(m3DCTP))
				request.WithQueryParameter("DCTP", m3DCTP.Trim());
			if (m3DCRF.HasValue)
				request.WithQueryParameter("DCRF", m3DCRF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DCRT.HasValue)
				request.WithQueryParameter("DCRT", m3DCRT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DeleteHeader
		/// Description DeleteHeader
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3LONO">Actionlog number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteHeader(
			string m3LONO, 
			int? m3CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3LONO))
				throw new ArgumentNullException(nameof(m3LONO));

			// Set mandatory parameters
			request
				.WithQueryParameter("LONO", m3LONO.Trim());

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
		/// Name DeleteLine
		/// Description DeleteLine
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3LONO">Actionlog number (Required)</param>
		/// <param name="m3ACTN">Action sequence number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteLine(
			string m3LONO, 
			int m3ACTN, 
			int? m3CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3LONO))
				throw new ArgumentNullException(nameof(m3LONO));

			// Set mandatory parameters
			request
				.WithQueryParameter("LONO", m3LONO.Trim())
				.WithQueryParameter("ACTN", m3ACTN.ToString(CultureInfo.CurrentCulture));

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
		/// Name Implement
		/// Description Implement
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3LONO">Actionlog number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ACTN">Action sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ImplementResponse></returns>
		/// <exception cref="M3Exception<ImplementResponse>"></exception>
		public async Task<M3Response<ImplementResponse>> Implement(
			string m3LONO, 
			int? m3CONO = null, 
			decimal? m3ACTN = null, 
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
			if (string.IsNullOrWhiteSpace(m3LONO))
				throw new ArgumentNullException(nameof(m3LONO));

			// Set mandatory parameters
			request
				.WithQueryParameter("LONO", m3LONO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACTN.HasValue)
				request.WithQueryParameter("ACTN", m3ACTN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ImplementResponse>(
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
		/// Name ListHeader
		/// Description ListHeader
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LONO">Actionlog number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3ROLE">Role</param>
		/// <param name="m3FSTS">From status</param>
		/// <param name="m3TSTS">To status</param>
		/// <param name="m3ORI1">Origin</param>
		/// <param name="m3TRD1">Transfer date</param>
		/// <param name="m3TRT5">Transfer time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListHeaderResponse></returns>
		/// <exception cref="M3Exception<ListHeaderResponse>"></exception>
		public async Task<M3Response<ListHeaderResponse>> ListHeader(
			int? m3CONO = null, 
			string m3LONO = null, 
			string m3RESP = null, 
			string m3ROLE = null, 
			string m3FSTS = null, 
			string m3TSTS = null, 
			string m3ORI1 = null, 
			DateTime? m3TRD1 = null, 
			int? m3TRT5 = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LONO))
				request.WithQueryParameter("LONO", m3LONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ROLE))
				request.WithQueryParameter("ROLE", m3ROLE.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSTS))
				request.WithQueryParameter("FSTS", m3FSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSTS))
				request.WithQueryParameter("TSTS", m3TSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORI1))
				request.WithQueryParameter("ORI1", m3ORI1.Trim());
			if (m3TRD1.HasValue)
				request.WithQueryParameter("TRD1", m3TRD1.Value.ToM3String());
			if (m3TRT5.HasValue)
				request.WithQueryParameter("TRT5", m3TRT5.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ListHeaderResponse>(
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
		/// Name ListLine
		/// Description ListLine
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LONO">Actionlog number</param>
		/// <param name="m3DCTP">Decision type</param>
		/// <param name="m3DCRF">Decision reference</param>
		/// <param name="m3FSTS">From status</param>
		/// <param name="m3TSTS">To status</param>
		/// <param name="m3ACT0">Action type</param>
		/// <param name="m3RES2">Responsible header</param>
		/// <param name="m3ROLE">Role</param>
		/// <param name="m3ORI1">Origin</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListLineResponse></returns>
		/// <exception cref="M3Exception<ListLineResponse>"></exception>
		public async Task<M3Response<ListLineResponse>> ListLine(
			int? m3CONO = null, 
			string m3LONO = null, 
			string m3DCTP = null, 
			int? m3DCRF = null, 
			string m3FSTS = null, 
			string m3TSTS = null, 
			string m3ACT0 = null, 
			string m3RES2 = null, 
			string m3ROLE = null, 
			string m3ORI1 = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LONO))
				request.WithQueryParameter("LONO", m3LONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DCTP))
				request.WithQueryParameter("DCTP", m3DCTP.Trim());
			if (m3DCRF.HasValue)
				request.WithQueryParameter("DCRF", m3DCRF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FSTS))
				request.WithQueryParameter("FSTS", m3FSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSTS))
				request.WithQueryParameter("TSTS", m3TSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACT0))
				request.WithQueryParameter("ACT0", m3ACT0.Trim());
			if (!string.IsNullOrWhiteSpace(m3RES2))
				request.WithQueryParameter("RES2", m3RES2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ROLE))
				request.WithQueryParameter("ROLE", m3ROLE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORI1))
				request.WithQueryParameter("ORI1", m3ORI1.Trim());

			// Execute the request
			var result = await Execute<ListLineResponse>(
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
		/// Name RtvMessage
		/// Description Retrieve Message
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3RTDA">Message ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RtvMessageResponse></returns>
		/// <exception cref="M3Exception<RtvMessageResponse>"></exception>
		public async Task<M3Response<RtvMessageResponse>> RtvMessage(
			string m3RTDA = null, 
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
			if (!string.IsNullOrWhiteSpace(m3RTDA))
				request.WithQueryParameter("RTDA", m3RTDA.Trim());

			// Execute the request
			var result = await Execute<RtvMessageResponse>(
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
		/// Name SndCreateLine
		/// Description SndCreateLine
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LONO">Actionlog number</param>
		/// <param name="m3ACT0">Action type</param>
		/// <param name="m3DEDT">Decision date</param>
		/// <param name="m3DECT">Decision time</param>
		/// <param name="m3TMSX">Time suffix</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3KR01">Alpha field 20 positions</param>
		/// <param name="m3KR02">Alpha field 20 positions</param>
		/// <param name="m3KR03">Alpha field 20 positions</param>
		/// <param name="m3KR04">Alpha field 20 positions</param>
		/// <param name="m3KR05">Alpha field 20 positions</param>
		/// <param name="m3KR06">Alpha field 20 positions</param>
		/// <param name="m3KR07">Alpha field 20 positions</param>
		/// <param name="m3KR08">Alpha field 20 positions</param>
		/// <param name="m3KR09">Alpha field 20 positions</param>
		/// <param name="m3KR10">Alpha field 20 positions</param>
		/// <param name="m3KR11">Alpha field 20 positions</param>
		/// <param name="m3KR12">Alpha field 20 positions</param>
		/// <param name="m3KR13">Alpha field 20 positions</param>
		/// <param name="m3KR14">Alpha field 20 positions</param>
		/// <param name="m3KR15">Alpha field 20 positions</param>
		/// <param name="m3KR16">Alpha field 20 positions</param>
		/// <param name="m3KR17">Alpha field 20 positions</param>
		/// <param name="m3KR18">Alpha field 20 positions</param>
		/// <param name="m3KR19">Alpha field 20 positions</param>
		/// <param name="m3KR20">Alpha field 20 positions</param>
		/// <param name="m3KR21">Alpha field 20 positions</param>
		/// <param name="m3KR22">Alpha field 20 positions</param>
		/// <param name="m3KR23">Alpha field 20 positions</param>
		/// <param name="m3KR24">Alpha field 20 positions</param>
		/// <param name="m3KR25">Alpha field 20 positions</param>
		/// <param name="m3KR26">Alpha field 20 positions</param>
		/// <param name="m3KR27">Alpha field 20 positions</param>
		/// <param name="m3KR28">Alpha field 20 positions</param>
		/// <param name="m3KR29">Alpha field 20 positions</param>
		/// <param name="m3KR30">Alpha field 20 positions</param>
		/// <param name="m3KR31">Alpha field 20 positions</param>
		/// <param name="m3KR32">Alpha field 20 positions</param>
		/// <param name="m3KR33">Alpha field 20 positions</param>
		/// <param name="m3KR34">Alpha field 20 positions</param>
		/// <param name="m3KR35">Alpha field 20 positions</param>
		/// <param name="m3KR36">Alpha field 20 positions</param>
		/// <param name="m3KR37">Alpha field 20 positions</param>
		/// <param name="m3KR38">Alpha field 20 positions</param>
		/// <param name="m3KR39">Alpha field 20 positions</param>
		/// <param name="m3KR40">Alpha field 20 positions</param>
		/// <param name="m3DCTP">Decision type</param>
		/// <param name="m3DCRF">Decision reference</param>
		/// <param name="m3DCRT">Decision reference type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndCreateLine(
			int? m3CONO = null, 
			string m3LONO = null, 
			string m3ACT0 = null, 
			DateTime? m3DEDT = null, 
			int? m3DECT = null, 
			int? m3TMSX = null, 
			string m3RESP = null, 
			string m3KR01 = null, 
			string m3KR02 = null, 
			string m3KR03 = null, 
			string m3KR04 = null, 
			string m3KR05 = null, 
			string m3KR06 = null, 
			string m3KR07 = null, 
			string m3KR08 = null, 
			string m3KR09 = null, 
			string m3KR10 = null, 
			string m3KR11 = null, 
			string m3KR12 = null, 
			string m3KR13 = null, 
			string m3KR14 = null, 
			string m3KR15 = null, 
			string m3KR16 = null, 
			string m3KR17 = null, 
			string m3KR18 = null, 
			string m3KR19 = null, 
			string m3KR20 = null, 
			string m3KR21 = null, 
			string m3KR22 = null, 
			string m3KR23 = null, 
			string m3KR24 = null, 
			string m3KR25 = null, 
			string m3KR26 = null, 
			string m3KR27 = null, 
			string m3KR28 = null, 
			string m3KR29 = null, 
			string m3KR30 = null, 
			string m3KR31 = null, 
			string m3KR32 = null, 
			string m3KR33 = null, 
			string m3KR34 = null, 
			string m3KR35 = null, 
			string m3KR36 = null, 
			string m3KR37 = null, 
			string m3KR38 = null, 
			string m3KR39 = null, 
			string m3KR40 = null, 
			string m3DCTP = null, 
			int? m3DCRF = null, 
			int? m3DCRT = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LONO))
				request.WithQueryParameter("LONO", m3LONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACT0))
				request.WithQueryParameter("ACT0", m3ACT0.Trim());
			if (m3DEDT.HasValue)
				request.WithQueryParameter("DEDT", m3DEDT.Value.ToM3String());
			if (m3DECT.HasValue)
				request.WithQueryParameter("DECT", m3DECT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TMSX.HasValue)
				request.WithQueryParameter("TMSX", m3TMSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR01))
				request.WithQueryParameter("KR01", m3KR01.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR02))
				request.WithQueryParameter("KR02", m3KR02.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR03))
				request.WithQueryParameter("KR03", m3KR03.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR04))
				request.WithQueryParameter("KR04", m3KR04.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR05))
				request.WithQueryParameter("KR05", m3KR05.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR06))
				request.WithQueryParameter("KR06", m3KR06.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR07))
				request.WithQueryParameter("KR07", m3KR07.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR08))
				request.WithQueryParameter("KR08", m3KR08.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR09))
				request.WithQueryParameter("KR09", m3KR09.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR10))
				request.WithQueryParameter("KR10", m3KR10.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR11))
				request.WithQueryParameter("KR11", m3KR11.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR12))
				request.WithQueryParameter("KR12", m3KR12.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR13))
				request.WithQueryParameter("KR13", m3KR13.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR14))
				request.WithQueryParameter("KR14", m3KR14.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR15))
				request.WithQueryParameter("KR15", m3KR15.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR16))
				request.WithQueryParameter("KR16", m3KR16.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR17))
				request.WithQueryParameter("KR17", m3KR17.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR18))
				request.WithQueryParameter("KR18", m3KR18.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR19))
				request.WithQueryParameter("KR19", m3KR19.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR20))
				request.WithQueryParameter("KR20", m3KR20.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR21))
				request.WithQueryParameter("KR21", m3KR21.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR22))
				request.WithQueryParameter("KR22", m3KR22.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR23))
				request.WithQueryParameter("KR23", m3KR23.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR24))
				request.WithQueryParameter("KR24", m3KR24.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR25))
				request.WithQueryParameter("KR25", m3KR25.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR26))
				request.WithQueryParameter("KR26", m3KR26.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR27))
				request.WithQueryParameter("KR27", m3KR27.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR28))
				request.WithQueryParameter("KR28", m3KR28.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR29))
				request.WithQueryParameter("KR29", m3KR29.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR30))
				request.WithQueryParameter("KR30", m3KR30.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR31))
				request.WithQueryParameter("KR31", m3KR31.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR32))
				request.WithQueryParameter("KR32", m3KR32.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR33))
				request.WithQueryParameter("KR33", m3KR33.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR34))
				request.WithQueryParameter("KR34", m3KR34.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR35))
				request.WithQueryParameter("KR35", m3KR35.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR36))
				request.WithQueryParameter("KR36", m3KR36.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR37))
				request.WithQueryParameter("KR37", m3KR37.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR38))
				request.WithQueryParameter("KR38", m3KR38.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR39))
				request.WithQueryParameter("KR39", m3KR39.Trim());
			if (!string.IsNullOrWhiteSpace(m3KR40))
				request.WithQueryParameter("KR40", m3KR40.Trim());
			if (!string.IsNullOrWhiteSpace(m3DCTP))
				request.WithQueryParameter("DCTP", m3DCTP.Trim());
			if (m3DCRF.HasValue)
				request.WithQueryParameter("DCRF", m3DCRF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DCRT.HasValue)
				request.WithQueryParameter("DCRT", m3DCRT.Value.ToString(CultureInfo.CurrentCulture));

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
