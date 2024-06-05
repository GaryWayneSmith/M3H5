/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_ATNR">Attribute number (Required)</param>
		/// <param name="m3_SIMD">Simulation (Required)</param>
		/// <param name="m3_ATID">Attribute identity</param>
		/// <param name="m3_AVSQ">Attribute value sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAttrLine(
			decimal m3_ATNR, 
			int m3_SIMD, 
			string m3_ATID = null, 
			int? m3_AVSQ = null, 
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
				.WithQueryParameter("ATNR", m3_ATNR.ToString())
				.WithQueryParameter("SIMD", m3_SIMD.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ATID))
				request.WithQueryParameter("ATID", m3_ATID.Trim());
			if (m3_AVSQ.HasValue)
				request.WithQueryParameter("AVSQ", m3_AVSQ.Value.ToString());

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
		/// Name DltAttrModel
		/// Description Delete attribute model
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_SIMD">Simulation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAttrModel(
			decimal? m3_ATNR = null, 
			int? m3_SIMD = null, 
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
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (m3_SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3_SIMD.Value.ToString());

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
		/// Name GetAttrInfo
		/// Description GetAttrInfo
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ATID">Attribute identity</param>
		/// <param name="m3_ATMO">Attribute model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAttrInfoResponse></returns>
		/// <exception cref="M3Exception<GetAttrInfoResponse>"></exception>
		public async Task<M3Response<GetAttrInfoResponse>> GetAttrInfo(
			string m3_ATID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAttrInfo",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ATID))
				request.WithQueryParameter("ATID", m3_ATID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATMO))
				request.WithQueryParameter("ATMO", m3_ATMO.Trim());

			// Execute the request
			var result = await Execute<GetAttrInfoResponse>(
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
		/// Name GetAttrLine
		/// Description Get attribute line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ATMO">Attribute model (Required)</param>
		/// <param name="m3_ATID">Attribute identity (Required)</param>
		/// <param name="m3_ATNR">Attribute number (Required)</param>
		/// <param name="m3_SIMD">Simulation</param>
		/// <param name="m3_ATNB">Attribute number lot</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_PRDT">Price date</param>
		/// <param name="m3_OFNO">Quotation number</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_DSPS">Forced sequence</param>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAttrLineResponse></returns>
		/// <exception cref="M3Exception<GetAttrLineResponse>"></exception>
		public async Task<M3Response<GetAttrLineResponse>> GetAttrLine(
			string m3_ATMO, 
			string m3_ATID, 
			decimal m3_ATNR, 
			int? m3_SIMD = null, 
			decimal? m3_ATNB = null, 
			string m3_CUCD = null, 
			DateTime? m3_PRDT = null, 
			string m3_OFNO = null, 
			int? m3_VERS = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			int? m3_DSPS = null, 
			string m3_ORCA = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ATMO))
				throw new ArgumentNullException("m3_ATMO");
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATMO", m3_ATMO.Trim())
				.WithQueryParameter("ATID", m3_ATID.Trim())
				.WithQueryParameter("ATNR", m3_ATNR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3_SIMD.Value.ToString());
			if (m3_ATNB.HasValue)
				request.WithQueryParameter("ATNB", m3_ATNB.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3_PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_OFNO))
				request.WithQueryParameter("OFNO", m3_OFNO.Trim());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (m3_DSPS.HasValue)
				request.WithQueryParameter("DSPS", m3_DSPS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());

			// Execute the request
			var result = await Execute<GetAttrLineResponse>(
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
		/// Name GetForcedSeq
		/// Description Get forced sequence number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_SIMD">Simulation</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetForcedSeqResponse></returns>
		/// <exception cref="M3Exception<GetForcedSeqResponse>"></exception>
		public async Task<M3Response<GetForcedSeqResponse>> GetForcedSeq(
			decimal? m3_ATNR = null, 
			int? m3_SIMD = null, 
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
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (m3_SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3_SIMD.Value.ToString());

			// Execute the request
			var result = await Execute<GetForcedSeqResponse>(
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
		/// Name GetHeadings
		/// Description Get headings
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadingsResponse></returns>
		/// <exception cref="M3Exception<GetHeadingsResponse>"></exception>
		public async Task<M3Response<GetHeadingsResponse>> GetHeadings(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHeadings",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetHeadingsResponse>(
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
		/// Name GetHeadings2
		/// Description Get headings 2
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadings2Response></returns>
		/// <exception cref="M3Exception<GetHeadings2Response>"></exception>
		public async Task<M3Response<GetHeadings2Response>> GetHeadings2(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHeadings2",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetHeadings2Response>(
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
		/// Name GetStartValues
		/// Description Get start values
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORCA">Order category (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_SIMD">Simulation</param>
		/// <param name="m3_ATNB">Attribute number lot</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_OFNO">Quotation number</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_PRDT">Price date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetStartValuesResponse></returns>
		/// <exception cref="M3Exception<GetStartValuesResponse>"></exception>
		public async Task<M3Response<GetStartValuesResponse>> GetStartValues(
			string m3_ORCA, 
			string m3_ITNO, 
			string m3_CUCD, 
			decimal? m3_ATNR = null, 
			int? m3_SIMD = null, 
			decimal? m3_ATNB = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
			string m3_OFNO = null, 
			int? m3_VERS = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			DateTime? m3_PRDT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ORCA))
				throw new ArgumentNullException("m3_ORCA");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORCA", m3_ORCA.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (m3_SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3_SIMD.Value.ToString());
			if (m3_ATNB.HasValue)
				request.WithQueryParameter("ATNB", m3_ATNB.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OFNO))
				request.WithQueryParameter("OFNO", m3_OFNO.Trim());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (m3_PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3_PRDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetStartValuesResponse>(
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
		/// Name GetSumHead
		/// Description Get summary head
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_SIMD">Simulation</param>
		/// <param name="m3_ATNB">Attribute number lot</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_PRDT">Priority date</param>
		/// <param name="m3_OFNO">Quotation number</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSumHeadResponse></returns>
		/// <exception cref="M3Exception<GetSumHeadResponse>"></exception>
		public async Task<M3Response<GetSumHeadResponse>> GetSumHead(
			decimal? m3_ATNR = null, 
			int? m3_SIMD = null, 
			decimal? m3_ATNB = null, 
			string m3_CUCD = null, 
			DateTime? m3_PRDT = null, 
			string m3_OFNO = null, 
			int? m3_VERS = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			string m3_ORCA = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
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
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (m3_SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3_SIMD.Value.ToString());
			if (m3_ATNB.HasValue)
				request.WithQueryParameter("ATNB", m3_ATNB.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3_PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_OFNO))
				request.WithQueryParameter("OFNO", m3_OFNO.Trim());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());

			// Execute the request
			var result = await Execute<GetSumHeadResponse>(
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
		/// Name GetUserLanguage
		/// Description Get user language
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetUserLanguageResponse></returns>
		/// <exception cref="M3Exception<GetUserLanguageResponse>"></exception>
		public async Task<M3Response<GetUserLanguageResponse>> GetUserLanguage(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetUserLanguage",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetUserLanguageResponse>(
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
		/// Name GetValues
		/// Description GetValues
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_SIMD">Simulation</param>
		/// <param name="m3_ATNB">Attribute number lot</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_OFNO">Quotation number</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="m3_NONE">Not used</param>
		/// <param name="m3_PONR">Order line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_PRDT">Price date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetValuesResponse></returns>
		/// <exception cref="M3Exception<GetValuesResponse>"></exception>
		public async Task<M3Response<GetValuesResponse>> GetValues(
			string m3_ORCA = null, 
			string m3_ITNO = null, 
			string m3_CUCD = null, 
			decimal? m3_ATNR = null, 
			int? m3_SIMD = null, 
			decimal? m3_ATNB = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
			string m3_OFNO = null, 
			int? m3_VERS = null, 
			string m3_NONE = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			DateTime? m3_PRDT = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (m3_SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3_SIMD.Value.ToString());
			if (m3_ATNB.HasValue)
				request.WithQueryParameter("ATNB", m3_ATNB.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OFNO))
				request.WithQueryParameter("OFNO", m3_OFNO.Trim());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NONE))
				request.WithQueryParameter("NONE", m3_NONE.Trim());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (m3_PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3_PRDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetValuesResponse>(
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
		/// Name LstAttrLineText
		/// Description List attribute model line text
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATMO">Attribute model</param>
		/// <param name="m3_ATID">Attribute identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrLineTextResponse></returns>
		/// <exception cref="M3Exception<LstAttrLineTextResponse>"></exception>
		public async Task<M3Response<LstAttrLineTextResponse>> LstAttrLineText(
			string m3_ATMO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAttrLineText",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ATMO))
				request.WithQueryParameter("ATMO", m3_ATMO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATID))
				request.WithQueryParameter("ATID", m3_ATID.Trim());

			// Execute the request
			var result = await Execute<LstAttrLineTextResponse>(
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
		/// Name LstAttrLines
		/// Description List attribute lines connected to display group
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ATMO">Attribute model (Required)</param>
		/// <param name="m3_DSPG">Display group (Required)</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_SIMD">Simulation</param>
		/// <param name="m3_ATNB">Attribute number lot</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_PRDT">Price date</param>
		/// <param name="m3_OFNO">Quotation number</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_DSPS">Forced sequence</param>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrLinesResponse></returns>
		/// <exception cref="M3Exception<LstAttrLinesResponse>"></exception>
		public async Task<M3Response<LstAttrLinesResponse>> LstAttrLines(
			string m3_ATMO, 
			string m3_DSPG, 
			decimal? m3_ATNR = null, 
			int? m3_SIMD = null, 
			decimal? m3_ATNB = null, 
			string m3_CUCD = null, 
			DateTime? m3_PRDT = null, 
			string m3_OFNO = null, 
			int? m3_VERS = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			int? m3_DSPS = null, 
			string m3_ORCA = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ATMO))
				throw new ArgumentNullException("m3_ATMO");
			if (string.IsNullOrWhiteSpace(m3_DSPG))
				throw new ArgumentNullException("m3_DSPG");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATMO", m3_ATMO.Trim())
				.WithQueryParameter("DSPG", m3_DSPG.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (m3_SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3_SIMD.Value.ToString());
			if (m3_ATNB.HasValue)
				request.WithQueryParameter("ATNB", m3_ATNB.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3_PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_OFNO))
				request.WithQueryParameter("OFNO", m3_OFNO.Trim());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (m3_DSPS.HasValue)
				request.WithQueryParameter("DSPS", m3_DSPS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());

			// Execute the request
			var result = await Execute<LstAttrLinesResponse>(
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
		/// Name LstAttrModels
		/// Description List attribute models for product group
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITCL">Product group</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrModelsResponse></returns>
		/// <exception cref="M3Exception<LstAttrModelsResponse>"></exception>
		public async Task<M3Response<LstAttrModelsResponse>> LstAttrModels(
			string m3_ITCL = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_ITCL))
				request.WithQueryParameter("ITCL", m3_ITCL.Trim());

			// Execute the request
			var result = await Execute<LstAttrModelsResponse>(
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
		/// Name LstAttrValueTxt
		/// Description List attribute value line text
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrValueTxtResponse></returns>
		/// <exception cref="M3Exception<LstAttrValueTxtResponse>"></exception>
		public async Task<M3Response<LstAttrValueTxtResponse>> LstAttrValueTxt(
			decimal? m3_TXID = null, 
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
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

			// Execute the request
			var result = await Execute<LstAttrValueTxtResponse>(
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
		/// Name LstAttrValues
		/// Description List attribute values
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ATID">Attribute identity (Required)</param>
		/// <param name="m3_ATNR">Attribute number (Required)</param>
		/// <param name="m3_SIMD">Simulation (Required)</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_PRDT">Price date</param>
		/// <param name="m3_OFNO">Quotation number</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_LALL">List all attribute values</param>
		/// <param name="m3_CFOK">Search attribute OK</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_ORTP">Customer order type</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_CSC1">Country</param>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_EQNO">Equipment number</param>
		/// <param name="m3_BIRT">Origin identity</param>
		/// <param name="m3_TAIL">Registration number/site</param>
		/// <param name="m3_AVSQ">Sequence number of attribute value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrValuesResponse></returns>
		/// <exception cref="M3Exception<LstAttrValuesResponse>"></exception>
		public async Task<M3Response<LstAttrValuesResponse>> LstAttrValues(
			string m3_ATID, 
			decimal m3_ATNR, 
			int m3_SIMD, 
			string m3_CUCD = null, 
			DateTime? m3_PRDT = null, 
			string m3_OFNO = null, 
			int? m3_VERS = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			int? m3_LALL = null, 
			int? m3_CFOK = null, 
			string m3_ITNO = null, 
			string m3_CUNO = null, 
			string m3_ORTP = null, 
			string m3_CSCD = null, 
			string m3_PROJ = null, 
			string m3_SUNO = null, 
			string m3_ORTY = null, 
			string m3_CSC1 = null, 
			string m3_ORCA = null, 
			string m3_WHLO = null, 
			string m3_FACI = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_BANO = null, 
			string m3_EQNO = null, 
			long? m3_BIRT = null, 
			string m3_TAIL = null, 
			int? m3_AVSQ = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3_ATID.Trim())
				.WithQueryParameter("ATNR", m3_ATNR.ToString())
				.WithQueryParameter("SIMD", m3_SIMD.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3_PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_OFNO))
				request.WithQueryParameter("OFNO", m3_OFNO.Trim());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (m3_LALL.HasValue)
				request.WithQueryParameter("LALL", m3_LALL.Value.ToString());
			if (m3_CFOK.HasValue)
				request.WithQueryParameter("CFOK", m3_CFOK.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTP))
				request.WithQueryParameter("ORTP", m3_ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSC1))
				request.WithQueryParameter("CSC1", m3_CSC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQNO))
				request.WithQueryParameter("EQNO", m3_EQNO.Trim());
			if (m3_BIRT.HasValue)
				request.WithQueryParameter("BIRT", m3_BIRT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TAIL))
				request.WithQueryParameter("TAIL", m3_TAIL.Trim());
			if (m3_AVSQ.HasValue)
				request.WithQueryParameter("AVSQ", m3_AVSQ.Value.ToString());

			// Execute the request
			var result = await Execute<LstAttrValuesResponse>(
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
		/// Name LstDepAttrLines
		/// Description List dependency attribute lines
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ATMO">Attribute model (Required)</param>
		/// <param name="m3_ATID">Attribute identity (Required)</param>
		/// <param name="m3_ATNR">Attribute number (Required)</param>
		/// <param name="m3_SIMD">Simulation</param>
		/// <param name="m3_ATNB">Attribute number lot</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_PRDT">Price date</param>
		/// <param name="m3_OFNO">Quotation number</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_DSPS">Forced sequence</param>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDepAttrLinesResponse></returns>
		/// <exception cref="M3Exception<LstDepAttrLinesResponse>"></exception>
		public async Task<M3Response<LstDepAttrLinesResponse>> LstDepAttrLines(
			string m3_ATMO, 
			string m3_ATID, 
			decimal m3_ATNR, 
			int? m3_SIMD = null, 
			decimal? m3_ATNB = null, 
			string m3_CUCD = null, 
			DateTime? m3_PRDT = null, 
			string m3_OFNO = null, 
			int? m3_VERS = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			int? m3_DSPS = null, 
			string m3_ORCA = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ATMO))
				throw new ArgumentNullException("m3_ATMO");
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATMO", m3_ATMO.Trim())
				.WithQueryParameter("ATID", m3_ATID.Trim())
				.WithQueryParameter("ATNR", m3_ATNR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3_SIMD.Value.ToString());
			if (m3_ATNB.HasValue)
				request.WithQueryParameter("ATNB", m3_ATNB.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3_PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_OFNO))
				request.WithQueryParameter("OFNO", m3_OFNO.Trim());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (m3_DSPS.HasValue)
				request.WithQueryParameter("DSPS", m3_DSPS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());

			// Execute the request
			var result = await Execute<LstDepAttrLinesResponse>(
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
		/// Name LstDepAttribute
		/// Description List attributes with check attributes
		/// Version Release: 
		/// </summary>
		/// <param name="m3_ATMO">Attribute model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDepAttributeResponse></returns>
		/// <exception cref="M3Exception<LstDepAttributeResponse>"></exception>
		public async Task<M3Response<LstDepAttributeResponse>> LstDepAttribute(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDepAttribute",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ATMO))
				request.WithQueryParameter("ATMO", m3_ATMO.Trim());

			// Execute the request
			var result = await Execute<LstDepAttributeResponse>(
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
		/// Name LstDepError
		/// Description List dependency errors
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_SIMD">Simulation</param>
		/// <param name="m3_ATID">Attribute identity</param>
		/// <param name="m3_CFOK">Use control values</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_ORTP">Customer order type</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_CSC1">Country</param>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_EQNO">Equipment number</param>
		/// <param name="m3_BIRT">Origin identity</param>
		/// <param name="m3_TAIL">Registration number/site</param>
		/// <param name="m3_AVSQ">Attribute value sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDepErrorResponse></returns>
		/// <exception cref="M3Exception<LstDepErrorResponse>"></exception>
		public async Task<M3Response<LstDepErrorResponse>> LstDepError(
			decimal? m3_ATNR = null, 
			int? m3_SIMD = null, 
			string m3_ATID = null, 
			int? m3_CFOK = null, 
			string m3_ITNO = null, 
			string m3_CUNO = null, 
			string m3_ORTP = null, 
			string m3_CSCD = null, 
			string m3_PROJ = null, 
			string m3_SUNO = null, 
			string m3_ORTY = null, 
			string m3_CSC1 = null, 
			string m3_ORCA = null, 
			string m3_WHLO = null, 
			string m3_FACI = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_BANO = null, 
			string m3_EQNO = null, 
			long? m3_BIRT = null, 
			string m3_TAIL = null, 
			int? m3_AVSQ = null, 
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
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (m3_SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3_SIMD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ATID))
				request.WithQueryParameter("ATID", m3_ATID.Trim());
			if (m3_CFOK.HasValue)
				request.WithQueryParameter("CFOK", m3_CFOK.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTP))
				request.WithQueryParameter("ORTP", m3_ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSC1))
				request.WithQueryParameter("CSC1", m3_CSC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQNO))
				request.WithQueryParameter("EQNO", m3_EQNO.Trim());
			if (m3_BIRT.HasValue)
				request.WithQueryParameter("BIRT", m3_BIRT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TAIL))
				request.WithQueryParameter("TAIL", m3_TAIL.Trim());
			if (m3_AVSQ.HasValue)
				request.WithQueryParameter("AVSQ", m3_AVSQ.Value.ToString());

			// Execute the request
			var result = await Execute<LstDepErrorResponse>(
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
		/// Name LstDspGroups
		/// Description List display groups
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_SIMD">Simulation</param>
		/// <param name="m3_ATNB">Attribute number lot</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDspGroupsResponse></returns>
		/// <exception cref="M3Exception<LstDspGroupsResponse>"></exception>
		public async Task<M3Response<LstDspGroupsResponse>> LstDspGroups(
			decimal? m3_ATNR = null, 
			int? m3_SIMD = null, 
			decimal? m3_ATNB = null, 
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
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (m3_SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3_SIMD.Value.ToString());
			if (m3_ATNB.HasValue)
				request.WithQueryParameter("ATNB", m3_ATNB.Value.ToString());

			// Execute the request
			var result = await Execute<LstDspGroupsResponse>(
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
		/// Name LstItemsAttr
		/// Description List items for attribute model
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITCL">Product group</param>
		/// <param name="m3_ATMO">Attribute model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemsAttrResponse></returns>
		/// <exception cref="M3Exception<LstItemsAttrResponse>"></exception>
		public async Task<M3Response<LstItemsAttrResponse>> LstItemsAttr(
			string m3_ITCL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItemsAttr",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITCL))
				request.WithQueryParameter("ITCL", m3_ITCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATMO))
				request.WithQueryParameter("ATMO", m3_ATMO.Trim());

			// Execute the request
			var result = await Execute<LstItemsAttrResponse>(
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
		/// Name LstPrdGroups
		/// Description List product groups
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPrdGroupsResponse></returns>
		/// <exception cref="M3Exception<LstPrdGroupsResponse>"></exception>
		public async Task<M3Response<LstPrdGroupsResponse>> LstPrdGroups(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPrdGroups",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstPrdGroupsResponse>(
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
		/// Name LstSumLines
		/// Description List summary lines
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_SIMD">Simulation</param>
		/// <param name="m3_ATNB">Attribute number lot</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_PRDT">Priority date</param>
		/// <param name="m3_OFNO">Quotation number</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSumLinesResponse></returns>
		/// <exception cref="M3Exception<LstSumLinesResponse>"></exception>
		public async Task<M3Response<LstSumLinesResponse>> LstSumLines(
			decimal? m3_ATNR = null, 
			int? m3_SIMD = null, 
			decimal? m3_ATNB = null, 
			string m3_CUCD = null, 
			DateTime? m3_PRDT = null, 
			string m3_OFNO = null, 
			int? m3_VERS = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			string m3_ORCA = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
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
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (m3_SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3_SIMD.Value.ToString());
			if (m3_ATNB.HasValue)
				request.WithQueryParameter("ATNB", m3_ATNB.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3_PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_OFNO))
				request.WithQueryParameter("OFNO", m3_OFNO.Trim());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());

			// Execute the request
			var result = await Execute<LstSumLinesResponse>(
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
		/// Name SaveConfig
		/// Description Save Configuration
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="m3_SIMD">Simulation</param>
		/// <param name="m3_ATN2">Attribute number</param>
		/// <param name="m3_SIM2">Simulation</param>
		/// <param name="m3_CFOK">Search attribute OK</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_ORTP">Customer order type</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_CSC1">Country</param>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_EQNO">Equipment number</param>
		/// <param name="m3_BIRT">Origin identity</param>
		/// <param name="m3_TAIL">Registration number/site</param>
		/// <param name="m3_OFNO">Quotation number</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SaveConfigResponse></returns>
		/// <exception cref="M3Exception<SaveConfigResponse>"></exception>
		public async Task<M3Response<SaveConfigResponse>> SaveConfig(
			decimal? m3_ATNR = null, 
			int? m3_SIMD = null, 
			decimal? m3_ATN2 = null, 
			int? m3_SIM2 = null, 
			int? m3_CFOK = null, 
			string m3_ITNO = null, 
			string m3_CUNO = null, 
			string m3_ORTP = null, 
			string m3_CSCD = null, 
			string m3_PROJ = null, 
			string m3_SUNO = null, 
			string m3_ORTY = null, 
			string m3_CSC1 = null, 
			string m3_ORCA = null, 
			string m3_WHLO = null, 
			string m3_FACI = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_BANO = null, 
			string m3_EQNO = null, 
			long? m3_BIRT = null, 
			string m3_TAIL = null, 
			string m3_OFNO = null, 
			int? m3_VERS = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
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
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());
			if (m3_SIMD.HasValue)
				request.WithQueryParameter("SIMD", m3_SIMD.Value.ToString());
			if (m3_ATN2.HasValue)
				request.WithQueryParameter("ATN2", m3_ATN2.Value.ToString());
			if (m3_SIM2.HasValue)
				request.WithQueryParameter("SIM2", m3_SIM2.Value.ToString());
			if (m3_CFOK.HasValue)
				request.WithQueryParameter("CFOK", m3_CFOK.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTP))
				request.WithQueryParameter("ORTP", m3_ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSC1))
				request.WithQueryParameter("CSC1", m3_CSC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQNO))
				request.WithQueryParameter("EQNO", m3_EQNO.Trim());
			if (m3_BIRT.HasValue)
				request.WithQueryParameter("BIRT", m3_BIRT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TAIL))
				request.WithQueryParameter("TAIL", m3_TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OFNO))
				request.WithQueryParameter("OFNO", m3_OFNO.Trim());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());

			// Execute the request
			var result = await Execute<SaveConfigResponse>(
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
		/// Name SetAttrValue
		/// Description Set or change attribute values
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ATNR">Attribute number (Required)</param>
		/// <param name="m3_SIMD">Simulation (Required)</param>
		/// <param name="m3_ATID">Attribute identity (Required)</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_PRDT">Price date</param>
		/// <param name="m3_OFNO">Quotation number</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_ATAN">Target value</param>
		/// <param name="m3_ANUF">From attribute value</param>
		/// <param name="m3_ANUT">To attribute value</param>
		/// <param name="m3_ATVA">Attribute value</param>
		/// <param name="m3_DATE">Entry date</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_CFOK">Search attribute OK</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_ORTP">Customer order type</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_CSC1">Country</param>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_EQNO">Equipment number</param>
		/// <param name="m3_BIRT">Origin identity</param>
		/// <param name="m3_TAIL">Registration number/site</param>
		/// <param name="m3_AVSQ">Attribute value sequence number</param>
		/// <param name="m3_ATCI">Attachment indicator</param>
		/// <param name="m3_SHIP">Shipless indicator</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SetAttrValueResponse></returns>
		/// <exception cref="M3Exception<SetAttrValueResponse>"></exception>
		public async Task<M3Response<SetAttrValueResponse>> SetAttrValue(
			decimal m3_ATNR, 
			int m3_SIMD, 
			string m3_ATID, 
			string m3_CUCD = null, 
			DateTime? m3_PRDT = null, 
			string m3_OFNO = null, 
			int? m3_VERS = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			decimal? m3_ATAN = null, 
			decimal? m3_ANUF = null, 
			decimal? m3_ANUT = null, 
			string m3_ATVA = null, 
			DateTime? m3_DATE = null, 
			decimal? m3_TXID = null, 
			string m3_LNCD = null, 
			int? m3_CFOK = null, 
			string m3_ITNO = null, 
			string m3_CUNO = null, 
			string m3_ORTP = null, 
			string m3_CSCD = null, 
			string m3_PROJ = null, 
			string m3_SUNO = null, 
			string m3_ORTY = null, 
			string m3_CSC1 = null, 
			string m3_ORCA = null, 
			string m3_WHLO = null, 
			string m3_FACI = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_BANO = null, 
			string m3_EQNO = null, 
			long? m3_BIRT = null, 
			string m3_TAIL = null, 
			int? m3_AVSQ = null, 
			int? m3_ATCI = null, 
			int? m3_SHIP = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATNR", m3_ATNR.ToString())
				.WithQueryParameter("SIMD", m3_SIMD.ToString())
				.WithQueryParameter("ATID", m3_ATID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3_PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_OFNO))
				request.WithQueryParameter("OFNO", m3_OFNO.Trim());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (m3_ATAN.HasValue)
				request.WithQueryParameter("ATAN", m3_ATAN.Value.ToString());
			if (m3_ANUF.HasValue)
				request.WithQueryParameter("ANUF", m3_ANUF.Value.ToString());
			if (m3_ANUT.HasValue)
				request.WithQueryParameter("ANUT", m3_ANUT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ATVA))
				request.WithQueryParameter("ATVA", m3_ATVA.Trim());
			if (m3_DATE.HasValue)
				request.WithQueryParameter("DATE", m3_DATE.Value.ToM3String());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (m3_CFOK.HasValue)
				request.WithQueryParameter("CFOK", m3_CFOK.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTP))
				request.WithQueryParameter("ORTP", m3_ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSC1))
				request.WithQueryParameter("CSC1", m3_CSC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQNO))
				request.WithQueryParameter("EQNO", m3_EQNO.Trim());
			if (m3_BIRT.HasValue)
				request.WithQueryParameter("BIRT", m3_BIRT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TAIL))
				request.WithQueryParameter("TAIL", m3_TAIL.Trim());
			if (m3_AVSQ.HasValue)
				request.WithQueryParameter("AVSQ", m3_AVSQ.Value.ToString());
			if (m3_ATCI.HasValue)
				request.WithQueryParameter("ATCI", m3_ATCI.Value.ToString());
			if (m3_SHIP.HasValue)
				request.WithQueryParameter("SHIP", m3_SHIP.Value.ToString());

			// Execute the request
			var result = await Execute<SetAttrValueResponse>(
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
		/// Name ValidateData
		/// Description Validate data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORCA">Order category</param>
		/// <param name="m3_OFNO">Quotation number</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ValidateDataResponse></returns>
		/// <exception cref="M3Exception<ValidateDataResponse>"></exception>
		public async Task<M3Response<ValidateDataResponse>> ValidateData(
			string m3_ORCA = null, 
			string m3_OFNO = null, 
			int? m3_VERS = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
			string m3_CUCD = null, 
			string m3_ITNO = null, 
			string m3_SERN = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_ORCA))
				request.WithQueryParameter("ORCA", m3_ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OFNO))
				request.WithQueryParameter("OFNO", m3_OFNO.Trim());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());

			// Execute the request
			var result = await Execute<ValidateDataResponse>(
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
