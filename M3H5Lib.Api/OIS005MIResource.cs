/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_TEDS">Description 1</param>
		/// <param name="m3_RCOP">Reasonability check method</param>
		/// <param name="m3_D2QT">Minimum quantity</param>
		/// <param name="m3_D3QT">Maximum quantity</param>
		/// <param name="m3_ADCU">Expiration time adjustment - days</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="m3_DGDS">Dangerous goods indicator</param>
		/// <param name="m3_MTHC">Material handling code</param>
		/// <param name="m3_PIPA">Pilot part</param>
		/// <param name="m3_RSEC">Partner´s engineering change order no</param>
		/// <param name="m3_RSED">Engineering change order date</param>
		/// <param name="m3_RSRN">Partner design revision number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_SMCD">Salesperson</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_CFIN">Configuration number</param>
		/// <param name="m3_SRMT">Strict rotation method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_ITNO, 
			string m3_CUNO = null, 
			string m3_POPN = null, 
			string m3_ITDS = null, 
			string m3_TEDS = null, 
			int? m3_RCOP = null, 
			decimal? m3_D2QT = null, 
			decimal? m3_D3QT = null, 
			int? m3_ADCU = null, 
			string m3_ALUN = null, 
			int? m3_DGDS = null, 
			string m3_MTHC = null, 
			int? m3_PIPA = null, 
			string m3_RSEC = null, 
			DateTime? m3_RSED = null, 
			string m3_RSRN = null, 
			string m3_RESP = null, 
			string m3_SMCD = null, 
			DateTime? m3_FDAT = null, 
			DateTime? m3_TDAT = null, 
			long? m3_CFIN = null, 
			int? m3_SRMT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDS))
				request.WithQueryParameter("TEDS", m3_TEDS.Trim());
			if (m3_RCOP.HasValue)
				request.WithQueryParameter("RCOP", m3_RCOP.Value.ToString());
			if (m3_D2QT.HasValue)
				request.WithQueryParameter("D2QT", m3_D2QT.Value.ToString());
			if (m3_D3QT.HasValue)
				request.WithQueryParameter("D3QT", m3_D3QT.Value.ToString());
			if (m3_ADCU.HasValue)
				request.WithQueryParameter("ADCU", m3_ADCU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());
			if (m3_DGDS.HasValue)
				request.WithQueryParameter("DGDS", m3_DGDS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MTHC))
				request.WithQueryParameter("MTHC", m3_MTHC.Trim());
			if (m3_PIPA.HasValue)
				request.WithQueryParameter("PIPA", m3_PIPA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSEC))
				request.WithQueryParameter("RSEC", m3_RSEC.Trim());
			if (m3_RSED.HasValue)
				request.WithQueryParameter("RSED", m3_RSED.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_RSRN))
				request.WithQueryParameter("RSRN", m3_RSRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());
			if (m3_CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3_CFIN.Value.ToString());
			if (m3_SRMT.HasValue)
				request.WithQueryParameter("SRMT", m3_SRMT.Value.ToString());

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
		/// Name Del
		/// Description Delete Item per Customer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			string m3_ITNO, 
			string m3_CUNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());

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
		/// Name Get
		/// Description Get Item per Customer record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_ITNO, 
			string m3_CUNO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name List
		/// Description List Items/Customer in customer order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3_CUNO = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Execute the request
			var result = await Execute<ListResponse>(
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
		/// Name LstByItem
		/// Description List in item order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByItemResponse></returns>
		/// <exception cref="M3Exception<LstByItemResponse>"></exception>
		public async Task<M3Response<LstByItemResponse>> LstByItem(
			string m3_ITNO = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<LstByItemResponse>(
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
		/// Name LstByPopNo
		/// Description List in popular number order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByPopNoResponse></returns>
		/// <exception cref="M3Exception<LstByPopNoResponse>"></exception>
		public async Task<M3Response<LstByPopNoResponse>> LstByPopNo(
			string m3_POPN = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());

			// Execute the request
			var result = await Execute<LstByPopNoResponse>(
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
		/// Name Upd
		/// Description Update Customer Alias
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_TEDS">Description 1</param>
		/// <param name="m3_RCOP">Reasonability check method</param>
		/// <param name="m3_D2QT">Minimum quantity</param>
		/// <param name="m3_D3QT">Maximum quantity</param>
		/// <param name="m3_ADCU">Expiration time adjustment - days</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="m3_DGDS">Dangerous goods indicator</param>
		/// <param name="m3_MTHC">Material handling code</param>
		/// <param name="m3_PIPA">Pilot part</param>
		/// <param name="m3_RSEC">Partners engineering change order no</param>
		/// <param name="m3_RSED">Engineering change order date</param>
		/// <param name="m3_RSRN">Partner design revision number</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_SMCD">Salesperson</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_CFIN">Configuration number</param>
		/// <param name="m3_SRMT">Strict rotation method</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3_ITNO, 
			string m3_CUNO = null, 
			string m3_POPN = null, 
			string m3_ITDS = null, 
			string m3_TEDS = null, 
			int? m3_RCOP = null, 
			decimal? m3_D2QT = null, 
			decimal? m3_D3QT = null, 
			int? m3_ADCU = null, 
			string m3_ALUN = null, 
			int? m3_DGDS = null, 
			string m3_MTHC = null, 
			int? m3_PIPA = null, 
			string m3_RSEC = null, 
			DateTime? m3_RSED = null, 
			string m3_RSRN = null, 
			string m3_RESP = null, 
			string m3_SMCD = null, 
			DateTime? m3_FDAT = null, 
			DateTime? m3_TDAT = null, 
			long? m3_CFIN = null, 
			int? m3_SRMT = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDS))
				request.WithQueryParameter("TEDS", m3_TEDS.Trim());
			if (m3_RCOP.HasValue)
				request.WithQueryParameter("RCOP", m3_RCOP.Value.ToString());
			if (m3_D2QT.HasValue)
				request.WithQueryParameter("D2QT", m3_D2QT.Value.ToString());
			if (m3_D3QT.HasValue)
				request.WithQueryParameter("D3QT", m3_D3QT.Value.ToString());
			if (m3_ADCU.HasValue)
				request.WithQueryParameter("ADCU", m3_ADCU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());
			if (m3_DGDS.HasValue)
				request.WithQueryParameter("DGDS", m3_DGDS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MTHC))
				request.WithQueryParameter("MTHC", m3_MTHC.Trim());
			if (m3_PIPA.HasValue)
				request.WithQueryParameter("PIPA", m3_PIPA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSEC))
				request.WithQueryParameter("RSEC", m3_RSEC.Trim());
			if (m3_RSED.HasValue)
				request.WithQueryParameter("RSED", m3_RSED.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_RSRN))
				request.WithQueryParameter("RSRN", m3_RSRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());
			if (m3_CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3_CFIN.Value.ToString());
			if (m3_SRMT.HasValue)
				request.WithQueryParameter("SRMT", m3_SRMT.Value.ToString());

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
