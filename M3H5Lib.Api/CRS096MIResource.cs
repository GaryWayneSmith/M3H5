/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS096MI;
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
	/// Name: CRS096MI
	/// Component Name: Milestone
	/// Description: Milestone Chain interface
	/// Version Release: 14.x
	///</summary>
	public partial class CRS096MIResource : M3BaseResourceEndpoint
	{
		public CRS096MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS096MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddMilestnLine
		/// Description Adds line to Milestone chain
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSTN">Milestone chain (Required)</param>
		/// <param name="m3_MIID">Milestone identity (Required)</param>
		/// <param name="m3_LINO">Line number</param>
		/// <param name="m3_MIPD">Milestone planned date</param>
		/// <param name="m3_MIF1">Forecast date- First</param>
		/// <param name="m3_MIFL">Forecast date- Last</param>
		/// <param name="m3_MIA1">Actual date- First</param>
		/// <param name="m3_MIAD">Actual date- Last</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_SNDM">Send application message</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddMilestnLine(
			long m3_MSTN, 
			string m3_MIID, 
			int? m3_LINO = null, 
			DateTime? m3_MIPD = null, 
			DateTime? m3_MIF1 = null, 
			DateTime? m3_MIFL = null, 
			DateTime? m3_MIA1 = null, 
			DateTime? m3_MIAD = null, 
			string m3_RESP = null, 
			int? m3_SNDM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddMilestnLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MIID))
				throw new ArgumentNullException("m3_MIID");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSTN", m3_MSTN.ToString())
				.WithQueryParameter("MIID", m3_MIID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_LINO.HasValue)
				request.WithQueryParameter("LINO", m3_LINO.Value.ToString());
			if (m3_MIPD.HasValue)
				request.WithQueryParameter("MIPD", m3_MIPD.Value.ToM3String());
			if (m3_MIF1.HasValue)
				request.WithQueryParameter("MIF1", m3_MIF1.Value.ToM3String());
			if (m3_MIFL.HasValue)
				request.WithQueryParameter("MIFL", m3_MIFL.Value.ToM3String());
			if (m3_MIA1.HasValue)
				request.WithQueryParameter("MIA1", m3_MIA1.Value.ToM3String());
			if (m3_MIAD.HasValue)
				request.WithQueryParameter("MIAD", m3_MIAD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_SNDM.HasValue)
				request.WithQueryParameter("SNDM", m3_SNDM.Value.ToString());

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
		/// Name AddMilestoneChn
		/// Description Adds Milestone Chain
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MICI">Milestone template (Required)</param>
		/// <param name="m3_PLDT">Planning date (Required)</param>
		/// <param name="m3_PLAN">Planning type (Required)</param>
		/// <param name="m3_MSTN">Milestone chain</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddMilestoneChn(
			string m3_MICI, 
			DateTime m3_PLDT, 
			string m3_PLAN, 
			long? m3_MSTN = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_RESP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddMilestoneChn",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MICI))
				throw new ArgumentNullException("m3_MICI");
			if (string.IsNullOrWhiteSpace(m3_PLAN))
				throw new ArgumentNullException("m3_PLAN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MICI", m3_MICI.Trim())
				.WithQueryParameter("PLDT", m3_PLDT.ToM3String())
				.WithQueryParameter("PLAN", m3_PLAN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_MSTN.HasValue)
				request.WithQueryParameter("MSTN", m3_MSTN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());

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
		/// Name DelMilestoneChn
		/// Description Deletes Milestone Chain
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSTN">Milestone chain (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelMilestoneChn(
			long m3_MSTN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelMilestoneChn",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MSTN", m3_MSTN.ToString());

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
		/// Name DelMilestoneLn
		/// Description Deletes Milestone Chain line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSTN">Milestone chain (Required)</param>
		/// <param name="m3_LINO">Line number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelMilestoneLn(
			long m3_MSTN, 
			int? m3_LINO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelMilestoneLn",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MSTN", m3_MSTN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_LINO.HasValue)
				request.WithQueryParameter("LINO", m3_LINO.Value.ToString());

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
		/// Name GetMilestoneChn
		/// Description Gets Milestone Chain detail
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSTN">Milestone chain (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMilestoneChnResponse></returns>
		/// <exception cref="M3Exception<GetMilestoneChnResponse>"></exception>
		public async Task<M3Response<GetMilestoneChnResponse>> GetMilestoneChn(
			long m3_MSTN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMilestoneChn",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MSTN", m3_MSTN.ToString());

			// Execute the request
			var result = await Execute<GetMilestoneChnResponse>(
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
		/// Name GetMilestoneLn
		/// Description Displays Milestone chain line detail
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSTN">Milestone chain (Required)</param>
		/// <param name="m3_LINO">Line number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMilestoneLnResponse></returns>
		/// <exception cref="M3Exception<GetMilestoneLnResponse>"></exception>
		public async Task<M3Response<GetMilestoneLnResponse>> GetMilestoneLn(
			long m3_MSTN, 
			int? m3_LINO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMilestoneLn",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MSTN", m3_MSTN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_LINO.HasValue)
				request.WithQueryParameter("LINO", m3_LINO.Value.ToString());

			// Execute the request
			var result = await Execute<GetMilestoneLnResponse>(
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
		/// Name LstMilestoneChn
		/// Description Lists Milestone
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSTN">Milestone chain</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMilestoneChnResponse></returns>
		/// <exception cref="M3Exception<LstMilestoneChnResponse>"></exception>
		public async Task<M3Response<LstMilestoneChnResponse>> LstMilestoneChn(
			long? m3_MSTN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMilestoneChn",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_MSTN.HasValue)
				request.WithQueryParameter("MSTN", m3_MSTN.Value.ToString());

			// Execute the request
			var result = await Execute<LstMilestoneChnResponse>(
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
		/// Name LstMilestoneLns
		/// Description Lists Milestone chain line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSTN">Milestone chain (Required)</param>
		/// <param name="m3_LINO">Line number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMilestoneLnsResponse></returns>
		/// <exception cref="M3Exception<LstMilestoneLnsResponse>"></exception>
		public async Task<M3Response<LstMilestoneLnsResponse>> LstMilestoneLns(
			long m3_MSTN, 
			int? m3_LINO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMilestoneLns",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MSTN", m3_MSTN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_LINO.HasValue)
				request.WithQueryParameter("LINO", m3_LINO.Value.ToString());

			// Execute the request
			var result = await Execute<LstMilestoneLnsResponse>(
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
		/// Name LstMlstnChnProj
		/// Description Lists Milestone chain on Project Number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_MSTN">Milestone chain</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMlstnChnProjResponse></returns>
		/// <exception cref="M3Exception<LstMlstnChnProjResponse>"></exception>
		public async Task<M3Response<LstMlstnChnProjResponse>> LstMlstnChnProj(
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			long? m3_MSTN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMlstnChnProj",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (m3_MSTN.HasValue)
				request.WithQueryParameter("MSTN", m3_MSTN.Value.ToString());

			// Execute the request
			var result = await Execute<LstMlstnChnProjResponse>(
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
		/// Name UpdMilestnLine
		/// Description Updates Milestone line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSTN">Milestone chain (Required)</param>
		/// <param name="m3_LINO">Line number</param>
		/// <param name="m3_ADAT">Adjust date</param>
		/// <param name="m3_MIID">Milestone identity</param>
		/// <param name="m3_MIPD">Milestone planned date</param>
		/// <param name="m3_MIF1">Forecast date- First</param>
		/// <param name="m3_MIFL">Forecast date- Last</param>
		/// <param name="m3_MIA1">Actual date-First</param>
		/// <param name="m3_MIAD">Actual date-First</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_SNDM">Send application message</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdMilestnLine(
			long m3_MSTN, 
			int? m3_LINO = null, 
			DateTime? m3_ADAT = null, 
			string m3_MIID = null, 
			DateTime? m3_MIPD = null, 
			DateTime? m3_MIF1 = null, 
			DateTime? m3_MIFL = null, 
			DateTime? m3_MIA1 = null, 
			DateTime? m3_MIAD = null, 
			string m3_RESP = null, 
			int? m3_SNDM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdMilestnLine",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MSTN", m3_MSTN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_LINO.HasValue)
				request.WithQueryParameter("LINO", m3_LINO.Value.ToString());
			if (m3_ADAT.HasValue)
				request.WithQueryParameter("ADAT", m3_ADAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_MIID))
				request.WithQueryParameter("MIID", m3_MIID.Trim());
			if (m3_MIPD.HasValue)
				request.WithQueryParameter("MIPD", m3_MIPD.Value.ToM3String());
			if (m3_MIF1.HasValue)
				request.WithQueryParameter("MIF1", m3_MIF1.Value.ToM3String());
			if (m3_MIFL.HasValue)
				request.WithQueryParameter("MIFL", m3_MIFL.Value.ToM3String());
			if (m3_MIA1.HasValue)
				request.WithQueryParameter("MIA1", m3_MIA1.Value.ToM3String());
			if (m3_MIAD.HasValue)
				request.WithQueryParameter("MIAD", m3_MIAD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (m3_SNDM.HasValue)
				request.WithQueryParameter("SNDM", m3_SNDM.Value.ToString());

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
		/// Name UpdMilestoneChn
		/// Description Updates Milestone Chain
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSTN">Milestone chain (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdMilestoneChn(
			long m3_MSTN, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_RESP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdMilestoneChn",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MSTN", m3_MSTN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());

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
