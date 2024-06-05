/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.POS211MI;
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
	/// Name: POS211MI
	/// Component Name: ProjectTimePlanning
	/// Description: Project order time planning interface
	/// Version Release: 11.1
	///</summary>
	public partial class POS211MIResource : M3BaseResourceEndpoint
	{
		public POS211MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "POS211MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name CheckIn
		/// Description Check out time planning version
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PROJ">Project (Required)</param>
		/// <param name="m3_DTUM">Date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CheckIn(
			string m3_DIVI, 
			string m3_PROJ, 
			DateTime m3_DTUM, 
			int? m3_CONO = null, 
			int? m3_VERS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CheckIn",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PROJ))
				throw new ArgumentNullException("m3_PROJ");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PROJ", m3_PROJ.Trim())
				.WithQueryParameter("DTUM", m3_DTUM.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());

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
		/// Name CheckOut
		/// Description Check out time planning version
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PROJ">Project (Required)</param>
		/// <param name="m3_DTUM">Date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CheckOut(
			string m3_DIVI, 
			string m3_PROJ, 
			DateTime m3_DTUM, 
			int? m3_CONO = null, 
			int? m3_VERS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CheckOut",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PROJ))
				throw new ArgumentNullException("m3_PROJ");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PROJ", m3_PROJ.Trim())
				.WithQueryParameter("DTUM", m3_DTUM.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());

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
		/// Name ChgBasicData
		/// Description Modify time planning basic data
		/// Version Release: 11.5
		/// </summary>
		/// <param name="m3_PROJ">Project number (Required)</param>
		/// <param name="m3_DTUM">Date (Required)</param>
		/// <param name="m3_ELNO">Project element (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="m3_ORSD">Original start date</param>
		/// <param name="m3_PLSD">Planned start date</param>
		/// <param name="m3_ORFD">Original finish date</param>
		/// <param name="m3_PLFD">Planned finish date</param>
		/// <param name="m3_RELS">Relative days start</param>
		/// <param name="m3_RELF">Relative days finish</param>
		/// <param name="m3_FIXD">Fixed date</param>
		/// <param name="m3_PLDA">Planned days</param>
		/// <param name="m3_PLHO">Planned hours</param>
		/// <param name="m3_RLTS">Relative time setting</param>
		/// <param name="m3_OPRI">Priority</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChgBasicDataResponse></returns>
		/// <exception cref="M3Exception<ChgBasicDataResponse>"></exception>
		public async Task<M3Response<ChgBasicDataResponse>> ChgBasicData(
			string m3_PROJ, 
			DateTime m3_DTUM, 
			string m3_ELNO, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_VERS = null, 
			DateTime? m3_ORSD = null, 
			int? m3_PLSD = null, 
			DateTime? m3_ORFD = null, 
			DateTime? m3_PLFD = null, 
			int? m3_RELS = null, 
			int? m3_RELF = null, 
			int? m3_FIXD = null, 
			int? m3_PLDA = null, 
			decimal? m3_PLHO = null, 
			int? m3_RLTS = null, 
			int? m3_OPRI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PROJ))
				throw new ArgumentNullException("m3_PROJ");
			if (string.IsNullOrWhiteSpace(m3_ELNO))
				throw new ArgumentNullException("m3_ELNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PROJ", m3_PROJ.Trim())
				.WithQueryParameter("DTUM", m3_DTUM.ToM3String())
				.WithQueryParameter("ELNO", m3_ELNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());
			if (m3_ORSD.HasValue)
				request.WithQueryParameter("ORSD", m3_ORSD.Value.ToM3String());
			if (m3_PLSD.HasValue)
				request.WithQueryParameter("PLSD", m3_PLSD.Value.ToString());
			if (m3_ORFD.HasValue)
				request.WithQueryParameter("ORFD", m3_ORFD.Value.ToM3String());
			if (m3_PLFD.HasValue)
				request.WithQueryParameter("PLFD", m3_PLFD.Value.ToM3String());
			if (m3_RELS.HasValue)
				request.WithQueryParameter("RELS", m3_RELS.Value.ToString());
			if (m3_RELF.HasValue)
				request.WithQueryParameter("RELF", m3_RELF.Value.ToString());
			if (m3_FIXD.HasValue)
				request.WithQueryParameter("FIXD", m3_FIXD.Value.ToString());
			if (m3_PLDA.HasValue)
				request.WithQueryParameter("PLDA", m3_PLDA.Value.ToString());
			if (m3_PLHO.HasValue)
				request.WithQueryParameter("PLHO", m3_PLHO.Value.ToString());
			if (m3_RLTS.HasValue)
				request.WithQueryParameter("RLTS", m3_RLTS.Value.ToString());
			if (m3_OPRI.HasValue)
				request.WithQueryParameter("OPRI", m3_OPRI.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

			// Execute the request
			var result = await Execute<ChgBasicDataResponse>(
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
		/// Name ChgConnection1
		/// Description Update element connections
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PROJ">Project (Required)</param>
		/// <param name="m3_DTUM">Date (Required)</param>
		/// <param name="m3_ELNO">Project element (Required)</param>
		/// <param name="m3_CONE">Connected project element (Required)</param>
		/// <param name="m3_COTE">Controlling project element (Required)</param>
		/// <param name="m3_WTCO">Connection type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="m3_TMSL">Time slack</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgConnection1(
			string m3_DIVI, 
			string m3_PROJ, 
			DateTime m3_DTUM, 
			string m3_ELNO, 
			string m3_CONE, 
			string m3_COTE, 
			string m3_WTCO, 
			int? m3_CONO = null, 
			int? m3_VERS = null, 
			int? m3_TMSL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgConnection1",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PROJ))
				throw new ArgumentNullException("m3_PROJ");
			if (string.IsNullOrWhiteSpace(m3_ELNO))
				throw new ArgumentNullException("m3_ELNO");
			if (string.IsNullOrWhiteSpace(m3_CONE))
				throw new ArgumentNullException("m3_CONE");
			if (string.IsNullOrWhiteSpace(m3_COTE))
				throw new ArgumentNullException("m3_COTE");
			if (string.IsNullOrWhiteSpace(m3_WTCO))
				throw new ArgumentNullException("m3_WTCO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PROJ", m3_PROJ.Trim())
				.WithQueryParameter("DTUM", m3_DTUM.ToM3String())
				.WithQueryParameter("ELNO", m3_ELNO.Trim())
				.WithQueryParameter("CONE", m3_CONE.Trim())
				.WithQueryParameter("COTE", m3_COTE.Trim())
				.WithQueryParameter("WTCO", m3_WTCO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());
			if (m3_TMSL.HasValue)
				request.WithQueryParameter("TMSL", m3_TMSL.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
		/// Name DltConnection1
		/// Description Delete element connections
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PROJ">Project (Required)</param>
		/// <param name="m3_DTUM">Date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltConnection1(
			string m3_DIVI, 
			string m3_PROJ, 
			DateTime m3_DTUM, 
			int? m3_CONO = null, 
			int? m3_VERS = null, 
			string m3_ELNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltConnection1",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PROJ))
				throw new ArgumentNullException("m3_PROJ");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PROJ", m3_PROJ.Trim())
				.WithQueryParameter("DTUM", m3_DTUM.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());

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
		/// Name GetBasicData
		/// Description Retrieve time planning basic data
		/// Version Release: 11.1
		/// </summary>
		/// <param name="m3_PROJ">Project number (Required)</param>
		/// <param name="m3_DTUM">Date (Required)</param>
		/// <param name="m3_ELNO">Project element (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicDataResponse></returns>
		/// <exception cref="M3Exception<GetBasicDataResponse>"></exception>
		public async Task<M3Response<GetBasicDataResponse>> GetBasicData(
			string m3_PROJ, 
			DateTime m3_DTUM, 
			string m3_ELNO, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_VERS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PROJ))
				throw new ArgumentNullException("m3_PROJ");
			if (string.IsNullOrWhiteSpace(m3_ELNO))
				throw new ArgumentNullException("m3_ELNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PROJ", m3_PROJ.Trim())
				.WithQueryParameter("DTUM", m3_DTUM.ToM3String())
				.WithQueryParameter("ELNO", m3_ELNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());

			// Execute the request
			var result = await Execute<GetBasicDataResponse>(
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
		/// Name Lock
		/// Description Lock time schedule
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PROJ">Project (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_DTUM">Date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Lock(
			string m3_DIVI, 
			string m3_PROJ, 
			int m3_VERS, 
			DateTime m3_DTUM, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Lock",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PROJ))
				throw new ArgumentNullException("m3_PROJ");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PROJ", m3_PROJ.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString())
				.WithQueryParameter("DTUM", m3_DTUM.ToM3String());

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
		/// Name LstConnection1
		/// Description List connections per connected element
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PROJ">Project number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_DTUM">Date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CONE">Connected project element</param>
		/// <param name="m3_COTE">Controlling project element</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_KLEN">Key length</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstConnection1Response></returns>
		/// <exception cref="M3Exception<LstConnection1Response>"></exception>
		public async Task<M3Response<LstConnection1Response>> LstConnection1(
			string m3_DIVI, 
			string m3_PROJ, 
			int m3_VERS, 
			DateTime m3_DTUM, 
			int? m3_CONO = null, 
			string m3_CONE = null, 
			string m3_COTE = null, 
			string m3_ELNO = null, 
			string m3_KLEN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstConnection1",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PROJ))
				throw new ArgumentNullException("m3_PROJ");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PROJ", m3_PROJ.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString())
				.WithQueryParameter("DTUM", m3_DTUM.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CONE))
				request.WithQueryParameter("CONE", m3_CONE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COTE))
				request.WithQueryParameter("COTE", m3_COTE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KLEN))
				request.WithQueryParameter("KLEN", m3_KLEN.Trim());

			// Execute the request
			var result = await Execute<LstConnection1Response>(
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
		/// Name LstHead
		/// Description List time planning head
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PROJ">Project number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DTUM">Date</param>
		/// <param name="m3_KLEN">Key length</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadResponse></returns>
		/// <exception cref="M3Exception<LstHeadResponse>"></exception>
		public async Task<M3Response<LstHeadResponse>> LstHead(
			string m3_DIVI, 
			string m3_PROJ, 
			int m3_VERS, 
			int? m3_CONO = null, 
			DateTime? m3_DTUM = null, 
			string m3_KLEN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PROJ))
				throw new ArgumentNullException("m3_PROJ");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PROJ", m3_PROJ.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_DTUM.HasValue)
				request.WithQueryParameter("DTUM", m3_DTUM.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_KLEN))
				request.WithQueryParameter("KLEN", m3_KLEN.Trim());

			// Execute the request
			var result = await Execute<LstHeadResponse>(
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
		/// Name LstLine
		/// Description List time planning line
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PROJ">Project number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DTUM">Date</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_KLEN">Key length</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineResponse></returns>
		/// <exception cref="M3Exception<LstLineResponse>"></exception>
		public async Task<M3Response<LstLineResponse>> LstLine(
			string m3_DIVI, 
			string m3_PROJ, 
			int m3_VERS, 
			int? m3_CONO = null, 
			DateTime? m3_DTUM = null, 
			string m3_ELNO = null, 
			string m3_KLEN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PROJ))
				throw new ArgumentNullException("m3_PROJ");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PROJ", m3_PROJ.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_DTUM.HasValue)
				request.WithQueryParameter("DTUM", m3_DTUM.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_KLEN))
				request.WithQueryParameter("KLEN", m3_KLEN.Trim());

			// Execute the request
			var result = await Execute<LstLineResponse>(
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
		/// Name Regenerate
		/// Description Regenerate dates upwards in the time schedule.
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PROJ">Project (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_DTUM">Date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Regenerate(
			string m3_DIVI, 
			string m3_PROJ, 
			int m3_VERS, 
			DateTime m3_DTUM, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Regenerate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PROJ))
				throw new ArgumentNullException("m3_PROJ");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PROJ", m3_PROJ.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString())
				.WithQueryParameter("DTUM", m3_DTUM.ToM3String());

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
	}
}
// EOF
