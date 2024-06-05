/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MMS016MI;
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
	/// Name: MMS016MI
	/// Component Name: StyleInfo
	/// Description: Style information interface
	/// Version Release: 5ea0
	///</summary>
	public partial class MMS016MIResource : M3BaseResourceEndpoint
	{
		public MMS016MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS016MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add Style Information
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_STYN">Style number (Required)</param>
		/// <param name="m3_STAT">Status (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SECH">Season check</param>
		/// <param name="m3_FM01">User-defined field heading 1</param>
		/// <param name="m3_FM02">User-defined field heading 2</param>
		/// <param name="m3_FM03">User-defined field heading 3</param>
		/// <param name="m3_FM04">User-defined field heading 4</param>
		/// <param name="m3_FM05">User-defined field heading 5</param>
		/// <param name="m3_FM06">User-defined field heading 6</param>
		/// <param name="m3_FM07">User-defined field heading 7</param>
		/// <param name="m3_FM08">User-defined field heading 8</param>
		/// <param name="m3_FM09">User-defined field heading 9</param>
		/// <param name="m3_FM10">User-defined field heading 10</param>
		/// <param name="m3_FM11">User-defined field heading 11</param>
		/// <param name="m3_FM12">User-defined field heading 12</param>
		/// <param name="m3_FM13">User-defined field heading 13</param>
		/// <param name="m3_FM14">User-defined field heading 14</param>
		/// <param name="m3_FM15">User-defined field heading 15</param>
		/// <param name="m3_FM16">User-defined field heading 16</param>
		/// <param name="m3_FM17">User-defined field heading 17</param>
		/// <param name="m3_FM18">User-defined field heading 18</param>
		/// <param name="m3_FM19">User-defined field heading 19</param>
		/// <param name="m3_FM20">User-defined field heading 20</param>
		/// <param name="m3_SEA2">Season selection</param>
		/// <param name="m3_PNYN">Classification per season</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_STYN, 
			string m3_STAT, 
			int? m3_CONO = null, 
			int? m3_SECH = null, 
			string m3_FM01 = null, 
			string m3_FM02 = null, 
			string m3_FM03 = null, 
			string m3_FM04 = null, 
			string m3_FM05 = null, 
			string m3_FM06 = null, 
			string m3_FM07 = null, 
			string m3_FM08 = null, 
			string m3_FM09 = null, 
			string m3_FM10 = null, 
			string m3_FM11 = null, 
			string m3_FM12 = null, 
			string m3_FM13 = null, 
			string m3_FM14 = null, 
			string m3_FM15 = null, 
			string m3_FM16 = null, 
			string m3_FM17 = null, 
			string m3_FM18 = null, 
			string m3_FM19 = null, 
			string m3_FM20 = null, 
			int? m3_SEA2 = null, 
			int? m3_PNYN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STYN))
				throw new ArgumentNullException("m3_STYN");
			if (string.IsNullOrWhiteSpace(m3_STAT))
				throw new ArgumentNullException("m3_STAT");

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3_STYN.Trim())
				.WithQueryParameter("STAT", m3_STAT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_SECH.HasValue)
				request.WithQueryParameter("SECH", m3_SECH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FM01))
				request.WithQueryParameter("FM01", m3_FM01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM02))
				request.WithQueryParameter("FM02", m3_FM02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM03))
				request.WithQueryParameter("FM03", m3_FM03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM04))
				request.WithQueryParameter("FM04", m3_FM04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM05))
				request.WithQueryParameter("FM05", m3_FM05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM06))
				request.WithQueryParameter("FM06", m3_FM06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM07))
				request.WithQueryParameter("FM07", m3_FM07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM08))
				request.WithQueryParameter("FM08", m3_FM08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM09))
				request.WithQueryParameter("FM09", m3_FM09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM10))
				request.WithQueryParameter("FM10", m3_FM10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM11))
				request.WithQueryParameter("FM11", m3_FM11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM12))
				request.WithQueryParameter("FM12", m3_FM12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM13))
				request.WithQueryParameter("FM13", m3_FM13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM14))
				request.WithQueryParameter("FM14", m3_FM14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM15))
				request.WithQueryParameter("FM15", m3_FM15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM16))
				request.WithQueryParameter("FM16", m3_FM16.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM17))
				request.WithQueryParameter("FM17", m3_FM17.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM18))
				request.WithQueryParameter("FM18", m3_FM18.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM19))
				request.WithQueryParameter("FM19", m3_FM19.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM20))
				request.WithQueryParameter("FM20", m3_FM20.Trim());
			if (m3_SEA2.HasValue)
				request.WithQueryParameter("SEA2", m3_SEA2.Value.ToString());
			if (m3_PNYN.HasValue)
				request.WithQueryParameter("PNYN", m3_PNYN.Value.ToString());

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
		/// Name Copy
		/// Description Copy Style Information
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_STYN">Style number (Required)</param>
		/// <param name="m3_STYT">Style number target (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_SECH">Season check</param>
		/// <param name="m3_FM01">User-defined field heading 1</param>
		/// <param name="m3_FM02">User-defined field heading 2</param>
		/// <param name="m3_FM03">User-defined field heading 3</param>
		/// <param name="m3_FM04">User-defined field heading 4</param>
		/// <param name="m3_FM05">User-defined field heading 5</param>
		/// <param name="m3_FM06">User-defined field heading 6</param>
		/// <param name="m3_FM07">User-defined field heading 7</param>
		/// <param name="m3_FM08">User-defined field heading 8</param>
		/// <param name="m3_FM09">User-defined field heading 9</param>
		/// <param name="m3_FM10">User-defined field heading 10</param>
		/// <param name="m3_FM11">User-defined field heading 11</param>
		/// <param name="m3_FM12">User-defined field heading 12</param>
		/// <param name="m3_FM13">User-defined field heading 13</param>
		/// <param name="m3_FM14">User-defined field heading 14</param>
		/// <param name="m3_FM15">User-defined field heading 15</param>
		/// <param name="m3_FM16">User-defined field heading 16</param>
		/// <param name="m3_FM17">User-defined field heading 17</param>
		/// <param name="m3_FM18">User-defined field heading 18</param>
		/// <param name="m3_FM19">User-defined field heading 19</param>
		/// <param name="m3_FM20">User-defined field heading 20</param>
		/// <param name="m3_SEA2">Season selection</param>
		/// <param name="m3_PNYN">Classification per season</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Copy(
			string m3_STYN, 
			string m3_STYT, 
			int? m3_CONO = null, 
			string m3_STAT = null, 
			int? m3_SECH = null, 
			string m3_FM01 = null, 
			string m3_FM02 = null, 
			string m3_FM03 = null, 
			string m3_FM04 = null, 
			string m3_FM05 = null, 
			string m3_FM06 = null, 
			string m3_FM07 = null, 
			string m3_FM08 = null, 
			string m3_FM09 = null, 
			string m3_FM10 = null, 
			string m3_FM11 = null, 
			string m3_FM12 = null, 
			string m3_FM13 = null, 
			string m3_FM14 = null, 
			string m3_FM15 = null, 
			string m3_FM16 = null, 
			string m3_FM17 = null, 
			string m3_FM18 = null, 
			string m3_FM19 = null, 
			string m3_FM20 = null, 
			int? m3_SEA2 = null, 
			int? m3_PNYN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Copy",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STYN))
				throw new ArgumentNullException("m3_STYN");
			if (string.IsNullOrWhiteSpace(m3_STYT))
				throw new ArgumentNullException("m3_STYT");

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3_STYN.Trim())
				.WithQueryParameter("STYT", m3_STYT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_SECH.HasValue)
				request.WithQueryParameter("SECH", m3_SECH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FM01))
				request.WithQueryParameter("FM01", m3_FM01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM02))
				request.WithQueryParameter("FM02", m3_FM02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM03))
				request.WithQueryParameter("FM03", m3_FM03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM04))
				request.WithQueryParameter("FM04", m3_FM04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM05))
				request.WithQueryParameter("FM05", m3_FM05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM06))
				request.WithQueryParameter("FM06", m3_FM06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM07))
				request.WithQueryParameter("FM07", m3_FM07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM08))
				request.WithQueryParameter("FM08", m3_FM08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM09))
				request.WithQueryParameter("FM09", m3_FM09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM10))
				request.WithQueryParameter("FM10", m3_FM10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM11))
				request.WithQueryParameter("FM11", m3_FM11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM12))
				request.WithQueryParameter("FM12", m3_FM12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM13))
				request.WithQueryParameter("FM13", m3_FM13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM14))
				request.WithQueryParameter("FM14", m3_FM14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM15))
				request.WithQueryParameter("FM15", m3_FM15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM16))
				request.WithQueryParameter("FM16", m3_FM16.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM17))
				request.WithQueryParameter("FM17", m3_FM17.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM18))
				request.WithQueryParameter("FM18", m3_FM18.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM19))
				request.WithQueryParameter("FM19", m3_FM19.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM20))
				request.WithQueryParameter("FM20", m3_FM20.Trim());
			if (m3_SEA2.HasValue)
				request.WithQueryParameter("SEA2", m3_SEA2.Value.ToString());
			if (m3_PNYN.HasValue)
				request.WithQueryParameter("PNYN", m3_PNYN.Value.ToString());

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
		/// Name Delete
		/// Description Delete Style Information
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_STYN">Style number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3_STYN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Delete",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STYN))
				throw new ArgumentNullException("m3_STYN");

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3_STYN.Trim());

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
		/// Name Get
		/// Description Retrieve Style Info
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_STYN">Style number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_STYN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STYN))
				throw new ArgumentNullException("m3_STYN");

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3_STYN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name List
		/// Description Retrieve Style Info
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STYN">Style number</param>
		/// <param name="m3_STOP">Stop trans when error</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			int? m3_CONO = null, 
			string m3_STYN = null, 
			int? m3_STOP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/List",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STYN))
				request.WithQueryParameter("STYN", m3_STYN.Trim());
			if (m3_STOP.HasValue)
				request.WithQueryParameter("STOP", m3_STOP.Value.ToString());

			// Execute the request
			var result = await Execute<ListResponse>(
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
		/// Name Update
		/// Description Update Style Information
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_STYN">Style number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_SECH">Season check</param>
		/// <param name="m3_FM01">User-defined field heading 1</param>
		/// <param name="m3_FM02">User-defined field heading 2</param>
		/// <param name="m3_FM03">User-defined field heading 3</param>
		/// <param name="m3_FM04">User-defined field heading 4</param>
		/// <param name="m3_FM05">User-defined field heading 5</param>
		/// <param name="m3_FM06">User-defined field heading 6</param>
		/// <param name="m3_FM07">User-defined field heading 7</param>
		/// <param name="m3_FM08">User-defined field heading 8</param>
		/// <param name="m3_FM09">User-defined field heading 9</param>
		/// <param name="m3_FM10">User-defined field heading 10</param>
		/// <param name="m3_FM11">User-defined field heading 11</param>
		/// <param name="m3_FM12">User-defined field heading 12</param>
		/// <param name="m3_FM13">User-defined field heading 13</param>
		/// <param name="m3_FM14">User-defined field heading 14</param>
		/// <param name="m3_FM15">User-defined field heading 15</param>
		/// <param name="m3_FM16">User-defined field heading 16</param>
		/// <param name="m3_FM17">User-defined field heading 17</param>
		/// <param name="m3_FM18">User-defined field heading 18</param>
		/// <param name="m3_FM19">User-defined field heading 19</param>
		/// <param name="m3_FM20">User-defined field heading 20</param>
		/// <param name="m3_SEA2">Season selection</param>
		/// <param name="m3_PNYN">Classification per season</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Update(
			string m3_STYN, 
			int? m3_CONO = null, 
			string m3_STAT = null, 
			int? m3_SECH = null, 
			string m3_FM01 = null, 
			string m3_FM02 = null, 
			string m3_FM03 = null, 
			string m3_FM04 = null, 
			string m3_FM05 = null, 
			string m3_FM06 = null, 
			string m3_FM07 = null, 
			string m3_FM08 = null, 
			string m3_FM09 = null, 
			string m3_FM10 = null, 
			string m3_FM11 = null, 
			string m3_FM12 = null, 
			string m3_FM13 = null, 
			string m3_FM14 = null, 
			string m3_FM15 = null, 
			string m3_FM16 = null, 
			string m3_FM17 = null, 
			string m3_FM18 = null, 
			string m3_FM19 = null, 
			string m3_FM20 = null, 
			int? m3_SEA2 = null, 
			int? m3_PNYN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Update",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STYN))
				throw new ArgumentNullException("m3_STYN");

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3_STYN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_SECH.HasValue)
				request.WithQueryParameter("SECH", m3_SECH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FM01))
				request.WithQueryParameter("FM01", m3_FM01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM02))
				request.WithQueryParameter("FM02", m3_FM02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM03))
				request.WithQueryParameter("FM03", m3_FM03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM04))
				request.WithQueryParameter("FM04", m3_FM04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM05))
				request.WithQueryParameter("FM05", m3_FM05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM06))
				request.WithQueryParameter("FM06", m3_FM06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM07))
				request.WithQueryParameter("FM07", m3_FM07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM08))
				request.WithQueryParameter("FM08", m3_FM08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM09))
				request.WithQueryParameter("FM09", m3_FM09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM10))
				request.WithQueryParameter("FM10", m3_FM10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM11))
				request.WithQueryParameter("FM11", m3_FM11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM12))
				request.WithQueryParameter("FM12", m3_FM12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM13))
				request.WithQueryParameter("FM13", m3_FM13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM14))
				request.WithQueryParameter("FM14", m3_FM14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM15))
				request.WithQueryParameter("FM15", m3_FM15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM16))
				request.WithQueryParameter("FM16", m3_FM16.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM17))
				request.WithQueryParameter("FM17", m3_FM17.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM18))
				request.WithQueryParameter("FM18", m3_FM18.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM19))
				request.WithQueryParameter("FM19", m3_FM19.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FM20))
				request.WithQueryParameter("FM20", m3_FM20.Trim());
			if (m3_SEA2.HasValue)
				request.WithQueryParameter("SEA2", m3_SEA2.Value.ToString());
			if (m3_PNYN.HasValue)
				request.WithQueryParameter("PNYN", m3_PNYN.Value.ToString());

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
