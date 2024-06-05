/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.CRS980MI;
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
	/// Name: CRS980MI
	/// Component Name: TextBlocks
	/// Description: Text blocks interface
	/// Version Release: 5ea2
	///</summary>
	public partial class CRS980MIResource : M3BaseResourceEndpoint
	{
		public CRS980MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS980MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddTxtBlockHead
		/// Description Add text header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3TXID">Text identity (Required)</param>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3KFLD">File key (Required)</param>
		/// <param name="m3USID">User (Required)</param>
		/// <param name="m3TFIL">Transfer file (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3TXVR">Text block</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TXCC">Text control code</param>
		/// <param name="m3TXEI">External/internal text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTxtBlockHead(
			decimal m3TXID, 
			string m3FILE, 
			string m3KFLD, 
			string m3USID, 
			string m3TFIL, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3TXVR = null, 
			string m3LNCD = null, 
			string m3TX40 = null, 
			string m3TXCC = null, 
			int? m3TXEI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddTxtBlockHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3KFLD))
				throw new ArgumentNullException(nameof(m3KFLD));
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));
			if (string.IsNullOrWhiteSpace(m3TFIL))
				throw new ArgumentNullException(nameof(m3TFIL));

			// Set mandatory parameters
			request
				.WithQueryParameter("TXID", m3TXID.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("KFLD", m3KFLD.Trim())
				.WithQueryParameter("USID", m3USID.Trim())
				.WithQueryParameter("TFIL", m3TFIL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXVR))
				request.WithQueryParameter("TXVR", m3TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXCC))
				request.WithQueryParameter("TXCC", m3TXCC.Trim());
			if (m3TXEI.HasValue)
				request.WithQueryParameter("TXEI", m3TXEI.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddTxtBlockLine
		/// Description Add a single line of text to a textblock
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3TXID">Text identity (Required)</param>
		/// <param name="m3TFIL">Transfer file (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3TXVR">Text block</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3LINO">Line number</param>
		/// <param name="m3TX60">Text</param>
		/// <param name="m3FILE">Table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddTxtBlockLineResponse></returns>
		/// <exception cref="M3Exception<AddTxtBlockLineResponse>"></exception>
		public async Task<M3Response<AddTxtBlockLineResponse>> AddTxtBlockLine(
			decimal m3TXID, 
			string m3TFIL, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3TXVR = null, 
			string m3LNCD = null, 
			int? m3LINO = null, 
			string m3TX60 = null, 
			string m3FILE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddTxtBlockLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TFIL))
				throw new ArgumentNullException(nameof(m3TFIL));

			// Set mandatory parameters
			request
				.WithQueryParameter("TXID", m3TXID.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TFIL", m3TFIL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXVR))
				request.WithQueryParameter("TXVR", m3TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (m3LINO.HasValue)
				request.WithQueryParameter("LINO", m3LINO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX60))
				request.WithQueryParameter("TX60", m3TX60.Trim());
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());

			// Execute the request
			var result = await Execute<AddTxtBlockLineResponse>(
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
		/// Name DltTxtBlockLins
		/// Description Delete a textblock with its lines
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3TXID">Text identity (Required)</param>
		/// <param name="m3TFIL">Transfer file (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3TXVR">Text block</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3FILE">Table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltTxtBlockLins(
			decimal m3TXID, 
			string m3TFIL, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3TXVR = null, 
			string m3LNCD = null, 
			string m3FILE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltTxtBlockLins",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TFIL))
				throw new ArgumentNullException(nameof(m3TFIL));

			// Set mandatory parameters
			request
				.WithQueryParameter("TXID", m3TXID.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TFIL", m3TFIL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXVR))
				request.WithQueryParameter("TXVR", m3TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());

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
		/// Name GetTextID
		/// Description Get Text ID from any file in M3
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FILE">Table</param>
		/// <param name="m3KV01">Key value 1</param>
		/// <param name="m3KV02">Key value 2</param>
		/// <param name="m3KV03">Key value 3</param>
		/// <param name="m3KV04">Key value 4</param>
		/// <param name="m3KV05">Key value 5</param>
		/// <param name="m3KV06">Key value 6</param>
		/// <param name="m3KV08">Key value 8</param>
		/// <param name="m3KV09">Key value 9</param>
		/// <param name="m3KV10">Key value 10</param>
		/// <param name="m3KV11">Key value11</param>
		/// <param name="m3KV12">Key value 12</param>
		/// <param name="m3KV13">Key value 13</param>
		/// <param name="m3KV14">Key value 14</param>
		/// <param name="m3KV15">Key value 15</param>
		/// <param name="m3KV07">Key value 7</param>
		/// <param name="m3KV16">Key value 16</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTextIDResponse></returns>
		/// <exception cref="M3Exception<GetTextIDResponse>"></exception>
		public async Task<M3Response<GetTextIDResponse>> GetTextID(
			string m3FILE = null, 
			string m3KV01 = null, 
			string m3KV02 = null, 
			string m3KV03 = null, 
			string m3KV04 = null, 
			string m3KV05 = null, 
			string m3KV06 = null, 
			string m3KV08 = null, 
			string m3KV09 = null, 
			string m3KV10 = null, 
			string m3KV11 = null, 
			string m3KV12 = null, 
			string m3KV13 = null, 
			string m3KV14 = null, 
			string m3KV15 = null, 
			string m3KV07 = null, 
			string m3KV16 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetTextID",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3KV07))
				request.WithQueryParameter("KV07", m3KV07.Trim());
			if (!string.IsNullOrWhiteSpace(m3KV16))
				request.WithQueryParameter("KV16", m3KV16.Trim());

			// Execute the request
			var result = await Execute<GetTextIDResponse>(
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
		/// Name LstTxtBlocks
		/// Description Return Textblock variants and language codes for given TXID
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3TXID">Text identity (Required)</param>
		/// <param name="m3TFIL">Transfer file (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3FILE">Table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTxtBlocksResponse></returns>
		/// <exception cref="M3Exception<LstTxtBlocksResponse>"></exception>
		public async Task<M3Response<LstTxtBlocksResponse>> LstTxtBlocks(
			decimal m3TXID, 
			string m3TFIL, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3FILE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTxtBlocks",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TFIL))
				throw new ArgumentNullException(nameof(m3TFIL));

			// Set mandatory parameters
			request
				.WithQueryParameter("TXID", m3TXID.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TFIL", m3TFIL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());

			// Execute the request
			var result = await Execute<LstTxtBlocksResponse>(
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
		/// Name RtvNewTextID
		/// Description Retrieve a new text id
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3TXVR">Text block</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3TABL">Table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RtvNewTextIDResponse></returns>
		/// <exception cref="M3Exception<RtvNewTextIDResponse>"></exception>
		public async Task<M3Response<RtvNewTextIDResponse>> RtvNewTextID(
			string m3FILE, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			decimal? m3TXID = null, 
			string m3TXVR = null, 
			string m3LNCD = null, 
			string m3TABL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RtvNewTextID",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TXVR))
				request.WithQueryParameter("TXVR", m3TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TABL))
				request.WithQueryParameter("TABL", m3TABL.Trim());

			// Execute the request
			var result = await Execute<RtvNewTextIDResponse>(
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
		/// Name SetTextID
		/// Description Set Text ID from any file in M3
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3FILE">Table</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3KV01">Key value 1</param>
		/// <param name="m3KV02">Key value 2</param>
		/// <param name="m3KV03">Key value 3</param>
		/// <param name="m3KV04">Key value 4</param>
		/// <param name="m3KV05">Key value 5</param>
		/// <param name="m3KV06">Key value 6</param>
		/// <param name="m3KV07">Key value 7</param>
		/// <param name="m3KV08">Key value 8</param>
		/// <param name="m3KV09">Key value 9</param>
		/// <param name="m3KV10">Key value 10</param>
		/// <param name="m3KV11">Key value11</param>
		/// <param name="m3KV12">Key value 12</param>
		/// <param name="m3KV13">Key value 13</param>
		/// <param name="m3KV14">Key value 14</param>
		/// <param name="m3KV15">Key value 15</param>
		/// <param name="m3KV16">Key value 16</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetTextID(
			string m3FILE = null, 
			decimal? m3TXID = null, 
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
			M3Request request = new M3Request(M3Config)
			{
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SetTextID",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
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
		/// Name SltTxtBlock
		/// Description Select text from a specific text block
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3TXID">Text identity (Required)</param>
		/// <param name="m3TFIL">Transfer file (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3TXVR">Text block</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3FILE">Table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SltTxtBlockResponse></returns>
		/// <exception cref="M3Exception<SltTxtBlockResponse>"></exception>
		public async Task<M3Response<SltTxtBlockResponse>> SltTxtBlock(
			decimal m3TXID, 
			string m3TFIL, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3TXVR = null, 
			string m3LNCD = null, 
			string m3FILE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SltTxtBlock",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3TFIL))
				throw new ArgumentNullException(nameof(m3TFIL));

			// Set mandatory parameters
			request
				.WithQueryParameter("TXID", m3TXID.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TFIL", m3TFIL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXVR))
				request.WithQueryParameter("TXVR", m3TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());

			// Execute the request
			var result = await Execute<SltTxtBlockResponse>(
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
