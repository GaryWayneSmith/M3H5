/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PPS360MI;
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
	/// Name: PPS360MI
	/// Component Name: PUR
	/// Description: Api: Delivery notes
	/// Version Release: 5ea0
	///</summary>
	public partial class PPS360MIResource : M3BaseResourceEndpoint
	{
		public PPS360MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPS360MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AdviseHead
		/// Description Advise Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SUTY">Supplier type (Required)</param>
		/// <param name="m3_SUDO">Delivery note number (Required)</param>
		/// <param name="m3_DNDT">Delivery note date (Required)</param>
		/// <param name="m3_SHD4">Planned pickup date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AdviseHead(
			string m3_WHLO, 
			string m3_SUNO, 
			int m3_SUTY, 
			string m3_SUDO, 
			DateTime m3_DNDT, 
			DateTime m3_SHD4, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AdviseHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SUDO))
				throw new ArgumentNullException("m3_SUDO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SUTY", m3_SUTY.ToString())
				.WithQueryParameter("SUDO", m3_SUDO.Trim())
				.WithQueryParameter("DNDT", m3_DNDT.ToM3String())
				.WithQueryParameter("SHD4", m3_SHD4.ToM3String());

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
		/// Name CloseItem
		/// Description Close a Item (PDNLIN)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SUDO">Delivery note number (Required)</param>
		/// <param name="m3_DNDT">Delivery note date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CloseItem(
			string m3_WHLO, 
			string m3_SUNO, 
			string m3_SUDO, 
			DateTime m3_DNDT, 
			int? m3_CONO = null, 
			string m3_ITNO = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
			string m3_AGNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CloseItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SUDO))
				throw new ArgumentNullException("m3_SUDO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SUDO", m3_SUDO.Trim())
				.WithQueryParameter("DNDT", m3_DNDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());

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
		/// Name CloseItmPackage
		/// Description Close a Item per package (PFTRNS)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SUDO">Delivery note number (Required)</param>
		/// <param name="m3_DNDT">Delivery note date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_RIDN">Order number</param>
		/// <param name="m3_RIDL">Order line</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CloseItmPackage(
			string m3_WHLO, 
			string m3_SUNO, 
			string m3_SUDO, 
			DateTime m3_DNDT, 
			int? m3_CONO = null, 
			string m3_PACN = null, 
			string m3_ITNO = null, 
			string m3_RIDN = null, 
			int? m3_RIDL = null, 
			int? m3_RIDX = null, 
			string m3_AGNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CloseItmPackage",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SUDO))
				throw new ArgumentNullException("m3_SUDO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SUDO", m3_SUDO.Trim())
				.WithQueryParameter("DNDT", m3_DNDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RIDN))
				request.WithQueryParameter("RIDN", m3_RIDN.Trim());
			if (m3_RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3_RIDL.Value.ToString());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());

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
		/// Name ClosePackage
		/// Description Close a package (PPTRNS)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SUDO">Delivery note number (Required)</param>
		/// <param name="m3_DNDT">Delivery note date (Required)</param>
		/// <param name="m3_PACN">Package number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ClosePackage(
			string m3_WHLO, 
			string m3_SUNO, 
			string m3_SUDO, 
			DateTime m3_DNDT, 
			string m3_PACN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ClosePackage",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SUDO))
				throw new ArgumentNullException("m3_SUDO");
			if (string.IsNullOrWhiteSpace(m3_PACN))
				throw new ArgumentNullException("m3_PACN");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SUDO", m3_SUDO.Trim())
				.WithQueryParameter("DNDT", m3_DNDT.ToM3String())
				.WithQueryParameter("PACN", m3_PACN.Trim());

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
		/// Name DltHead
		/// Description Delete Delivery Note Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SUTY">Supplier type (Required)</param>
		/// <param name="m3_SUDO">Delivery note number (Required)</param>
		/// <param name="m3_DNDT">Delivery note date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltHead(
			string m3_WHLO, 
			string m3_SUNO, 
			int m3_SUTY, 
			string m3_SUDO, 
			DateTime m3_DNDT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SUDO))
				throw new ArgumentNullException("m3_SUDO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SUTY", m3_SUTY.ToString())
				.WithQueryParameter("SUDO", m3_SUDO.Trim())
				.WithQueryParameter("DNDT", m3_DNDT.ToM3String());

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
		/// Name GetDetail
		/// Description Gets a Delivery note package detail record (PFTRNS)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SUTY">Supplier type (Required)</param>
		/// <param name="m3_SUDO">Delivery note number (Required)</param>
		/// <param name="m3_PACN">Package number (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_BANO">Lot number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DNDT">Delivery note date</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDetailResponse></returns>
		/// <exception cref="M3Exception<GetDetailResponse>"></exception>
		public async Task<M3Response<GetDetailResponse>> GetDetail(
			string m3_WHLO, 
			string m3_SUNO, 
			int m3_SUTY, 
			string m3_SUDO, 
			string m3_PACN, 
			string m3_ITNO, 
			string m3_RIDN, 
			int m3_RIDL, 
			string m3_AGNB, 
			string m3_BANO, 
			int? m3_CONO = null, 
			DateTime? m3_DNDT = null, 
			int? m3_RIDX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SUDO))
				throw new ArgumentNullException("m3_SUDO");
			if (string.IsNullOrWhiteSpace(m3_PACN))
				throw new ArgumentNullException("m3_PACN");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SUTY", m3_SUTY.ToString())
				.WithQueryParameter("SUDO", m3_SUDO.Trim())
				.WithQueryParameter("PACN", m3_PACN.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString())
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("BANO", m3_BANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3_DNDT.Value.ToM3String());
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());

			// Execute the request
			var result = await Execute<GetDetailResponse>(
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
		/// Name GetHead
		/// Description Gets a Delivery note head record (PDNHEA)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SUTY">Supplier type (Required)</param>
		/// <param name="m3_SUDO">Delivery note number (Required)</param>
		/// <param name="m3_DNDT">Delivery note date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadResponse></returns>
		/// <exception cref="M3Exception<GetHeadResponse>"></exception>
		public async Task<M3Response<GetHeadResponse>> GetHead(
			string m3_WHLO, 
			string m3_SUNO, 
			int m3_SUTY, 
			string m3_SUDO, 
			DateTime m3_DNDT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SUDO))
				throw new ArgumentNullException("m3_SUDO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SUTY", m3_SUTY.ToString())
				.WithQueryParameter("SUDO", m3_SUDO.Trim())
				.WithQueryParameter("DNDT", m3_DNDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetHeadResponse>(
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
		/// Name GetPackage
		/// Description Gets a Delivery note package record (PPTRNS)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SUTY">Supplier type (Required)</param>
		/// <param name="m3_SUDO">Delivery note number (Required)</param>
		/// <param name="m3_DNDT">Delivery note date (Required)</param>
		/// <param name="m3_PACN">Package number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPackageResponse></returns>
		/// <exception cref="M3Exception<GetPackageResponse>"></exception>
		public async Task<M3Response<GetPackageResponse>> GetPackage(
			string m3_WHLO, 
			string m3_SUNO, 
			int m3_SUTY, 
			string m3_SUDO, 
			DateTime m3_DNDT, 
			string m3_PACN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPackage",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SUDO))
				throw new ArgumentNullException("m3_SUDO");
			if (string.IsNullOrWhiteSpace(m3_PACN))
				throw new ArgumentNullException("m3_PACN");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SUTY", m3_SUTY.ToString())
				.WithQueryParameter("SUDO", m3_SUDO.Trim())
				.WithQueryParameter("DNDT", m3_DNDT.ToM3String())
				.WithQueryParameter("PACN", m3_PACN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetPackageResponse>(
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
		/// Name LstDetail
		/// Description List Delivey notes package details  (PFTRNS, 00)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SUTY">Supplier type (Required)</param>
		/// <param name="m3_SUDO">Delivery note number (Required)</param>
		/// <param name="m3_DNDT">Delivery note date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDetailResponse></returns>
		/// <exception cref="M3Exception<LstDetailResponse>"></exception>
		public async Task<M3Response<LstDetailResponse>> LstDetail(
			string m3_WHLO, 
			string m3_SUNO, 
			int m3_SUTY, 
			string m3_SUDO, 
			DateTime m3_DNDT, 
			int? m3_CONO = null, 
			string m3_PACN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDetail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SUDO))
				throw new ArgumentNullException("m3_SUDO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SUTY", m3_SUTY.ToString())
				.WithQueryParameter("SUDO", m3_SUDO.Trim())
				.WithQueryParameter("DNDT", m3_DNDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());

			// Execute the request
			var result = await Execute<LstDetailResponse>(
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
		/// Name LstDetailByPack
		/// Description List Delivey notes package details  (PFTRNS, 00)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PACN">Package number (Required)</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_DNDT">Delivery note date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDetailByPackResponse></returns>
		/// <exception cref="M3Exception<LstDetailByPackResponse>"></exception>
		public async Task<M3Response<LstDetailByPackResponse>> LstDetailByPack(
			string m3_PACN, 
			string m3_WHLO = null, 
			string m3_SUNO = null, 
			string m3_SUDO = null, 
			DateTime? m3_DNDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstDetailByPack",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PACN))
				throw new ArgumentNullException("m3_PACN");

			// Set mandatory parameters
			request
				.WithQueryParameter("PACN", m3_PACN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (m3_DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3_DNDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstDetailByPackResponse>(
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
		/// Name LstHeadByPack
		/// Description List Delivery notes per package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_DNDT">Delivery note date</param>
		/// <param name="m3_FRDT">From date</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="m3_FRSL">From - Lowest status</param>
		/// <param name="m3_TOSL">To - Lowest status</param>
		/// <param name="m3_FRST">From - Highest status</param>
		/// <param name="m3_TOST">To - Highest status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadByPackResponse></returns>
		/// <exception cref="M3Exception<LstHeadByPackResponse>"></exception>
		public async Task<M3Response<LstHeadByPackResponse>> LstHeadByPack(
			string m3_PACN = null, 
			string m3_WHLO = null, 
			string m3_SUNO = null, 
			string m3_SUDO = null, 
			DateTime? m3_DNDT = null, 
			DateTime? m3_FRDT = null, 
			DateTime? m3_TODT = null, 
			string m3_FRSL = null, 
			string m3_TOSL = null, 
			string m3_FRST = null, 
			string m3_TOST = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstHeadByPack",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (m3_DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3_DNDT.Value.ToM3String());
			if (m3_FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3_FRDT.Value.ToM3String());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_FRSL))
				request.WithQueryParameter("FRSL", m3_FRSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOSL))
				request.WithQueryParameter("TOSL", m3_TOSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRST))
				request.WithQueryParameter("FRST", m3_FRST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOST))
				request.WithQueryParameter("TOST", m3_TOST.Trim());

			// Execute the request
			var result = await Execute<LstHeadByPackResponse>(
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
		/// Name LstHeadBySts
		/// Description List Delivery notes per status
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_FRSL">From - Lowest status (Required)</param>
		/// <param name="m3_TOSL">To - Lowest status (Required)</param>
		/// <param name="m3_FRST">From - Highest status (Required)</param>
		/// <param name="m3_TOST">To - Highest status (Required)</param>
		/// <param name="m3_FRDT">From date</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadByStsResponse></returns>
		/// <exception cref="M3Exception<LstHeadByStsResponse>"></exception>
		public async Task<M3Response<LstHeadByStsResponse>> LstHeadBySts(
			string m3_WHLO, 
			string m3_FRSL, 
			string m3_TOSL, 
			string m3_FRST, 
			string m3_TOST, 
			DateTime? m3_FRDT = null, 
			DateTime? m3_TODT = null, 
			string m3_SUNO = null, 
			string m3_SUDO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstHeadBySts",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_FRSL))
				throw new ArgumentNullException("m3_FRSL");
			if (string.IsNullOrWhiteSpace(m3_TOSL))
				throw new ArgumentNullException("m3_TOSL");
			if (string.IsNullOrWhiteSpace(m3_FRST))
				throw new ArgumentNullException("m3_FRST");
			if (string.IsNullOrWhiteSpace(m3_TOST))
				throw new ArgumentNullException("m3_TOST");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("FRSL", m3_FRSL.Trim())
				.WithQueryParameter("TOSL", m3_TOSL.Trim())
				.WithQueryParameter("FRST", m3_FRST.Trim())
				.WithQueryParameter("TOST", m3_TOST.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3_FRDT.Value.ToM3String());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());

			// Execute the request
			var result = await Execute<LstHeadByStsResponse>(
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
		/// Name LstHeadBySup
		/// Description List Delivery note head by supplier (PDNHEA, 00)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SUTY">Supplier type</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_DNDT">Delivery note date</param>
		/// <param name="m3_MLTS">Select display for supplier</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadBySupResponse></returns>
		/// <exception cref="M3Exception<LstHeadBySupResponse>"></exception>
		public async Task<M3Response<LstHeadBySupResponse>> LstHeadBySup(
			string m3_WHLO, 
			int? m3_CONO = null, 
			string m3_SUNO = null, 
			int? m3_SUTY = null, 
			string m3_SUDO = null, 
			DateTime? m3_DNDT = null, 
			int? m3_MLTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstHeadBySup",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_SUTY.HasValue)
				request.WithQueryParameter("SUTY", m3_SUTY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (m3_DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3_DNDT.Value.ToM3String());
			if (m3_MLTS.HasValue)
				request.WithQueryParameter("MLTS", m3_MLTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstHeadBySupResponse>(
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
		/// Name LstPackage
		/// Description List Delivey notes package  (PPTRNS, 00)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SUTY">Supplier type (Required)</param>
		/// <param name="m3_SUDO">Delivery note number (Required)</param>
		/// <param name="m3_DNDT">Delivery note date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPackageResponse></returns>
		/// <exception cref="M3Exception<LstPackageResponse>"></exception>
		public async Task<M3Response<LstPackageResponse>> LstPackage(
			string m3_WHLO, 
			string m3_SUNO, 
			int m3_SUTY, 
			string m3_SUDO, 
			DateTime m3_DNDT, 
			int? m3_CONO = null, 
			string m3_PACN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPackage",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SUDO))
				throw new ArgumentNullException("m3_SUDO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SUTY", m3_SUTY.ToString())
				.WithQueryParameter("SUDO", m3_SUDO.Trim())
				.WithQueryParameter("DNDT", m3_DNDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());

			// Execute the request
			var result = await Execute<LstPackageResponse>(
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
		/// Name LstPackageBySts
		/// Description List package by status
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_DNDT">Delivery note date</param>
		/// <param name="m3_PACO">Package level</param>
		/// <param name="m3_STS1">List advised packages</param>
		/// <param name="m3_STS2">List notified packages</param>
		/// <param name="m3_STS3">List staged packages</param>
		/// <param name="m3_STS4">List goods received packages</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPackageByStsResponse></returns>
		/// <exception cref="M3Exception<LstPackageByStsResponse>"></exception>
		public async Task<M3Response<LstPackageByStsResponse>> LstPackageBySts(
			string m3_PACN = null, 
			string m3_WHLO = null, 
			string m3_SUNO = null, 
			string m3_SUDO = null, 
			DateTime? m3_DNDT = null, 
			int? m3_PACO = null, 
			int? m3_STS1 = null, 
			int? m3_STS2 = null, 
			int? m3_STS3 = null, 
			int? m3_STS4 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPackageBySts",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (m3_DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3_DNDT.Value.ToM3String());
			if (m3_PACO.HasValue)
				request.WithQueryParameter("PACO", m3_PACO.Value.ToString());
			if (m3_STS1.HasValue)
				request.WithQueryParameter("STS1", m3_STS1.Value.ToString());
			if (m3_STS2.HasValue)
				request.WithQueryParameter("STS2", m3_STS2.Value.ToString());
			if (m3_STS3.HasValue)
				request.WithQueryParameter("STS3", m3_STS3.Value.ToString());
			if (m3_STS4.HasValue)
				request.WithQueryParameter("STS4", m3_STS4.Value.ToString());

			// Execute the request
			var result = await Execute<LstPackageByStsResponse>(
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
		/// Name LstSSCCBySts
		/// Description List package by status with SSCC as input
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SSCC">SSCC number (Required)</param>
		/// <param name="m3_PACO">Package level</param>
		/// <param name="m3_STS1">List advised packages</param>
		/// <param name="m3_STS2">List notified packages</param>
		/// <param name="m3_STS3">List staged packages</param>
		/// <param name="m3_STS4">List goods received packages</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSSCCByStsResponse></returns>
		/// <exception cref="M3Exception<LstSSCCByStsResponse>"></exception>
		public async Task<M3Response<LstSSCCByStsResponse>> LstSSCCBySts(
			string m3_SSCC, 
			int? m3_PACO = null, 
			int? m3_STS1 = null, 
			int? m3_STS2 = null, 
			int? m3_STS3 = null, 
			int? m3_STS4 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSSCCBySts",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SSCC))
				throw new ArgumentNullException("m3_SSCC");

			// Set mandatory parameters
			request
				.WithQueryParameter("SSCC", m3_SSCC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PACO.HasValue)
				request.WithQueryParameter("PACO", m3_PACO.Value.ToString());
			if (m3_STS1.HasValue)
				request.WithQueryParameter("STS1", m3_STS1.Value.ToString());
			if (m3_STS2.HasValue)
				request.WithQueryParameter("STS2", m3_STS2.Value.ToString());
			if (m3_STS3.HasValue)
				request.WithQueryParameter("STS3", m3_STS3.Value.ToString());
			if (m3_STS4.HasValue)
				request.WithQueryParameter("STS4", m3_STS4.Value.ToString());

			// Execute the request
			var result = await Execute<LstSSCCByStsResponse>(
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
		/// Name NotifyPackage
		/// Description Notify a package (PPTRNS)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SUTY">Supplier type (Required)</param>
		/// <param name="m3_SUDO">Delivery note number (Required)</param>
		/// <param name="m3_DNDT">Delivery note date (Required)</param>
		/// <param name="m3_PACN">Package number (Required)</param>
		/// <param name="m3_DLDT">Planned delivery date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> NotifyPackage(
			string m3_WHLO, 
			string m3_SUNO, 
			int m3_SUTY, 
			string m3_SUDO, 
			DateTime m3_DNDT, 
			string m3_PACN, 
			DateTime m3_DLDT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/NotifyPackage",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SUDO))
				throw new ArgumentNullException("m3_SUDO");
			if (string.IsNullOrWhiteSpace(m3_PACN))
				throw new ArgumentNullException("m3_PACN");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SUTY", m3_SUTY.ToString())
				.WithQueryParameter("SUDO", m3_SUDO.Trim())
				.WithQueryParameter("DNDT", m3_DNDT.ToM3String())
				.WithQueryParameter("PACN", m3_PACN.Trim())
				.WithQueryParameter("DLDT", m3_DLDT.ToM3String());

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
		/// Name ReceiveHead
		/// Description Goods receive on delivery note header level (PDNHEA)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SUTY">Supplier type (Required)</param>
		/// <param name="m3_SUDO">Delivery note number (Required)</param>
		/// <param name="m3_DNDT">Delivery note date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ReceiveHead(
			string m3_WHLO, 
			string m3_SUNO, 
			int m3_SUTY, 
			string m3_SUDO, 
			DateTime m3_DNDT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ReceiveHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SUDO))
				throw new ArgumentNullException("m3_SUDO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SUTY", m3_SUTY.ToString())
				.WithQueryParameter("SUDO", m3_SUDO.Trim())
				.WithQueryParameter("DNDT", m3_DNDT.ToM3String());

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
		/// Name RevTransNotHead
		/// Description Transaction for reversing a complete transport notification
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SUDO">Delivery note number (Required)</param>
		/// <param name="m3_DNDT">Delivery note date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RevTransNotHead(
			string m3_WHLO, 
			string m3_SUNO, 
			string m3_SUDO, 
			DateTime m3_DNDT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RevTransNotHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SUDO))
				throw new ArgumentNullException("m3_SUDO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SUDO", m3_SUDO.Trim())
				.WithQueryParameter("DNDT", m3_DNDT.ToM3String());

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
		/// Name StagePackage
		/// Description Staging packages before goods receipt
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PACN">Package number</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_DNDT">Delivery note date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<StagePackageResponse></returns>
		/// <exception cref="M3Exception<StagePackageResponse>"></exception>
		public async Task<M3Response<StagePackageResponse>> StagePackage(
			string m3_PACN = null, 
			string m3_WHLO = null, 
			string m3_SUNO = null, 
			string m3_SUDO = null, 
			DateTime? m3_DNDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StagePackage",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (m3_DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3_DNDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<StagePackageResponse>(
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
		/// Name StageSSCC
		/// Description Staging package by SSCC number before goods receipt
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SSCC">SSCC number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<StageSSCCResponse></returns>
		/// <exception cref="M3Exception<StageSSCCResponse>"></exception>
		public async Task<M3Response<StageSSCCResponse>> StageSSCC(
			string m3_SSCC, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StageSSCC",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SSCC))
				throw new ArgumentNullException("m3_SSCC");

			// Set mandatory parameters
			request
				.WithQueryParameter("SSCC", m3_SSCC.Trim());

			// Execute the request
			var result = await Execute<StageSSCCResponse>(
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
		/// Name TransNotifyHead
		/// Description Updates a transport notification  (PDNHEA)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_DNDT">Delivery note date</param>
		/// <param name="m3_E0B4">Transport identity - departure</param>
		/// <param name="m3_E0BH">Trailer registration number</param>
		/// <param name="m3_BOLN">Bill of lading</param>
		/// <param name="m3_FWRF">Forwarding agent reference</param>
		/// <param name="m3_SHD4">Planned pickup date</param>
		/// <param name="m3_ARDT">Arrival date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> TransNotifyHead(
			int? m3_CONO = null, 
			string m3_WHLO = null, 
			string m3_SUNO = null, 
			string m3_SUDO = null, 
			DateTime? m3_DNDT = null, 
			string m3_E0B4 = null, 
			string m3_E0BH = null, 
			string m3_BOLN = null, 
			string m3_FWRF = null, 
			DateTime? m3_SHD4 = null, 
			DateTime? m3_ARDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/TransNotifyHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (m3_DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3_DNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_E0B4))
				request.WithQueryParameter("E0B4", m3_E0B4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0BH))
				request.WithQueryParameter("E0BH", m3_E0BH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BOLN))
				request.WithQueryParameter("BOLN", m3_BOLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWRF))
				request.WithQueryParameter("FWRF", m3_FWRF.Trim());
			if (m3_SHD4.HasValue)
				request.WithQueryParameter("SHD4", m3_SHD4.Value.ToM3String());
			if (m3_ARDT.HasValue)
				request.WithQueryParameter("ARDT", m3_ARDT.Value.ToM3String());

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
		/// Name UpdHead
		/// Description Updates a Delivery note head record (PDNHEA)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_SUTY">Supplier type (Required)</param>
		/// <param name="m3_SUDO">Delivery note number (Required)</param>
		/// <param name="m3_DNDT">Delivery note date (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_E0PA">Partner</param>
		/// <param name="m3_E0QA">Code list qualifier</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_E0B4">Transport identity - departure</param>
		/// <param name="m3_E0BH">Trailer registration number</param>
		/// <param name="m3_E0B5">Transport nationality - departure</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_TFNO">Facsimile transmission number</param>
		/// <param name="m3_VRNO">VAT registration number</param>
		/// <param name="m3_DPNR">Delivery schedule</param>
		/// <param name="m3_RSAG">Delivery contract number</param>
		/// <param name="m3_SORN">Supplier order number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_CFK1">User-defined field 1 - import tracking</param>
		/// <param name="m3_CFK2">User-defined field 2 - import tracking</param>
		/// <param name="m3_CFK3">User-defined field 3 - import tracking</param>
		/// <param name="m3_CFK4">User-defined field 4 - import tracking</param>
		/// <param name="m3_CFK5">User-defined field 5 - import tracking</param>
		/// <param name="m3_CFK6">User-defined date 1 - import tracking</param>
		/// <param name="m3_CFK7">User-defined date 2 - import tracking</param>
		/// <param name="m3_CFK8">User-defined date 3 - import tracking</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdHead(
			string m3_WHLO, 
			string m3_SUNO, 
			int m3_SUTY, 
			string m3_SUDO, 
			DateTime m3_DNDT, 
			int? m3_CONO = null, 
			string m3_ADID = null, 
			string m3_E0PA = null, 
			string m3_E0QA = null, 
			string m3_MODL = null, 
			string m3_E0B4 = null, 
			string m3_E0BH = null, 
			string m3_E0B5 = null, 
			string m3_TEDL = null, 
			string m3_YREF = null, 
			string m3_TFNO = null, 
			string m3_VRNO = null, 
			string m3_DPNR = null, 
			string m3_RSAG = null, 
			string m3_SORN = null, 
			string m3_RESP = null, 
			string m3_CFK1 = null, 
			string m3_CFK2 = null, 
			string m3_CFK3 = null, 
			string m3_CFK4 = null, 
			string m3_CFK5 = null, 
			DateTime? m3_CFK6 = null, 
			DateTime? m3_CFK7 = null, 
			DateTime? m3_CFK8 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_SUDO))
				throw new ArgumentNullException("m3_SUDO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("SUTY", m3_SUTY.ToString())
				.WithQueryParameter("SUDO", m3_SUDO.Trim())
				.WithQueryParameter("DNDT", m3_DNDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0PA))
				request.WithQueryParameter("E0PA", m3_E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0QA))
				request.WithQueryParameter("E0QA", m3_E0QA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0B4))
				request.WithQueryParameter("E0B4", m3_E0B4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0BH))
				request.WithQueryParameter("E0BH", m3_E0BH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0B5))
				request.WithQueryParameter("E0B5", m3_E0B5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRNO))
				request.WithQueryParameter("VRNO", m3_VRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DPNR))
				request.WithQueryParameter("DPNR", m3_DPNR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSAG))
				request.WithQueryParameter("RSAG", m3_RSAG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SORN))
				request.WithQueryParameter("SORN", m3_SORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFK1))
				request.WithQueryParameter("CFK1", m3_CFK1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFK2))
				request.WithQueryParameter("CFK2", m3_CFK2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFK3))
				request.WithQueryParameter("CFK3", m3_CFK3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFK4))
				request.WithQueryParameter("CFK4", m3_CFK4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFK5))
				request.WithQueryParameter("CFK5", m3_CFK5.Trim());
			if (m3_CFK6.HasValue)
				request.WithQueryParameter("CFK6", m3_CFK6.Value.ToM3String());
			if (m3_CFK7.HasValue)
				request.WithQueryParameter("CFK7", m3_CFK7.Value.ToM3String());
			if (m3_CFK8.HasValue)
				request.WithQueryParameter("CFK8", m3_CFK8.Value.ToM3String());

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
