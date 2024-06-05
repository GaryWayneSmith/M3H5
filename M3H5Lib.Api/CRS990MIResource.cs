/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS990MI;
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
	/// Name: CRS990MI
	/// Component Name: Browse
	/// Description: Api: Generic Browse
	/// Version Release: 12
	///</summary>
	public partial class CRS990MIResource : M3BaseResourceEndpoint
	{
		public CRS990MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS990MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Get
		/// Description Get Fields from any file defined in CMNBDF
		/// Version Release: 12.5
		/// </summary>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_KV01">Key value (Required)</param>
		/// <param name="m3_VARI">Browse variant</param>
		/// <param name="m3_USID">User</param>
		/// <param name="m3_NFTR">Number of filters</param>
		/// <param name="m3_KV02">Key value</param>
		/// <param name="m3_FL01">Field</param>
		/// <param name="m3_FL02">Field</param>
		/// <param name="m3_FL03">Field</param>
		/// <param name="m3_FL04">Field</param>
		/// <param name="m3_FL05">Field</param>
		/// <param name="m3_FL06">Field</param>
		/// <param name="m3_FL07">Field</param>
		/// <param name="m3_FL08">Field</param>
		/// <param name="m3_FL09">Field</param>
		/// <param name="m3_FL10">Field</param>
		/// <param name="m3_FL11">Field</param>
		/// <param name="m3_FL12">Field</param>
		/// <param name="m3_FL13">Field</param>
		/// <param name="m3_FL14">Field</param>
		/// <param name="m3_FL15">Field</param>
		/// <param name="m3_KV03">Key value</param>
		/// <param name="m3_KV04">Key value</param>
		/// <param name="m3_KV05">Key value</param>
		/// <param name="m3_KV06">Key value 6</param>
		/// <param name="m3_KV07">Key value</param>
		/// <param name="m3_KV08">Key value</param>
		/// <param name="m3_KV09">Key value</param>
		/// <param name="m3_KV10">Key value</param>
		/// <param name="m3_KV11">Key value</param>
		/// <param name="m3_KV12">Key value</param>
		/// <param name="m3_KV13">Key value</param>
		/// <param name="m3_KV14">Key value</param>
		/// <param name="m3_KV15">Key value 1</param>
		/// <param name="m3_KV16">Key value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_FLDI, 
			string m3_KV01, 
			string m3_VARI = null, 
			string m3_USID = null, 
			int? m3_NFTR = null, 
			string m3_KV02 = null, 
			string m3_FL01 = null, 
			string m3_FL02 = null, 
			string m3_FL03 = null, 
			string m3_FL04 = null, 
			string m3_FL05 = null, 
			string m3_FL06 = null, 
			string m3_FL07 = null, 
			string m3_FL08 = null, 
			string m3_FL09 = null, 
			string m3_FL10 = null, 
			string m3_FL11 = null, 
			string m3_FL12 = null, 
			string m3_FL13 = null, 
			string m3_FL14 = null, 
			string m3_FL15 = null, 
			string m3_KV03 = null, 
			string m3_KV04 = null, 
			string m3_KV05 = null, 
			string m3_KV06 = null, 
			string m3_KV07 = null, 
			string m3_KV08 = null, 
			string m3_KV09 = null, 
			string m3_KV10 = null, 
			string m3_KV11 = null, 
			string m3_KV12 = null, 
			string m3_KV13 = null, 
			string m3_KV14 = null, 
			string m3_KV15 = null, 
			string m3_KV16 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");
			if (string.IsNullOrWhiteSpace(m3_KV01))
				throw new ArgumentNullException("m3_KV01");

			// Set mandatory parameters
			request
				.WithQueryParameter("FLDI", m3_FLDI.Trim())
				.WithQueryParameter("KV01", m3_KV01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_VARI))
				request.WithQueryParameter("VARI", m3_VARI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());
			if (m3_NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3_NFTR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_KV02))
				request.WithQueryParameter("KV02", m3_KV02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL01))
				request.WithQueryParameter("FL01", m3_FL01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL02))
				request.WithQueryParameter("FL02", m3_FL02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL03))
				request.WithQueryParameter("FL03", m3_FL03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL04))
				request.WithQueryParameter("FL04", m3_FL04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL05))
				request.WithQueryParameter("FL05", m3_FL05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL06))
				request.WithQueryParameter("FL06", m3_FL06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL07))
				request.WithQueryParameter("FL07", m3_FL07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL08))
				request.WithQueryParameter("FL08", m3_FL08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL09))
				request.WithQueryParameter("FL09", m3_FL09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL10))
				request.WithQueryParameter("FL10", m3_FL10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL11))
				request.WithQueryParameter("FL11", m3_FL11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL12))
				request.WithQueryParameter("FL12", m3_FL12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL13))
				request.WithQueryParameter("FL13", m3_FL13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL14))
				request.WithQueryParameter("FL14", m3_FL14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FL15))
				request.WithQueryParameter("FL15", m3_FL15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV03))
				request.WithQueryParameter("KV03", m3_KV03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV04))
				request.WithQueryParameter("KV04", m3_KV04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV05))
				request.WithQueryParameter("KV05", m3_KV05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV06))
				request.WithQueryParameter("KV06", m3_KV06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV07))
				request.WithQueryParameter("KV07", m3_KV07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV08))
				request.WithQueryParameter("KV08", m3_KV08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV09))
				request.WithQueryParameter("KV09", m3_KV09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV10))
				request.WithQueryParameter("KV10", m3_KV10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV11))
				request.WithQueryParameter("KV11", m3_KV11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV12))
				request.WithQueryParameter("KV12", m3_KV12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV13))
				request.WithQueryParameter("KV13", m3_KV13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV14))
				request.WithQueryParameter("KV14", m3_KV14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV15))
				request.WithQueryParameter("KV15", m3_KV15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV16))
				request.WithQueryParameter("KV16", m3_KV16.Trim());

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
		/// Name GetBrowse
		/// Description Get all Fields from any file defined in CMNBDF
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_KV01">Key value (Required)</param>
		/// <param name="m3_VARI">Browse variant</param>
		/// <param name="m3_USID">User</param>
		/// <param name="m3_NFTR">Number of filters</param>
		/// <param name="m3_KV02">Key value</param>
		/// <param name="m3_KV03">Key value</param>
		/// <param name="m3_KV04">Key value</param>
		/// <param name="m3_KV05">Key value</param>
		/// <param name="m3_KV06">Key value 6</param>
		/// <param name="m3_KV07">Key value</param>
		/// <param name="m3_KV08">Key value</param>
		/// <param name="m3_KV09">Key value</param>
		/// <param name="m3_KV10">Key value</param>
		/// <param name="m3_KV11">Key value</param>
		/// <param name="m3_KV12">Key value</param>
		/// <param name="m3_KV13">Key value</param>
		/// <param name="m3_KV14">Key value</param>
		/// <param name="m3_KV15">Key value 1</param>
		/// <param name="m3_KV16">Key value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBrowseResponse></returns>
		/// <exception cref="M3Exception<GetBrowseResponse>"></exception>
		public async Task<M3Response<GetBrowseResponse>> GetBrowse(
			string m3_FLDI, 
			string m3_KV01, 
			string m3_VARI = null, 
			string m3_USID = null, 
			int? m3_NFTR = null, 
			string m3_KV02 = null, 
			string m3_KV03 = null, 
			string m3_KV04 = null, 
			string m3_KV05 = null, 
			string m3_KV06 = null, 
			string m3_KV07 = null, 
			string m3_KV08 = null, 
			string m3_KV09 = null, 
			string m3_KV10 = null, 
			string m3_KV11 = null, 
			string m3_KV12 = null, 
			string m3_KV13 = null, 
			string m3_KV14 = null, 
			string m3_KV15 = null, 
			string m3_KV16 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBrowse",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");
			if (string.IsNullOrWhiteSpace(m3_KV01))
				throw new ArgumentNullException("m3_KV01");

			// Set mandatory parameters
			request
				.WithQueryParameter("FLDI", m3_FLDI.Trim())
				.WithQueryParameter("KV01", m3_KV01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_VARI))
				request.WithQueryParameter("VARI", m3_VARI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());
			if (m3_NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3_NFTR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_KV02))
				request.WithQueryParameter("KV02", m3_KV02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV03))
				request.WithQueryParameter("KV03", m3_KV03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV04))
				request.WithQueryParameter("KV04", m3_KV04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV05))
				request.WithQueryParameter("KV05", m3_KV05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV06))
				request.WithQueryParameter("KV06", m3_KV06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV07))
				request.WithQueryParameter("KV07", m3_KV07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV08))
				request.WithQueryParameter("KV08", m3_KV08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV09))
				request.WithQueryParameter("KV09", m3_KV09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV10))
				request.WithQueryParameter("KV10", m3_KV10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV11))
				request.WithQueryParameter("KV11", m3_KV11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV12))
				request.WithQueryParameter("KV12", m3_KV12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV13))
				request.WithQueryParameter("KV13", m3_KV13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV14))
				request.WithQueryParameter("KV14", m3_KV14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV15))
				request.WithQueryParameter("KV15", m3_KV15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV16))
				request.WithQueryParameter("KV16", m3_KV16.Trim());

			// Execute the request
			var result = await Execute<GetBrowseResponse>(
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
		/// Name GetHeading
		/// Description Get the heading as a single row
		/// Version Release: 12.5
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FLDI">Field</param>
		/// <param name="m3_VARI">Browse variant</param>
		/// <param name="m3_USID">User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadingResponse></returns>
		/// <exception cref="M3Exception<GetHeadingResponse>"></exception>
		public async Task<M3Response<GetHeadingResponse>> GetHeading(
			int? m3_CONO = null, 
			string m3_FLDI = null, 
			string m3_VARI = null, 
			string m3_USID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHeading",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FLDI))
				request.WithQueryParameter("FLDI", m3_FLDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VARI))
				request.WithQueryParameter("VARI", m3_VARI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());

			// Execute the request
			var result = await Execute<GetHeadingResponse>(
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
		/// Name InitBrowse
		/// Description Access Browse definition and return column headings
		/// Version Release: 12.5
		/// </summary>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_VARI">Browse variant</param>
		/// <param name="m3_USID">User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<InitBrowseResponse></returns>
		/// <exception cref="M3Exception<InitBrowseResponse>"></exception>
		public async Task<M3Response<InitBrowseResponse>> InitBrowse(
			string m3_FLDI, 
			string m3_VARI = null, 
			string m3_USID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/InitBrowse",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FLDI", m3_FLDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_VARI))
				request.WithQueryParameter("VARI", m3_VARI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());

			// Execute the request
			var result = await Execute<InitBrowseResponse>(
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
		/// Name InitBrowseWHead
		/// Description Init and return column headings and heading as a row
		/// Version Release: 12.5
		/// </summary>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_VARI">Browse variant</param>
		/// <param name="m3_USID">User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<InitBrowseWHeadResponse></returns>
		/// <exception cref="M3Exception<InitBrowseWHeadResponse>"></exception>
		public async Task<M3Response<InitBrowseWHeadResponse>> InitBrowseWHead(
			string m3_FLDI, 
			string m3_VARI = null, 
			string m3_USID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/InitBrowseWHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FLDI", m3_FLDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_VARI))
				request.WithQueryParameter("VARI", m3_VARI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());

			// Execute the request
			var result = await Execute<InitBrowseWHeadResponse>(
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
		/// Name LstBrowse
		/// Description List all Fields from any file defined in CMNBDF
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_KV01">Key value (Required)</param>
		/// <param name="m3_VARI">Browse variant</param>
		/// <param name="m3_USID">User</param>
		/// <param name="m3_KV02">Key value</param>
		/// <param name="m3_KV03">Key value</param>
		/// <param name="m3_KV04">Key value</param>
		/// <param name="m3_KV05">Key value</param>
		/// <param name="m3_KV06">Key value 6</param>
		/// <param name="m3_KV07">Key value</param>
		/// <param name="m3_KV08">Key value</param>
		/// <param name="m3_KV09">Key value</param>
		/// <param name="m3_KV10">Key value</param>
		/// <param name="m3_KV11">Key value</param>
		/// <param name="m3_KV12">Key value</param>
		/// <param name="m3_KV13">Key value</param>
		/// <param name="m3_KV14">Key value</param>
		/// <param name="m3_KV15">Key value 1</param>
		/// <param name="m3_KV16">Key value</param>
		/// <param name="m3_PGDN">Page down</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBrowseResponse></returns>
		/// <exception cref="M3Exception<LstBrowseResponse>"></exception>
		public async Task<M3Response<LstBrowseResponse>> LstBrowse(
			string m3_FLDI, 
			string m3_KV01, 
			string m3_VARI = null, 
			string m3_USID = null, 
			string m3_KV02 = null, 
			string m3_KV03 = null, 
			string m3_KV04 = null, 
			string m3_KV05 = null, 
			string m3_KV06 = null, 
			string m3_KV07 = null, 
			string m3_KV08 = null, 
			string m3_KV09 = null, 
			string m3_KV10 = null, 
			string m3_KV11 = null, 
			string m3_KV12 = null, 
			string m3_KV13 = null, 
			string m3_KV14 = null, 
			string m3_KV15 = null, 
			string m3_KV16 = null, 
			int? m3_PGDN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBrowse",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");
			if (string.IsNullOrWhiteSpace(m3_KV01))
				throw new ArgumentNullException("m3_KV01");

			// Set mandatory parameters
			request
				.WithQueryParameter("FLDI", m3_FLDI.Trim())
				.WithQueryParameter("KV01", m3_KV01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_VARI))
				request.WithQueryParameter("VARI", m3_VARI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV02))
				request.WithQueryParameter("KV02", m3_KV02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV03))
				request.WithQueryParameter("KV03", m3_KV03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV04))
				request.WithQueryParameter("KV04", m3_KV04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV05))
				request.WithQueryParameter("KV05", m3_KV05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV06))
				request.WithQueryParameter("KV06", m3_KV06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV07))
				request.WithQueryParameter("KV07", m3_KV07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV08))
				request.WithQueryParameter("KV08", m3_KV08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV09))
				request.WithQueryParameter("KV09", m3_KV09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV10))
				request.WithQueryParameter("KV10", m3_KV10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV11))
				request.WithQueryParameter("KV11", m3_KV11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV12))
				request.WithQueryParameter("KV12", m3_KV12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV13))
				request.WithQueryParameter("KV13", m3_KV13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV14))
				request.WithQueryParameter("KV14", m3_KV14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV15))
				request.WithQueryParameter("KV15", m3_KV15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV16))
				request.WithQueryParameter("KV16", m3_KV16.Trim());
			if (m3_PGDN.HasValue)
				request.WithQueryParameter("PGDN", m3_PGDN.Value.ToString());

			// Execute the request
			var result = await Execute<LstBrowseResponse>(
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
		/// Name LstRows
		/// Description Init, set start and return rows
		/// Version Release: 12.5
		/// </summary>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_VARI">Browse variant</param>
		/// <param name="m3_USID">User</param>
		/// <param name="m3_KV01">Key value</param>
		/// <param name="m3_KV02">Key value</param>
		/// <param name="m3_KV03">Key value</param>
		/// <param name="m3_KV04">Key value</param>
		/// <param name="m3_KV05">Key value</param>
		/// <param name="m3_KV06">Key value</param>
		/// <param name="m3_KV07">Key value</param>
		/// <param name="m3_KV08">Key value</param>
		/// <param name="m3_KV09">Key value</param>
		/// <param name="m3_KV10">Key value</param>
		/// <param name="m3_KV11">Key value</param>
		/// <param name="m3_KV12">Key value</param>
		/// <param name="m3_KV13">Key value</param>
		/// <param name="m3_KV14">Key value</param>
		/// <param name="m3_KV15">Key value</param>
		/// <param name="m3_KV16">Key value</param>
		/// <param name="m3_PGDN">PageDown(SETGT)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRowsResponse></returns>
		/// <exception cref="M3Exception<LstRowsResponse>"></exception>
		public async Task<M3Response<LstRowsResponse>> LstRows(
			string m3_FLDI, 
			string m3_VARI = null, 
			string m3_USID = null, 
			string m3_KV01 = null, 
			string m3_KV02 = null, 
			string m3_KV03 = null, 
			string m3_KV04 = null, 
			string m3_KV05 = null, 
			string m3_KV06 = null, 
			string m3_KV07 = null, 
			string m3_KV08 = null, 
			string m3_KV09 = null, 
			string m3_KV10 = null, 
			string m3_KV11 = null, 
			string m3_KV12 = null, 
			string m3_KV13 = null, 
			string m3_KV14 = null, 
			string m3_KV15 = null, 
			string m3_KV16 = null, 
			int? m3_PGDN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstRows",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FLDI", m3_FLDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_VARI))
				request.WithQueryParameter("VARI", m3_VARI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV01))
				request.WithQueryParameter("KV01", m3_KV01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV02))
				request.WithQueryParameter("KV02", m3_KV02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV03))
				request.WithQueryParameter("KV03", m3_KV03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV04))
				request.WithQueryParameter("KV04", m3_KV04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV05))
				request.WithQueryParameter("KV05", m3_KV05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV06))
				request.WithQueryParameter("KV06", m3_KV06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV07))
				request.WithQueryParameter("KV07", m3_KV07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV08))
				request.WithQueryParameter("KV08", m3_KV08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV09))
				request.WithQueryParameter("KV09", m3_KV09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV10))
				request.WithQueryParameter("KV10", m3_KV10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV11))
				request.WithQueryParameter("KV11", m3_KV11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV12))
				request.WithQueryParameter("KV12", m3_KV12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV13))
				request.WithQueryParameter("KV13", m3_KV13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV14))
				request.WithQueryParameter("KV14", m3_KV14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV15))
				request.WithQueryParameter("KV15", m3_KV15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV16))
				request.WithQueryParameter("KV16", m3_KV16.Trim());
			if (m3_PGDN.HasValue)
				request.WithQueryParameter("PGDN", m3_PGDN.Value.ToString());

			// Execute the request
			var result = await Execute<LstRowsResponse>(
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
		/// Name LstRowsWPos
		/// Description Set start and return rows for sel columns
		/// Version Release: 12.5
		/// </summary>
		/// <param name="m3_KV01">Key value</param>
		/// <param name="m3_KV02">Key value</param>
		/// <param name="m3_KV03">Key value</param>
		/// <param name="m3_KV04">Key value</param>
		/// <param name="m3_KV05">Key value</param>
		/// <param name="m3_KV06">Key value</param>
		/// <param name="m3_KV07">Key value</param>
		/// <param name="m3_KV08">Key value</param>
		/// <param name="m3_KV09">Key value</param>
		/// <param name="m3_KV10">Key value</param>
		/// <param name="m3_KV11">Key value</param>
		/// <param name="m3_KV12">Key value</param>
		/// <param name="m3_KV13">Key value</param>
		/// <param name="m3_KV14">Key value</param>
		/// <param name="m3_KV15">Key value</param>
		/// <param name="m3_KV16">Key value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRowsWPosResponse></returns>
		/// <exception cref="M3Exception<LstRowsWPosResponse>"></exception>
		public async Task<M3Response<LstRowsWPosResponse>> LstRowsWPos(
			string m3_KV01 = null, 
			string m3_KV02 = null, 
			string m3_KV03 = null, 
			string m3_KV04 = null, 
			string m3_KV05 = null, 
			string m3_KV06 = null, 
			string m3_KV07 = null, 
			string m3_KV08 = null, 
			string m3_KV09 = null, 
			string m3_KV10 = null, 
			string m3_KV11 = null, 
			string m3_KV12 = null, 
			string m3_KV13 = null, 
			string m3_KV14 = null, 
			string m3_KV15 = null, 
			string m3_KV16 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstRowsWPos",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_KV01))
				request.WithQueryParameter("KV01", m3_KV01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV02))
				request.WithQueryParameter("KV02", m3_KV02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV03))
				request.WithQueryParameter("KV03", m3_KV03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV04))
				request.WithQueryParameter("KV04", m3_KV04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV05))
				request.WithQueryParameter("KV05", m3_KV05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV06))
				request.WithQueryParameter("KV06", m3_KV06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV07))
				request.WithQueryParameter("KV07", m3_KV07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV08))
				request.WithQueryParameter("KV08", m3_KV08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV09))
				request.WithQueryParameter("KV09", m3_KV09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV10))
				request.WithQueryParameter("KV10", m3_KV10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV11))
				request.WithQueryParameter("KV11", m3_KV11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV12))
				request.WithQueryParameter("KV12", m3_KV12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV13))
				request.WithQueryParameter("KV13", m3_KV13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV14))
				request.WithQueryParameter("KV14", m3_KV14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV15))
				request.WithQueryParameter("KV15", m3_KV15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV16))
				request.WithQueryParameter("KV16", m3_KV16.Trim());

			// Execute the request
			var result = await Execute<LstRowsWPosResponse>(
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
