/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.CRSPCIMI;
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
	/// Name: CRSPCIMI
	/// Component Name: Sales configurator
	/// Description: Sales configurator API
	/// Version Release: 5ea1
	///</summary>
	public partial class CRSPCIMIResource : M3BaseResourceEndpoint
	{
		public CRSPCIMIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRSPCIMI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name DltAttrLine
		/// Description Delete attribute line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATNR">Attribute number (Required)</param>
		/// <param name="m3SIMD">Simulation (Required)</param>
		/// <param name="m3ATID">Attribute identity</param>
		/// <param name="m3AVSQ">Attribute value sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAttrLine(
			decimal m3ATNR, 
			int m3SIMD, 
			string m3ATID = null, 
			int? m3AVSQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltAttrLine",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("ATNR", m3ATNR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SIMD", m3SIMD.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ATID))
				request.WithQueryParameter("ATID", m3ATID.Trim());
			if (m3AVSQ.HasValue)
				request.WithQueryParameter("AVSQ", m3AVSQ.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltAttrModel
		/// Description Delete attribute model
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3SIMD">Simulation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAttrModel(
			decimal? m3ATNR = null, 
			int? m3SIMD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltAttrModel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3SIMD.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetAttrInfo
		/// Description GetAttrInfo
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3ATID">Attribute identity</param>
		/// <param name="m3ATMO">Attribute model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAttrInfoResponse></returns>
		/// <exception cref="M3Exception<GetAttrInfoResponse>"></exception>
		public async Task<M3Response<GetAttrInfoResponse>> GetAttrInfo(
			string m3ATID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAttrInfo",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ATID))
				request.WithQueryParameter("ATID", m3ATID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATMO))
				request.WithQueryParameter("ATMO", m3ATMO.Trim());

			// Execute the request
			var result = await Execute<GetAttrInfoResponse>(
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
		/// Name GetAttrLine
		/// Description Get attribute line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ATMO">Attribute model (Required)</param>
		/// <param name="m3ATID">Attribute identity (Required)</param>
		/// <param name="m3ATNR">Attribute number (Required)</param>
		/// <param name="m3SIMD">Simulation</param>
		/// <param name="m3ATNB">Attribute number lot</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3PRDT">Price date</param>
		/// <param name="m3OFNO">Quotation number</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3DSPS">Forced sequence</param>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAttrLineResponse></returns>
		/// <exception cref="M3Exception<GetAttrLineResponse>"></exception>
		public async Task<M3Response<GetAttrLineResponse>> GetAttrLine(
			string m3ATMO, 
			string m3ATID, 
			decimal m3ATNR, 
			int? m3SIMD = null, 
			decimal? m3ATNB = null, 
			string m3CUCD = null, 
			DateTime? m3PRDT = null, 
			string m3OFNO = null, 
			int? m3VERS = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
			int? m3DSPS = null, 
			string m3ORCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAttrLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ATMO))
				throw new ArgumentNullException(nameof(m3ATMO));
			if (string.IsNullOrWhiteSpace(m3ATID))
				throw new ArgumentNullException(nameof(m3ATID));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATMO", m3ATMO.Trim())
				.WithQueryParameter("ATID", m3ATID.Trim())
				.WithQueryParameter("ATNR", m3ATNR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3SIMD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNB.HasValue)
				request.WithQueryParameter("ATNB", m3ATNB.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3OFNO))
				request.WithQueryParameter("OFNO", m3OFNO.Trim());
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSPS.HasValue)
				request.WithQueryParameter("DSPS", m3DSPS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());

			// Execute the request
			var result = await Execute<GetAttrLineResponse>(
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
		/// Name GetForcedSeq
		/// Description Get forced sequence number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3SIMD">Simulation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetForcedSeqResponse></returns>
		/// <exception cref="M3Exception<GetForcedSeqResponse>"></exception>
		public async Task<M3Response<GetForcedSeqResponse>> GetForcedSeq(
			decimal? m3ATNR = null, 
			int? m3SIMD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetForcedSeq",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3SIMD.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetForcedSeqResponse>(
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
		/// Name GetHeadings
		/// Description Get headings
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadingsResponse></returns>
		/// <exception cref="M3Exception<GetHeadingsResponse>"></exception>
		public async Task<M3Response<GetHeadingsResponse>> GetHeadings(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHeadings",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetHeadingsResponse>(
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
		/// Name GetHeadings2
		/// Description Get headings 2
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadings2Response></returns>
		/// <exception cref="M3Exception<GetHeadings2Response>"></exception>
		public async Task<M3Response<GetHeadings2Response>> GetHeadings2(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHeadings2",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetHeadings2Response>(
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
		/// Name GetStartValues
		/// Description Get start values
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ORCA">Order category (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3SIMD">Simulation</param>
		/// <param name="m3ATNB">Attribute number lot</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3OFNO">Quotation number</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3PRDT">Price date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetStartValuesResponse></returns>
		/// <exception cref="M3Exception<GetStartValuesResponse>"></exception>
		public async Task<M3Response<GetStartValuesResponse>> GetStartValues(
			string m3ORCA, 
			string m3ITNO, 
			string m3CUCD, 
			decimal? m3ATNR = null, 
			int? m3SIMD = null, 
			decimal? m3ATNB = null, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
			string m3OFNO = null, 
			int? m3VERS = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
			DateTime? m3PRDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetStartValues",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORCA))
				throw new ArgumentNullException(nameof(m3ORCA));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORCA", m3ORCA.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3SIMD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNB.HasValue)
				request.WithQueryParameter("ATNB", m3ATNB.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OFNO))
				request.WithQueryParameter("OFNO", m3OFNO.Trim());
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3PRDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetStartValuesResponse>(
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
		/// Name GetSumHead
		/// Description Get summary head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3SIMD">Simulation</param>
		/// <param name="m3ATNB">Attribute number lot</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3PRDT">Priority date</param>
		/// <param name="m3OFNO">Quotation number</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSumHeadResponse></returns>
		/// <exception cref="M3Exception<GetSumHeadResponse>"></exception>
		public async Task<M3Response<GetSumHeadResponse>> GetSumHead(
			decimal? m3ATNR = null, 
			int? m3SIMD = null, 
			decimal? m3ATNB = null, 
			string m3CUCD = null, 
			DateTime? m3PRDT = null, 
			string m3OFNO = null, 
			int? m3VERS = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
			string m3ORCA = null, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSumHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3SIMD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNB.HasValue)
				request.WithQueryParameter("ATNB", m3ATNB.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3OFNO))
				request.WithQueryParameter("OFNO", m3OFNO.Trim());
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetSumHeadResponse>(
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
		/// Name GetUserLanguage
		/// Description Get user language
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetUserLanguageResponse></returns>
		/// <exception cref="M3Exception<GetUserLanguageResponse>"></exception>
		public async Task<M3Response<GetUserLanguageResponse>> GetUserLanguage(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetUserLanguage",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetUserLanguageResponse>(
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
		/// Name GetValues
		/// Description GetValues
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3SIMD">Simulation</param>
		/// <param name="m3ATNB">Attribute number lot</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3OFNO">Quotation number</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="m3NONE">Not used</param>
		/// <param name="m3PONR">Order line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3PRDT">Price date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetValuesResponse></returns>
		/// <exception cref="M3Exception<GetValuesResponse>"></exception>
		public async Task<M3Response<GetValuesResponse>> GetValues(
			string m3ORCA = null, 
			string m3ITNO = null, 
			string m3CUCD = null, 
			decimal? m3ATNR = null, 
			int? m3SIMD = null, 
			decimal? m3ATNB = null, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
			string m3OFNO = null, 
			int? m3VERS = null, 
			string m3NONE = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
			DateTime? m3PRDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetValues",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3SIMD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNB.HasValue)
				request.WithQueryParameter("ATNB", m3ATNB.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OFNO))
				request.WithQueryParameter("OFNO", m3OFNO.Trim());
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NONE))
				request.WithQueryParameter("NONE", m3NONE.Trim());
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3PRDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetValuesResponse>(
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
		/// Name LstAttrLineText
		/// Description List attribute model line text
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATMO">Attribute model</param>
		/// <param name="m3ATID">Attribute identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrLineTextResponse></returns>
		/// <exception cref="M3Exception<LstAttrLineTextResponse>"></exception>
		public async Task<M3Response<LstAttrLineTextResponse>> LstAttrLineText(
			string m3ATMO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAttrLineText",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ATMO))
				request.WithQueryParameter("ATMO", m3ATMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATID))
				request.WithQueryParameter("ATID", m3ATID.Trim());

			// Execute the request
			var result = await Execute<LstAttrLineTextResponse>(
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
		/// Name LstAttrLines
		/// Description List attribute lines connected to display group
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ATMO">Attribute model (Required)</param>
		/// <param name="m3DSPG">Display group (Required)</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3SIMD">Simulation</param>
		/// <param name="m3ATNB">Attribute number lot</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3PRDT">Price date</param>
		/// <param name="m3OFNO">Quotation number</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3DSPS">Forced sequence</param>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrLinesResponse></returns>
		/// <exception cref="M3Exception<LstAttrLinesResponse>"></exception>
		public async Task<M3Response<LstAttrLinesResponse>> LstAttrLines(
			string m3ATMO, 
			string m3DSPG, 
			decimal? m3ATNR = null, 
			int? m3SIMD = null, 
			decimal? m3ATNB = null, 
			string m3CUCD = null, 
			DateTime? m3PRDT = null, 
			string m3OFNO = null, 
			int? m3VERS = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
			int? m3DSPS = null, 
			string m3ORCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAttrLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ATMO))
				throw new ArgumentNullException(nameof(m3ATMO));
			if (string.IsNullOrWhiteSpace(m3DSPG))
				throw new ArgumentNullException(nameof(m3DSPG));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATMO", m3ATMO.Trim())
				.WithQueryParameter("DSPG", m3DSPG.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3SIMD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNB.HasValue)
				request.WithQueryParameter("ATNB", m3ATNB.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3OFNO))
				request.WithQueryParameter("OFNO", m3OFNO.Trim());
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSPS.HasValue)
				request.WithQueryParameter("DSPS", m3DSPS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());

			// Execute the request
			var result = await Execute<LstAttrLinesResponse>(
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
		/// Name LstAttrModels
		/// Description List attribute models for product group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITCL">Product group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrModelsResponse></returns>
		/// <exception cref="M3Exception<LstAttrModelsResponse>"></exception>
		public async Task<M3Response<LstAttrModelsResponse>> LstAttrModels(
			string m3ITCL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAttrModels",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITCL))
				request.WithQueryParameter("ITCL", m3ITCL.Trim());

			// Execute the request
			var result = await Execute<LstAttrModelsResponse>(
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
		/// Name LstAttrValueTxt
		/// Description List attribute value line text
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrValueTxtResponse></returns>
		/// <exception cref="M3Exception<LstAttrValueTxtResponse>"></exception>
		public async Task<M3Response<LstAttrValueTxtResponse>> LstAttrValueTxt(
			decimal? m3TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAttrValueTxt",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAttrValueTxtResponse>(
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
		/// Name LstAttrValues
		/// Description List attribute values
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ATID">Attribute identity (Required)</param>
		/// <param name="m3ATNR">Attribute number (Required)</param>
		/// <param name="m3SIMD">Simulation (Required)</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3PRDT">Price date</param>
		/// <param name="m3OFNO">Quotation number</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3LALL">List all attribute values</param>
		/// <param name="m3CFOK">Search attribute OK</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3ORTP">Customer order type</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3CSC1">Country</param>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3EQNO">Equipment number</param>
		/// <param name="m3BIRT">Origin identity</param>
		/// <param name="m3TAIL">Registration number/site</param>
		/// <param name="m3AVSQ">Sequence number of attribute value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrValuesResponse></returns>
		/// <exception cref="M3Exception<LstAttrValuesResponse>"></exception>
		public async Task<M3Response<LstAttrValuesResponse>> LstAttrValues(
			string m3ATID, 
			decimal m3ATNR, 
			int m3SIMD, 
			string m3CUCD = null, 
			DateTime? m3PRDT = null, 
			string m3OFNO = null, 
			int? m3VERS = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
			int? m3LALL = null, 
			int? m3CFOK = null, 
			string m3ITNO = null, 
			string m3CUNO = null, 
			string m3ORTP = null, 
			string m3CSCD = null, 
			string m3PROJ = null, 
			string m3SUNO = null, 
			string m3ORTY = null, 
			string m3CSC1 = null, 
			string m3ORCA = null, 
			string m3WHLO = null, 
			string m3FACI = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3BANO = null, 
			string m3EQNO = null, 
			long? m3BIRT = null, 
			string m3TAIL = null, 
			int? m3AVSQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAttrValues",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ATID))
				throw new ArgumentNullException(nameof(m3ATID));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3ATID.Trim())
				.WithQueryParameter("ATNR", m3ATNR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SIMD", m3SIMD.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3OFNO))
				request.WithQueryParameter("OFNO", m3OFNO.Trim());
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LALL.HasValue)
				request.WithQueryParameter("LALL", m3LALL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFOK.HasValue)
				request.WithQueryParameter("CFOK", m3CFOK.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTP))
				request.WithQueryParameter("ORTP", m3ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSC1))
				request.WithQueryParameter("CSC1", m3CSC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQNO))
				request.WithQueryParameter("EQNO", m3EQNO.Trim());
			if (m3BIRT.HasValue)
				request.WithQueryParameter("BIRT", m3BIRT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TAIL))
				request.WithQueryParameter("TAIL", m3TAIL.Trim());
			if (m3AVSQ.HasValue)
				request.WithQueryParameter("AVSQ", m3AVSQ.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAttrValuesResponse>(
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
		/// Name LstDepAttrLines
		/// Description List dependency attribute lines
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ATMO">Attribute model (Required)</param>
		/// <param name="m3ATID">Attribute identity (Required)</param>
		/// <param name="m3ATNR">Attribute number (Required)</param>
		/// <param name="m3SIMD">Simulation</param>
		/// <param name="m3ATNB">Attribute number lot</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3PRDT">Price date</param>
		/// <param name="m3OFNO">Quotation number</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3DSPS">Forced sequence</param>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDepAttrLinesResponse></returns>
		/// <exception cref="M3Exception<LstDepAttrLinesResponse>"></exception>
		public async Task<M3Response<LstDepAttrLinesResponse>> LstDepAttrLines(
			string m3ATMO, 
			string m3ATID, 
			decimal m3ATNR, 
			int? m3SIMD = null, 
			decimal? m3ATNB = null, 
			string m3CUCD = null, 
			DateTime? m3PRDT = null, 
			string m3OFNO = null, 
			int? m3VERS = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
			int? m3DSPS = null, 
			string m3ORCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDepAttrLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ATMO))
				throw new ArgumentNullException(nameof(m3ATMO));
			if (string.IsNullOrWhiteSpace(m3ATID))
				throw new ArgumentNullException(nameof(m3ATID));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATMO", m3ATMO.Trim())
				.WithQueryParameter("ATID", m3ATID.Trim())
				.WithQueryParameter("ATNR", m3ATNR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3SIMD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNB.HasValue)
				request.WithQueryParameter("ATNB", m3ATNB.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3OFNO))
				request.WithQueryParameter("OFNO", m3OFNO.Trim());
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSPS.HasValue)
				request.WithQueryParameter("DSPS", m3DSPS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());

			// Execute the request
			var result = await Execute<LstDepAttrLinesResponse>(
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
		/// Name LstDepAttribute
		/// Description List attributes with check attributes
		/// Version Release: 
		/// </summary>
		/// <param name="m3ATMO">Attribute model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDepAttributeResponse></returns>
		/// <exception cref="M3Exception<LstDepAttributeResponse>"></exception>
		public async Task<M3Response<LstDepAttributeResponse>> LstDepAttribute(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDepAttribute",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ATMO))
				request.WithQueryParameter("ATMO", m3ATMO.Trim());

			// Execute the request
			var result = await Execute<LstDepAttributeResponse>(
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
		/// Name LstDepError
		/// Description List dependency errors
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3SIMD">Simulation</param>
		/// <param name="m3ATID">Attribute identity</param>
		/// <param name="m3CFOK">Use control values</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3ORTP">Customer order type</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3CSC1">Country</param>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3EQNO">Equipment number</param>
		/// <param name="m3BIRT">Origin identity</param>
		/// <param name="m3TAIL">Registration number/site</param>
		/// <param name="m3AVSQ">Attribute value sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDepErrorResponse></returns>
		/// <exception cref="M3Exception<LstDepErrorResponse>"></exception>
		public async Task<M3Response<LstDepErrorResponse>> LstDepError(
			decimal? m3ATNR = null, 
			int? m3SIMD = null, 
			string m3ATID = null, 
			int? m3CFOK = null, 
			string m3ITNO = null, 
			string m3CUNO = null, 
			string m3ORTP = null, 
			string m3CSCD = null, 
			string m3PROJ = null, 
			string m3SUNO = null, 
			string m3ORTY = null, 
			string m3CSC1 = null, 
			string m3ORCA = null, 
			string m3WHLO = null, 
			string m3FACI = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3BANO = null, 
			string m3EQNO = null, 
			long? m3BIRT = null, 
			string m3TAIL = null, 
			int? m3AVSQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDepError",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3SIMD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ATID))
				request.WithQueryParameter("ATID", m3ATID.Trim());
			if (m3CFOK.HasValue)
				request.WithQueryParameter("CFOK", m3CFOK.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTP))
				request.WithQueryParameter("ORTP", m3ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSC1))
				request.WithQueryParameter("CSC1", m3CSC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQNO))
				request.WithQueryParameter("EQNO", m3EQNO.Trim());
			if (m3BIRT.HasValue)
				request.WithQueryParameter("BIRT", m3BIRT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TAIL))
				request.WithQueryParameter("TAIL", m3TAIL.Trim());
			if (m3AVSQ.HasValue)
				request.WithQueryParameter("AVSQ", m3AVSQ.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstDepErrorResponse>(
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
		/// Name LstDspGroups
		/// Description List display groups
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3SIMD">Simulation</param>
		/// <param name="m3ATNB">Attribute number lot</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDspGroupsResponse></returns>
		/// <exception cref="M3Exception<LstDspGroupsResponse>"></exception>
		public async Task<M3Response<LstDspGroupsResponse>> LstDspGroups(
			decimal? m3ATNR = null, 
			int? m3SIMD = null, 
			decimal? m3ATNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDspGroups",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3SIMD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNB.HasValue)
				request.WithQueryParameter("ATNB", m3ATNB.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstDspGroupsResponse>(
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
		/// Name LstItemsAttr
		/// Description List items for attribute model
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITCL">Product group</param>
		/// <param name="m3ATMO">Attribute model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemsAttrResponse></returns>
		/// <exception cref="M3Exception<LstItemsAttrResponse>"></exception>
		public async Task<M3Response<LstItemsAttrResponse>> LstItemsAttr(
			string m3ITCL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItemsAttr",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITCL))
				request.WithQueryParameter("ITCL", m3ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATMO))
				request.WithQueryParameter("ATMO", m3ATMO.Trim());

			// Execute the request
			var result = await Execute<LstItemsAttrResponse>(
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
		/// Name LstPrdGroups
		/// Description List product groups
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPrdGroupsResponse></returns>
		/// <exception cref="M3Exception<LstPrdGroupsResponse>"></exception>
		public async Task<M3Response<LstPrdGroupsResponse>> LstPrdGroups(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPrdGroups",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPrdGroupsResponse>(
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
		/// Name LstSumLines
		/// Description List summary lines
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3SIMD">Simulation</param>
		/// <param name="m3ATNB">Attribute number lot</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3PRDT">Priority date</param>
		/// <param name="m3OFNO">Quotation number</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSumLinesResponse></returns>
		/// <exception cref="M3Exception<LstSumLinesResponse>"></exception>
		public async Task<M3Response<LstSumLinesResponse>> LstSumLines(
			decimal? m3ATNR = null, 
			int? m3SIMD = null, 
			decimal? m3ATNB = null, 
			string m3CUCD = null, 
			DateTime? m3PRDT = null, 
			string m3OFNO = null, 
			int? m3VERS = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
			string m3ORCA = null, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSumLines",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3SIMD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNB.HasValue)
				request.WithQueryParameter("ATNB", m3ATNB.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3OFNO))
				request.WithQueryParameter("OFNO", m3OFNO.Trim());
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstSumLinesResponse>(
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
		/// Name SaveConfig
		/// Description Save Configuration
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="m3SIMD">Simulation</param>
		/// <param name="m3ATN2">Attribute number</param>
		/// <param name="m3SIM2">Simulation</param>
		/// <param name="m3CFOK">Search attribute OK</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3ORTP">Customer order type</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3CSC1">Country</param>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3EQNO">Equipment number</param>
		/// <param name="m3BIRT">Origin identity</param>
		/// <param name="m3TAIL">Registration number/site</param>
		/// <param name="m3OFNO">Quotation number</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SaveConfigResponse></returns>
		/// <exception cref="M3Exception<SaveConfigResponse>"></exception>
		public async Task<M3Response<SaveConfigResponse>> SaveConfig(
			decimal? m3ATNR = null, 
			int? m3SIMD = null, 
			decimal? m3ATN2 = null, 
			int? m3SIM2 = null, 
			int? m3CFOK = null, 
			string m3ITNO = null, 
			string m3CUNO = null, 
			string m3ORTP = null, 
			string m3CSCD = null, 
			string m3PROJ = null, 
			string m3SUNO = null, 
			string m3ORTY = null, 
			string m3CSC1 = null, 
			string m3ORCA = null, 
			string m3WHLO = null, 
			string m3FACI = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3BANO = null, 
			string m3EQNO = null, 
			long? m3BIRT = null, 
			string m3TAIL = null, 
			string m3OFNO = null, 
			int? m3VERS = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SaveConfig",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3SIMD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATN2.HasValue)
				request.WithQueryParameter("ATN2", m3ATN2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIM2.HasValue)
				request.WithQueryParameter("SIM2", m3SIM2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFOK.HasValue)
				request.WithQueryParameter("CFOK", m3CFOK.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTP))
				request.WithQueryParameter("ORTP", m3ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSC1))
				request.WithQueryParameter("CSC1", m3CSC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQNO))
				request.WithQueryParameter("EQNO", m3EQNO.Trim());
			if (m3BIRT.HasValue)
				request.WithQueryParameter("BIRT", m3BIRT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TAIL))
				request.WithQueryParameter("TAIL", m3TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3OFNO))
				request.WithQueryParameter("OFNO", m3OFNO.Trim());
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SaveConfigResponse>(
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
		/// Name SetAttrValue
		/// Description Set or change attribute values
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ATNR">Attribute number (Required)</param>
		/// <param name="m3SIMD">Simulation (Required)</param>
		/// <param name="m3ATID">Attribute identity (Required)</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3PRDT">Price date</param>
		/// <param name="m3OFNO">Quotation number</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3ATAN">Target value</param>
		/// <param name="m3ANUF">From attribute value</param>
		/// <param name="m3ANUT">To attribute value</param>
		/// <param name="m3ATVA">Attribute value</param>
		/// <param name="m3DATE">Entry date</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3CFOK">Search attribute OK</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3ORTP">Customer order type</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3CSC1">Country</param>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3EQNO">Equipment number</param>
		/// <param name="m3BIRT">Origin identity</param>
		/// <param name="m3TAIL">Registration number/site</param>
		/// <param name="m3AVSQ">Attribute value sequence number</param>
		/// <param name="m3ATCI">Attachment indicator</param>
		/// <param name="m3SHIP">Shipless indicator</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SetAttrValueResponse></returns>
		/// <exception cref="M3Exception<SetAttrValueResponse>"></exception>
		public async Task<M3Response<SetAttrValueResponse>> SetAttrValue(
			decimal m3ATNR, 
			int m3SIMD, 
			string m3ATID, 
			string m3CUCD = null, 
			DateTime? m3PRDT = null, 
			string m3OFNO = null, 
			int? m3VERS = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
			decimal? m3ATAN = null, 
			decimal? m3ANUF = null, 
			decimal? m3ANUT = null, 
			string m3ATVA = null, 
			DateTime? m3DATE = null, 
			decimal? m3TXID = null, 
			string m3LNCD = null, 
			int? m3CFOK = null, 
			string m3ITNO = null, 
			string m3CUNO = null, 
			string m3ORTP = null, 
			string m3CSCD = null, 
			string m3PROJ = null, 
			string m3SUNO = null, 
			string m3ORTY = null, 
			string m3CSC1 = null, 
			string m3ORCA = null, 
			string m3WHLO = null, 
			string m3FACI = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3BANO = null, 
			string m3EQNO = null, 
			long? m3BIRT = null, 
			string m3TAIL = null, 
			int? m3AVSQ = null, 
			int? m3ATCI = null, 
			int? m3SHIP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SetAttrValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ATID))
				throw new ArgumentNullException(nameof(m3ATID));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATNR", m3ATNR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SIMD", m3SIMD.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ATID", m3ATID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3OFNO))
				request.WithQueryParameter("OFNO", m3OFNO.Trim());
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATAN.HasValue)
				request.WithQueryParameter("ATAN", m3ATAN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ANUF.HasValue)
				request.WithQueryParameter("ANUF", m3ANUF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ANUT.HasValue)
				request.WithQueryParameter("ANUT", m3ANUT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ATVA))
				request.WithQueryParameter("ATVA", m3ATVA.Trim());
			if (m3DATE.HasValue)
				request.WithQueryParameter("DATE", m3DATE.Value.ToM3String());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (m3CFOK.HasValue)
				request.WithQueryParameter("CFOK", m3CFOK.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTP))
				request.WithQueryParameter("ORTP", m3ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSC1))
				request.WithQueryParameter("CSC1", m3CSC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQNO))
				request.WithQueryParameter("EQNO", m3EQNO.Trim());
			if (m3BIRT.HasValue)
				request.WithQueryParameter("BIRT", m3BIRT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TAIL))
				request.WithQueryParameter("TAIL", m3TAIL.Trim());
			if (m3AVSQ.HasValue)
				request.WithQueryParameter("AVSQ", m3AVSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATCI.HasValue)
				request.WithQueryParameter("ATCI", m3ATCI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SHIP.HasValue)
				request.WithQueryParameter("SHIP", m3SHIP.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SetAttrValueResponse>(
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
		/// Name ValidateData
		/// Description Validate data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="m3OFNO">Quotation number</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3POSX">Line suffix</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ValidateDataResponse></returns>
		/// <exception cref="M3Exception<ValidateDataResponse>"></exception>
		public async Task<M3Response<ValidateDataResponse>> ValidateData(
			string m3ORCA = null, 
			string m3OFNO = null, 
			int? m3VERS = null, 
			int? m3PONR = null, 
			int? m3POSX = null, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
			string m3CUCD = null, 
			string m3ITNO = null, 
			string m3SERN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ValidateData",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3OFNO))
				request.WithQueryParameter("OFNO", m3OFNO.Trim());
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3POSX.HasValue)
				request.WithQueryParameter("POSX", m3POSX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());

			// Execute the request
			var result = await Execute<ValidateDataResponse>(
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
