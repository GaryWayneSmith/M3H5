/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddItem
		/// Description Add itme for transport information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3UNNN">UN number</param>
		/// <param name="m3NNNN">NA number</param>
		/// <param name="m3CASN">CAS number</param>
		/// <param name="m3ECNM">EU number</param>
		/// <param name="m3EINM">EINECS number</param>
		/// <param name="m3ATOM">Atomic number</param>
		/// <param name="m3CEAN">CEA number</param>
		/// <param name="m3NAIC">NAICS code</param>
		/// <param name="m3ITEQ">Item equipment profile</param>
		/// <param name="m3CMMC">Freight commodity code</param>
		/// <param name="m3CMCL">Commodity class</param>
		/// <param name="m3A001">Alpha field 30 positions</param>
		/// <param name="m3A002">Alpha field 30 positions</param>
		/// <param name="m3A003">Alpha field 30 positions</param>
		/// <param name="m3A004">Alpha field 30 positions</param>
		/// <param name="m3A005">Alpha field 30 positions</param>
		/// <param name="m3A006">Alpha field 30 positions</param>
		/// <param name="m3A007">Alpha field 30 positions</param>
		/// <param name="m3A008">Alpha field 30 positions</param>
		/// <param name="m3A009">Alpha field 30 positions</param>
		/// <param name="m3A010">Alpha field 30 positions</param>
		/// <param name="m3A021">Alpha field 1 positions</param>
		/// <param name="m3A022">Alpha field 1 positions</param>
		/// <param name="m3A023">Alpha field 1 positions</param>
		/// <param name="m3A024">Alpha field 1 positions</param>
		/// <param name="m3A025">Alpha field 1 positions</param>
		/// <param name="m3A026">Alpha field 5 positions</param>
		/// <param name="m3A027">Alpha field 5 positions</param>
		/// <param name="m3A028">Alpha field 5 positions</param>
		/// <param name="m3A029">Alpha field 5 positions</param>
		/// <param name="m3A030">Alpha field 5 positions</param>
		/// <param name="m3A031">Alpha field 10 positions</param>
		/// <param name="m3A032">Alpha field 10 positions</param>
		/// <param name="m3A033">Alpha field 10 positions</param>
		/// <param name="m3A034">Alpha field 10 positions</param>
		/// <param name="m3A035">Alpha field 10 positions</param>
		/// <param name="m3A036">Alpha field 15 positions</param>
		/// <param name="m3A037">Alpha field 15 positions</param>
		/// <param name="m3A038">Alpha field 15 positions</param>
		/// <param name="m3A039">Alpha field 15 positions</param>
		/// <param name="m3A040">Alpha field 15 positions</param>
		/// <param name="m3HAZM">Hazardous material</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItem(
			string m3ITNO, 
			int? m3UNNN = null, 
			string m3NNNN = null, 
			string m3CASN = null, 
			string m3ECNM = null, 
			string m3EINM = null, 
			string m3ATOM = null, 
			string m3CEAN = null, 
			int? m3NAIC = null, 
			string m3ITEQ = null, 
			string m3CMMC = null, 
			string m3CMCL = null, 
			string m3A001 = null, 
			string m3A002 = null, 
			string m3A003 = null, 
			string m3A004 = null, 
			string m3A005 = null, 
			string m3A006 = null, 
			string m3A007 = null, 
			string m3A008 = null, 
			string m3A009 = null, 
			string m3A010 = null, 
			string m3A021 = null, 
			string m3A022 = null, 
			string m3A023 = null, 
			string m3A024 = null, 
			string m3A025 = null, 
			string m3A026 = null, 
			string m3A027 = null, 
			string m3A028 = null, 
			string m3A029 = null, 
			string m3A030 = null, 
			string m3A031 = null, 
			string m3A032 = null, 
			string m3A033 = null, 
			string m3A034 = null, 
			string m3A035 = null, 
			string m3A036 = null, 
			string m3A037 = null, 
			string m3A038 = null, 
			string m3A039 = null, 
			string m3A040 = null, 
			int? m3HAZM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3UNNN.HasValue)
				request.WithQueryParameter("UNNN", m3UNNN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NNNN))
				request.WithQueryParameter("NNNN", m3NNNN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CASN))
				request.WithQueryParameter("CASN", m3CASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECNM))
				request.WithQueryParameter("ECNM", m3ECNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3EINM))
				request.WithQueryParameter("EINM", m3EINM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATOM))
				request.WithQueryParameter("ATOM", m3ATOM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CEAN))
				request.WithQueryParameter("CEAN", m3CEAN.Trim());
			if (m3NAIC.HasValue)
				request.WithQueryParameter("NAIC", m3NAIC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITEQ))
				request.WithQueryParameter("ITEQ", m3ITEQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3CMMC))
				request.WithQueryParameter("CMMC", m3CMMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3CMCL))
				request.WithQueryParameter("CMCL", m3CMCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3A001))
				request.WithQueryParameter("A001", m3A001.Trim());
			if (!string.IsNullOrWhiteSpace(m3A002))
				request.WithQueryParameter("A002", m3A002.Trim());
			if (!string.IsNullOrWhiteSpace(m3A003))
				request.WithQueryParameter("A003", m3A003.Trim());
			if (!string.IsNullOrWhiteSpace(m3A004))
				request.WithQueryParameter("A004", m3A004.Trim());
			if (!string.IsNullOrWhiteSpace(m3A005))
				request.WithQueryParameter("A005", m3A005.Trim());
			if (!string.IsNullOrWhiteSpace(m3A006))
				request.WithQueryParameter("A006", m3A006.Trim());
			if (!string.IsNullOrWhiteSpace(m3A007))
				request.WithQueryParameter("A007", m3A007.Trim());
			if (!string.IsNullOrWhiteSpace(m3A008))
				request.WithQueryParameter("A008", m3A008.Trim());
			if (!string.IsNullOrWhiteSpace(m3A009))
				request.WithQueryParameter("A009", m3A009.Trim());
			if (!string.IsNullOrWhiteSpace(m3A010))
				request.WithQueryParameter("A010", m3A010.Trim());
			if (!string.IsNullOrWhiteSpace(m3A021))
				request.WithQueryParameter("A021", m3A021.Trim());
			if (!string.IsNullOrWhiteSpace(m3A022))
				request.WithQueryParameter("A022", m3A022.Trim());
			if (!string.IsNullOrWhiteSpace(m3A023))
				request.WithQueryParameter("A023", m3A023.Trim());
			if (!string.IsNullOrWhiteSpace(m3A024))
				request.WithQueryParameter("A024", m3A024.Trim());
			if (!string.IsNullOrWhiteSpace(m3A025))
				request.WithQueryParameter("A025", m3A025.Trim());
			if (!string.IsNullOrWhiteSpace(m3A026))
				request.WithQueryParameter("A026", m3A026.Trim());
			if (!string.IsNullOrWhiteSpace(m3A027))
				request.WithQueryParameter("A027", m3A027.Trim());
			if (!string.IsNullOrWhiteSpace(m3A028))
				request.WithQueryParameter("A028", m3A028.Trim());
			if (!string.IsNullOrWhiteSpace(m3A029))
				request.WithQueryParameter("A029", m3A029.Trim());
			if (!string.IsNullOrWhiteSpace(m3A030))
				request.WithQueryParameter("A030", m3A030.Trim());
			if (!string.IsNullOrWhiteSpace(m3A031))
				request.WithQueryParameter("A031", m3A031.Trim());
			if (!string.IsNullOrWhiteSpace(m3A032))
				request.WithQueryParameter("A032", m3A032.Trim());
			if (!string.IsNullOrWhiteSpace(m3A033))
				request.WithQueryParameter("A033", m3A033.Trim());
			if (!string.IsNullOrWhiteSpace(m3A034))
				request.WithQueryParameter("A034", m3A034.Trim());
			if (!string.IsNullOrWhiteSpace(m3A035))
				request.WithQueryParameter("A035", m3A035.Trim());
			if (!string.IsNullOrWhiteSpace(m3A036))
				request.WithQueryParameter("A036", m3A036.Trim());
			if (!string.IsNullOrWhiteSpace(m3A037))
				request.WithQueryParameter("A037", m3A037.Trim());
			if (!string.IsNullOrWhiteSpace(m3A038))
				request.WithQueryParameter("A038", m3A038.Trim());
			if (!string.IsNullOrWhiteSpace(m3A039))
				request.WithQueryParameter("A039", m3A039.Trim());
			if (!string.IsNullOrWhiteSpace(m3A040))
				request.WithQueryParameter("A040", m3A040.Trim());
			if (m3HAZM.HasValue)
				request.WithQueryParameter("HAZM", m3HAZM.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltItem
		/// Description Delete item for transport information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltItem(
			string m3ITNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

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
		/// Name GetItem
		/// Description Get item for transport information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItemResponse></returns>
		/// <exception cref="M3Exception<GetItemResponse>"></exception>
		public async Task<M3Response<GetItemResponse>> GetItem(
			string m3ITNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<GetItemResponse>(
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
		/// Name LstItem
		/// Description List item for transport information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItemResponse></returns>
		/// <exception cref="M3Exception<LstItemResponse>"></exception>
		public async Task<M3Response<LstItemResponse>> LstItem(
			string m3ITNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<LstItemResponse>(
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
		/// Name UpdItem
		/// Description Update item for transport information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3UNNN">UN number</param>
		/// <param name="m3NNNN">NA number</param>
		/// <param name="m3CASN">CAS number</param>
		/// <param name="m3ECNM">EU number</param>
		/// <param name="m3EINM">EINECS number</param>
		/// <param name="m3ATOM">Atomic number</param>
		/// <param name="m3CEAN">CEA number</param>
		/// <param name="m3NAIC">NAICS code</param>
		/// <param name="m3ITEQ">Item equipment profile</param>
		/// <param name="m3CMMC">Freight commodity code</param>
		/// <param name="m3CMCL">Commodity class</param>
		/// <param name="m3A001">Alpha field 30 positions</param>
		/// <param name="m3A002">Alpha field 30 positions</param>
		/// <param name="m3A003">Alpha field 30 positions</param>
		/// <param name="m3A004">Alpha field 30 positions</param>
		/// <param name="m3A005">Alpha field 30 positions</param>
		/// <param name="m3A006">Alpha field 30 positions</param>
		/// <param name="m3A007">Alpha field 30 positions</param>
		/// <param name="m3A008">Alpha field 30 positions</param>
		/// <param name="m3A009">Alpha field 30 positions</param>
		/// <param name="m3A010">Alpha field 30 positions</param>
		/// <param name="m3A021">Alpha field 1 positions</param>
		/// <param name="m3A022">Alpha field 1 positions</param>
		/// <param name="m3A023">Alpha field 1 positions</param>
		/// <param name="m3A024">Alpha field 1 positions</param>
		/// <param name="m3A025">Alpha field 1 positions</param>
		/// <param name="m3A026">Alpha field 5 positions</param>
		/// <param name="m3A027">Alpha field 5 positions</param>
		/// <param name="m3A028">Alpha field 5 positions</param>
		/// <param name="m3A029">Alpha field 5 positions</param>
		/// <param name="m3A030">Alpha field 5 positions</param>
		/// <param name="m3A031">Alpha field 10 positions</param>
		/// <param name="m3A032">Alpha field 10 positions</param>
		/// <param name="m3A033">Alpha field 10 positions</param>
		/// <param name="m3A034">Alpha field 10 positions</param>
		/// <param name="m3A035">Alpha field 10 positions</param>
		/// <param name="m3A036">Alpha field 15 positions</param>
		/// <param name="m3A037">Alpha field 15 positions</param>
		/// <param name="m3A038">Alpha field 15 positions</param>
		/// <param name="m3A039">Alpha field 15 positions</param>
		/// <param name="m3A040">Alpha field 15 positions</param>
		/// <param name="m3HAZM">Hazardous material</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItem(
			string m3ITNO, 
			int? m3UNNN = null, 
			string m3NNNN = null, 
			string m3CASN = null, 
			string m3ECNM = null, 
			string m3EINM = null, 
			string m3ATOM = null, 
			string m3CEAN = null, 
			int? m3NAIC = null, 
			string m3ITEQ = null, 
			string m3CMMC = null, 
			string m3CMCL = null, 
			string m3A001 = null, 
			string m3A002 = null, 
			string m3A003 = null, 
			string m3A004 = null, 
			string m3A005 = null, 
			string m3A006 = null, 
			string m3A007 = null, 
			string m3A008 = null, 
			string m3A009 = null, 
			string m3A010 = null, 
			string m3A021 = null, 
			string m3A022 = null, 
			string m3A023 = null, 
			string m3A024 = null, 
			string m3A025 = null, 
			string m3A026 = null, 
			string m3A027 = null, 
			string m3A028 = null, 
			string m3A029 = null, 
			string m3A030 = null, 
			string m3A031 = null, 
			string m3A032 = null, 
			string m3A033 = null, 
			string m3A034 = null, 
			string m3A035 = null, 
			string m3A036 = null, 
			string m3A037 = null, 
			string m3A038 = null, 
			string m3A039 = null, 
			string m3A040 = null, 
			int? m3HAZM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3UNNN.HasValue)
				request.WithQueryParameter("UNNN", m3UNNN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3NNNN))
				request.WithQueryParameter("NNNN", m3NNNN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CASN))
				request.WithQueryParameter("CASN", m3CASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECNM))
				request.WithQueryParameter("ECNM", m3ECNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3EINM))
				request.WithQueryParameter("EINM", m3EINM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATOM))
				request.WithQueryParameter("ATOM", m3ATOM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CEAN))
				request.WithQueryParameter("CEAN", m3CEAN.Trim());
			if (m3NAIC.HasValue)
				request.WithQueryParameter("NAIC", m3NAIC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITEQ))
				request.WithQueryParameter("ITEQ", m3ITEQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3CMMC))
				request.WithQueryParameter("CMMC", m3CMMC.Trim());
			if (!string.IsNullOrWhiteSpace(m3CMCL))
				request.WithQueryParameter("CMCL", m3CMCL.Trim());
			if (!string.IsNullOrWhiteSpace(m3A001))
				request.WithQueryParameter("A001", m3A001.Trim());
			if (!string.IsNullOrWhiteSpace(m3A002))
				request.WithQueryParameter("A002", m3A002.Trim());
			if (!string.IsNullOrWhiteSpace(m3A003))
				request.WithQueryParameter("A003", m3A003.Trim());
			if (!string.IsNullOrWhiteSpace(m3A004))
				request.WithQueryParameter("A004", m3A004.Trim());
			if (!string.IsNullOrWhiteSpace(m3A005))
				request.WithQueryParameter("A005", m3A005.Trim());
			if (!string.IsNullOrWhiteSpace(m3A006))
				request.WithQueryParameter("A006", m3A006.Trim());
			if (!string.IsNullOrWhiteSpace(m3A007))
				request.WithQueryParameter("A007", m3A007.Trim());
			if (!string.IsNullOrWhiteSpace(m3A008))
				request.WithQueryParameter("A008", m3A008.Trim());
			if (!string.IsNullOrWhiteSpace(m3A009))
				request.WithQueryParameter("A009", m3A009.Trim());
			if (!string.IsNullOrWhiteSpace(m3A010))
				request.WithQueryParameter("A010", m3A010.Trim());
			if (!string.IsNullOrWhiteSpace(m3A021))
				request.WithQueryParameter("A021", m3A021.Trim());
			if (!string.IsNullOrWhiteSpace(m3A022))
				request.WithQueryParameter("A022", m3A022.Trim());
			if (!string.IsNullOrWhiteSpace(m3A023))
				request.WithQueryParameter("A023", m3A023.Trim());
			if (!string.IsNullOrWhiteSpace(m3A024))
				request.WithQueryParameter("A024", m3A024.Trim());
			if (!string.IsNullOrWhiteSpace(m3A025))
				request.WithQueryParameter("A025", m3A025.Trim());
			if (!string.IsNullOrWhiteSpace(m3A026))
				request.WithQueryParameter("A026", m3A026.Trim());
			if (!string.IsNullOrWhiteSpace(m3A027))
				request.WithQueryParameter("A027", m3A027.Trim());
			if (!string.IsNullOrWhiteSpace(m3A028))
				request.WithQueryParameter("A028", m3A028.Trim());
			if (!string.IsNullOrWhiteSpace(m3A029))
				request.WithQueryParameter("A029", m3A029.Trim());
			if (!string.IsNullOrWhiteSpace(m3A030))
				request.WithQueryParameter("A030", m3A030.Trim());
			if (!string.IsNullOrWhiteSpace(m3A031))
				request.WithQueryParameter("A031", m3A031.Trim());
			if (!string.IsNullOrWhiteSpace(m3A032))
				request.WithQueryParameter("A032", m3A032.Trim());
			if (!string.IsNullOrWhiteSpace(m3A033))
				request.WithQueryParameter("A033", m3A033.Trim());
			if (!string.IsNullOrWhiteSpace(m3A034))
				request.WithQueryParameter("A034", m3A034.Trim());
			if (!string.IsNullOrWhiteSpace(m3A035))
				request.WithQueryParameter("A035", m3A035.Trim());
			if (!string.IsNullOrWhiteSpace(m3A036))
				request.WithQueryParameter("A036", m3A036.Trim());
			if (!string.IsNullOrWhiteSpace(m3A037))
				request.WithQueryParameter("A037", m3A037.Trim());
			if (!string.IsNullOrWhiteSpace(m3A038))
				request.WithQueryParameter("A038", m3A038.Trim());
			if (!string.IsNullOrWhiteSpace(m3A039))
				request.WithQueryParameter("A039", m3A039.Trim());
			if (!string.IsNullOrWhiteSpace(m3A040))
				request.WithQueryParameter("A040", m3A040.Trim());
			if (m3HAZM.HasValue)
				request.WithQueryParameter("HAZM", m3HAZM.Value.ToString(CultureInfo.CurrentCulture));

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
