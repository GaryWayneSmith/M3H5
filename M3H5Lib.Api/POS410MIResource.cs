/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PROJ">Project (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_OPDS">Operation description (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PLGR">Work center (Required)</param>
		/// <param name="m3_ELNO">Project element (Required)</param>
		/// <param name="m3_DEPT">Department (Required)</param>
		/// <param name="m3_REAR">Planning area (Required)</param>
		/// <param name="m3_TANR">Task number</param>
		/// <param name="m3_DOID">Document ID</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_PITI">Run time</param>
		/// <param name="m3_UMAT">Used labor run time</param>
		/// <param name="m3_PRNP">Planned number of workers - run time</param>
		/// <param name="m3_ORQT">Ordered quantity</param>
		/// <param name="m3_MAQT">Manufactured quantity</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_MSTI">Start time</param>
		/// <param name="m3_FIDT">Finish date</param>
		/// <param name="m3_MFTI">Finish time</param>
		/// <param name="m3_PLDA">Planned days</param>
		/// <param name="m3_PPOC">Percent of completion</param>
		/// <param name="m3_TXT1">Text line 1</param>
		/// <param name="m3_TXT2">Text line 2</param>
		/// <param name="m3_CMET">Calculation method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTask(
			string m3_DIVI, 
			string m3_PROJ, 
			int m3_VERS, 
			string m3_OPDS, 
			string m3_FACI, 
			string m3_PLGR, 
			string m3_ELNO, 
			string m3_DEPT, 
			string m3_REAR, 
			int? m3_TANR = null, 
			string m3_DOID = null, 
			string m3_SUNO = null, 
			int? m3_PITI = null, 
			int? m3_UMAT = null, 
			int? m3_PRNP = null, 
			decimal? m3_ORQT = null, 
			decimal? m3_MAQT = null, 
			DateTime? m3_STDT = null, 
			int? m3_MSTI = null, 
			DateTime? m3_FIDT = null, 
			int? m3_MFTI = null, 
			int? m3_PLDA = null, 
			int? m3_PPOC = null, 
			string m3_TXT1 = null, 
			string m3_TXT2 = null, 
			string m3_CMET = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PROJ))
				throw new ArgumentNullException("m3_PROJ");
			if (string.IsNullOrWhiteSpace(m3_OPDS))
				throw new ArgumentNullException("m3_OPDS");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PLGR))
				throw new ArgumentNullException("m3_PLGR");
			if (string.IsNullOrWhiteSpace(m3_ELNO))
				throw new ArgumentNullException("m3_ELNO");
			if (string.IsNullOrWhiteSpace(m3_DEPT))
				throw new ArgumentNullException("m3_DEPT");
			if (string.IsNullOrWhiteSpace(m3_REAR))
				throw new ArgumentNullException("m3_REAR");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PROJ", m3_PROJ.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString())
				.WithQueryParameter("OPDS", m3_OPDS.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PLGR", m3_PLGR.Trim())
				.WithQueryParameter("ELNO", m3_ELNO.Trim())
				.WithQueryParameter("DEPT", m3_DEPT.Trim())
				.WithQueryParameter("REAR", m3_REAR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_TANR.HasValue)
				request.WithQueryParameter("TANR", m3_TANR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_PITI.HasValue)
				request.WithQueryParameter("PITI", m3_PITI.Value.ToString());
			if (m3_UMAT.HasValue)
				request.WithQueryParameter("UMAT", m3_UMAT.Value.ToString());
			if (m3_PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3_PRNP.Value.ToString());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());
			if (m3_MAQT.HasValue)
				request.WithQueryParameter("MAQT", m3_MAQT.Value.ToString());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_MSTI.HasValue)
				request.WithQueryParameter("MSTI", m3_MSTI.Value.ToString());
			if (m3_FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3_FIDT.Value.ToM3String());
			if (m3_MFTI.HasValue)
				request.WithQueryParameter("MFTI", m3_MFTI.Value.ToString());
			if (m3_PLDA.HasValue)
				request.WithQueryParameter("PLDA", m3_PLDA.Value.ToString());
			if (m3_PPOC.HasValue)
				request.WithQueryParameter("PPOC", m3_PPOC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TXT1))
				request.WithQueryParameter("TXT1", m3_TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT2))
				request.WithQueryParameter("TXT2", m3_TXT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CMET))
				request.WithQueryParameter("CMET", m3_CMET.Trim());

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
		/// Name DelTask
		/// Description Delete Project order Task
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PROJ">Project (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_TANR">Task number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelTask(
			string m3_DIVI, 
			string m3_PROJ, 
			int m3_VERS, 
			int m3_TANR, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PROJ))
				throw new ArgumentNullException("m3_PROJ");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PROJ", m3_PROJ.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString())
				.WithQueryParameter("TANR", m3_TANR.ToString());

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
		/// Name GetTask
		/// Description Get Project Order task
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PROJ">Project (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_TANR">Task number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTaskResponse></returns>
		/// <exception cref="M3Exception<GetTaskResponse>"></exception>
		public async Task<M3Response<GetTaskResponse>> GetTask(
			string m3_DIVI, 
			string m3_PROJ, 
			int m3_VERS, 
			int m3_TANR, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PROJ))
				throw new ArgumentNullException("m3_PROJ");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PROJ", m3_PROJ.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString())
				.WithQueryParameter("TANR", m3_TANR.ToString());

			// Execute the request
			var result = await Execute<GetTaskResponse>(
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
		/// Name LstTask
		/// Description List Project order Task
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PROJ">Project number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTaskResponse></returns>
		/// <exception cref="M3Exception<LstTaskResponse>"></exception>
		public async Task<M3Response<LstTaskResponse>> LstTask(
			string m3_DIVI, 
			string m3_PROJ, 
			int m3_VERS, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstTask",
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
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());

			// Execute the request
			var result = await Execute<LstTaskResponse>(
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
		/// Name UpdTask
		/// Description Update Projetc order Task
		/// Version Release: MNB
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_PROJ">Project (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_TANR">Task number (Required)</param>
		/// <param name="m3_OPDS">Task description</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_REAR">Planning area</param>
		/// <param name="m3_DOID">Document ID</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_PITI">Run time</param>
		/// <param name="m3_UMAT">Used labor run time</param>
		/// <param name="m3_PRNP">Planned number of workers - run time</param>
		/// <param name="m3_ORQT">Ordered quantity</param>
		/// <param name="m3_MAQT">Manufactured quantity</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_MSTI">Start time</param>
		/// <param name="m3_FIDT">Finish date</param>
		/// <param name="m3_MFTI">Finish time</param>
		/// <param name="m3_PLDA">Planned days</param>
		/// <param name="m3_PPOC">Percent of completion</param>
		/// <param name="m3_TXT1">Text line 1</param>
		/// <param name="m3_TXT2">Text line 2</param>
		/// <param name="m3_CMET">Calculation method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdTask(
			string m3_DIVI, 
			string m3_PROJ, 
			int m3_VERS, 
			int m3_TANR, 
			string m3_OPDS = null, 
			string m3_FACI = null, 
			string m3_PLGR = null, 
			string m3_ELNO = null, 
			string m3_DEPT = null, 
			string m3_REAR = null, 
			string m3_DOID = null, 
			string m3_SUNO = null, 
			int? m3_PITI = null, 
			int? m3_UMAT = null, 
			int? m3_PRNP = null, 
			decimal? m3_ORQT = null, 
			decimal? m3_MAQT = null, 
			DateTime? m3_STDT = null, 
			int? m3_MSTI = null, 
			DateTime? m3_FIDT = null, 
			int? m3_MFTI = null, 
			int? m3_PLDA = null, 
			int? m3_PPOC = null, 
			string m3_TXT1 = null, 
			string m3_TXT2 = null, 
			string m3_CMET = null, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_PROJ))
				throw new ArgumentNullException("m3_PROJ");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("PROJ", m3_PROJ.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString())
				.WithQueryParameter("TANR", m3_TANR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OPDS))
				request.WithQueryParameter("OPDS", m3_OPDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REAR))
				request.WithQueryParameter("REAR", m3_REAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_PITI.HasValue)
				request.WithQueryParameter("PITI", m3_PITI.Value.ToString());
			if (m3_UMAT.HasValue)
				request.WithQueryParameter("UMAT", m3_UMAT.Value.ToString());
			if (m3_PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3_PRNP.Value.ToString());
			if (m3_ORQT.HasValue)
				request.WithQueryParameter("ORQT", m3_ORQT.Value.ToString());
			if (m3_MAQT.HasValue)
				request.WithQueryParameter("MAQT", m3_MAQT.Value.ToString());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_MSTI.HasValue)
				request.WithQueryParameter("MSTI", m3_MSTI.Value.ToString());
			if (m3_FIDT.HasValue)
				request.WithQueryParameter("FIDT", m3_FIDT.Value.ToM3String());
			if (m3_MFTI.HasValue)
				request.WithQueryParameter("MFTI", m3_MFTI.Value.ToString());
			if (m3_PLDA.HasValue)
				request.WithQueryParameter("PLDA", m3_PLDA.Value.ToString());
			if (m3_PPOC.HasValue)
				request.WithQueryParameter("PPOC", m3_PPOC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TXT1))
				request.WithQueryParameter("TXT1", m3_TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT2))
				request.WithQueryParameter("TXT2", m3_TXT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CMET))
				request.WithQueryParameter("CMET", m3_CMET.Trim());

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
