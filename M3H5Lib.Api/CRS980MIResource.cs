/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_TXID">Text identity (Required)</param>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_KFLD">File key (Required)</param>
		/// <param name="m3_USID">User (Required)</param>
		/// <param name="m3_TFIL">Transfer file (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_TXVR">Text block</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TXCC">Text control code</param>
		/// <param name="m3_TXEI">External/internal text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTxtBlockHead(
			decimal m3_TXID, 
			string m3_FILE, 
			string m3_KFLD, 
			string m3_USID, 
			string m3_TFIL, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_TXVR = null, 
			string m3_LNCD = null, 
			string m3_TX40 = null, 
			string m3_TXCC = null, 
			int? m3_TXEI = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_KFLD))
				throw new ArgumentNullException("m3_KFLD");
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");
			if (string.IsNullOrWhiteSpace(m3_TFIL))
				throw new ArgumentNullException("m3_TFIL");

			// Set mandatory parameters
			request
				.WithQueryParameter("TXID", m3_TXID.ToString())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("KFLD", m3_KFLD.Trim())
				.WithQueryParameter("USID", m3_USID.Trim())
				.WithQueryParameter("TFIL", m3_TFIL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXVR))
				request.WithQueryParameter("TXVR", m3_TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXCC))
				request.WithQueryParameter("TXCC", m3_TXCC.Trim());
			if (m3_TXEI.HasValue)
				request.WithQueryParameter("TXEI", m3_TXEI.Value.ToString());

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
		/// Name AddTxtBlockLine
		/// Description Add a single line of text to a textblock
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_TXID">Text identity (Required)</param>
		/// <param name="m3_TFIL">Transfer file (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_TXVR">Text block</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_LINO">Line number</param>
		/// <param name="m3_TX60">Text</param>
		/// <param name="m3_FILE">Table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddTxtBlockLineResponse></returns>
		/// <exception cref="M3Exception<AddTxtBlockLineResponse>"></exception>
		public async Task<M3Response<AddTxtBlockLineResponse>> AddTxtBlockLine(
			decimal m3_TXID, 
			string m3_TFIL, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_TXVR = null, 
			string m3_LNCD = null, 
			int? m3_LINO = null, 
			string m3_TX60 = null, 
			string m3_FILE = null, 
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
			if (string.IsNullOrWhiteSpace(m3_TFIL))
				throw new ArgumentNullException("m3_TFIL");

			// Set mandatory parameters
			request
				.WithQueryParameter("TXID", m3_TXID.ToString())
				.WithQueryParameter("TFIL", m3_TFIL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXVR))
				request.WithQueryParameter("TXVR", m3_TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (m3_LINO.HasValue)
				request.WithQueryParameter("LINO", m3_LINO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX60))
				request.WithQueryParameter("TX60", m3_TX60.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());

			// Execute the request
			var result = await Execute<AddTxtBlockLineResponse>(
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
		/// Name DltTxtBlockLins
		/// Description Delete a textblock with its lines
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_TXID">Text identity (Required)</param>
		/// <param name="m3_TFIL">Transfer file (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_TXVR">Text block</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_FILE">Table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltTxtBlockLins(
			decimal m3_TXID, 
			string m3_TFIL, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_TXVR = null, 
			string m3_LNCD = null, 
			string m3_FILE = null, 
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
			if (string.IsNullOrWhiteSpace(m3_TFIL))
				throw new ArgumentNullException("m3_TFIL");

			// Set mandatory parameters
			request
				.WithQueryParameter("TXID", m3_TXID.ToString())
				.WithQueryParameter("TFIL", m3_TFIL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXVR))
				request.WithQueryParameter("TXVR", m3_TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());

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
		/// Name GetTextID
		/// Description Get Text ID from any file in M3
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FILE">Table</param>
		/// <param name="m3_KV01">Key value 1</param>
		/// <param name="m3_KV02">Key value 2</param>
		/// <param name="m3_KV03">Key value 3</param>
		/// <param name="m3_KV04">Key value 4</param>
		/// <param name="m3_KV05">Key value 5</param>
		/// <param name="m3_KV06">Key value 6</param>
		/// <param name="m3_KV08">Key value 8</param>
		/// <param name="m3_KV09">Key value 9</param>
		/// <param name="m3_KV10">Key value 10</param>
		/// <param name="m3_KV11">Key value11</param>
		/// <param name="m3_KV12">Key value 12</param>
		/// <param name="m3_KV13">Key value 13</param>
		/// <param name="m3_KV14">Key value 14</param>
		/// <param name="m3_KV15">Key value 15</param>
		/// <param name="m3_KV07">Key value 7</param>
		/// <param name="m3_KV16">Key value 16</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTextIDResponse></returns>
		/// <exception cref="M3Exception<GetTextIDResponse>"></exception>
		public async Task<M3Response<GetTextIDResponse>> GetTextID(
			string m3_FILE = null, 
			string m3_KV01 = null, 
			string m3_KV02 = null, 
			string m3_KV03 = null, 
			string m3_KV04 = null, 
			string m3_KV05 = null, 
			string m3_KV06 = null, 
			string m3_KV08 = null, 
			string m3_KV09 = null, 
			string m3_KV10 = null, 
			string m3_KV11 = null, 
			string m3_KV12 = null, 
			string m3_KV13 = null, 
			string m3_KV14 = null, 
			string m3_KV15 = null, 
			string m3_KV07 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetTextID",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_KV07))
				request.WithQueryParameter("KV07", m3_KV07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KV16))
				request.WithQueryParameter("KV16", m3_KV16.Trim());

			// Execute the request
			var result = await Execute<GetTextIDResponse>(
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
		/// Name LstTxtBlocks
		/// Description Return Textblock variants and language codes for given TXID
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_TXID">Text identity (Required)</param>
		/// <param name="m3_TFIL">Transfer file (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_FILE">Table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTxtBlocksResponse></returns>
		/// <exception cref="M3Exception<LstTxtBlocksResponse>"></exception>
		public async Task<M3Response<LstTxtBlocksResponse>> LstTxtBlocks(
			decimal m3_TXID, 
			string m3_TFIL, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_FILE = null, 
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
			if (string.IsNullOrWhiteSpace(m3_TFIL))
				throw new ArgumentNullException("m3_TFIL");

			// Set mandatory parameters
			request
				.WithQueryParameter("TXID", m3_TXID.ToString())
				.WithQueryParameter("TFIL", m3_TFIL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());

			// Execute the request
			var result = await Execute<LstTxtBlocksResponse>(
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
		/// Name RtvNewTextID
		/// Description Retrieve a new text id
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_TXVR">Text block</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_TABL">Table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RtvNewTextIDResponse></returns>
		/// <exception cref="M3Exception<RtvNewTextIDResponse>"></exception>
		public async Task<M3Response<RtvNewTextIDResponse>> RtvNewTextID(
			string m3_FILE, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			decimal? m3_TXID = null, 
			string m3_TXVR = null, 
			string m3_LNCD = null, 
			string m3_TABL = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3_FILE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TXVR))
				request.WithQueryParameter("TXVR", m3_TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TABL))
				request.WithQueryParameter("TABL", m3_TABL.Trim());

			// Execute the request
			var result = await Execute<RtvNewTextIDResponse>(
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
		/// Name SetTextID
		/// Description Set Text ID from any file in M3
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_FILE">Table</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_KV01">Key value 1</param>
		/// <param name="m3_KV02">Key value 2</param>
		/// <param name="m3_KV03">Key value 3</param>
		/// <param name="m3_KV04">Key value 4</param>
		/// <param name="m3_KV05">Key value 5</param>
		/// <param name="m3_KV06">Key value 6</param>
		/// <param name="m3_KV07">Key value 7</param>
		/// <param name="m3_KV08">Key value 8</param>
		/// <param name="m3_KV09">Key value 9</param>
		/// <param name="m3_KV10">Key value 10</param>
		/// <param name="m3_KV11">Key value11</param>
		/// <param name="m3_KV12">Key value 12</param>
		/// <param name="m3_KV13">Key value 13</param>
		/// <param name="m3_KV14">Key value 14</param>
		/// <param name="m3_KV15">Key value 15</param>
		/// <param name="m3_KV16">Key value 16</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetTextID(
			string m3_FILE = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SetTextID",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
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
		/// Name SltTxtBlock
		/// Description Select text from a specific text block
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_TXID">Text identity (Required)</param>
		/// <param name="m3_TFIL">Transfer file (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_TXVR">Text block</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_FILE">Table</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SltTxtBlockResponse></returns>
		/// <exception cref="M3Exception<SltTxtBlockResponse>"></exception>
		public async Task<M3Response<SltTxtBlockResponse>> SltTxtBlock(
			decimal m3_TXID, 
			string m3_TFIL, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_TXVR = null, 
			string m3_LNCD = null, 
			string m3_FILE = null, 
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
			if (string.IsNullOrWhiteSpace(m3_TFIL))
				throw new ArgumentNullException("m3_TFIL");

			// Set mandatory parameters
			request
				.WithQueryParameter("TXID", m3_TXID.ToString())
				.WithQueryParameter("TFIL", m3_TFIL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXVR))
				request.WithQueryParameter("TXVR", m3_TXVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());

			// Execute the request
			var result = await Execute<SltTxtBlockResponse>(
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
