/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MWS001MI;
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
	/// Name: MWS001MI
	/// Component Name: Tool
	/// Description: Transport information
	/// Version Release: 5e90
	///</summary>
	public partial class MWS001MIResource : M3BaseResourceEndpoint
	{
		public MWS001MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MWS001MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddItem
		/// Description Add itme for transport information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_UNNN">UN number</param>
		/// <param name="m3_NNNN">NA number</param>
		/// <param name="m3_CASN">CAS number</param>
		/// <param name="m3_ECNM">EU number</param>
		/// <param name="m3_EINM">EINECS number</param>
		/// <param name="m3_ATOM">Atomic number</param>
		/// <param name="m3_CEAN">CEA number</param>
		/// <param name="m3_NAIC">NAICS code</param>
		/// <param name="m3_ITEQ">Item equipment profile</param>
		/// <param name="m3_CMMC">Freight commodity code</param>
		/// <param name="m3_CMCL">Commodity class</param>
		/// <param name="m3_A001">Alpha field 30 positions</param>
		/// <param name="m3_A002">Alpha field 30 positions</param>
		/// <param name="m3_A003">Alpha field 30 positions</param>
		/// <param name="m3_A004">Alpha field 30 positions</param>
		/// <param name="m3_A005">Alpha field 30 positions</param>
		/// <param name="m3_A006">Alpha field 30 positions</param>
		/// <param name="m3_A007">Alpha field 30 positions</param>
		/// <param name="m3_A008">Alpha field 30 positions</param>
		/// <param name="m3_A009">Alpha field 30 positions</param>
		/// <param name="m3_A010">Alpha field 30 positions</param>
		/// <param name="m3_A021">Alpha field 1 positions</param>
		/// <param name="m3_A022">Alpha field 1 positions</param>
		/// <param name="m3_A023">Alpha field 1 positions</param>
		/// <param name="m3_A024">Alpha field 1 positions</param>
		/// <param name="m3_A025">Alpha field 1 positions</param>
		/// <param name="m3_A026">Alpha field 5 positions</param>
		/// <param name="m3_A027">Alpha field 5 positions</param>
		/// <param name="m3_A028">Alpha field 5 positions</param>
		/// <param name="m3_A029">Alpha field 5 positions</param>
		/// <param name="m3_A030">Alpha field 5 positions</param>
		/// <param name="m3_A031">Alpha field 10 positions</param>
		/// <param name="m3_A032">Alpha field 10 positions</param>
		/// <param name="m3_A033">Alpha field 10 positions</param>
		/// <param name="m3_A034">Alpha field 10 positions</param>
		/// <param name="m3_A035">Alpha field 10 positions</param>
		/// <param name="m3_A036">Alpha field 15 positions</param>
		/// <param name="m3_A037">Alpha field 15 positions</param>
		/// <param name="m3_A038">Alpha field 15 positions</param>
		/// <param name="m3_A039">Alpha field 15 positions</param>
		/// <param name="m3_A040">Alpha field 15 positions</param>
		/// <param name="m3_HAZM">Hazardous material</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItem(
			string m3_ITNO, 
			int? m3_UNNN = null, 
			string m3_NNNN = null, 
			string m3_CASN = null, 
			string m3_ECNM = null, 
			string m3_EINM = null, 
			string m3_ATOM = null, 
			string m3_CEAN = null, 
			int? m3_NAIC = null, 
			string m3_ITEQ = null, 
			string m3_CMMC = null, 
			string m3_CMCL = null, 
			string m3_A001 = null, 
			string m3_A002 = null, 
			string m3_A003 = null, 
			string m3_A004 = null, 
			string m3_A005 = null, 
			string m3_A006 = null, 
			string m3_A007 = null, 
			string m3_A008 = null, 
			string m3_A009 = null, 
			string m3_A010 = null, 
			string m3_A021 = null, 
			string m3_A022 = null, 
			string m3_A023 = null, 
			string m3_A024 = null, 
			string m3_A025 = null, 
			string m3_A026 = null, 
			string m3_A027 = null, 
			string m3_A028 = null, 
			string m3_A029 = null, 
			string m3_A030 = null, 
			string m3_A031 = null, 
			string m3_A032 = null, 
			string m3_A033 = null, 
			string m3_A034 = null, 
			string m3_A035 = null, 
			string m3_A036 = null, 
			string m3_A037 = null, 
			string m3_A038 = null, 
			string m3_A039 = null, 
			string m3_A040 = null, 
			int? m3_HAZM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_UNNN.HasValue)
				request.WithQueryParameter("UNNN", m3_UNNN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NNNN))
				request.WithQueryParameter("NNNN", m3_NNNN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CASN))
				request.WithQueryParameter("CASN", m3_CASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECNM))
				request.WithQueryParameter("ECNM", m3_ECNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EINM))
				request.WithQueryParameter("EINM", m3_EINM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATOM))
				request.WithQueryParameter("ATOM", m3_ATOM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CEAN))
				request.WithQueryParameter("CEAN", m3_CEAN.Trim());
			if (m3_NAIC.HasValue)
				request.WithQueryParameter("NAIC", m3_NAIC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITEQ))
				request.WithQueryParameter("ITEQ", m3_ITEQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CMMC))
				request.WithQueryParameter("CMMC", m3_CMMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CMCL))
				request.WithQueryParameter("CMCL", m3_CMCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A001))
				request.WithQueryParameter("A001", m3_A001.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A002))
				request.WithQueryParameter("A002", m3_A002.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A003))
				request.WithQueryParameter("A003", m3_A003.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A004))
				request.WithQueryParameter("A004", m3_A004.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A005))
				request.WithQueryParameter("A005", m3_A005.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A006))
				request.WithQueryParameter("A006", m3_A006.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A007))
				request.WithQueryParameter("A007", m3_A007.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A008))
				request.WithQueryParameter("A008", m3_A008.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A009))
				request.WithQueryParameter("A009", m3_A009.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A010))
				request.WithQueryParameter("A010", m3_A010.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A021))
				request.WithQueryParameter("A021", m3_A021.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A022))
				request.WithQueryParameter("A022", m3_A022.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A023))
				request.WithQueryParameter("A023", m3_A023.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A024))
				request.WithQueryParameter("A024", m3_A024.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A025))
				request.WithQueryParameter("A025", m3_A025.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A026))
				request.WithQueryParameter("A026", m3_A026.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A027))
				request.WithQueryParameter("A027", m3_A027.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A028))
				request.WithQueryParameter("A028", m3_A028.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A029))
				request.WithQueryParameter("A029", m3_A029.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A030))
				request.WithQueryParameter("A030", m3_A030.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A031))
				request.WithQueryParameter("A031", m3_A031.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A032))
				request.WithQueryParameter("A032", m3_A032.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A033))
				request.WithQueryParameter("A033", m3_A033.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A034))
				request.WithQueryParameter("A034", m3_A034.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A035))
				request.WithQueryParameter("A035", m3_A035.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A036))
				request.WithQueryParameter("A036", m3_A036.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A037))
				request.WithQueryParameter("A037", m3_A037.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A038))
				request.WithQueryParameter("A038", m3_A038.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A039))
				request.WithQueryParameter("A039", m3_A039.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A040))
				request.WithQueryParameter("A040", m3_A040.Trim());
			if (m3_HAZM.HasValue)
				request.WithQueryParameter("HAZM", m3_HAZM.Value.ToString());

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
		/// Name DltItem
		/// Description Delete item for transport information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltItem(
			string m3_ITNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

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
		/// Name GetItem
		/// Description Get item for transport information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItemResponse></returns>
		/// <exception cref="M3Exception<GetItemResponse>"></exception>
		public async Task<M3Response<GetItemResponse>> GetItem(
			string m3_ITNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<GetItemResponse>(
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
		/// Name LstItem
		/// Description List item for transport information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemResponse></returns>
		/// <exception cref="M3Exception<LstItemResponse>"></exception>
		public async Task<M3Response<LstItemResponse>> LstItem(
			string m3_ITNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<LstItemResponse>(
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
		/// Name UpdItem
		/// Description Update item for transport information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_UNNN">UN number</param>
		/// <param name="m3_NNNN">NA number</param>
		/// <param name="m3_CASN">CAS number</param>
		/// <param name="m3_ECNM">EU number</param>
		/// <param name="m3_EINM">EINECS number</param>
		/// <param name="m3_ATOM">Atomic number</param>
		/// <param name="m3_CEAN">CEA number</param>
		/// <param name="m3_NAIC">NAICS code</param>
		/// <param name="m3_ITEQ">Item equipment profile</param>
		/// <param name="m3_CMMC">Freight commodity code</param>
		/// <param name="m3_CMCL">Commodity class</param>
		/// <param name="m3_A001">Alpha field 30 positions</param>
		/// <param name="m3_A002">Alpha field 30 positions</param>
		/// <param name="m3_A003">Alpha field 30 positions</param>
		/// <param name="m3_A004">Alpha field 30 positions</param>
		/// <param name="m3_A005">Alpha field 30 positions</param>
		/// <param name="m3_A006">Alpha field 30 positions</param>
		/// <param name="m3_A007">Alpha field 30 positions</param>
		/// <param name="m3_A008">Alpha field 30 positions</param>
		/// <param name="m3_A009">Alpha field 30 positions</param>
		/// <param name="m3_A010">Alpha field 30 positions</param>
		/// <param name="m3_A021">Alpha field 1 positions</param>
		/// <param name="m3_A022">Alpha field 1 positions</param>
		/// <param name="m3_A023">Alpha field 1 positions</param>
		/// <param name="m3_A024">Alpha field 1 positions</param>
		/// <param name="m3_A025">Alpha field 1 positions</param>
		/// <param name="m3_A026">Alpha field 5 positions</param>
		/// <param name="m3_A027">Alpha field 5 positions</param>
		/// <param name="m3_A028">Alpha field 5 positions</param>
		/// <param name="m3_A029">Alpha field 5 positions</param>
		/// <param name="m3_A030">Alpha field 5 positions</param>
		/// <param name="m3_A031">Alpha field 10 positions</param>
		/// <param name="m3_A032">Alpha field 10 positions</param>
		/// <param name="m3_A033">Alpha field 10 positions</param>
		/// <param name="m3_A034">Alpha field 10 positions</param>
		/// <param name="m3_A035">Alpha field 10 positions</param>
		/// <param name="m3_A036">Alpha field 15 positions</param>
		/// <param name="m3_A037">Alpha field 15 positions</param>
		/// <param name="m3_A038">Alpha field 15 positions</param>
		/// <param name="m3_A039">Alpha field 15 positions</param>
		/// <param name="m3_A040">Alpha field 15 positions</param>
		/// <param name="m3_HAZM">Hazardous material</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItem(
			string m3_ITNO, 
			int? m3_UNNN = null, 
			string m3_NNNN = null, 
			string m3_CASN = null, 
			string m3_ECNM = null, 
			string m3_EINM = null, 
			string m3_ATOM = null, 
			string m3_CEAN = null, 
			int? m3_NAIC = null, 
			string m3_ITEQ = null, 
			string m3_CMMC = null, 
			string m3_CMCL = null, 
			string m3_A001 = null, 
			string m3_A002 = null, 
			string m3_A003 = null, 
			string m3_A004 = null, 
			string m3_A005 = null, 
			string m3_A006 = null, 
			string m3_A007 = null, 
			string m3_A008 = null, 
			string m3_A009 = null, 
			string m3_A010 = null, 
			string m3_A021 = null, 
			string m3_A022 = null, 
			string m3_A023 = null, 
			string m3_A024 = null, 
			string m3_A025 = null, 
			string m3_A026 = null, 
			string m3_A027 = null, 
			string m3_A028 = null, 
			string m3_A029 = null, 
			string m3_A030 = null, 
			string m3_A031 = null, 
			string m3_A032 = null, 
			string m3_A033 = null, 
			string m3_A034 = null, 
			string m3_A035 = null, 
			string m3_A036 = null, 
			string m3_A037 = null, 
			string m3_A038 = null, 
			string m3_A039 = null, 
			string m3_A040 = null, 
			int? m3_HAZM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_UNNN.HasValue)
				request.WithQueryParameter("UNNN", m3_UNNN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_NNNN))
				request.WithQueryParameter("NNNN", m3_NNNN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CASN))
				request.WithQueryParameter("CASN", m3_CASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECNM))
				request.WithQueryParameter("ECNM", m3_ECNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EINM))
				request.WithQueryParameter("EINM", m3_EINM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATOM))
				request.WithQueryParameter("ATOM", m3_ATOM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CEAN))
				request.WithQueryParameter("CEAN", m3_CEAN.Trim());
			if (m3_NAIC.HasValue)
				request.WithQueryParameter("NAIC", m3_NAIC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITEQ))
				request.WithQueryParameter("ITEQ", m3_ITEQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CMMC))
				request.WithQueryParameter("CMMC", m3_CMMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CMCL))
				request.WithQueryParameter("CMCL", m3_CMCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A001))
				request.WithQueryParameter("A001", m3_A001.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A002))
				request.WithQueryParameter("A002", m3_A002.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A003))
				request.WithQueryParameter("A003", m3_A003.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A004))
				request.WithQueryParameter("A004", m3_A004.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A005))
				request.WithQueryParameter("A005", m3_A005.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A006))
				request.WithQueryParameter("A006", m3_A006.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A007))
				request.WithQueryParameter("A007", m3_A007.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A008))
				request.WithQueryParameter("A008", m3_A008.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A009))
				request.WithQueryParameter("A009", m3_A009.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A010))
				request.WithQueryParameter("A010", m3_A010.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A021))
				request.WithQueryParameter("A021", m3_A021.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A022))
				request.WithQueryParameter("A022", m3_A022.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A023))
				request.WithQueryParameter("A023", m3_A023.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A024))
				request.WithQueryParameter("A024", m3_A024.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A025))
				request.WithQueryParameter("A025", m3_A025.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A026))
				request.WithQueryParameter("A026", m3_A026.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A027))
				request.WithQueryParameter("A027", m3_A027.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A028))
				request.WithQueryParameter("A028", m3_A028.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A029))
				request.WithQueryParameter("A029", m3_A029.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A030))
				request.WithQueryParameter("A030", m3_A030.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A031))
				request.WithQueryParameter("A031", m3_A031.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A032))
				request.WithQueryParameter("A032", m3_A032.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A033))
				request.WithQueryParameter("A033", m3_A033.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A034))
				request.WithQueryParameter("A034", m3_A034.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A035))
				request.WithQueryParameter("A035", m3_A035.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A036))
				request.WithQueryParameter("A036", m3_A036.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A037))
				request.WithQueryParameter("A037", m3_A037.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A038))
				request.WithQueryParameter("A038", m3_A038.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A039))
				request.WithQueryParameter("A039", m3_A039.Trim());
			if (!string.IsNullOrWhiteSpace(m3_A040))
				request.WithQueryParameter("A040", m3_A040.Trim());
			if (m3_HAZM.HasValue)
				request.WithQueryParameter("HAZM", m3_HAZM.Value.ToString());

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
