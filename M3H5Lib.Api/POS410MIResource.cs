/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.POS410MI;
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
	/// Name: POS410MI
	/// Component Name: ProjectOrder
	/// Description: Management of project task Project Order
	/// Version Release: MNB
	///</summary>
	public partial class POS410MIResource : M3BaseResourceEndpoint
	{
		public POS410MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "POS410MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddTask
		/// Description Add Project Order Task
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PROJ">Project (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3OPDS">Operation description (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PLGR">Work center (Required)</param>
		/// <param name="m3ELNO">Project element (Required)</param>
		/// <param name="m3DEPT">Department (Required)</param>
		/// <param name="m3REAR">Planning area (Required)</param>
		/// <param name="m3TANR">Task number</param>
		/// <param name="m3DOID">Document ID</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3PITI">Run time</param>
		/// <param name="m3UMAT">Used labor run time</param>
		/// <param name="m3PRNP">Planned number of workers - run time</param>
		/// <param name="m3ORQT">Ordered quantity</param>
		/// <param name="m3MAQT">Manufactured quantity</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3MSTI">Start time</param>
		/// <param name="m3FIDT">Finish date</param>
		/// <param name="m3MFTI">Finish time</param>
		/// <param name="m3PLDA">Planned days</param>
		/// <param name="m3PPOC">Percent of completion</param>
		/// <param name="m3TXT1">Text line 1</param>
		/// <param name="m3TXT2">Text line 2</param>
		/// <param name="m3CMET">Calculation method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTask(
			string m3DIVI, 
			string m3PROJ, 
			int m3VERS, 
			string m3OPDS, 
			string m3FACI, 
			string m3PLGR, 
			string m3ELNO, 
			string m3DEPT, 
			string m3REAR, 
			int? m3TANR = null, 
			string m3DOID = null, 
			string m3SUNO = null, 
			int? m3PITI = null, 
			int? m3UMAT = null, 
			int? m3PRNP = null, 
			decimal? m3ORQT = null, 
			decimal? m3MAQT = null, 
			DateTime? m3STDT = null, 
			int? m3MSTI = null, 
			DateTime? m3FIDT = null, 
			int? m3MFTI = null, 
			int? m3PLDA = null, 
			int? m3PPOC = null, 
			string m3TXT1 = null, 
			string m3TXT2 = null, 
			string m3CMET = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddTask",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3PROJ))
				throw new ArgumentNullException(nameof(m3PROJ));
			if (string.IsNullOrWhiteSpace(m3OPDS))
				throw new ArgumentNullException(nameof(m3OPDS));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PLGR))
				throw new ArgumentNullException(nameof(m3PLGR));
			if (string.IsNullOrWhiteSpace(m3ELNO))
				throw new ArgumentNullException(nameof(m3ELNO));
			if (string.IsNullOrWhiteSpace(m3DEPT))
				throw new ArgumentNullException(nameof(m3DEPT));
			if (string.IsNullOrWhiteSpace(m3REAR))
				throw new ArgumentNullException(nameof(m3REAR));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("PROJ", m3PROJ.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OPDS", m3OPDS.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PLGR", m3PLGR.Trim())
				.WithQueryParameter("ELNO", m3ELNO.Trim())
				.WithQueryParameter("DEPT", m3DEPT.Trim())
				.WithQueryParameter("REAR", m3REAR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3TANR.HasValue)
				request.WithQueryParameter("TANR", m3TANR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3PITI.HasValue)
				request.WithQueryParameter("PITI", m3PITI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UMAT.HasValue)
				request.WithQueryParameter("UMAT", m3UMAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3PRNP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3ORQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MAQT.HasValue)
				request.WithQueryParameter("MAQT", m3MAQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3MSTI.HasValue)
				request.WithQueryParameter("MSTI", m3MSTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3FIDT.Value.ToM3String());
			if (m3MFTI.HasValue)
				request.WithQueryParameter("MFTI", m3MFTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLDA.HasValue)
				request.WithQueryParameter("PLDA", m3PLDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PPOC.HasValue)
				request.WithQueryParameter("PPOC", m3PPOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TXT1))
				request.WithQueryParameter("TXT1", m3TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT2))
				request.WithQueryParameter("TXT2", m3TXT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CMET))
				request.WithQueryParameter("CMET", m3CMET.Trim());

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
		/// Name DelTask
		/// Description Delete Project order Task
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PROJ">Project (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3TANR">Task number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelTask(
			string m3DIVI, 
			string m3PROJ, 
			int m3VERS, 
			int m3TANR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelTask",
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
				.WithQueryParameter("TANR", m3TANR.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetTask
		/// Description Get Project Order task
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PROJ">Project (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3TANR">Task number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTaskResponse></returns>
		/// <exception cref="M3Exception<GetTaskResponse>"></exception>
		public async Task<M3Response<GetTaskResponse>> GetTask(
			string m3DIVI, 
			string m3PROJ, 
			int m3VERS, 
			int m3TANR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetTask",
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
				.WithQueryParameter("TANR", m3TANR.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetTaskResponse>(
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
		/// Name LstTask
		/// Description List Project order Task
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PROJ">Project number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTaskResponse></returns>
		/// <exception cref="M3Exception<LstTaskResponse>"></exception>
		public async Task<M3Response<LstTaskResponse>> LstTask(
			string m3DIVI, 
			string m3PROJ, 
			int m3VERS, 
			string m3ELNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTask",
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
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());

			// Execute the request
			var result = await Execute<LstTaskResponse>(
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
		/// Name UpdTask
		/// Description Update Projetc order Task
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3PROJ">Project (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3TANR">Task number (Required)</param>
		/// <param name="m3OPDS">Task description</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3REAR">Planning area</param>
		/// <param name="m3DOID">Document ID</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3PITI">Run time</param>
		/// <param name="m3UMAT">Used labor run time</param>
		/// <param name="m3PRNP">Planned number of workers - run time</param>
		/// <param name="m3ORQT">Ordered quantity</param>
		/// <param name="m3MAQT">Manufactured quantity</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3MSTI">Start time</param>
		/// <param name="m3FIDT">Finish date</param>
		/// <param name="m3MFTI">Finish time</param>
		/// <param name="m3PLDA">Planned days</param>
		/// <param name="m3PPOC">Percent of completion</param>
		/// <param name="m3TXT1">Text line 1</param>
		/// <param name="m3TXT2">Text line 2</param>
		/// <param name="m3CMET">Calculation method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTask(
			string m3DIVI, 
			string m3PROJ, 
			int m3VERS, 
			int m3TANR, 
			string m3OPDS = null, 
			string m3FACI = null, 
			string m3PLGR = null, 
			string m3ELNO = null, 
			string m3DEPT = null, 
			string m3REAR = null, 
			string m3DOID = null, 
			string m3SUNO = null, 
			int? m3PITI = null, 
			int? m3UMAT = null, 
			int? m3PRNP = null, 
			decimal? m3ORQT = null, 
			decimal? m3MAQT = null, 
			DateTime? m3STDT = null, 
			int? m3MSTI = null, 
			DateTime? m3FIDT = null, 
			int? m3MFTI = null, 
			int? m3PLDA = null, 
			int? m3PPOC = null, 
			string m3TXT1 = null, 
			string m3TXT2 = null, 
			string m3CMET = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdTask",
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
				.WithQueryParameter("TANR", m3TANR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OPDS))
				request.WithQueryParameter("OPDS", m3OPDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3REAR))
				request.WithQueryParameter("REAR", m3REAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3PITI.HasValue)
				request.WithQueryParameter("PITI", m3PITI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UMAT.HasValue)
				request.WithQueryParameter("UMAT", m3UMAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3PRNP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3ORQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MAQT.HasValue)
				request.WithQueryParameter("MAQT", m3MAQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3MSTI.HasValue)
				request.WithQueryParameter("MSTI", m3MSTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3FIDT.Value.ToM3String());
			if (m3MFTI.HasValue)
				request.WithQueryParameter("MFTI", m3MFTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLDA.HasValue)
				request.WithQueryParameter("PLDA", m3PLDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PPOC.HasValue)
				request.WithQueryParameter("PPOC", m3PPOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TXT1))
				request.WithQueryParameter("TXT1", m3TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT2))
				request.WithQueryParameter("TXT2", m3TXT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CMET))
				request.WithQueryParameter("CMET", m3CMET.Trim());

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
