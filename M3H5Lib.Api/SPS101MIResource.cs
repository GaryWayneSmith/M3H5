/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.SPS101MI;
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
	/// Name: SPS101MI
	/// Component Name: SupplyChainPlannerBasic
	/// Description: SCP basic data interface
	/// Version Release: 14.x
	///</summary>
	public partial class SPS101MIResource : M3BaseResourceEndpoint
	{
		public SPS101MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "SPS101MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name BuildSelection
		/// Description Build selection to populate MSCTRA
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3APIP">APS - policy (Required)</param>
		/// <param name="m3FWHL">From warehouse</param>
		/// <param name="m3TWHL">To warehouse</param>
		/// <param name="m3WHGR">Warehouse group</param>
		/// <param name="m3SSTF">Start date</param>
		/// <param name="m3CRTM">Critical material</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> BuildSelection(
			string m3APIP, 
			string m3FWHL = null, 
			string m3TWHL = null, 
			string m3WHGR = null, 
			DateTime? m3SSTF = null, 
			int? m3CRTM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/BuildSelection",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3APIP))
				throw new ArgumentNullException(nameof(m3APIP));

			// Set mandatory parameters
			request
				.WithQueryParameter("APIP", m3APIP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FWHL))
				request.WithQueryParameter("FWHL", m3FWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWHL))
				request.WithQueryParameter("TWHL", m3TWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHGR))
				request.WithQueryParameter("WHGR", m3WHGR.Trim());
			if (m3SSTF.HasValue)
				request.WithQueryParameter("SSTF", m3SSTF.Value.ToM3String());
			if (m3CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3CRTM.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DeleteMOP
		/// Description Delete Manufactuting Order Proposals
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3SCVE">SCP Version (Required)</param>
		/// <param name="m3VCAT">Version category (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteMOP(
			string m3DIVI, 
			string m3SCVE, 
			string m3VCAT, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DeleteMOP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SCVE))
				throw new ArgumentNullException(nameof(m3SCVE));
			if (string.IsNullOrWhiteSpace(m3VCAT))
				throw new ArgumentNullException(nameof(m3VCAT));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("SCVE", m3SCVE.Trim())
				.WithQueryParameter("VCAT", m3VCAT.Trim());

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
		/// Name DeletePOP
		/// Description Delete Purchase Order Proposals
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3SCVE">SCP Version (Required)</param>
		/// <param name="m3VCAT">Version category (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeletePOP(
			string m3DIVI, 
			string m3SCVE, 
			string m3VCAT, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DeletePOP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SCVE))
				throw new ArgumentNullException(nameof(m3SCVE));
			if (string.IsNullOrWhiteSpace(m3VCAT))
				throw new ArgumentNullException(nameof(m3VCAT));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("SCVE", m3SCVE.Trim())
				.WithQueryParameter("VCAT", m3VCAT.Trim());

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
		/// Name DisAndImpINV
		/// Description Disaggregate and implement inventory
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SCVE">SCP version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DisAndImpINVResponse></returns>
		/// <exception cref="M3Exception<DisAndImpINVResponse>"></exception>
		public async Task<M3Response<DisAndImpINVResponse>> DisAndImpINV(
			string m3SCVE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DisAndImpINV",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SCVE))
				request.WithQueryParameter("SCVE", m3SCVE.Trim());

			// Execute the request
			var result = await Execute<DisAndImpINVResponse>(
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
		/// Name DisAndImpMDS
		/// Description Disaggregate and implement MDS
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SCVE">SCP version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DisAndImpMDSResponse></returns>
		/// <exception cref="M3Exception<DisAndImpMDSResponse>"></exception>
		public async Task<M3Response<DisAndImpMDSResponse>> DisAndImpMDS(
			string m3SCVE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DisAndImpMDS",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SCVE))
				request.WithQueryParameter("SCVE", m3SCVE.Trim());

			// Execute the request
			var result = await Execute<DisAndImpMDSResponse>(
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
		/// Name DisAndImpSOR
		/// Description Disaggregate and implement sourcing rules
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SCVE">SCP version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DisAndImpSORResponse></returns>
		/// <exception cref="M3Exception<DisAndImpSORResponse>"></exception>
		public async Task<M3Response<DisAndImpSORResponse>> DisAndImpSOR(
			string m3SCVE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DisAndImpSOR",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SCVE))
				request.WithQueryParameter("SCVE", m3SCVE.Trim());

			// Execute the request
			var result = await Execute<DisAndImpSORResponse>(
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
		/// Name Select
		/// Description Select
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SCVE">SCP Version (Required)</param>
		/// <param name="m3SCTR">Transfer Category (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			string m3SCVE, 
			string m3SCTR, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Select",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SCVE))
				throw new ArgumentNullException(nameof(m3SCVE));
			if (string.IsNullOrWhiteSpace(m3SCTR))
				throw new ArgumentNullException(nameof(m3SCTR));

			// Set mandatory parameters
			request
				.WithQueryParameter("SCVE", m3SCVE.Trim())
				.WithQueryParameter("SCTR", m3SCTR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelectResponse>(
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
		/// Name SelectYOP
		/// Description SelectYOP
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SCVE">SCP Version (Required)</param>
		/// <param name="m3SCTR">Transfer Category (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectYOPResponse></returns>
		/// <exception cref="M3Exception<SelectYOPResponse>"></exception>
		public async Task<M3Response<SelectYOPResponse>> SelectYOP(
			string m3SCVE, 
			string m3SCTR, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelectYOP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SCVE))
				throw new ArgumentNullException(nameof(m3SCVE));
			if (string.IsNullOrWhiteSpace(m3SCTR))
				throw new ArgumentNullException(nameof(m3SCTR));

			// Set mandatory parameters
			request
				.WithQueryParameter("SCVE", m3SCVE.Trim())
				.WithQueryParameter("SCTR", m3SCTR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelectYOPResponse>(
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
		/// Name SndDOP
		/// Description Add planning proposal to MSCTRA
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3SCVE">SCP version (Required)</param>
		/// <param name="m3VCAT">Category (Required)</param>
		/// <param name="m3SCTR">Transfer category (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ITNO">Itemnumber (Required)</param>
		/// <param name="m3PLDT">Planning date (Required)</param>
		/// <param name="m3PPQT">Planned quantity (Required)</param>
		/// <param name="m3PSTS">Status (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3TWHL">To warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndDOP(
			string m3DIVI, 
			string m3SCVE, 
			string m3VCAT, 
			string m3SCTR, 
			string m3WHLO, 
			string m3ITNO, 
			DateTime m3PLDT, 
			decimal m3PPQT, 
			string m3PSTS, 
			int? m3CONO = null, 
			string m3TWHL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SndDOP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SCVE))
				throw new ArgumentNullException(nameof(m3SCVE));
			if (string.IsNullOrWhiteSpace(m3VCAT))
				throw new ArgumentNullException(nameof(m3VCAT));
			if (string.IsNullOrWhiteSpace(m3SCTR))
				throw new ArgumentNullException(nameof(m3SCTR));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3PSTS))
				throw new ArgumentNullException(nameof(m3PSTS));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("SCVE", m3SCVE.Trim())
				.WithQueryParameter("VCAT", m3VCAT.Trim())
				.WithQueryParameter("SCTR", m3SCTR.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("PLDT", m3PLDT.ToM3String())
				.WithQueryParameter("PPQT", m3PPQT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PSTS", m3PSTS.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TWHL))
				request.WithQueryParameter("TWHL", m3TWHL.Trim());

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
		/// Name SndInventory
		/// Description Add Invenvtory Build-Up without answer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SCVE">SCP Version (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3NDID">From Node (Required)</param>
		/// <param name="m3NDCA">From Node Category (Required)</param>
		/// <param name="m3SCPG">SCP item group (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3CESS">Calculated extra safety stock</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndInventory(
			string m3SCVE, 
			DateTime m3FRDT, 
			string m3NDID, 
			int m3NDCA, 
			string m3SCPG, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			decimal? m3CESS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SndInventory",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SCVE))
				throw new ArgumentNullException(nameof(m3SCVE));
			if (string.IsNullOrWhiteSpace(m3NDID))
				throw new ArgumentNullException(nameof(m3NDID));
			if (string.IsNullOrWhiteSpace(m3SCPG))
				throw new ArgumentNullException(nameof(m3SCPG));

			// Set mandatory parameters
			request
				.WithQueryParameter("SCVE", m3SCVE.Trim())
				.WithQueryParameter("FRDT", m3FRDT.ToM3String())
				.WithQueryParameter("NDID", m3NDID.Trim())
				.WithQueryParameter("NDCA", m3NDCA.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SCPG", m3SCPG.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3CESS.HasValue)
				request.WithQueryParameter("CESS", m3CESS.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name SndMOP
		/// Description Export planned MO from YOP
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Divsion (Required)</param>
		/// <param name="m3SCVE">SCP version (Required)</param>
		/// <param name="m3VCAT">Category (Required)</param>
		/// <param name="m3SCTR">Transfer category (Required)</param>
		/// <param name="m3FACI">Facilty (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ITNO">Itemnumber (Required)</param>
		/// <param name="m3PLDT">Planning date (Required)</param>
		/// <param name="m3PPQT">Planned quantity (Required)</param>
		/// <param name="m3PSTS">Status (Required)</param>
		/// <param name="m3SIMD">Simulation (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3AOID">Alternative routing</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndMOP(
			string m3DIVI, 
			string m3SCVE, 
			string m3VCAT, 
			string m3SCTR, 
			string m3FACI, 
			string m3WHLO, 
			string m3ITNO, 
			DateTime m3PLDT, 
			decimal m3PPQT, 
			string m3PSTS, 
			int m3SIMD, 
			int? m3CONO = null, 
			string m3AOID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SndMOP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SCVE))
				throw new ArgumentNullException(nameof(m3SCVE));
			if (string.IsNullOrWhiteSpace(m3VCAT))
				throw new ArgumentNullException(nameof(m3VCAT));
			if (string.IsNullOrWhiteSpace(m3SCTR))
				throw new ArgumentNullException(nameof(m3SCTR));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3PSTS))
				throw new ArgumentNullException(nameof(m3PSTS));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("SCVE", m3SCVE.Trim())
				.WithQueryParameter("VCAT", m3VCAT.Trim())
				.WithQueryParameter("SCTR", m3SCTR.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("PLDT", m3PLDT.ToM3String())
				.WithQueryParameter("PPQT", m3PPQT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PSTS", m3PSTS.Trim())
				.WithQueryParameter("SIMD", m3SIMD.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AOID))
				request.WithQueryParameter("AOID", m3AOID.Trim());

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
		/// Name SndMds
		/// Description Add Updated Demands without answer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SCVE">SCP Version (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3NDID">From Node (Required)</param>
		/// <param name="m3NDCA">From Node Category (Required)</param>
		/// <param name="m3SCPG">SCP item group (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3DEMA">Demand</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndMds(
			string m3SCVE, 
			DateTime m3FRDT, 
			string m3NDID, 
			int m3NDCA, 
			string m3SCPG, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			decimal? m3DEMA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SndMds",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SCVE))
				throw new ArgumentNullException(nameof(m3SCVE));
			if (string.IsNullOrWhiteSpace(m3NDID))
				throw new ArgumentNullException(nameof(m3NDID));
			if (string.IsNullOrWhiteSpace(m3SCPG))
				throw new ArgumentNullException(nameof(m3SCPG));

			// Set mandatory parameters
			request
				.WithQueryParameter("SCVE", m3SCVE.Trim())
				.WithQueryParameter("FRDT", m3FRDT.ToM3String())
				.WithQueryParameter("NDID", m3NDID.Trim())
				.WithQueryParameter("NDCA", m3NDCA.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SCPG", m3SCPG.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3DEMA.HasValue)
				request.WithQueryParameter("DEMA", m3DEMA.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name SndPOP
		/// Description Export planned MO from YOP
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3SCVE">SCP version (Required)</param>
		/// <param name="m3VCAT">Category (Required)</param>
		/// <param name="m3SCTR">Transfer category (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ITNO">Itemnumber (Required)</param>
		/// <param name="m3SUNO">Supplier (Required)</param>
		/// <param name="m3PLDT">Planning date (Required)</param>
		/// <param name="m3PPQT">Planned quantity (Required)</param>
		/// <param name="m3PSTS">Status (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndPOP(
			string m3DIVI, 
			string m3SCVE, 
			string m3VCAT, 
			string m3SCTR, 
			string m3WHLO, 
			string m3ITNO, 
			string m3SUNO, 
			DateTime m3PLDT, 
			decimal m3PPQT, 
			string m3PSTS, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SndPOP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SCVE))
				throw new ArgumentNullException(nameof(m3SCVE));
			if (string.IsNullOrWhiteSpace(m3VCAT))
				throw new ArgumentNullException(nameof(m3VCAT));
			if (string.IsNullOrWhiteSpace(m3SCTR))
				throw new ArgumentNullException(nameof(m3SCTR));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3PSTS))
				throw new ArgumentNullException(nameof(m3PSTS));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("SCVE", m3SCVE.Trim())
				.WithQueryParameter("VCAT", m3VCAT.Trim())
				.WithQueryParameter("SCTR", m3SCTR.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("PLDT", m3PLDT.ToM3String())
				.WithQueryParameter("PPQT", m3PPQT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PSTS", m3PSTS.Trim());

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
		/// Name SndRules
		/// Description Add Sourcing Rules without answer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SCVE">SCP Version (Required)</param>
		/// <param name="m3FRDT">From date (Required)</param>
		/// <param name="m3NDID">From Node (Required)</param>
		/// <param name="m3NDCA">From Node Category (Required)</param>
		/// <param name="m3TNOD">To Node (Required)</param>
		/// <param name="m3TNCA">To Node Category (Required)</param>
		/// <param name="m3SCPG">SCP Group (Required)</param>
		/// <param name="m3PRSH">Precentage Share (Required)</param>
		/// <param name="m3PUIT">Acquisition code (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndRules(
			string m3SCVE, 
			DateTime m3FRDT, 
			string m3NDID, 
			int m3NDCA, 
			string m3TNOD, 
			int m3TNCA, 
			string m3SCPG, 
			int m3PRSH, 
			int m3PUIT, 
			int? m3CONO = null, 
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SndRules",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SCVE))
				throw new ArgumentNullException(nameof(m3SCVE));
			if (string.IsNullOrWhiteSpace(m3NDID))
				throw new ArgumentNullException(nameof(m3NDID));
			if (string.IsNullOrWhiteSpace(m3TNOD))
				throw new ArgumentNullException(nameof(m3TNOD));
			if (string.IsNullOrWhiteSpace(m3SCPG))
				throw new ArgumentNullException(nameof(m3SCPG));

			// Set mandatory parameters
			request
				.WithQueryParameter("SCVE", m3SCVE.Trim())
				.WithQueryParameter("FRDT", m3FRDT.ToM3String())
				.WithQueryParameter("NDID", m3NDID.Trim())
				.WithQueryParameter("NDCA", m3NDCA.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TNOD", m3TNOD.Trim())
				.WithQueryParameter("TNCA", m3TNCA.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SCPG", m3SCPG.Trim())
				.WithQueryParameter("PRSH", m3PRSH.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PUIT", m3PUIT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

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
		/// Name TriggerUpdatJob
		/// Description Export planned MO from YOP
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3SCVE">SCP version (Required)</param>
		/// <param name="m3VCAT">Category (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> TriggerUpdatJob(
			string m3DIVI, 
			string m3SCVE, 
			string m3VCAT, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/TriggerUpdatJob",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SCVE))
				throw new ArgumentNullException(nameof(m3SCVE));
			if (string.IsNullOrWhiteSpace(m3VCAT))
				throw new ArgumentNullException(nameof(m3VCAT));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("SCVE", m3SCVE.Trim())
				.WithQueryParameter("VCAT", m3VCAT.Trim());

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
