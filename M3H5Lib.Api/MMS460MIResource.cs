/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.MMS460MI;
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
	/// Name: MMS460MI
	/// Component Name: Packages
	/// Description: Package Definitions
	/// Version Release: 14.x
	///</summary>
	public partial class MMS460MIResource : M3BaseResourceEndpoint
	{
		public MMS460MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS460MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddKitPackDef
		/// Description Add Kit Package Definition
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PPNB">Pre-pack number</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddKitPackDefResponse></returns>
		/// <exception cref="M3Exception<AddKitPackDefResponse>"></exception>
		public async Task<M3Response<AddKitPackDefResponse>> AddKitPackDef(
			string m3FACI, 
			string m3PPNB = null, 
			string m3PRNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddKitPackDef",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PPNB))
				request.WithQueryParameter("PPNB", m3PPNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());

			// Execute the request
			var result = await Execute<AddKitPackDefResponse>(
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
		/// Name AddPackDefHead
		/// Description Add Package Definition Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PPNB">Pre-pack number (Required)</param>
		/// <param name="m3DSCR">Description</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3PPSA">Pre-pack status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPackDefHead(
			string m3PPNB, 
			string m3DSCR = null, 
			string m3PACT = null, 
			string m3PPSA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPackDefHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PPNB))
				throw new ArgumentNullException(nameof(m3PPNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("PPNB", m3PPNB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DSCR))
				request.WithQueryParameter("DSCR", m3DSCR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PPSA))
				request.WithQueryParameter("PPSA", m3PPSA.Trim());

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
		/// Name AddPackDefLine
		/// Description Add Package Definition Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PPNB">Pre-pack number (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3D1QT">Standard quantity</param>
		/// <param name="m3D2QT">Minimum quantity</param>
		/// <param name="m3D3QT">Maximum quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPackDefLine(
			string m3PPNB, 
			string m3ITNO, 
			decimal? m3TRQT = null, 
			decimal? m3D1QT = null, 
			decimal? m3D2QT = null, 
			decimal? m3D3QT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPackDefLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PPNB))
				throw new ArgumentNullException(nameof(m3PPNB));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PPNB", m3PPNB.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3TRQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3D1QT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D2QT.HasValue)
				request.WithQueryParameter("D2QT", m3D2QT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D3QT.HasValue)
				request.WithQueryParameter("D3QT", m3D3QT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgPackDefHead
		/// Description Change Package Definition Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PPNB">Pre-pack number (Required)</param>
		/// <param name="m3DSCR">Description</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3PPSA">Pre-pack status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgPackDefHead(
			string m3PPNB, 
			string m3DSCR = null, 
			string m3PACT = null, 
			string m3PPSA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgPackDefHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PPNB))
				throw new ArgumentNullException(nameof(m3PPNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("PPNB", m3PPNB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DSCR))
				request.WithQueryParameter("DSCR", m3DSCR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PPSA))
				request.WithQueryParameter("PPSA", m3PPSA.Trim());

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
		/// Name ChgPackDefLine
		/// Description Change Pack Definition Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PPNB">Pre-pack number (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3D1QT">Standard quantity</param>
		/// <param name="m3D2QT">Minimum quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgPackDefLine(
			string m3PPNB, 
			string m3ITNO, 
			decimal? m3TRQT = null, 
			decimal? m3D1QT = null, 
			decimal? m3D2QT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgPackDefLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PPNB))
				throw new ArgumentNullException(nameof(m3PPNB));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PPNB", m3PPNB.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3TRQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3D1QT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D2QT.HasValue)
				request.WithQueryParameter("D2QT", m3D2QT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelPackDef
		/// Description Del Package Definition Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PPNB">Pre-pack number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelPackDef(
			string m3PPNB, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelPackDef",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PPNB))
				throw new ArgumentNullException(nameof(m3PPNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("PPNB", m3PPNB.Trim());

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
		/// Name DelPackDefLine
		/// Description Delete Package Definition Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PPNB">Pre-pack number (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelPackDefLine(
			string m3PPNB, 
			string m3ITNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelPackDefLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PPNB))
				throw new ArgumentNullException(nameof(m3PPNB));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PPNB", m3PPNB.Trim())
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
		/// Name GetPackDefHead
		/// Description Get Package Definition Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PPNB">Pre-pack number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPackDefHeadResponse></returns>
		/// <exception cref="M3Exception<GetPackDefHeadResponse>"></exception>
		public async Task<M3Response<GetPackDefHeadResponse>> GetPackDefHead(
			string m3PPNB, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPackDefHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PPNB))
				throw new ArgumentNullException(nameof(m3PPNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("PPNB", m3PPNB.Trim());

			// Execute the request
			var result = await Execute<GetPackDefHeadResponse>(
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
		/// Name LstPackDefLine
		/// Description List Package Definition Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PPNB">Pre-pack number (Required)</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPackDefLineResponse></returns>
		/// <exception cref="M3Exception<LstPackDefLineResponse>"></exception>
		public async Task<M3Response<LstPackDefLineResponse>> LstPackDefLine(
			string m3PPNB, 
			string m3ITNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPackDefLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PPNB))
				throw new ArgumentNullException(nameof(m3PPNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("PPNB", m3PPNB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<LstPackDefLineResponse>(
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
