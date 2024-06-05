/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name BuildSelection
		/// Description Build selection to populate MSCTRA
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_APIP">APS - policy (Required)</param>
		/// <param name="m3_FWHL">From warehouse</param>
		/// <param name="m3_TWHL">To warehouse</param>
		/// <param name="m3_WHGR">Warehouse group</param>
		/// <param name="m3_SSTF">Start date</param>
		/// <param name="m3_CRTM">Critical material</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> BuildSelection(
			string m3_APIP, 
			string m3_FWHL = null, 
			string m3_TWHL = null, 
			string m3_WHGR = null, 
			DateTime? m3_SSTF = null, 
			int? m3_CRTM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/BuildSelection",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_APIP))
				throw new ArgumentNullException("m3_APIP");

			// Set mandatory parameters
			request
				.WithQueryParameter("APIP", m3_APIP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FWHL))
				request.WithQueryParameter("FWHL", m3_FWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWHL))
				request.WithQueryParameter("TWHL", m3_TWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHGR))
				request.WithQueryParameter("WHGR", m3_WHGR.Trim());
			if (m3_SSTF.HasValue)
				request.WithQueryParameter("SSTF", m3_SSTF.Value.ToM3String());
			if (m3_CRTM.HasValue)
				request.WithQueryParameter("CRTM", m3_CRTM.Value.ToString());

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
		/// Name DeleteMOP
		/// Description Delete Manufactuting Order Proposals
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_SCVE">SCP Version (Required)</param>
		/// <param name="m3_VCAT">Version category (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteMOP(
			string m3_DIVI, 
			string m3_SCVE, 
			string m3_VCAT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeleteMOP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SCVE))
				throw new ArgumentNullException("m3_SCVE");
			if (string.IsNullOrWhiteSpace(m3_VCAT))
				throw new ArgumentNullException("m3_VCAT");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("SCVE", m3_SCVE.Trim())
				.WithQueryParameter("VCAT", m3_VCAT.Trim());

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
		/// Name DeletePOP
		/// Description Delete Purchase Order Proposals
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_SCVE">SCP Version (Required)</param>
		/// <param name="m3_VCAT">Version category (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeletePOP(
			string m3_DIVI, 
			string m3_SCVE, 
			string m3_VCAT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeletePOP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SCVE))
				throw new ArgumentNullException("m3_SCVE");
			if (string.IsNullOrWhiteSpace(m3_VCAT))
				throw new ArgumentNullException("m3_VCAT");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("SCVE", m3_SCVE.Trim())
				.WithQueryParameter("VCAT", m3_VCAT.Trim());

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
		/// Name DisAndImpINV
		/// Description Disaggregate and implement inventory
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SCVE">SCP version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DisAndImpINVResponse></returns>
		/// <exception cref="M3Exception<DisAndImpINVResponse>"></exception>
		public async Task<M3Response<DisAndImpINVResponse>> DisAndImpINV(
			string m3_SCVE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DisAndImpINV",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SCVE))
				request.WithQueryParameter("SCVE", m3_SCVE.Trim());

			// Execute the request
			var result = await Execute<DisAndImpINVResponse>(
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
		/// Name DisAndImpMDS
		/// Description Disaggregate and implement MDS
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SCVE">SCP version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DisAndImpMDSResponse></returns>
		/// <exception cref="M3Exception<DisAndImpMDSResponse>"></exception>
		public async Task<M3Response<DisAndImpMDSResponse>> DisAndImpMDS(
			string m3_SCVE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DisAndImpMDS",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SCVE))
				request.WithQueryParameter("SCVE", m3_SCVE.Trim());

			// Execute the request
			var result = await Execute<DisAndImpMDSResponse>(
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
		/// Name DisAndImpSOR
		/// Description Disaggregate and implement sourcing rules
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SCVE">SCP version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DisAndImpSORResponse></returns>
		/// <exception cref="M3Exception<DisAndImpSORResponse>"></exception>
		public async Task<M3Response<DisAndImpSORResponse>> DisAndImpSOR(
			string m3_SCVE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DisAndImpSOR",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SCVE))
				request.WithQueryParameter("SCVE", m3_SCVE.Trim());

			// Execute the request
			var result = await Execute<DisAndImpSORResponse>(
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
		/// Name Select
		/// Description Select
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SCVE">SCP Version (Required)</param>
		/// <param name="m3_SCTR">Transfer Category (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectResponse></returns>
		/// <exception cref="M3Exception<SelectResponse>"></exception>
		public async Task<M3Response<SelectResponse>> Select(
			string m3_SCVE, 
			string m3_SCTR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Select",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SCVE))
				throw new ArgumentNullException("m3_SCVE");
			if (string.IsNullOrWhiteSpace(m3_SCTR))
				throw new ArgumentNullException("m3_SCTR");

			// Set mandatory parameters
			request
				.WithQueryParameter("SCVE", m3_SCVE.Trim())
				.WithQueryParameter("SCTR", m3_SCTR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<SelectResponse>(
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
		/// Name SelectYOP
		/// Description SelectYOP
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SCVE">SCP Version (Required)</param>
		/// <param name="m3_SCTR">Transfer Category (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelectYOPResponse></returns>
		/// <exception cref="M3Exception<SelectYOPResponse>"></exception>
		public async Task<M3Response<SelectYOPResponse>> SelectYOP(
			string m3_SCVE, 
			string m3_SCTR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelectYOP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SCVE))
				throw new ArgumentNullException("m3_SCVE");
			if (string.IsNullOrWhiteSpace(m3_SCTR))
				throw new ArgumentNullException("m3_SCTR");

			// Set mandatory parameters
			request
				.WithQueryParameter("SCVE", m3_SCVE.Trim())
				.WithQueryParameter("SCTR", m3_SCTR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<SelectYOPResponse>(
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
		/// Name SndDOP
		/// Description Add planning proposal to MSCTRA
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_SCVE">SCP version (Required)</param>
		/// <param name="m3_VCAT">Category (Required)</param>
		/// <param name="m3_SCTR">Transfer category (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ITNO">Itemnumber (Required)</param>
		/// <param name="m3_PLDT">Planning date (Required)</param>
		/// <param name="m3_PPQT">Planned quantity (Required)</param>
		/// <param name="m3_PSTS">Status (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_TWHL">To warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndDOP(
			string m3_DIVI, 
			string m3_SCVE, 
			string m3_VCAT, 
			string m3_SCTR, 
			string m3_WHLO, 
			string m3_ITNO, 
			DateTime m3_PLDT, 
			decimal m3_PPQT, 
			string m3_PSTS, 
			int? m3_CONO = null, 
			string m3_TWHL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndDOP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SCVE))
				throw new ArgumentNullException("m3_SCVE");
			if (string.IsNullOrWhiteSpace(m3_VCAT))
				throw new ArgumentNullException("m3_VCAT");
			if (string.IsNullOrWhiteSpace(m3_SCTR))
				throw new ArgumentNullException("m3_SCTR");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_PSTS))
				throw new ArgumentNullException("m3_PSTS");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("SCVE", m3_SCVE.Trim())
				.WithQueryParameter("VCAT", m3_VCAT.Trim())
				.WithQueryParameter("SCTR", m3_SCTR.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("PLDT", m3_PLDT.ToM3String())
				.WithQueryParameter("PPQT", m3_PPQT.ToString())
				.WithQueryParameter("PSTS", m3_PSTS.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TWHL))
				request.WithQueryParameter("TWHL", m3_TWHL.Trim());

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
		/// Name SndInventory
		/// Description Add Invenvtory Build-Up without answer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SCVE">SCP Version (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_NDID">From Node (Required)</param>
		/// <param name="m3_NDCA">From Node Category (Required)</param>
		/// <param name="m3_SCPG">SCP item group (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_CESS">Calculated extra safety stock</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndInventory(
			string m3_SCVE, 
			DateTime m3_FRDT, 
			string m3_NDID, 
			int m3_NDCA, 
			string m3_SCPG, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			decimal? m3_CESS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndInventory",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SCVE))
				throw new ArgumentNullException("m3_SCVE");
			if (string.IsNullOrWhiteSpace(m3_NDID))
				throw new ArgumentNullException("m3_NDID");
			if (string.IsNullOrWhiteSpace(m3_SCPG))
				throw new ArgumentNullException("m3_SCPG");

			// Set mandatory parameters
			request
				.WithQueryParameter("SCVE", m3_SCVE.Trim())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String())
				.WithQueryParameter("NDID", m3_NDID.Trim())
				.WithQueryParameter("NDCA", m3_NDCA.ToString())
				.WithQueryParameter("SCPG", m3_SCPG.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_CESS.HasValue)
				request.WithQueryParameter("CESS", m3_CESS.Value.ToString());

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
		/// Name SndMOP
		/// Description Export planned MO from YOP
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Divsion (Required)</param>
		/// <param name="m3_SCVE">SCP version (Required)</param>
		/// <param name="m3_VCAT">Category (Required)</param>
		/// <param name="m3_SCTR">Transfer category (Required)</param>
		/// <param name="m3_FACI">Facilty (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ITNO">Itemnumber (Required)</param>
		/// <param name="m3_PLDT">Planning date (Required)</param>
		/// <param name="m3_PPQT">Planned quantity (Required)</param>
		/// <param name="m3_PSTS">Status (Required)</param>
		/// <param name="m3_SIMD">Simulation (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_AOID">Alternative routing</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndMOP(
			string m3_DIVI, 
			string m3_SCVE, 
			string m3_VCAT, 
			string m3_SCTR, 
			string m3_FACI, 
			string m3_WHLO, 
			string m3_ITNO, 
			DateTime m3_PLDT, 
			decimal m3_PPQT, 
			string m3_PSTS, 
			int m3_SIMD, 
			int? m3_CONO = null, 
			string m3_AOID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndMOP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SCVE))
				throw new ArgumentNullException("m3_SCVE");
			if (string.IsNullOrWhiteSpace(m3_VCAT))
				throw new ArgumentNullException("m3_VCAT");
			if (string.IsNullOrWhiteSpace(m3_SCTR))
				throw new ArgumentNullException("m3_SCTR");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_PSTS))
				throw new ArgumentNullException("m3_PSTS");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("SCVE", m3_SCVE.Trim())
				.WithQueryParameter("VCAT", m3_VCAT.Trim())
				.WithQueryParameter("SCTR", m3_SCTR.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("PLDT", m3_PLDT.ToM3String())
				.WithQueryParameter("PPQT", m3_PPQT.ToString())
				.WithQueryParameter("PSTS", m3_PSTS.Trim())
				.WithQueryParameter("SIMD", m3_SIMD.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AOID))
				request.WithQueryParameter("AOID", m3_AOID.Trim());

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
		/// Name SndMds
		/// Description Add Updated Demands without answer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SCVE">SCP Version (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_NDID">From Node (Required)</param>
		/// <param name="m3_NDCA">From Node Category (Required)</param>
		/// <param name="m3_SCPG">SCP item group (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_DEMA">Demand</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndMds(
			string m3_SCVE, 
			DateTime m3_FRDT, 
			string m3_NDID, 
			int m3_NDCA, 
			string m3_SCPG, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			decimal? m3_DEMA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndMds",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SCVE))
				throw new ArgumentNullException("m3_SCVE");
			if (string.IsNullOrWhiteSpace(m3_NDID))
				throw new ArgumentNullException("m3_NDID");
			if (string.IsNullOrWhiteSpace(m3_SCPG))
				throw new ArgumentNullException("m3_SCPG");

			// Set mandatory parameters
			request
				.WithQueryParameter("SCVE", m3_SCVE.Trim())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String())
				.WithQueryParameter("NDID", m3_NDID.Trim())
				.WithQueryParameter("NDCA", m3_NDCA.ToString())
				.WithQueryParameter("SCPG", m3_SCPG.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_DEMA.HasValue)
				request.WithQueryParameter("DEMA", m3_DEMA.Value.ToString());

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
		/// Name SndPOP
		/// Description Export planned MO from YOP
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_SCVE">SCP version (Required)</param>
		/// <param name="m3_VCAT">Category (Required)</param>
		/// <param name="m3_SCTR">Transfer category (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ITNO">Itemnumber (Required)</param>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_PLDT">Planning date (Required)</param>
		/// <param name="m3_PPQT">Planned quantity (Required)</param>
		/// <param name="m3_PSTS">Status (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndPOP(
			string m3_DIVI, 
			string m3_SCVE, 
			string m3_VCAT, 
			string m3_SCTR, 
			string m3_WHLO, 
			string m3_ITNO, 
			string m3_SUNO, 
			DateTime m3_PLDT, 
			decimal m3_PPQT, 
			string m3_PSTS, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndPOP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SCVE))
				throw new ArgumentNullException("m3_SCVE");
			if (string.IsNullOrWhiteSpace(m3_VCAT))
				throw new ArgumentNullException("m3_VCAT");
			if (string.IsNullOrWhiteSpace(m3_SCTR))
				throw new ArgumentNullException("m3_SCTR");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_PSTS))
				throw new ArgumentNullException("m3_PSTS");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("SCVE", m3_SCVE.Trim())
				.WithQueryParameter("VCAT", m3_VCAT.Trim())
				.WithQueryParameter("SCTR", m3_SCTR.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("PLDT", m3_PLDT.ToM3String())
				.WithQueryParameter("PPQT", m3_PPQT.ToString())
				.WithQueryParameter("PSTS", m3_PSTS.Trim());

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
		/// Name SndRules
		/// Description Add Sourcing Rules without answer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SCVE">SCP Version (Required)</param>
		/// <param name="m3_FRDT">From date (Required)</param>
		/// <param name="m3_NDID">From Node (Required)</param>
		/// <param name="m3_NDCA">From Node Category (Required)</param>
		/// <param name="m3_TNOD">To Node (Required)</param>
		/// <param name="m3_TNCA">To Node Category (Required)</param>
		/// <param name="m3_SCPG">SCP Group (Required)</param>
		/// <param name="m3_PRSH">Precentage Share (Required)</param>
		/// <param name="m3_PUIT">Acquisition code (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndRules(
			string m3_SCVE, 
			DateTime m3_FRDT, 
			string m3_NDID, 
			int m3_NDCA, 
			string m3_TNOD, 
			int m3_TNCA, 
			string m3_SCPG, 
			int m3_PRSH, 
			int m3_PUIT, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndRules",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SCVE))
				throw new ArgumentNullException("m3_SCVE");
			if (string.IsNullOrWhiteSpace(m3_NDID))
				throw new ArgumentNullException("m3_NDID");
			if (string.IsNullOrWhiteSpace(m3_TNOD))
				throw new ArgumentNullException("m3_TNOD");
			if (string.IsNullOrWhiteSpace(m3_SCPG))
				throw new ArgumentNullException("m3_SCPG");

			// Set mandatory parameters
			request
				.WithQueryParameter("SCVE", m3_SCVE.Trim())
				.WithQueryParameter("FRDT", m3_FRDT.ToM3String())
				.WithQueryParameter("NDID", m3_NDID.Trim())
				.WithQueryParameter("NDCA", m3_NDCA.ToString())
				.WithQueryParameter("TNOD", m3_TNOD.Trim())
				.WithQueryParameter("TNCA", m3_TNCA.ToString())
				.WithQueryParameter("SCPG", m3_SCPG.Trim())
				.WithQueryParameter("PRSH", m3_PRSH.ToString())
				.WithQueryParameter("PUIT", m3_PUIT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

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
		/// Name TriggerUpdatJob
		/// Description Export planned MO from YOP
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_SCVE">SCP version (Required)</param>
		/// <param name="m3_VCAT">Category (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> TriggerUpdatJob(
			string m3_DIVI, 
			string m3_SCVE, 
			string m3_VCAT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/TriggerUpdatJob",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SCVE))
				throw new ArgumentNullException("m3_SCVE");
			if (string.IsNullOrWhiteSpace(m3_VCAT))
				throw new ArgumentNullException("m3_VCAT");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("SCVE", m3_SCVE.Trim())
				.WithQueryParameter("VCAT", m3_VCAT.Trim());

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
