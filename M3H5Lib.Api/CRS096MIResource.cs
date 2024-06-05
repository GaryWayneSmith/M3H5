/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddMilestnLine
		/// Description Adds line to Milestone chain
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSTN">Milestone chain (Required)</param>
		/// <param name="m3MIID">Milestone identity (Required)</param>
		/// <param name="m3LINO">Line number</param>
		/// <param name="m3MIPD">Milestone planned date</param>
		/// <param name="m3MIF1">Forecast date- First</param>
		/// <param name="m3MIFL">Forecast date- Last</param>
		/// <param name="m3MIA1">Actual date- First</param>
		/// <param name="m3MIAD">Actual date- Last</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3SNDM">Send application message</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddMilestnLine(
			long m3MSTN, 
			string m3MIID, 
			int? m3LINO = null, 
			DateTime? m3MIPD = null, 
			DateTime? m3MIF1 = null, 
			DateTime? m3MIFL = null, 
			DateTime? m3MIA1 = null, 
			DateTime? m3MIAD = null, 
			string m3RESP = null, 
			int? m3SNDM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddMilestnLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MIID))
				throw new ArgumentNullException(nameof(m3MIID));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSTN", m3MSTN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("MIID", m3MIID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3LINO.HasValue)
				request.WithQueryParameter("LINO", m3LINO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MIPD.HasValue)
				request.WithQueryParameter("MIPD", m3MIPD.Value.ToM3String());
			if (m3MIF1.HasValue)
				request.WithQueryParameter("MIF1", m3MIF1.Value.ToM3String());
			if (m3MIFL.HasValue)
				request.WithQueryParameter("MIFL", m3MIFL.Value.ToM3String());
			if (m3MIA1.HasValue)
				request.WithQueryParameter("MIA1", m3MIA1.Value.ToM3String());
			if (m3MIAD.HasValue)
				request.WithQueryParameter("MIAD", m3MIAD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3SNDM.HasValue)
				request.WithQueryParameter("SNDM", m3SNDM.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddMilestoneChn
		/// Description Adds Milestone Chain
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MICI">Milestone template (Required)</param>
		/// <param name="m3PLDT">Planning date (Required)</param>
		/// <param name="m3PLAN">Planning type (Required)</param>
		/// <param name="m3MSTN">Milestone chain</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddMilestoneChn(
			string m3MICI, 
			DateTime m3PLDT, 
			string m3PLAN, 
			long? m3MSTN = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3RESP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddMilestoneChn",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MICI))
				throw new ArgumentNullException(nameof(m3MICI));
			if (string.IsNullOrWhiteSpace(m3PLAN))
				throw new ArgumentNullException(nameof(m3PLAN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MICI", m3MICI.Trim())
				.WithQueryParameter("PLDT", m3PLDT.ToM3String())
				.WithQueryParameter("PLAN", m3PLAN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3MSTN.HasValue)
				request.WithQueryParameter("MSTN", m3MSTN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());

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
		/// Name DelMilestoneChn
		/// Description Deletes Milestone Chain
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSTN">Milestone chain (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelMilestoneChn(
			long m3MSTN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelMilestoneChn",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MSTN", m3MSTN.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelMilestoneLn
		/// Description Deletes Milestone Chain line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSTN">Milestone chain (Required)</param>
		/// <param name="m3LINO">Line number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelMilestoneLn(
			long m3MSTN, 
			int? m3LINO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelMilestoneLn",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MSTN", m3MSTN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3LINO.HasValue)
				request.WithQueryParameter("LINO", m3LINO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetMilestoneChn
		/// Description Gets Milestone Chain detail
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSTN">Milestone chain (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMilestoneChnResponse></returns>
		/// <exception cref="M3Exception<GetMilestoneChnResponse>"></exception>
		public async Task<M3Response<GetMilestoneChnResponse>> GetMilestoneChn(
			long m3MSTN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetMilestoneChn",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MSTN", m3MSTN.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetMilestoneChnResponse>(
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
		/// Name GetMilestoneLn
		/// Description Displays Milestone chain line detail
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSTN">Milestone chain (Required)</param>
		/// <param name="m3LINO">Line number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMilestoneLnResponse></returns>
		/// <exception cref="M3Exception<GetMilestoneLnResponse>"></exception>
		public async Task<M3Response<GetMilestoneLnResponse>> GetMilestoneLn(
			long m3MSTN, 
			int? m3LINO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetMilestoneLn",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MSTN", m3MSTN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3LINO.HasValue)
				request.WithQueryParameter("LINO", m3LINO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetMilestoneLnResponse>(
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
		/// Name LstMilestoneChn
		/// Description Lists Milestone
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSTN">Milestone chain</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMilestoneChnResponse></returns>
		/// <exception cref="M3Exception<LstMilestoneChnResponse>"></exception>
		public async Task<M3Response<LstMilestoneChnResponse>> LstMilestoneChn(
			long? m3MSTN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMilestoneChn",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3MSTN.HasValue)
				request.WithQueryParameter("MSTN", m3MSTN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstMilestoneChnResponse>(
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
		/// Name LstMilestoneLns
		/// Description Lists Milestone chain line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSTN">Milestone chain (Required)</param>
		/// <param name="m3LINO">Line number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMilestoneLnsResponse></returns>
		/// <exception cref="M3Exception<LstMilestoneLnsResponse>"></exception>
		public async Task<M3Response<LstMilestoneLnsResponse>> LstMilestoneLns(
			long m3MSTN, 
			int? m3LINO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMilestoneLns",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MSTN", m3MSTN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3LINO.HasValue)
				request.WithQueryParameter("LINO", m3LINO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstMilestoneLnsResponse>(
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
		/// Name LstMlstnChnProj
		/// Description Lists Milestone chain on Project Number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3MSTN">Milestone chain</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMlstnChnProjResponse></returns>
		/// <exception cref="M3Exception<LstMlstnChnProjResponse>"></exception>
		public async Task<M3Response<LstMlstnChnProjResponse>> LstMlstnChnProj(
			string m3PROJ = null, 
			string m3ELNO = null, 
			long? m3MSTN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMlstnChnProj",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (m3MSTN.HasValue)
				request.WithQueryParameter("MSTN", m3MSTN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstMlstnChnProjResponse>(
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
		/// Name UpdMilestnLine
		/// Description Updates Milestone line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSTN">Milestone chain (Required)</param>
		/// <param name="m3LINO">Line number</param>
		/// <param name="m3ADAT">Adjust date</param>
		/// <param name="m3MIID">Milestone identity</param>
		/// <param name="m3MIPD">Milestone planned date</param>
		/// <param name="m3MIF1">Forecast date- First</param>
		/// <param name="m3MIFL">Forecast date- Last</param>
		/// <param name="m3MIA1">Actual date-First</param>
		/// <param name="m3MIAD">Actual date-First</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3SNDM">Send application message</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdMilestnLine(
			long m3MSTN, 
			int? m3LINO = null, 
			DateTime? m3ADAT = null, 
			string m3MIID = null, 
			DateTime? m3MIPD = null, 
			DateTime? m3MIF1 = null, 
			DateTime? m3MIFL = null, 
			DateTime? m3MIA1 = null, 
			DateTime? m3MIAD = null, 
			string m3RESP = null, 
			int? m3SNDM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdMilestnLine",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MSTN", m3MSTN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3LINO.HasValue)
				request.WithQueryParameter("LINO", m3LINO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADAT.HasValue)
				request.WithQueryParameter("ADAT", m3ADAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3MIID))
				request.WithQueryParameter("MIID", m3MIID.Trim());
			if (m3MIPD.HasValue)
				request.WithQueryParameter("MIPD", m3MIPD.Value.ToM3String());
			if (m3MIF1.HasValue)
				request.WithQueryParameter("MIF1", m3MIF1.Value.ToM3String());
			if (m3MIFL.HasValue)
				request.WithQueryParameter("MIFL", m3MIFL.Value.ToM3String());
			if (m3MIA1.HasValue)
				request.WithQueryParameter("MIA1", m3MIA1.Value.ToM3String());
			if (m3MIAD.HasValue)
				request.WithQueryParameter("MIAD", m3MIAD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (m3SNDM.HasValue)
				request.WithQueryParameter("SNDM", m3SNDM.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdMilestoneChn
		/// Description Updates Milestone Chain
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSTN">Milestone chain (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdMilestoneChn(
			long m3MSTN, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3RESP = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdMilestoneChn",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("MSTN", m3MSTN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());

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
