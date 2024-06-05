/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name CheckIn
		/// Description Check out time planning version
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PROJ">Project (Required)</param>
		/// <param name="m3DTUM">Date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CheckIn(
			string m3DIVI, 
			string m3PROJ, 
			DateTime m3DTUM, 
			int? m3CONO = null, 
			int? m3VERS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CheckIn",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PROJ))
				throw new ArgumentNullException(nameof(m3PROJ));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PROJ", m3PROJ.Trim())
				.WithQueryParameter("DTUM", m3DTUM.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name CheckOut
		/// Description Check out time planning version
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PROJ">Project (Required)</param>
		/// <param name="m3DTUM">Date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CheckOut(
			string m3DIVI, 
			string m3PROJ, 
			DateTime m3DTUM, 
			int? m3CONO = null, 
			int? m3VERS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CheckOut",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PROJ))
				throw new ArgumentNullException(nameof(m3PROJ));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PROJ", m3PROJ.Trim())
				.WithQueryParameter("DTUM", m3DTUM.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgBasicData
		/// Description Modify time planning basic data
		/// Version Release: 11.5
		/// </summary>
		/// <param name="m3PROJ">Project number (Required)</param>
		/// <param name="m3DTUM">Date (Required)</param>
		/// <param name="m3ELNO">Project element (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="m3ORSD">Original start date</param>
		/// <param name="m3PLSD">Planned start date</param>
		/// <param name="m3ORFD">Original finish date</param>
		/// <param name="m3PLFD">Planned finish date</param>
		/// <param name="m3RELS">Relative days start</param>
		/// <param name="m3RELF">Relative days finish</param>
		/// <param name="m3FIXD">Fixed date</param>
		/// <param name="m3PLDA">Planned days</param>
		/// <param name="m3PLHO">Planned hours</param>
		/// <param name="m3RLTS">Relative time setting</param>
		/// <param name="m3OPRI">Priority</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChgBasicDataResponse></returns>
		/// <exception cref="M3Exception<ChgBasicDataResponse>"></exception>
		public async Task<M3Response<ChgBasicDataResponse>> ChgBasicData(
			string m3PROJ, 
			DateTime m3DTUM, 
			string m3ELNO, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			int? m3VERS = null, 
			DateTime? m3ORSD = null, 
			int? m3PLSD = null, 
			DateTime? m3ORFD = null, 
			DateTime? m3PLFD = null, 
			int? m3RELS = null, 
			int? m3RELF = null, 
			int? m3FIXD = null, 
			int? m3PLDA = null, 
			decimal? m3PLHO = null, 
			int? m3RLTS = null, 
			int? m3OPRI = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PROJ))
				throw new ArgumentNullException(nameof(m3PROJ));
			if (string.IsNullOrWhiteSpace(m3ELNO))
				throw new ArgumentNullException(nameof(m3ELNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PROJ", m3PROJ.Trim())
				.WithQueryParameter("DTUM", m3DTUM.ToM3String())
				.WithQueryParameter("ELNO", m3ELNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORSD.HasValue)
				request.WithQueryParameter("ORSD", m3ORSD.Value.ToM3String());
			if (m3PLSD.HasValue)
				request.WithQueryParameter("PLSD", m3PLSD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORFD.HasValue)
				request.WithQueryParameter("ORFD", m3ORFD.Value.ToM3String());
			if (m3PLFD.HasValue)
				request.WithQueryParameter("PLFD", m3PLFD.Value.ToM3String());
			if (m3RELS.HasValue)
				request.WithQueryParameter("RELS", m3RELS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RELF.HasValue)
				request.WithQueryParameter("RELF", m3RELF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FIXD.HasValue)
				request.WithQueryParameter("FIXD", m3FIXD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLDA.HasValue)
				request.WithQueryParameter("PLDA", m3PLDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLHO.HasValue)
				request.WithQueryParameter("PLHO", m3PLHO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RLTS.HasValue)
				request.WithQueryParameter("RLTS", m3RLTS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPRI.HasValue)
				request.WithQueryParameter("OPRI", m3OPRI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ChgBasicDataResponse>(
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
		/// Name ChgConnection1
		/// Description Update element connections
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PROJ">Project (Required)</param>
		/// <param name="m3DTUM">Date (Required)</param>
		/// <param name="m3ELNO">Project element (Required)</param>
		/// <param name="m3CONE">Connected project element (Required)</param>
		/// <param name="m3COTE">Controlling project element (Required)</param>
		/// <param name="m3WTCO">Connection type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="m3TMSL">Time slack</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgConnection1(
			string m3DIVI, 
			string m3PROJ, 
			DateTime m3DTUM, 
			string m3ELNO, 
			string m3CONE, 
			string m3COTE, 
			string m3WTCO, 
			int? m3CONO = null, 
			int? m3VERS = null, 
			int? m3TMSL = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgConnection1",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PROJ))
				throw new ArgumentNullException(nameof(m3PROJ));
			if (string.IsNullOrWhiteSpace(m3ELNO))
				throw new ArgumentNullException(nameof(m3ELNO));
			if (string.IsNullOrWhiteSpace(m3CONE))
				throw new ArgumentNullException(nameof(m3CONE));
			if (string.IsNullOrWhiteSpace(m3COTE))
				throw new ArgumentNullException(nameof(m3COTE));
			if (string.IsNullOrWhiteSpace(m3WTCO))
				throw new ArgumentNullException(nameof(m3WTCO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PROJ", m3PROJ.Trim())
				.WithQueryParameter("DTUM", m3DTUM.ToM3String())
				.WithQueryParameter("ELNO", m3ELNO.Trim())
				.WithQueryParameter("CONE", m3CONE.Trim())
				.WithQueryParameter("COTE", m3COTE.Trim())
				.WithQueryParameter("WTCO", m3WTCO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TMSL.HasValue)
				request.WithQueryParameter("TMSL", m3TMSL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltConnection1
		/// Description Delete element connections
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PROJ">Project (Required)</param>
		/// <param name="m3DTUM">Date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltConnection1(
			string m3DIVI, 
			string m3PROJ, 
			DateTime m3DTUM, 
			int? m3CONO = null, 
			int? m3VERS = null, 
			string m3ELNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltConnection1",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PROJ))
				throw new ArgumentNullException(nameof(m3PROJ));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PROJ", m3PROJ.Trim())
				.WithQueryParameter("DTUM", m3DTUM.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());

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
		/// Name GetBasicData
		/// Description Retrieve time planning basic data
		/// Version Release: 11.1
		/// </summary>
		/// <param name="m3PROJ">Project number (Required)</param>
		/// <param name="m3DTUM">Date (Required)</param>
		/// <param name="m3ELNO">Project element (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicDataResponse></returns>
		/// <exception cref="M3Exception<GetBasicDataResponse>"></exception>
		public async Task<M3Response<GetBasicDataResponse>> GetBasicData(
			string m3PROJ, 
			DateTime m3DTUM, 
			string m3ELNO, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			int? m3VERS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PROJ))
				throw new ArgumentNullException(nameof(m3PROJ));
			if (string.IsNullOrWhiteSpace(m3ELNO))
				throw new ArgumentNullException(nameof(m3ELNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PROJ", m3PROJ.Trim())
				.WithQueryParameter("DTUM", m3DTUM.ToM3String())
				.WithQueryParameter("ELNO", m3ELNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetBasicDataResponse>(
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
		/// Name Lock
		/// Description Lock time schedule
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PROJ">Project (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3DTUM">Date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Lock(
			string m3DIVI, 
			string m3PROJ, 
			int m3VERS, 
			DateTime m3DTUM, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Lock",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PROJ))
				throw new ArgumentNullException(nameof(m3PROJ));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PROJ", m3PROJ.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DTUM", m3DTUM.ToM3String());

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
		/// Name LstConnection1
		/// Description List connections per connected element
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PROJ">Project number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3DTUM">Date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CONE">Connected project element</param>
		/// <param name="m3COTE">Controlling project element</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3KLEN">Key length</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstConnection1Response></returns>
		/// <exception cref="M3Exception<LstConnection1Response>"></exception>
		public async Task<M3Response<LstConnection1Response>> LstConnection1(
			string m3DIVI, 
			string m3PROJ, 
			int m3VERS, 
			DateTime m3DTUM, 
			int? m3CONO = null, 
			string m3CONE = null, 
			string m3COTE = null, 
			string m3ELNO = null, 
			string m3KLEN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstConnection1",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PROJ))
				throw new ArgumentNullException(nameof(m3PROJ));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PROJ", m3PROJ.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DTUM", m3DTUM.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CONE))
				request.WithQueryParameter("CONE", m3CONE.Trim());
			if (!string.IsNullOrWhiteSpace(m3COTE))
				request.WithQueryParameter("COTE", m3COTE.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3KLEN))
				request.WithQueryParameter("KLEN", m3KLEN.Trim());

			// Execute the request
			var result = await Execute<LstConnection1Response>(
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
		/// Name LstHead
		/// Description List time planning head
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PROJ">Project number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DTUM">Date</param>
		/// <param name="m3KLEN">Key length</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadResponse></returns>
		/// <exception cref="M3Exception<LstHeadResponse>"></exception>
		public async Task<M3Response<LstHeadResponse>> LstHead(
			string m3DIVI, 
			string m3PROJ, 
			int m3VERS, 
			int? m3CONO = null, 
			DateTime? m3DTUM = null, 
			string m3KLEN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PROJ))
				throw new ArgumentNullException(nameof(m3PROJ));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PROJ", m3PROJ.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTUM.HasValue)
				request.WithQueryParameter("DTUM", m3DTUM.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3KLEN))
				request.WithQueryParameter("KLEN", m3KLEN.Trim());

			// Execute the request
			var result = await Execute<LstHeadResponse>(
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
		/// Name LstLine
		/// Description List time planning line
		/// Version Release: 12.3
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PROJ">Project number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DTUM">Date</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3KLEN">Key length</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineResponse></returns>
		/// <exception cref="M3Exception<LstLineResponse>"></exception>
		public async Task<M3Response<LstLineResponse>> LstLine(
			string m3DIVI, 
			string m3PROJ, 
			int m3VERS, 
			int? m3CONO = null, 
			DateTime? m3DTUM = null, 
			string m3ELNO = null, 
			string m3KLEN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PROJ))
				throw new ArgumentNullException(nameof(m3PROJ));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PROJ", m3PROJ.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTUM.HasValue)
				request.WithQueryParameter("DTUM", m3DTUM.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3KLEN))
				request.WithQueryParameter("KLEN", m3KLEN.Trim());

			// Execute the request
			var result = await Execute<LstLineResponse>(
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
		/// Name Regenerate
		/// Description Regenerate dates upwards in the time schedule.
		/// Version Release: 12.4
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PROJ">Project (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3DTUM">Date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Regenerate(
			string m3DIVI, 
			string m3PROJ, 
			int m3VERS, 
			DateTime m3DTUM, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Regenerate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PROJ))
				throw new ArgumentNullException(nameof(m3PROJ));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PROJ", m3PROJ.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DTUM", m3DTUM.ToM3String());

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
	}
}
// EOF
