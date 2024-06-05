/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.MOS104MI;
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
	/// Name: MOS104MI
	/// Component Name: MOS104MI
	/// Description: Api: List Operation Elements
	/// Version Release: 5ea3
	///</summary>
	public partial class MOS104MIResource : M3BaseResourceEndpoint
	{
		public MOS104MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS104MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddOpElement
		/// Description Add Operation Element
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3ACTT">Operation element type (Required)</param>
		/// <param name="m3ACTS">Task element number</param>
		/// <param name="m3ACTR">Work element</param>
		/// <param name="m3TOOL">Tool number</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3INSI">Inspection identity</param>
		/// <param name="m3ACDS">Description</param>
		/// <param name="m3TXT1">Text line 1</param>
		/// <param name="m3TXT2">Text line 2</param>
		/// <param name="m3SETI">Setup time</param>
		/// <param name="m3PITI">Run time</param>
		/// <param name="m3SENP">Planned number of workers - setup</param>
		/// <param name="m3PRNP">Planned number of workers - run time</param>
		/// <param name="m3LASK">Labor skill</param>
		/// <param name="m3INSK">Inspection skill</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3PERM">Permit</param>
		/// <param name="m3TPRM">Permit type</param>
		/// <param name="m3PRMA">Permit mandatory</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3STMB">Status mobility</param>
		/// <param name="m3CATY">Capability type</param>
		/// <param name="m3TRQT">Transaction quantity - basic U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddOpElementResponse></returns>
		/// <exception cref="M3Exception<AddOpElementResponse>"></exception>
		public async Task<M3Response<AddOpElementResponse>> AddOpElement(
			string m3MWNO, 
			int m3OPNO, 
			string m3ACTT, 
			int? m3ACTS = null, 
			string m3ACTR = null, 
			string m3TOOL = null, 
			string m3SERN = null, 
			string m3EMNO = null, 
			string m3DOID = null, 
			string m3INSI = null, 
			string m3ACDS = null, 
			string m3TXT1 = null, 
			string m3TXT2 = null, 
			int? m3SETI = null, 
			int? m3PITI = null, 
			int? m3SENP = null, 
			int? m3PRNP = null, 
			string m3LASK = null, 
			string m3INSK = null, 
			string m3STAT = null, 
			string m3RESP = null, 
			string m3PERM = null, 
			string m3TPRM = null, 
			int? m3PRMA = null, 
			decimal? m3TXID = null, 
			string m3STMB = null, 
			string m3CATY = null, 
			decimal? m3TRQT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddOpElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));
			if (string.IsNullOrWhiteSpace(m3ACTT))
				throw new ArgumentNullException(nameof(m3ACTT));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACTT", m3ACTT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3ACTS.HasValue)
				request.WithQueryParameter("ACTS", m3ACTS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACTR))
				request.WithQueryParameter("ACTR", m3ACTR.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOOL))
				request.WithQueryParameter("TOOL", m3TOOL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3INSI))
				request.WithQueryParameter("INSI", m3INSI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACDS))
				request.WithQueryParameter("ACDS", m3ACDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT1))
				request.WithQueryParameter("TXT1", m3TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT2))
				request.WithQueryParameter("TXT2", m3TXT2.Trim());
			if (m3SETI.HasValue)
				request.WithQueryParameter("SETI", m3SETI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PITI.HasValue)
				request.WithQueryParameter("PITI", m3PITI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SENP.HasValue)
				request.WithQueryParameter("SENP", m3SENP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3PRNP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LASK))
				request.WithQueryParameter("LASK", m3LASK.Trim());
			if (!string.IsNullOrWhiteSpace(m3INSK))
				request.WithQueryParameter("INSK", m3INSK.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PERM))
				request.WithQueryParameter("PERM", m3PERM.Trim());
			if (!string.IsNullOrWhiteSpace(m3TPRM))
				request.WithQueryParameter("TPRM", m3TPRM.Trim());
			if (m3PRMA.HasValue)
				request.WithQueryParameter("PRMA", m3PRMA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STMB))
				request.WithQueryParameter("STMB", m3STMB.Trim());
			if (!string.IsNullOrWhiteSpace(m3CATY))
				request.WithQueryParameter("CATY", m3CATY.Trim());
			if (m3TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3TRQT.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddOpElementResponse>(
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
		/// Name AllocTool
		/// Description AllocTool
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3ACTS">Operation element number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AllocTool(
			string m3MWNO, 
			int m3OPNO, 
			int m3ACTS, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AllocTool",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACTS", m3ACTS.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgOpElement
		/// Description Change Operation Element
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3ACTS">Task element number (Required)</param>
		/// <param name="m3ACTT">Operation element type (Required)</param>
		/// <param name="m3ACTR">Work element</param>
		/// <param name="m3TOOL">Tool number</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3INSI">Inspection identity</param>
		/// <param name="m3ACDS">Description</param>
		/// <param name="m3TXT1">Text line 1</param>
		/// <param name="m3TXT2">Text line 2</param>
		/// <param name="m3SETI">Setup time</param>
		/// <param name="m3PITI">Run time</param>
		/// <param name="m3SENP">Planned number of workers - setup</param>
		/// <param name="m3PRNP">Planned number of workers - run time</param>
		/// <param name="m3LASK">Labor skill</param>
		/// <param name="m3INSK">Inspection skill</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3PERM">Permit</param>
		/// <param name="m3TPRM">Permit type</param>
		/// <param name="m3PRMA">Permit mandatory</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3STMB">Status mobility</param>
		/// <param name="m3CATY">Capability type</param>
		/// <param name="m3TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3TRTM">Transaction time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgOpElement(
			string m3MWNO, 
			int m3OPNO, 
			int m3ACTS, 
			string m3ACTT, 
			string m3ACTR = null, 
			string m3TOOL = null, 
			string m3SERN = null, 
			string m3EMNO = null, 
			string m3DOID = null, 
			string m3INSI = null, 
			string m3ACDS = null, 
			string m3TXT1 = null, 
			string m3TXT2 = null, 
			int? m3SETI = null, 
			int? m3PITI = null, 
			int? m3SENP = null, 
			int? m3PRNP = null, 
			string m3LASK = null, 
			string m3INSK = null, 
			string m3STAT = null, 
			string m3RESP = null, 
			string m3PERM = null, 
			string m3TPRM = null, 
			int? m3PRMA = null, 
			decimal? m3TXID = null, 
			string m3STMB = null, 
			string m3CATY = null, 
			decimal? m3TRQT = null, 
			DateTime? m3TRDT = null, 
			int? m3TRTM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgOpElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));
			if (string.IsNullOrWhiteSpace(m3ACTT))
				throw new ArgumentNullException(nameof(m3ACTT));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACTS", m3ACTS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACTT", m3ACTT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ACTR))
				request.WithQueryParameter("ACTR", m3ACTR.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOOL))
				request.WithQueryParameter("TOOL", m3TOOL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3INSI))
				request.WithQueryParameter("INSI", m3INSI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACDS))
				request.WithQueryParameter("ACDS", m3ACDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT1))
				request.WithQueryParameter("TXT1", m3TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT2))
				request.WithQueryParameter("TXT2", m3TXT2.Trim());
			if (m3SETI.HasValue)
				request.WithQueryParameter("SETI", m3SETI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PITI.HasValue)
				request.WithQueryParameter("PITI", m3PITI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SENP.HasValue)
				request.WithQueryParameter("SENP", m3SENP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3PRNP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LASK))
				request.WithQueryParameter("LASK", m3LASK.Trim());
			if (!string.IsNullOrWhiteSpace(m3INSK))
				request.WithQueryParameter("INSK", m3INSK.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3PERM))
				request.WithQueryParameter("PERM", m3PERM.Trim());
			if (!string.IsNullOrWhiteSpace(m3TPRM))
				request.WithQueryParameter("TPRM", m3TPRM.Trim());
			if (m3PRMA.HasValue)
				request.WithQueryParameter("PRMA", m3PRMA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STMB))
				request.WithQueryParameter("STMB", m3STMB.Trim());
			if (!string.IsNullOrWhiteSpace(m3CATY))
				request.WithQueryParameter("CATY", m3CATY.Trim());
			if (m3TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3TRQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DeAllocTool
		/// Description DeAllocTool
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3ACTS">Operation element number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeAllocTool(
			string m3MWNO, 
			int m3OPNO, 
			int m3ACTS, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DeAllocTool",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACTS", m3ACTS.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltOpElement
		/// Description Delete Operation Element
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3ACTS">Task element number (Required)</param>
		/// <param name="m3ACTR">Work element</param>
		/// <param name="m3ACTT">Operation element type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltOpElement(
			string m3MWNO, 
			int m3OPNO, 
			int m3ACTS, 
			string m3ACTR = null, 
			string m3ACTT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltOpElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACTS", m3ACTS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ACTR))
				request.WithQueryParameter("ACTR", m3ACTR.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACTT))
				request.WithQueryParameter("ACTT", m3ACTT.Trim());

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
		/// Name GetOpElement
		/// Description Get Operation Element
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3ACTS">Task element number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOpElementResponse></returns>
		/// <exception cref="M3Exception<GetOpElementResponse>"></exception>
		public async Task<M3Response<GetOpElementResponse>> GetOpElement(
			string m3MWNO, 
			int m3OPNO, 
			int m3ACTS, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetOpElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACTS", m3ACTS.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetOpElementResponse>(
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
		/// Name LstOperElement
		/// Description List Operation Elemenrs
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MWNO">Work order number (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3ACTT">Operation element type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOperElementResponse></returns>
		/// <exception cref="M3Exception<LstOperElementResponse>"></exception>
		public async Task<M3Response<LstOperElementResponse>> LstOperElement(
			string m3MWNO, 
			int m3OPNO, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3ACTT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstOperElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MWNO))
				throw new ArgumentNullException(nameof(m3MWNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MWNO", m3MWNO.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACTT))
				request.WithQueryParameter("ACTT", m3ACTT.Trim());

			// Execute the request
			var result = await Execute<LstOperElementResponse>(
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
		/// Name LstReqElement
		/// Description List Request Elemenrs
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PLPN">Planned order (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3PLPS">Subnumber - planned order</param>
		/// <param name="m3PLP2">Subnumber - order proposal</param>
		/// <param name="m3ACTT">Operation element type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstReqElementResponse></returns>
		/// <exception cref="M3Exception<LstReqElementResponse>"></exception>
		public async Task<M3Response<LstReqElementResponse>> LstReqElement(
			int m3PLPN, 
			int m3OPNO, 
			string m3FACI = null, 
			string m3PRNO = null, 
			int? m3PLPS = null, 
			int? m3PLP2 = null, 
			string m3ACTT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstReqElement",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PLPN", m3PLPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (m3PLPS.HasValue)
				request.WithQueryParameter("PLPS", m3PLPS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLP2.HasValue)
				request.WithQueryParameter("PLP2", m3PLP2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACTT))
				request.WithQueryParameter("ACTT", m3ACTT.Trim());

			// Execute the request
			var result = await Execute<LstReqElementResponse>(
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
		/// Name Search
		/// Description Search Operation Elemenrs
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3SQRY">Search query</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchResponse></returns>
		/// <exception cref="M3Exception<SearchResponse>"></exception>
		public async Task<M3Response<SearchResponse>> Search(
			string m3SQRY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Search",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SQRY))
				request.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchResponse>(
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
