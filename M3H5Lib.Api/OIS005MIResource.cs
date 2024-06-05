/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.OIS005MI;
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
	/// Name: OIS005MI
	/// Component Name: ItemCustomer
	/// Description: Api: Item / Customer
	/// Version Release: 5ea0
	///</summary>
	public partial class OIS005MIResource : M3BaseResourceEndpoint
	{
		public OIS005MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS005MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add Item per Customer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3TEDS">Description 1</param>
		/// <param name="m3RCOP">Reasonability check method</param>
		/// <param name="m3D2QT">Minimum quantity</param>
		/// <param name="m3D3QT">Maximum quantity</param>
		/// <param name="m3ADCU">Expiration time adjustment - days</param>
		/// <param name="m3ALUN">Alternate U/M</param>
		/// <param name="m3DGDS">Dangerous goods indicator</param>
		/// <param name="m3MTHC">Material handling code</param>
		/// <param name="m3PIPA">Pilot part</param>
		/// <param name="m3RSEC">Partner´s engineering change order no</param>
		/// <param name="m3RSED">Engineering change order date</param>
		/// <param name="m3RSRN">Partner design revision number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3SMCD">Salesperson</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3CFIN">Configuration number</param>
		/// <param name="m3SRMT">Strict rotation method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3ITNO, 
			string m3CUNO = null, 
			string m3POPN = null, 
			string m3ITDS = null, 
			string m3TEDS = null, 
			int? m3RCOP = null, 
			decimal? m3D2QT = null, 
			decimal? m3D3QT = null, 
			int? m3ADCU = null, 
			string m3ALUN = null, 
			int? m3DGDS = null, 
			string m3MTHC = null, 
			int? m3PIPA = null, 
			string m3RSEC = null, 
			DateTime? m3RSED = null, 
			string m3RSRN = null, 
			string m3RESP = null, 
			string m3SMCD = null, 
			DateTime? m3FDAT = null, 
			DateTime? m3TDAT = null, 
			long? m3CFIN = null, 
			int? m3SRMT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDS))
				request.WithQueryParameter("TEDS", m3TEDS.Trim());
			if (m3RCOP.HasValue)
				request.WithQueryParameter("RCOP", m3RCOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D2QT.HasValue)
				request.WithQueryParameter("D2QT", m3D2QT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D3QT.HasValue)
				request.WithQueryParameter("D3QT", m3D3QT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADCU.HasValue)
				request.WithQueryParameter("ADCU", m3ADCU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALUN))
				request.WithQueryParameter("ALUN", m3ALUN.Trim());
			if (m3DGDS.HasValue)
				request.WithQueryParameter("DGDS", m3DGDS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MTHC))
				request.WithQueryParameter("MTHC", m3MTHC.Trim());
			if (m3PIPA.HasValue)
				request.WithQueryParameter("PIPA", m3PIPA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RSEC))
				request.WithQueryParameter("RSEC", m3RSEC.Trim());
			if (m3RSED.HasValue)
				request.WithQueryParameter("RSED", m3RSED.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3RSRN))
				request.WithQueryParameter("RSRN", m3RSRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCD))
				request.WithQueryParameter("SMCD", m3SMCD.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());
			if (m3CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3CFIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SRMT.HasValue)
				request.WithQueryParameter("SRMT", m3SRMT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Del
		/// Description Delete Item per Customer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			string m3ITNO, 
			string m3CUNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Del",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());

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
		/// Name Get
		/// Description Get Item per Customer record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3ITNO, 
			string m3CUNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name List
		/// Description List Items/Customer in customer order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3CUNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/List",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Execute the request
			var result = await Execute<ListResponse>(
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
		/// Name LstByItem
		/// Description List in item order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByItemResponse></returns>
		/// <exception cref="M3Exception<LstByItemResponse>"></exception>
		public async Task<M3Response<LstByItemResponse>> LstByItem(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByItem",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<LstByItemResponse>(
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
		/// Name LstByPopNo
		/// Description List in popular number order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByPopNoResponse></returns>
		/// <exception cref="M3Exception<LstByPopNoResponse>"></exception>
		public async Task<M3Response<LstByPopNoResponse>> LstByPopNo(
			string m3POPN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByPopNo",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());

			// Execute the request
			var result = await Execute<LstByPopNoResponse>(
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
		/// Name Upd
		/// Description Update Customer Alias
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3TEDS">Description 1</param>
		/// <param name="m3RCOP">Reasonability check method</param>
		/// <param name="m3D2QT">Minimum quantity</param>
		/// <param name="m3D3QT">Maximum quantity</param>
		/// <param name="m3ADCU">Expiration time adjustment - days</param>
		/// <param name="m3ALUN">Alternate U/M</param>
		/// <param name="m3DGDS">Dangerous goods indicator</param>
		/// <param name="m3MTHC">Material handling code</param>
		/// <param name="m3PIPA">Pilot part</param>
		/// <param name="m3RSEC">Partners engineering change order no</param>
		/// <param name="m3RSED">Engineering change order date</param>
		/// <param name="m3RSRN">Partner design revision number</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3SMCD">Salesperson</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3CFIN">Configuration number</param>
		/// <param name="m3SRMT">Strict rotation method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3ITNO, 
			string m3CUNO = null, 
			string m3POPN = null, 
			string m3ITDS = null, 
			string m3TEDS = null, 
			int? m3RCOP = null, 
			decimal? m3D2QT = null, 
			decimal? m3D3QT = null, 
			int? m3ADCU = null, 
			string m3ALUN = null, 
			int? m3DGDS = null, 
			string m3MTHC = null, 
			int? m3PIPA = null, 
			string m3RSEC = null, 
			DateTime? m3RSED = null, 
			string m3RSRN = null, 
			string m3RESP = null, 
			string m3SMCD = null, 
			DateTime? m3FDAT = null, 
			DateTime? m3TDAT = null, 
			long? m3CFIN = null, 
			int? m3SRMT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Upd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDS))
				request.WithQueryParameter("TEDS", m3TEDS.Trim());
			if (m3RCOP.HasValue)
				request.WithQueryParameter("RCOP", m3RCOP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D2QT.HasValue)
				request.WithQueryParameter("D2QT", m3D2QT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D3QT.HasValue)
				request.WithQueryParameter("D3QT", m3D3QT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADCU.HasValue)
				request.WithQueryParameter("ADCU", m3ADCU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALUN))
				request.WithQueryParameter("ALUN", m3ALUN.Trim());
			if (m3DGDS.HasValue)
				request.WithQueryParameter("DGDS", m3DGDS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MTHC))
				request.WithQueryParameter("MTHC", m3MTHC.Trim());
			if (m3PIPA.HasValue)
				request.WithQueryParameter("PIPA", m3PIPA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RSEC))
				request.WithQueryParameter("RSEC", m3RSEC.Trim());
			if (m3RSED.HasValue)
				request.WithQueryParameter("RSED", m3RSED.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3RSRN))
				request.WithQueryParameter("RSRN", m3RSRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCD))
				request.WithQueryParameter("SMCD", m3SMCD.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());
			if (m3CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3CFIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SRMT.HasValue)
				request.WithQueryParameter("SRMT", m3SRMT.Value.ToString(CultureInfo.CurrentCulture));

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
