/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.RPS675MI;
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
	/// Name: RPS675MI
	/// Component Name: SurplusReturn
	/// Description: Surplus Return
	/// Version Release: 
	///</summary>
	public partial class RPS675MIResource : M3BaseResourceEndpoint
	{
		public RPS675MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "RPS675MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddSurplHead
		/// Description Add surplus Head
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_PRAN">Parts return number (Required)</param>
		/// <param name="m3_RESP">Responsible (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSurplHead(
			string m3_SUNO, 
			int m3_YEA4, 
			string m3_PRAN, 
			string m3_RESP, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSurplHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_PRAN))
				throw new ArgumentNullException("m3_PRAN");
			if (string.IsNullOrWhiteSpace(m3_RESP))
				throw new ArgumentNullException("m3_RESP");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("PRAN", m3_PRAN.Trim())
				.WithQueryParameter("RESP", m3_RESP.Trim());

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
		/// Name AddSurplLine
		/// Description Add surplus Line
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_PRAN">Parts return number (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_RETT">Return type (Required)</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_SPQT">Surplus quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSurplLine(
			string m3_SUNO, 
			int m3_YEA4, 
			string m3_PRAN, 
			string m3_FACI, 
			string m3_ITNO, 
			string m3_RETT, 
			string m3_WHLO = null, 
			decimal? m3_SPQT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSurplLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_PRAN))
				throw new ArgumentNullException("m3_PRAN");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_RETT))
				throw new ArgumentNullException("m3_RETT");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("PRAN", m3_PRAN.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("RETT", m3_RETT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (m3_SPQT.HasValue)
				request.WithQueryParameter("SPQT", m3_SPQT.Value.ToString());

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
		/// Name DltSurplHead
		/// Description Delete surplus Head
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_PRAN">Parts return number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltSurplHead(
			string m3_SUNO, 
			int m3_YEA4, 
			string m3_PRAN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltSurplHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_PRAN))
				throw new ArgumentNullException("m3_PRAN");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("PRAN", m3_PRAN.Trim());

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
		/// Name DltSurplLine
		/// Description Delete surplus return
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_PRAN">Parts return number (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_RETT">Return type (Required)</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltSurplLine(
			string m3_SUNO, 
			int m3_YEA4, 
			string m3_PRAN, 
			string m3_FACI, 
			string m3_ITNO, 
			string m3_RETT, 
			string m3_WHLO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltSurplLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_PRAN))
				throw new ArgumentNullException("m3_PRAN");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_RETT))
				throw new ArgumentNullException("m3_RETT");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("PRAN", m3_PRAN.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("RETT", m3_RETT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());

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
		/// Name GetSurplRec
		/// Description Get Surplus Record
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_PRAN">Parts return number (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_RETT">Return type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSurplRecResponse></returns>
		/// <exception cref="M3Exception<GetSurplRecResponse>"></exception>
		public async Task<M3Response<GetSurplRecResponse>> GetSurplRec(
			string m3_SUNO, 
			int m3_YEA4, 
			string m3_PRAN, 
			string m3_FACI, 
			string m3_ITNO, 
			string m3_RETT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSurplRec",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_PRAN))
				throw new ArgumentNullException("m3_PRAN");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_RETT))
				throw new ArgumentNullException("m3_RETT");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("PRAN", m3_PRAN.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("RETT", m3_RETT.Trim());

			// Execute the request
			var result = await Execute<GetSurplRecResponse>(
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
		/// Name LstSurInvFac
		/// Description List Surplus inventory per facility
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_PRAN">Parts return number (Required)</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSurInvFacResponse></returns>
		/// <exception cref="M3Exception<LstSurInvFacResponse>"></exception>
		public async Task<M3Response<LstSurInvFacResponse>> LstSurInvFac(
			string m3_SUNO, 
			int m3_YEA4, 
			string m3_PRAN, 
			string m3_FACI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSurInvFac",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_PRAN))
				throw new ArgumentNullException("m3_PRAN");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("PRAN", m3_PRAN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());

			// Execute the request
			var result = await Execute<LstSurInvFacResponse>(
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
		/// Name LstSurInvRet
		/// Description List Surplus inventory per return type
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_PRAN">Parts return number (Required)</param>
		/// <param name="m3_RETT">Return type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSurInvRetResponse></returns>
		/// <exception cref="M3Exception<LstSurInvRetResponse>"></exception>
		public async Task<M3Response<LstSurInvRetResponse>> LstSurInvRet(
			string m3_SUNO, 
			int m3_YEA4, 
			string m3_PRAN, 
			string m3_RETT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSurInvRet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_PRAN))
				throw new ArgumentNullException("m3_PRAN");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("PRAN", m3_PRAN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RETT))
				request.WithQueryParameter("RETT", m3_RETT.Trim());

			// Execute the request
			var result = await Execute<LstSurInvRetResponse>(
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
		/// Name LstSurPackages
		/// Description List Surplus Packages
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_PRAN">Parts return number (Required)</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_RETT">Return type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSurPackagesResponse></returns>
		/// <exception cref="M3Exception<LstSurPackagesResponse>"></exception>
		public async Task<M3Response<LstSurPackagesResponse>> LstSurPackages(
			string m3_SUNO, 
			int m3_YEA4, 
			string m3_PRAN, 
			string m3_FACI = null, 
			string m3_ITNO = null, 
			string m3_RETT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSurPackages",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_PRAN))
				throw new ArgumentNullException("m3_PRAN");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("PRAN", m3_PRAN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RETT))
				request.WithQueryParameter("RETT", m3_RETT.Trim());

			// Execute the request
			var result = await Execute<LstSurPackagesResponse>(
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
		/// Name UpdStatus1969
		/// Description Update status to 19 or 69
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_PRAN">Parts return number (Required)</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_RETT">Return type</param>
		/// <param name="m3_RUST">Return status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdStatus1969(
			string m3_SUNO, 
			int m3_YEA4, 
			string m3_PRAN, 
			string m3_FACI = null, 
			string m3_ITNO = null, 
			string m3_RETT = null, 
			string m3_RUST = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdStatus1969",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_PRAN))
				throw new ArgumentNullException("m3_PRAN");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("PRAN", m3_PRAN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RETT))
				request.WithQueryParameter("RETT", m3_RETT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RUST))
				request.WithQueryParameter("RUST", m3_RUST.Trim());

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
		/// Name UpdSurInvFac
		/// Description Update surplus inventory
		/// Version Release: 
		/// </summary>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_YEA4">Year (Required)</param>
		/// <param name="m3_PRAN">Parts return number (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_RETA">Authorized return type (Required)</param>
		/// <param name="m3_RETT">Return type</param>
		/// <param name="m3_AHQT">Authorized quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdSurInvFac(
			string m3_SUNO, 
			int m3_YEA4, 
			string m3_PRAN, 
			string m3_FACI, 
			string m3_ITNO, 
			string m3_RETA, 
			string m3_RETT = null, 
			decimal? m3_AHQT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdSurInvFac",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_PRAN))
				throw new ArgumentNullException("m3_PRAN");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_RETA))
				throw new ArgumentNullException("m3_RETA");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("YEA4", m3_YEA4.ToString())
				.WithQueryParameter("PRAN", m3_PRAN.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("RETA", m3_RETA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RETT))
				request.WithQueryParameter("RETT", m3_RETT.Trim());
			if (m3_AHQT.HasValue)
				request.WithQueryParameter("AHQT", m3_AHQT.Value.ToString());

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
