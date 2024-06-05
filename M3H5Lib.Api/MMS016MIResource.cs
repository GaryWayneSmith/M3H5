/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add Style Information
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3STYN">Style number (Required)</param>
		/// <param name="m3STAT">Status (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SECH">Season check</param>
		/// <param name="m3FM01">User-defined field heading 1</param>
		/// <param name="m3FM02">User-defined field heading 2</param>
		/// <param name="m3FM03">User-defined field heading 3</param>
		/// <param name="m3FM04">User-defined field heading 4</param>
		/// <param name="m3FM05">User-defined field heading 5</param>
		/// <param name="m3FM06">User-defined field heading 6</param>
		/// <param name="m3FM07">User-defined field heading 7</param>
		/// <param name="m3FM08">User-defined field heading 8</param>
		/// <param name="m3FM09">User-defined field heading 9</param>
		/// <param name="m3FM10">User-defined field heading 10</param>
		/// <param name="m3FM11">User-defined field heading 11</param>
		/// <param name="m3FM12">User-defined field heading 12</param>
		/// <param name="m3FM13">User-defined field heading 13</param>
		/// <param name="m3FM14">User-defined field heading 14</param>
		/// <param name="m3FM15">User-defined field heading 15</param>
		/// <param name="m3FM16">User-defined field heading 16</param>
		/// <param name="m3FM17">User-defined field heading 17</param>
		/// <param name="m3FM18">User-defined field heading 18</param>
		/// <param name="m3FM19">User-defined field heading 19</param>
		/// <param name="m3FM20">User-defined field heading 20</param>
		/// <param name="m3SEA2">Season selection</param>
		/// <param name="m3PNYN">Classification per season</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3STYN, 
			string m3STAT, 
			int? m3CONO = null, 
			int? m3SECH = null, 
			string m3FM01 = null, 
			string m3FM02 = null, 
			string m3FM03 = null, 
			string m3FM04 = null, 
			string m3FM05 = null, 
			string m3FM06 = null, 
			string m3FM07 = null, 
			string m3FM08 = null, 
			string m3FM09 = null, 
			string m3FM10 = null, 
			string m3FM11 = null, 
			string m3FM12 = null, 
			string m3FM13 = null, 
			string m3FM14 = null, 
			string m3FM15 = null, 
			string m3FM16 = null, 
			string m3FM17 = null, 
			string m3FM18 = null, 
			string m3FM19 = null, 
			string m3FM20 = null, 
			int? m3SEA2 = null, 
			int? m3PNYN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STYN))
				throw new ArgumentNullException(nameof(m3STYN));
			if (string.IsNullOrWhiteSpace(m3STAT))
				throw new ArgumentNullException(nameof(m3STAT));

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3STYN.Trim())
				.WithQueryParameter("STAT", m3STAT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SECH.HasValue)
				request.WithQueryParameter("SECH", m3SECH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FM01))
				request.WithQueryParameter("FM01", m3FM01.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM02))
				request.WithQueryParameter("FM02", m3FM02.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM03))
				request.WithQueryParameter("FM03", m3FM03.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM04))
				request.WithQueryParameter("FM04", m3FM04.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM05))
				request.WithQueryParameter("FM05", m3FM05.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM06))
				request.WithQueryParameter("FM06", m3FM06.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM07))
				request.WithQueryParameter("FM07", m3FM07.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM08))
				request.WithQueryParameter("FM08", m3FM08.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM09))
				request.WithQueryParameter("FM09", m3FM09.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM10))
				request.WithQueryParameter("FM10", m3FM10.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM11))
				request.WithQueryParameter("FM11", m3FM11.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM12))
				request.WithQueryParameter("FM12", m3FM12.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM13))
				request.WithQueryParameter("FM13", m3FM13.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM14))
				request.WithQueryParameter("FM14", m3FM14.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM15))
				request.WithQueryParameter("FM15", m3FM15.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM16))
				request.WithQueryParameter("FM16", m3FM16.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM17))
				request.WithQueryParameter("FM17", m3FM17.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM18))
				request.WithQueryParameter("FM18", m3FM18.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM19))
				request.WithQueryParameter("FM19", m3FM19.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM20))
				request.WithQueryParameter("FM20", m3FM20.Trim());
			if (m3SEA2.HasValue)
				request.WithQueryParameter("SEA2", m3SEA2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNYN.HasValue)
				request.WithQueryParameter("PNYN", m3PNYN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Copy
		/// Description Copy Style Information
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3STYN">Style number (Required)</param>
		/// <param name="m3STYT">Style number target (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3SECH">Season check</param>
		/// <param name="m3FM01">User-defined field heading 1</param>
		/// <param name="m3FM02">User-defined field heading 2</param>
		/// <param name="m3FM03">User-defined field heading 3</param>
		/// <param name="m3FM04">User-defined field heading 4</param>
		/// <param name="m3FM05">User-defined field heading 5</param>
		/// <param name="m3FM06">User-defined field heading 6</param>
		/// <param name="m3FM07">User-defined field heading 7</param>
		/// <param name="m3FM08">User-defined field heading 8</param>
		/// <param name="m3FM09">User-defined field heading 9</param>
		/// <param name="m3FM10">User-defined field heading 10</param>
		/// <param name="m3FM11">User-defined field heading 11</param>
		/// <param name="m3FM12">User-defined field heading 12</param>
		/// <param name="m3FM13">User-defined field heading 13</param>
		/// <param name="m3FM14">User-defined field heading 14</param>
		/// <param name="m3FM15">User-defined field heading 15</param>
		/// <param name="m3FM16">User-defined field heading 16</param>
		/// <param name="m3FM17">User-defined field heading 17</param>
		/// <param name="m3FM18">User-defined field heading 18</param>
		/// <param name="m3FM19">User-defined field heading 19</param>
		/// <param name="m3FM20">User-defined field heading 20</param>
		/// <param name="m3SEA2">Season selection</param>
		/// <param name="m3PNYN">Classification per season</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Copy(
			string m3STYN, 
			string m3STYT, 
			int? m3CONO = null, 
			string m3STAT = null, 
			int? m3SECH = null, 
			string m3FM01 = null, 
			string m3FM02 = null, 
			string m3FM03 = null, 
			string m3FM04 = null, 
			string m3FM05 = null, 
			string m3FM06 = null, 
			string m3FM07 = null, 
			string m3FM08 = null, 
			string m3FM09 = null, 
			string m3FM10 = null, 
			string m3FM11 = null, 
			string m3FM12 = null, 
			string m3FM13 = null, 
			string m3FM14 = null, 
			string m3FM15 = null, 
			string m3FM16 = null, 
			string m3FM17 = null, 
			string m3FM18 = null, 
			string m3FM19 = null, 
			string m3FM20 = null, 
			int? m3SEA2 = null, 
			int? m3PNYN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Copy",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STYN))
				throw new ArgumentNullException(nameof(m3STYN));
			if (string.IsNullOrWhiteSpace(m3STYT))
				throw new ArgumentNullException(nameof(m3STYT));

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3STYN.Trim())
				.WithQueryParameter("STYT", m3STYT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3SECH.HasValue)
				request.WithQueryParameter("SECH", m3SECH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FM01))
				request.WithQueryParameter("FM01", m3FM01.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM02))
				request.WithQueryParameter("FM02", m3FM02.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM03))
				request.WithQueryParameter("FM03", m3FM03.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM04))
				request.WithQueryParameter("FM04", m3FM04.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM05))
				request.WithQueryParameter("FM05", m3FM05.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM06))
				request.WithQueryParameter("FM06", m3FM06.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM07))
				request.WithQueryParameter("FM07", m3FM07.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM08))
				request.WithQueryParameter("FM08", m3FM08.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM09))
				request.WithQueryParameter("FM09", m3FM09.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM10))
				request.WithQueryParameter("FM10", m3FM10.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM11))
				request.WithQueryParameter("FM11", m3FM11.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM12))
				request.WithQueryParameter("FM12", m3FM12.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM13))
				request.WithQueryParameter("FM13", m3FM13.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM14))
				request.WithQueryParameter("FM14", m3FM14.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM15))
				request.WithQueryParameter("FM15", m3FM15.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM16))
				request.WithQueryParameter("FM16", m3FM16.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM17))
				request.WithQueryParameter("FM17", m3FM17.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM18))
				request.WithQueryParameter("FM18", m3FM18.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM19))
				request.WithQueryParameter("FM19", m3FM19.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM20))
				request.WithQueryParameter("FM20", m3FM20.Trim());
			if (m3SEA2.HasValue)
				request.WithQueryParameter("SEA2", m3SEA2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNYN.HasValue)
				request.WithQueryParameter("PNYN", m3PNYN.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Delete
		/// Description Delete Style Information
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3STYN">Style number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3STYN, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Delete",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STYN))
				throw new ArgumentNullException(nameof(m3STYN));

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3STYN.Trim());

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
		/// Name Get
		/// Description Retrieve Style Info
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3STYN">Style number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3STYN, 
			int? m3CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3STYN))
				throw new ArgumentNullException(nameof(m3STYN));

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3STYN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name List
		/// Description Retrieve Style Info
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STYN">Style number</param>
		/// <param name="m3STOP">Stop trans when error</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			int? m3CONO = null, 
			string m3STYN = null, 
			int? m3STOP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/List",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STYN))
				request.WithQueryParameter("STYN", m3STYN.Trim());
			if (m3STOP.HasValue)
				request.WithQueryParameter("STOP", m3STOP.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ListResponse>(
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
		/// Name Update
		/// Description Update Style Information
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3STYN">Style number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3SECH">Season check</param>
		/// <param name="m3FM01">User-defined field heading 1</param>
		/// <param name="m3FM02">User-defined field heading 2</param>
		/// <param name="m3FM03">User-defined field heading 3</param>
		/// <param name="m3FM04">User-defined field heading 4</param>
		/// <param name="m3FM05">User-defined field heading 5</param>
		/// <param name="m3FM06">User-defined field heading 6</param>
		/// <param name="m3FM07">User-defined field heading 7</param>
		/// <param name="m3FM08">User-defined field heading 8</param>
		/// <param name="m3FM09">User-defined field heading 9</param>
		/// <param name="m3FM10">User-defined field heading 10</param>
		/// <param name="m3FM11">User-defined field heading 11</param>
		/// <param name="m3FM12">User-defined field heading 12</param>
		/// <param name="m3FM13">User-defined field heading 13</param>
		/// <param name="m3FM14">User-defined field heading 14</param>
		/// <param name="m3FM15">User-defined field heading 15</param>
		/// <param name="m3FM16">User-defined field heading 16</param>
		/// <param name="m3FM17">User-defined field heading 17</param>
		/// <param name="m3FM18">User-defined field heading 18</param>
		/// <param name="m3FM19">User-defined field heading 19</param>
		/// <param name="m3FM20">User-defined field heading 20</param>
		/// <param name="m3SEA2">Season selection</param>
		/// <param name="m3PNYN">Classification per season</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Update(
			string m3STYN, 
			int? m3CONO = null, 
			string m3STAT = null, 
			int? m3SECH = null, 
			string m3FM01 = null, 
			string m3FM02 = null, 
			string m3FM03 = null, 
			string m3FM04 = null, 
			string m3FM05 = null, 
			string m3FM06 = null, 
			string m3FM07 = null, 
			string m3FM08 = null, 
			string m3FM09 = null, 
			string m3FM10 = null, 
			string m3FM11 = null, 
			string m3FM12 = null, 
			string m3FM13 = null, 
			string m3FM14 = null, 
			string m3FM15 = null, 
			string m3FM16 = null, 
			string m3FM17 = null, 
			string m3FM18 = null, 
			string m3FM19 = null, 
			string m3FM20 = null, 
			int? m3SEA2 = null, 
			int? m3PNYN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Update",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STYN))
				throw new ArgumentNullException(nameof(m3STYN));

			// Set mandatory parameters
			request
				.WithQueryParameter("STYN", m3STYN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3SECH.HasValue)
				request.WithQueryParameter("SECH", m3SECH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FM01))
				request.WithQueryParameter("FM01", m3FM01.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM02))
				request.WithQueryParameter("FM02", m3FM02.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM03))
				request.WithQueryParameter("FM03", m3FM03.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM04))
				request.WithQueryParameter("FM04", m3FM04.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM05))
				request.WithQueryParameter("FM05", m3FM05.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM06))
				request.WithQueryParameter("FM06", m3FM06.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM07))
				request.WithQueryParameter("FM07", m3FM07.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM08))
				request.WithQueryParameter("FM08", m3FM08.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM09))
				request.WithQueryParameter("FM09", m3FM09.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM10))
				request.WithQueryParameter("FM10", m3FM10.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM11))
				request.WithQueryParameter("FM11", m3FM11.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM12))
				request.WithQueryParameter("FM12", m3FM12.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM13))
				request.WithQueryParameter("FM13", m3FM13.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM14))
				request.WithQueryParameter("FM14", m3FM14.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM15))
				request.WithQueryParameter("FM15", m3FM15.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM16))
				request.WithQueryParameter("FM16", m3FM16.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM17))
				request.WithQueryParameter("FM17", m3FM17.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM18))
				request.WithQueryParameter("FM18", m3FM18.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM19))
				request.WithQueryParameter("FM19", m3FM19.Trim());
			if (!string.IsNullOrWhiteSpace(m3FM20))
				request.WithQueryParameter("FM20", m3FM20.Trim());
			if (m3SEA2.HasValue)
				request.WithQueryParameter("SEA2", m3SEA2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNYN.HasValue)
				request.WithQueryParameter("PNYN", m3PNYN.Value.ToString(CultureInfo.CurrentCulture));

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
