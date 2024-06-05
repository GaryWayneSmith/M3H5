/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Get
		/// Description Get Fields from any file defined in CMNBDF
		/// Version Release: 12.5
		/// </summary>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3KV01">Key value (Required)</param>
		/// <param name="m3VARI">Browse variant</param>
		/// <param name="m3USID">User</param>
		/// <param name="m3NFTR">Number of filters</param>
		/// <param name="m3KV02">Key value</param>
		/// <param name="m3FL01">Field</param>
		/// <param name="m3FL02">Field</param>
		/// <param name="m3FL03">Field</param>
		/// <param name="m3FL04">Field</param>
		/// <param name="m3FL05">Field</param>
		/// <param name="m3FL06">Field</param>
		/// <param name="m3FL07">Field</param>
		/// <param name="m3FL08">Field</param>
		/// <param name="m3FL09">Field</param>
		/// <param name="m3FL10">Field</param>
		/// <param name="m3FL11">Field</param>
		/// <param name="m3FL12">Field</param>
		/// <param name="m3FL13">Field</param>
		/// <param name="m3FL14">Field</param>
		/// <param name="m3FL15">Field</param>
		/// <param name="m3KV03">Key value</param>
		/// <param name="m3KV04">Key value</param>
		/// <param name="m3KV05">Key value</param>
		/// <param name="m3KV06">Key value 6</param>
		/// <param name="m3KV07">Key value</param>
		/// <param name="m3KV08">Key value</param>
		/// <param name="m3KV09">Key value</param>
		/// <param name="m3KV10">Key value</param>
		/// <param name="m3KV11">Key value</param>
		/// <param name="m3KV12">Key value</param>
		/// <param name="m3KV13">Key value</param>
		/// <param name="m3KV14">Key value</param>
		/// <param name="m3KV15">Key value 1</param>
		/// <param name="m3KV16">Key value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3FLDI, 
			string m3KV01, 
			string m3VARI = null, 
			string m3USID = null, 
			int? m3NFTR = null, 
			string m3KV02 = null, 
			string m3FL01 = null, 
			string m3FL02 = null, 
			string m3FL03 = null, 
			string m3FL04 = null, 
			string m3FL05 = null, 
			string m3FL06 = null, 
			string m3FL07 = null, 
			string m3FL08 = null, 
			string m3FL09 = null, 
			string m3FL10 = null, 
			string m3FL11 = null, 
			string m3FL12 = null, 
			string m3FL13 = null, 
			string m3FL14 = null, 
			string m3FL15 = null, 
			string m3KV03 = null, 
			string m3KV04 = null, 
			string m3KV05 = null, 
			string m3KV06 = null, 
			string m3KV07 = null, 
			string m3KV08 = null, 
			string m3KV09 = null, 
			string m3KV10 = null, 
			string m3KV11 = null, 
			string m3KV12 = null, 
			string m3KV13 = null, 
			string m3KV14 = null, 
			string m3KV15 = null, 
			string m3KV16 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));
			if (string.IsNullOrWhiteSpace(m3KV01))
				throw new ArgumentNullException(nameof(m3KV01));

			// Set mandatory parameters
			request
				.WithQueryParameter("FLDI", m3FLDI.Trim())
				.WithQueryParameter("KV01", m3KV01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3VARI))
				request.WithQueryParameter("VARI", m3VARI.Trim());
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());
			if (m3NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3NFTR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3KV02))
				request.WithQueryParameter("KV02", m3KV02.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL01))
				request.WithQueryParameter("FL01", m3FL01.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL02))
				request.WithQueryParameter("FL02", m3FL02.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL03))
				request.WithQueryParameter("FL03", m3FL03.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL04))
				request.WithQueryParameter("FL04", m3FL04.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL05))
				request.WithQueryParameter("FL05", m3FL05.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL06))
				request.WithQueryParameter("FL06", m3FL06.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL07))
				request.WithQueryParameter("FL07", m3FL07.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL08))
				request.WithQueryParameter("FL08", m3FL08.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL09))
				request.WithQueryParameter("FL09", m3FL09.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL10))
				request.WithQueryParameter("FL10", m3FL10.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL11))
				request.WithQueryParameter("FL11", m3FL11.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL12))
				request.WithQueryParameter("FL12", m3FL12.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL13))
				request.WithQueryParameter("FL13", m3FL13.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL14))
				request.WithQueryParameter("FL14", m3FL14.Trim());
			if (!string.IsNullOrWhiteSpace(m3FL15))
				request.WithQueryParameter("FL15", m3FL15.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV03))
				request.WithQueryParameter("KV03", m3KV03.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV04))
				request.WithQueryParameter("KV04", m3KV04.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV05))
				request.WithQueryParameter("KV05", m3KV05.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV06))
				request.WithQueryParameter("KV06", m3KV06.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV07))
				request.WithQueryParameter("KV07", m3KV07.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV08))
				request.WithQueryParameter("KV08", m3KV08.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV09))
				request.WithQueryParameter("KV09", m3KV09.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV10))
				request.WithQueryParameter("KV10", m3KV10.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV11))
				request.WithQueryParameter("KV11", m3KV11.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV12))
				request.WithQueryParameter("KV12", m3KV12.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV13))
				request.WithQueryParameter("KV13", m3KV13.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV14))
				request.WithQueryParameter("KV14", m3KV14.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV15))
				request.WithQueryParameter("KV15", m3KV15.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV16))
				request.WithQueryParameter("KV16", m3KV16.Trim());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name GetBrowse
		/// Description Get all Fields from any file defined in CMNBDF
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3KV01">Key value (Required)</param>
		/// <param name="m3VARI">Browse variant</param>
		/// <param name="m3USID">User</param>
		/// <param name="m3NFTR">Number of filters</param>
		/// <param name="m3KV02">Key value</param>
		/// <param name="m3KV03">Key value</param>
		/// <param name="m3KV04">Key value</param>
		/// <param name="m3KV05">Key value</param>
		/// <param name="m3KV06">Key value 6</param>
		/// <param name="m3KV07">Key value</param>
		/// <param name="m3KV08">Key value</param>
		/// <param name="m3KV09">Key value</param>
		/// <param name="m3KV10">Key value</param>
		/// <param name="m3KV11">Key value</param>
		/// <param name="m3KV12">Key value</param>
		/// <param name="m3KV13">Key value</param>
		/// <param name="m3KV14">Key value</param>
		/// <param name="m3KV15">Key value 1</param>
		/// <param name="m3KV16">Key value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBrowseResponse></returns>
		/// <exception cref="M3Exception<GetBrowseResponse>"></exception>
		public async Task<M3Response<GetBrowseResponse>> GetBrowse(
			string m3FLDI, 
			string m3KV01, 
			string m3VARI = null, 
			string m3USID = null, 
			int? m3NFTR = null, 
			string m3KV02 = null, 
			string m3KV03 = null, 
			string m3KV04 = null, 
			string m3KV05 = null, 
			string m3KV06 = null, 
			string m3KV07 = null, 
			string m3KV08 = null, 
			string m3KV09 = null, 
			string m3KV10 = null, 
			string m3KV11 = null, 
			string m3KV12 = null, 
			string m3KV13 = null, 
			string m3KV14 = null, 
			string m3KV15 = null, 
			string m3KV16 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBrowse",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));
			if (string.IsNullOrWhiteSpace(m3KV01))
				throw new ArgumentNullException(nameof(m3KV01));

			// Set mandatory parameters
			request
				.WithQueryParameter("FLDI", m3FLDI.Trim())
				.WithQueryParameter("KV01", m3KV01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3VARI))
				request.WithQueryParameter("VARI", m3VARI.Trim());
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());
			if (m3NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3NFTR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3KV02))
				request.WithQueryParameter("KV02", m3KV02.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV03))
				request.WithQueryParameter("KV03", m3KV03.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV04))
				request.WithQueryParameter("KV04", m3KV04.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV05))
				request.WithQueryParameter("KV05", m3KV05.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV06))
				request.WithQueryParameter("KV06", m3KV06.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV07))
				request.WithQueryParameter("KV07", m3KV07.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV08))
				request.WithQueryParameter("KV08", m3KV08.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV09))
				request.WithQueryParameter("KV09", m3KV09.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV10))
				request.WithQueryParameter("KV10", m3KV10.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV11))
				request.WithQueryParameter("KV11", m3KV11.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV12))
				request.WithQueryParameter("KV12", m3KV12.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV13))
				request.WithQueryParameter("KV13", m3KV13.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV14))
				request.WithQueryParameter("KV14", m3KV14.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV15))
				request.WithQueryParameter("KV15", m3KV15.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV16))
				request.WithQueryParameter("KV16", m3KV16.Trim());

			// Execute the request
			var result = await Execute<GetBrowseResponse>(
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
		/// Name GetHeading
		/// Description Get the heading as a single row
		/// Version Release: 12.5
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FLDI">Field</param>
		/// <param name="m3VARI">Browse variant</param>
		/// <param name="m3USID">User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadingResponse></returns>
		/// <exception cref="M3Exception<GetHeadingResponse>"></exception>
		public async Task<M3Response<GetHeadingResponse>> GetHeading(
			int? m3CONO = null, 
			string m3FLDI = null, 
			string m3VARI = null, 
			string m3USID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetHeading",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3VARI))
				request.WithQueryParameter("VARI", m3VARI.Trim());
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());

			// Execute the request
			var result = await Execute<GetHeadingResponse>(
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
		/// Name InitBrowse
		/// Description Access Browse definition and return column headings
		/// Version Release: 12.5
		/// </summary>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3VARI">Browse variant</param>
		/// <param name="m3USID">User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<InitBrowseResponse></returns>
		/// <exception cref="M3Exception<InitBrowseResponse>"></exception>
		public async Task<M3Response<InitBrowseResponse>> InitBrowse(
			string m3FLDI, 
			string m3VARI = null, 
			string m3USID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/InitBrowse",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FLDI", m3FLDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3VARI))
				request.WithQueryParameter("VARI", m3VARI.Trim());
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());

			// Execute the request
			var result = await Execute<InitBrowseResponse>(
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
		/// Name InitBrowseWHead
		/// Description Init and return column headings and heading as a row
		/// Version Release: 12.5
		/// </summary>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3VARI">Browse variant</param>
		/// <param name="m3USID">User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<InitBrowseWHeadResponse></returns>
		/// <exception cref="M3Exception<InitBrowseWHeadResponse>"></exception>
		public async Task<M3Response<InitBrowseWHeadResponse>> InitBrowseWHead(
			string m3FLDI, 
			string m3VARI = null, 
			string m3USID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/InitBrowseWHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FLDI", m3FLDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3VARI))
				request.WithQueryParameter("VARI", m3VARI.Trim());
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());

			// Execute the request
			var result = await Execute<InitBrowseWHeadResponse>(
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
		/// Name LstBrowse
		/// Description List all Fields from any file defined in CMNBDF
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3KV01">Key value (Required)</param>
		/// <param name="m3VARI">Browse variant</param>
		/// <param name="m3USID">User</param>
		/// <param name="m3KV02">Key value</param>
		/// <param name="m3KV03">Key value</param>
		/// <param name="m3KV04">Key value</param>
		/// <param name="m3KV05">Key value</param>
		/// <param name="m3KV06">Key value 6</param>
		/// <param name="m3KV07">Key value</param>
		/// <param name="m3KV08">Key value</param>
		/// <param name="m3KV09">Key value</param>
		/// <param name="m3KV10">Key value</param>
		/// <param name="m3KV11">Key value</param>
		/// <param name="m3KV12">Key value</param>
		/// <param name="m3KV13">Key value</param>
		/// <param name="m3KV14">Key value</param>
		/// <param name="m3KV15">Key value 1</param>
		/// <param name="m3KV16">Key value</param>
		/// <param name="m3PGDN">Page down</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBrowseResponse></returns>
		/// <exception cref="M3Exception<LstBrowseResponse>"></exception>
		public async Task<M3Response<LstBrowseResponse>> LstBrowse(
			string m3FLDI, 
			string m3KV01, 
			string m3VARI = null, 
			string m3USID = null, 
			string m3KV02 = null, 
			string m3KV03 = null, 
			string m3KV04 = null, 
			string m3KV05 = null, 
			string m3KV06 = null, 
			string m3KV07 = null, 
			string m3KV08 = null, 
			string m3KV09 = null, 
			string m3KV10 = null, 
			string m3KV11 = null, 
			string m3KV12 = null, 
			string m3KV13 = null, 
			string m3KV14 = null, 
			string m3KV15 = null, 
			string m3KV16 = null, 
			int? m3PGDN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstBrowse",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));
			if (string.IsNullOrWhiteSpace(m3KV01))
				throw new ArgumentNullException(nameof(m3KV01));

			// Set mandatory parameters
			request
				.WithQueryParameter("FLDI", m3FLDI.Trim())
				.WithQueryParameter("KV01", m3KV01.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3VARI))
				request.WithQueryParameter("VARI", m3VARI.Trim());
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV02))
				request.WithQueryParameter("KV02", m3KV02.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV03))
				request.WithQueryParameter("KV03", m3KV03.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV04))
				request.WithQueryParameter("KV04", m3KV04.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV05))
				request.WithQueryParameter("KV05", m3KV05.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV06))
				request.WithQueryParameter("KV06", m3KV06.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV07))
				request.WithQueryParameter("KV07", m3KV07.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV08))
				request.WithQueryParameter("KV08", m3KV08.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV09))
				request.WithQueryParameter("KV09", m3KV09.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV10))
				request.WithQueryParameter("KV10", m3KV10.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV11))
				request.WithQueryParameter("KV11", m3KV11.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV12))
				request.WithQueryParameter("KV12", m3KV12.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV13))
				request.WithQueryParameter("KV13", m3KV13.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV14))
				request.WithQueryParameter("KV14", m3KV14.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV15))
				request.WithQueryParameter("KV15", m3KV15.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV16))
				request.WithQueryParameter("KV16", m3KV16.Trim());
			if (m3PGDN.HasValue)
				request.WithQueryParameter("PGDN", m3PGDN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstBrowseResponse>(
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
		/// Name LstRows
		/// Description Init, set start and return rows
		/// Version Release: 12.5
		/// </summary>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3VARI">Browse variant</param>
		/// <param name="m3USID">User</param>
		/// <param name="m3KV01">Key value</param>
		/// <param name="m3KV02">Key value</param>
		/// <param name="m3KV03">Key value</param>
		/// <param name="m3KV04">Key value</param>
		/// <param name="m3KV05">Key value</param>
		/// <param name="m3KV06">Key value</param>
		/// <param name="m3KV07">Key value</param>
		/// <param name="m3KV08">Key value</param>
		/// <param name="m3KV09">Key value</param>
		/// <param name="m3KV10">Key value</param>
		/// <param name="m3KV11">Key value</param>
		/// <param name="m3KV12">Key value</param>
		/// <param name="m3KV13">Key value</param>
		/// <param name="m3KV14">Key value</param>
		/// <param name="m3KV15">Key value</param>
		/// <param name="m3KV16">Key value</param>
		/// <param name="m3PGDN">PageDown(SETGT)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRowsResponse></returns>
		/// <exception cref="M3Exception<LstRowsResponse>"></exception>
		public async Task<M3Response<LstRowsResponse>> LstRows(
			string m3FLDI, 
			string m3VARI = null, 
			string m3USID = null, 
			string m3KV01 = null, 
			string m3KV02 = null, 
			string m3KV03 = null, 
			string m3KV04 = null, 
			string m3KV05 = null, 
			string m3KV06 = null, 
			string m3KV07 = null, 
			string m3KV08 = null, 
			string m3KV09 = null, 
			string m3KV10 = null, 
			string m3KV11 = null, 
			string m3KV12 = null, 
			string m3KV13 = null, 
			string m3KV14 = null, 
			string m3KV15 = null, 
			string m3KV16 = null, 
			int? m3PGDN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstRows",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FLDI", m3FLDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3VARI))
				request.WithQueryParameter("VARI", m3VARI.Trim());
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV01))
				request.WithQueryParameter("KV01", m3KV01.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV02))
				request.WithQueryParameter("KV02", m3KV02.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV03))
				request.WithQueryParameter("KV03", m3KV03.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV04))
				request.WithQueryParameter("KV04", m3KV04.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV05))
				request.WithQueryParameter("KV05", m3KV05.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV06))
				request.WithQueryParameter("KV06", m3KV06.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV07))
				request.WithQueryParameter("KV07", m3KV07.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV08))
				request.WithQueryParameter("KV08", m3KV08.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV09))
				request.WithQueryParameter("KV09", m3KV09.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV10))
				request.WithQueryParameter("KV10", m3KV10.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV11))
				request.WithQueryParameter("KV11", m3KV11.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV12))
				request.WithQueryParameter("KV12", m3KV12.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV13))
				request.WithQueryParameter("KV13", m3KV13.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV14))
				request.WithQueryParameter("KV14", m3KV14.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV15))
				request.WithQueryParameter("KV15", m3KV15.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV16))
				request.WithQueryParameter("KV16", m3KV16.Trim());
			if (m3PGDN.HasValue)
				request.WithQueryParameter("PGDN", m3PGDN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstRowsResponse>(
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
		/// Name LstRowsWPos
		/// Description Set start and return rows for sel columns
		/// Version Release: 12.5
		/// </summary>
		/// <param name="m3KV01">Key value</param>
		/// <param name="m3KV02">Key value</param>
		/// <param name="m3KV03">Key value</param>
		/// <param name="m3KV04">Key value</param>
		/// <param name="m3KV05">Key value</param>
		/// <param name="m3KV06">Key value</param>
		/// <param name="m3KV07">Key value</param>
		/// <param name="m3KV08">Key value</param>
		/// <param name="m3KV09">Key value</param>
		/// <param name="m3KV10">Key value</param>
		/// <param name="m3KV11">Key value</param>
		/// <param name="m3KV12">Key value</param>
		/// <param name="m3KV13">Key value</param>
		/// <param name="m3KV14">Key value</param>
		/// <param name="m3KV15">Key value</param>
		/// <param name="m3KV16">Key value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRowsWPosResponse></returns>
		/// <exception cref="M3Exception<LstRowsWPosResponse>"></exception>
		public async Task<M3Response<LstRowsWPosResponse>> LstRowsWPos(
			string m3KV01 = null, 
			string m3KV02 = null, 
			string m3KV03 = null, 
			string m3KV04 = null, 
			string m3KV05 = null, 
			string m3KV06 = null, 
			string m3KV07 = null, 
			string m3KV08 = null, 
			string m3KV09 = null, 
			string m3KV10 = null, 
			string m3KV11 = null, 
			string m3KV12 = null, 
			string m3KV13 = null, 
			string m3KV14 = null, 
			string m3KV15 = null, 
			string m3KV16 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstRowsWPos",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3KV01))
				request.WithQueryParameter("KV01", m3KV01.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV02))
				request.WithQueryParameter("KV02", m3KV02.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV03))
				request.WithQueryParameter("KV03", m3KV03.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV04))
				request.WithQueryParameter("KV04", m3KV04.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV05))
				request.WithQueryParameter("KV05", m3KV05.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV06))
				request.WithQueryParameter("KV06", m3KV06.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV07))
				request.WithQueryParameter("KV07", m3KV07.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV08))
				request.WithQueryParameter("KV08", m3KV08.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV09))
				request.WithQueryParameter("KV09", m3KV09.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV10))
				request.WithQueryParameter("KV10", m3KV10.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV11))
				request.WithQueryParameter("KV11", m3KV11.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV12))
				request.WithQueryParameter("KV12", m3KV12.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV13))
				request.WithQueryParameter("KV13", m3KV13.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV14))
				request.WithQueryParameter("KV14", m3KV14.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV15))
				request.WithQueryParameter("KV15", m3KV15.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV16))
				request.WithQueryParameter("KV16", m3KV16.Trim());

			// Execute the request
			var result = await Execute<LstRowsWPosResponse>(
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
