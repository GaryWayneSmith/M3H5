/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SUTY">Supplier type (Required)</param>
		/// <param name="m3SUDO">Delivery note number (Required)</param>
		/// <param name="m3DNDT">Delivery note date (Required)</param>
		/// <param name="m3SHD4">Planned pickup date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AdviseHead(
			string m3WHLO, 
			string m3SUNO, 
			int m3SUTY, 
			string m3SUDO, 
			DateTime m3DNDT, 
			DateTime m3SHD4, 
			int? m3CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SUDO))
				throw new ArgumentNullException(nameof(m3SUDO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SUTY", m3SUTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SUDO", m3SUDO.Trim())
				.WithQueryParameter("DNDT", m3DNDT.ToM3String())
				.WithQueryParameter("SHD4", m3SHD4.ToM3String());

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
		/// Name CloseItem
		/// Description Close a Item (PDNLIN)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SUDO">Delivery note number (Required)</param>
		/// <param name="m3DNDT">Delivery note date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CloseItem(
			string m3WHLO, 
			string m3SUNO, 
			string m3SUDO, 
			DateTime m3DNDT, 
			int? m3CONO = null, 
			string m3ITNO = null, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
			string m3AGNB = null, 
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
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SUDO))
				throw new ArgumentNullException(nameof(m3SUDO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SUDO", m3SUDO.Trim())
				.WithQueryParameter("DNDT", m3DNDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());

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
		/// Name CloseItmPackage
		/// Description Close a Item per package (PFTRNS)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SUDO">Delivery note number (Required)</param>
		/// <param name="m3DNDT">Delivery note date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CloseItmPackage(
			string m3WHLO, 
			string m3SUNO, 
			string m3SUDO, 
			DateTime m3DNDT, 
			int? m3CONO = null, 
			string m3PACN = null, 
			string m3ITNO = null, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
			string m3AGNB = null, 
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
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SUDO))
				throw new ArgumentNullException(nameof(m3SUDO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SUDO", m3SUDO.Trim())
				.WithQueryParameter("DNDT", m3DNDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());

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
		/// Name ClosePackage
		/// Description Close a package (PPTRNS)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SUDO">Delivery note number (Required)</param>
		/// <param name="m3DNDT">Delivery note date (Required)</param>
		/// <param name="m3PACN">Package number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ClosePackage(
			string m3WHLO, 
			string m3SUNO, 
			string m3SUDO, 
			DateTime m3DNDT, 
			string m3PACN, 
			int? m3CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SUDO))
				throw new ArgumentNullException(nameof(m3SUDO));
			if (string.IsNullOrWhiteSpace(m3PACN))
				throw new ArgumentNullException(nameof(m3PACN));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SUDO", m3SUDO.Trim())
				.WithQueryParameter("DNDT", m3DNDT.ToM3String())
				.WithQueryParameter("PACN", m3PACN.Trim());

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
		/// Name DltHead
		/// Description Delete Delivery Note Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SUTY">Supplier type (Required)</param>
		/// <param name="m3SUDO">Delivery note number (Required)</param>
		/// <param name="m3DNDT">Delivery note date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltHead(
			string m3WHLO, 
			string m3SUNO, 
			int m3SUTY, 
			string m3SUDO, 
			DateTime m3DNDT, 
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
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SUDO))
				throw new ArgumentNullException(nameof(m3SUDO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SUTY", m3SUTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SUDO", m3SUDO.Trim())
				.WithQueryParameter("DNDT", m3DNDT.ToM3String());

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
		/// Name GetDetail
		/// Description Gets a Delivery note package detail record (PFTRNS)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SUTY">Supplier type (Required)</param>
		/// <param name="m3SUDO">Delivery note number (Required)</param>
		/// <param name="m3PACN">Package number (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3RIDL">Order line (Required)</param>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3BANO">Lot number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDetailResponse></returns>
		/// <exception cref="M3Exception<GetDetailResponse>"></exception>
		public async Task<M3Response<GetDetailResponse>> GetDetail(
			string m3WHLO, 
			string m3SUNO, 
			int m3SUTY, 
			string m3SUDO, 
			string m3PACN, 
			string m3ITNO, 
			string m3RIDN, 
			int m3RIDL, 
			string m3AGNB, 
			string m3BANO, 
			int? m3CONO = null, 
			DateTime? m3DNDT = null, 
			int? m3RIDX = null, 
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
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SUDO))
				throw new ArgumentNullException(nameof(m3SUDO));
			if (string.IsNullOrWhiteSpace(m3PACN))
				throw new ArgumentNullException(nameof(m3PACN));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));
			if (string.IsNullOrWhiteSpace(m3BANO))
				throw new ArgumentNullException(nameof(m3BANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SUTY", m3SUTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SUDO", m3SUDO.Trim())
				.WithQueryParameter("PACN", m3PACN.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("RIDN", m3RIDN.Trim())
				.WithQueryParameter("RIDL", m3RIDL.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("BANO", m3BANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetDetailResponse>(
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
		/// Name GetHead
		/// Description Gets a Delivery note head record (PDNHEA)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SUTY">Supplier type (Required)</param>
		/// <param name="m3SUDO">Delivery note number (Required)</param>
		/// <param name="m3DNDT">Delivery note date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadResponse></returns>
		/// <exception cref="M3Exception<GetHeadResponse>"></exception>
		public async Task<M3Response<GetHeadResponse>> GetHead(
			string m3WHLO, 
			string m3SUNO, 
			int m3SUTY, 
			string m3SUDO, 
			DateTime m3DNDT, 
			int? m3CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SUDO))
				throw new ArgumentNullException(nameof(m3SUDO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SUTY", m3SUTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SUDO", m3SUDO.Trim())
				.WithQueryParameter("DNDT", m3DNDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetHeadResponse>(
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
		/// Name GetPackage
		/// Description Gets a Delivery note package record (PPTRNS)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SUTY">Supplier type (Required)</param>
		/// <param name="m3SUDO">Delivery note number (Required)</param>
		/// <param name="m3DNDT">Delivery note date (Required)</param>
		/// <param name="m3PACN">Package number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPackageResponse></returns>
		/// <exception cref="M3Exception<GetPackageResponse>"></exception>
		public async Task<M3Response<GetPackageResponse>> GetPackage(
			string m3WHLO, 
			string m3SUNO, 
			int m3SUTY, 
			string m3SUDO, 
			DateTime m3DNDT, 
			string m3PACN, 
			int? m3CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SUDO))
				throw new ArgumentNullException(nameof(m3SUDO));
			if (string.IsNullOrWhiteSpace(m3PACN))
				throw new ArgumentNullException(nameof(m3PACN));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SUTY", m3SUTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SUDO", m3SUDO.Trim())
				.WithQueryParameter("DNDT", m3DNDT.ToM3String())
				.WithQueryParameter("PACN", m3PACN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetPackageResponse>(
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
		/// Name LstDetail
		/// Description List Delivey notes package details  (PFTRNS, 00)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SUTY">Supplier type (Required)</param>
		/// <param name="m3SUDO">Delivery note number (Required)</param>
		/// <param name="m3DNDT">Delivery note date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDetailResponse></returns>
		/// <exception cref="M3Exception<LstDetailResponse>"></exception>
		public async Task<M3Response<LstDetailResponse>> LstDetail(
			string m3WHLO, 
			string m3SUNO, 
			int m3SUTY, 
			string m3SUDO, 
			DateTime m3DNDT, 
			int? m3CONO = null, 
			string m3PACN = null, 
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
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SUDO))
				throw new ArgumentNullException(nameof(m3SUDO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SUTY", m3SUTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SUDO", m3SUDO.Trim())
				.WithQueryParameter("DNDT", m3DNDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());

			// Execute the request
			var result = await Execute<LstDetailResponse>(
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
		/// Name LstDetailByPack
		/// Description List Delivey notes package details  (PFTRNS, 00)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PACN">Package number (Required)</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstDetailByPackResponse></returns>
		/// <exception cref="M3Exception<LstDetailByPackResponse>"></exception>
		public async Task<M3Response<LstDetailByPackResponse>> LstDetailByPack(
			string m3PACN, 
			string m3WHLO = null, 
			string m3SUNO = null, 
			string m3SUDO = null, 
			DateTime? m3DNDT = null, 
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
			if (string.IsNullOrWhiteSpace(m3PACN))
				throw new ArgumentNullException(nameof(m3PACN));

			// Set mandatory parameters
			request
				.WithQueryParameter("PACN", m3PACN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstDetailByPackResponse>(
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
		/// Name LstHeadByPack
		/// Description List Delivery notes per package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="m3FRDT">From date</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="m3FRSL">From - Lowest status</param>
		/// <param name="m3TOSL">To - Lowest status</param>
		/// <param name="m3FRST">From - Highest status</param>
		/// <param name="m3TOST">To - Highest status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadByPackResponse></returns>
		/// <exception cref="M3Exception<LstHeadByPackResponse>"></exception>
		public async Task<M3Response<LstHeadByPackResponse>> LstHeadByPack(
			string m3PACN = null, 
			string m3WHLO = null, 
			string m3SUNO = null, 
			string m3SUDO = null, 
			DateTime? m3DNDT = null, 
			DateTime? m3FRDT = null, 
			DateTime? m3TODT = null, 
			string m3FRSL = null, 
			string m3TOSL = null, 
			string m3FRST = null, 
			string m3TOST = null, 
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
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());
			if (m3FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3FRDT.Value.ToM3String());
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3FRSL))
				request.WithQueryParameter("FRSL", m3FRSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOSL))
				request.WithQueryParameter("TOSL", m3TOSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRST))
				request.WithQueryParameter("FRST", m3FRST.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOST))
				request.WithQueryParameter("TOST", m3TOST.Trim());

			// Execute the request
			var result = await Execute<LstHeadByPackResponse>(
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
		/// Name LstHeadBySts
		/// Description List Delivery notes per status
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3FRSL">From - Lowest status (Required)</param>
		/// <param name="m3TOSL">To - Lowest status (Required)</param>
		/// <param name="m3FRST">From - Highest status (Required)</param>
		/// <param name="m3TOST">To - Highest status (Required)</param>
		/// <param name="m3FRDT">From date</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadByStsResponse></returns>
		/// <exception cref="M3Exception<LstHeadByStsResponse>"></exception>
		public async Task<M3Response<LstHeadByStsResponse>> LstHeadBySts(
			string m3WHLO, 
			string m3FRSL, 
			string m3TOSL, 
			string m3FRST, 
			string m3TOST, 
			DateTime? m3FRDT = null, 
			DateTime? m3TODT = null, 
			string m3SUNO = null, 
			string m3SUDO = null, 
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
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3FRSL))
				throw new ArgumentNullException(nameof(m3FRSL));
			if (string.IsNullOrWhiteSpace(m3TOSL))
				throw new ArgumentNullException(nameof(m3TOSL));
			if (string.IsNullOrWhiteSpace(m3FRST))
				throw new ArgumentNullException(nameof(m3FRST));
			if (string.IsNullOrWhiteSpace(m3TOST))
				throw new ArgumentNullException(nameof(m3TOST));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("FRSL", m3FRSL.Trim())
				.WithQueryParameter("TOSL", m3TOSL.Trim())
				.WithQueryParameter("FRST", m3FRST.Trim())
				.WithQueryParameter("TOST", m3TOST.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3FRDT.HasValue)
				request.WithQueryParameter("FRDT", m3FRDT.Value.ToM3String());
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());

			// Execute the request
			var result = await Execute<LstHeadByStsResponse>(
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
		/// Name LstHeadBySup
		/// Description List Delivery note head by supplier (PDNHEA, 00)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SUTY">Supplier type</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="m3MLTS">Select display for supplier</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadBySupResponse></returns>
		/// <exception cref="M3Exception<LstHeadBySupResponse>"></exception>
		public async Task<M3Response<LstHeadBySupResponse>> LstHeadBySup(
			string m3WHLO, 
			int? m3CONO = null, 
			string m3SUNO = null, 
			int? m3SUTY = null, 
			string m3SUDO = null, 
			DateTime? m3DNDT = null, 
			int? m3MLTS = null, 
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
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3SUTY.HasValue)
				request.WithQueryParameter("SUTY", m3SUTY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());
			if (m3MLTS.HasValue)
				request.WithQueryParameter("MLTS", m3MLTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstHeadBySupResponse>(
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
		/// Name LstPackage
		/// Description List Delivey notes package  (PPTRNS, 00)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SUTY">Supplier type (Required)</param>
		/// <param name="m3SUDO">Delivery note number (Required)</param>
		/// <param name="m3DNDT">Delivery note date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPackageResponse></returns>
		/// <exception cref="M3Exception<LstPackageResponse>"></exception>
		public async Task<M3Response<LstPackageResponse>> LstPackage(
			string m3WHLO, 
			string m3SUNO, 
			int m3SUTY, 
			string m3SUDO, 
			DateTime m3DNDT, 
			int? m3CONO = null, 
			string m3PACN = null, 
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
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SUDO))
				throw new ArgumentNullException(nameof(m3SUDO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SUTY", m3SUTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SUDO", m3SUDO.Trim())
				.WithQueryParameter("DNDT", m3DNDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());

			// Execute the request
			var result = await Execute<LstPackageResponse>(
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
		/// Name LstPackageBySts
		/// Description List package by status
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="m3PACO">Package level</param>
		/// <param name="m3STS1">List advised packages</param>
		/// <param name="m3STS2">List notified packages</param>
		/// <param name="m3STS3">List staged packages</param>
		/// <param name="m3STS4">List goods received packages</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPackageByStsResponse></returns>
		/// <exception cref="M3Exception<LstPackageByStsResponse>"></exception>
		public async Task<M3Response<LstPackageByStsResponse>> LstPackageBySts(
			string m3PACN = null, 
			string m3WHLO = null, 
			string m3SUNO = null, 
			string m3SUDO = null, 
			DateTime? m3DNDT = null, 
			int? m3PACO = null, 
			int? m3STS1 = null, 
			int? m3STS2 = null, 
			int? m3STS3 = null, 
			int? m3STS4 = null, 
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
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());
			if (m3PACO.HasValue)
				request.WithQueryParameter("PACO", m3PACO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STS1.HasValue)
				request.WithQueryParameter("STS1", m3STS1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STS2.HasValue)
				request.WithQueryParameter("STS2", m3STS2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STS3.HasValue)
				request.WithQueryParameter("STS3", m3STS3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STS4.HasValue)
				request.WithQueryParameter("STS4", m3STS4.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPackageByStsResponse>(
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
		/// Name LstSSCCBySts
		/// Description List package by status with SSCC as input
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SSCC">SSCC number (Required)</param>
		/// <param name="m3PACO">Package level</param>
		/// <param name="m3STS1">List advised packages</param>
		/// <param name="m3STS2">List notified packages</param>
		/// <param name="m3STS3">List staged packages</param>
		/// <param name="m3STS4">List goods received packages</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSSCCByStsResponse></returns>
		/// <exception cref="M3Exception<LstSSCCByStsResponse>"></exception>
		public async Task<M3Response<LstSSCCByStsResponse>> LstSSCCBySts(
			string m3SSCC, 
			int? m3PACO = null, 
			int? m3STS1 = null, 
			int? m3STS2 = null, 
			int? m3STS3 = null, 
			int? m3STS4 = null, 
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
			if (string.IsNullOrWhiteSpace(m3SSCC))
				throw new ArgumentNullException(nameof(m3SSCC));

			// Set mandatory parameters
			request
				.WithQueryParameter("SSCC", m3SSCC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3PACO.HasValue)
				request.WithQueryParameter("PACO", m3PACO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STS1.HasValue)
				request.WithQueryParameter("STS1", m3STS1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STS2.HasValue)
				request.WithQueryParameter("STS2", m3STS2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STS3.HasValue)
				request.WithQueryParameter("STS3", m3STS3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3STS4.HasValue)
				request.WithQueryParameter("STS4", m3STS4.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstSSCCByStsResponse>(
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
		/// Name NotifyPackage
		/// Description Notify a package (PPTRNS)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SUTY">Supplier type (Required)</param>
		/// <param name="m3SUDO">Delivery note number (Required)</param>
		/// <param name="m3DNDT">Delivery note date (Required)</param>
		/// <param name="m3PACN">Package number (Required)</param>
		/// <param name="m3DLDT">Planned delivery date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> NotifyPackage(
			string m3WHLO, 
			string m3SUNO, 
			int m3SUTY, 
			string m3SUDO, 
			DateTime m3DNDT, 
			string m3PACN, 
			DateTime m3DLDT, 
			int? m3CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SUDO))
				throw new ArgumentNullException(nameof(m3SUDO));
			if (string.IsNullOrWhiteSpace(m3PACN))
				throw new ArgumentNullException(nameof(m3PACN));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SUTY", m3SUTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SUDO", m3SUDO.Trim())
				.WithQueryParameter("DNDT", m3DNDT.ToM3String())
				.WithQueryParameter("PACN", m3PACN.Trim())
				.WithQueryParameter("DLDT", m3DLDT.ToM3String());

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
		/// Name ReceiveHead
		/// Description Goods receive on delivery note header level (PDNHEA)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SUTY">Supplier type (Required)</param>
		/// <param name="m3SUDO">Delivery note number (Required)</param>
		/// <param name="m3DNDT">Delivery note date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ReceiveHead(
			string m3WHLO, 
			string m3SUNO, 
			int m3SUTY, 
			string m3SUDO, 
			DateTime m3DNDT, 
			int? m3CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SUDO))
				throw new ArgumentNullException(nameof(m3SUDO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SUTY", m3SUTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SUDO", m3SUDO.Trim())
				.WithQueryParameter("DNDT", m3DNDT.ToM3String());

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
		/// Name RevTransNotHead
		/// Description Transaction for reversing a complete transport notification
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SUDO">Delivery note number (Required)</param>
		/// <param name="m3DNDT">Delivery note date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> RevTransNotHead(
			string m3WHLO, 
			string m3SUNO, 
			string m3SUDO, 
			DateTime m3DNDT, 
			int? m3CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SUDO))
				throw new ArgumentNullException(nameof(m3SUDO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SUDO", m3SUDO.Trim())
				.WithQueryParameter("DNDT", m3DNDT.ToM3String());

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
		/// Name StagePackage
		/// Description Staging packages before goods receipt
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<StagePackageResponse></returns>
		/// <exception cref="M3Exception<StagePackageResponse>"></exception>
		public async Task<M3Response<StagePackageResponse>> StagePackage(
			string m3PACN = null, 
			string m3WHLO = null, 
			string m3SUNO = null, 
			string m3SUDO = null, 
			DateTime? m3DNDT = null, 
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
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<StagePackageResponse>(
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
		/// Name StageSSCC
		/// Description Staging package by SSCC number before goods receipt
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SSCC">SSCC number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<StageSSCCResponse></returns>
		/// <exception cref="M3Exception<StageSSCCResponse>"></exception>
		public async Task<M3Response<StageSSCCResponse>> StageSSCC(
			string m3SSCC, 
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
			if (string.IsNullOrWhiteSpace(m3SSCC))
				throw new ArgumentNullException(nameof(m3SSCC));

			// Set mandatory parameters
			request
				.WithQueryParameter("SSCC", m3SSCC.Trim());

			// Execute the request
			var result = await Execute<StageSSCCResponse>(
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
		/// Name TransNotifyHead
		/// Description Updates a transport notification  (PDNHEA)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="m3E0B4">Transport identity - departure</param>
		/// <param name="m3E0BH">Trailer registration number</param>
		/// <param name="m3BOLN">Bill of lading</param>
		/// <param name="m3FWRF">Forwarding agent reference</param>
		/// <param name="m3SHD4">Planned pickup date</param>
		/// <param name="m3ARDT">Arrival date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> TransNotifyHead(
			int? m3CONO = null, 
			string m3WHLO = null, 
			string m3SUNO = null, 
			string m3SUDO = null, 
			DateTime? m3DNDT = null, 
			string m3E0B4 = null, 
			string m3E0BH = null, 
			string m3BOLN = null, 
			string m3FWRF = null, 
			DateTime? m3SHD4 = null, 
			DateTime? m3ARDT = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3E0B4))
				request.WithQueryParameter("E0B4", m3E0B4.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0BH))
				request.WithQueryParameter("E0BH", m3E0BH.Trim());
			if (!string.IsNullOrWhiteSpace(m3BOLN))
				request.WithQueryParameter("BOLN", m3BOLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWRF))
				request.WithQueryParameter("FWRF", m3FWRF.Trim());
			if (m3SHD4.HasValue)
				request.WithQueryParameter("SHD4", m3SHD4.Value.ToM3String());
			if (m3ARDT.HasValue)
				request.WithQueryParameter("ARDT", m3ARDT.Value.ToM3String());

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
		/// Name UpdHead
		/// Description Updates a Delivery note head record (PDNHEA)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SUTY">Supplier type (Required)</param>
		/// <param name="m3SUDO">Delivery note number (Required)</param>
		/// <param name="m3DNDT">Delivery note date (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3E0PA">Partner</param>
		/// <param name="m3E0QA">Code list qualifier</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3E0B4">Transport identity - departure</param>
		/// <param name="m3E0BH">Trailer registration number</param>
		/// <param name="m3E0B5">Transport nationality - departure</param>
		/// <param name="m3TEDL">Delivery terms</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3TFNO">Facsimile transmission number</param>
		/// <param name="m3VRNO">VAT registration number</param>
		/// <param name="m3DPNR">Delivery schedule</param>
		/// <param name="m3RSAG">Delivery contract number</param>
		/// <param name="m3SORN">Supplier order number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3CFK1">User-defined field 1 - import tracking</param>
		/// <param name="m3CFK2">User-defined field 2 - import tracking</param>
		/// <param name="m3CFK3">User-defined field 3 - import tracking</param>
		/// <param name="m3CFK4">User-defined field 4 - import tracking</param>
		/// <param name="m3CFK5">User-defined field 5 - import tracking</param>
		/// <param name="m3CFK6">User-defined date 1 - import tracking</param>
		/// <param name="m3CFK7">User-defined date 2 - import tracking</param>
		/// <param name="m3CFK8">User-defined date 3 - import tracking</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdHead(
			string m3WHLO, 
			string m3SUNO, 
			int m3SUTY, 
			string m3SUDO, 
			DateTime m3DNDT, 
			int? m3CONO = null, 
			string m3ADID = null, 
			string m3E0PA = null, 
			string m3E0QA = null, 
			string m3MODL = null, 
			string m3E0B4 = null, 
			string m3E0BH = null, 
			string m3E0B5 = null, 
			string m3TEDL = null, 
			string m3YREF = null, 
			string m3TFNO = null, 
			string m3VRNO = null, 
			string m3DPNR = null, 
			string m3RSAG = null, 
			string m3SORN = null, 
			string m3RESP = null, 
			string m3CFK1 = null, 
			string m3CFK2 = null, 
			string m3CFK3 = null, 
			string m3CFK4 = null, 
			string m3CFK5 = null, 
			DateTime? m3CFK6 = null, 
			DateTime? m3CFK7 = null, 
			DateTime? m3CFK8 = null, 
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
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SUDO))
				throw new ArgumentNullException(nameof(m3SUDO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SUTY", m3SUTY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SUDO", m3SUDO.Trim())
				.WithQueryParameter("DNDT", m3DNDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0PA))
				request.WithQueryParameter("E0PA", m3E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0QA))
				request.WithQueryParameter("E0QA", m3E0QA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0B4))
				request.WithQueryParameter("E0B4", m3E0B4.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0BH))
				request.WithQueryParameter("E0BH", m3E0BH.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0B5))
				request.WithQueryParameter("E0B5", m3E0B5.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRNO))
				request.WithQueryParameter("VRNO", m3VRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DPNR))
				request.WithQueryParameter("DPNR", m3DPNR.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSAG))
				request.WithQueryParameter("RSAG", m3RSAG.Trim());
			if (!string.IsNullOrWhiteSpace(m3SORN))
				request.WithQueryParameter("SORN", m3SORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFK1))
				request.WithQueryParameter("CFK1", m3CFK1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFK2))
				request.WithQueryParameter("CFK2", m3CFK2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFK3))
				request.WithQueryParameter("CFK3", m3CFK3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFK4))
				request.WithQueryParameter("CFK4", m3CFK4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFK5))
				request.WithQueryParameter("CFK5", m3CFK5.Trim());
			if (m3CFK6.HasValue)
				request.WithQueryParameter("CFK6", m3CFK6.Value.ToM3String());
			if (m3CFK7.HasValue)
				request.WithQueryParameter("CFK7", m3CFK7.Value.ToM3String());
			if (m3CFK8.HasValue)
				request.WithQueryParameter("CFK8", m3CFK8.Value.ToM3String());

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
