/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS111MI;
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
	/// Name: CRS111MI
	/// Component Name: EmailAddress
	/// Description: E-mail address repository interface
	/// Version Release: 5ea0
	///</summary>
	public partial class CRS111MIResource : M3BaseResourceEndpoint
	{
		public CRS111MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS111MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add e-mail address
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_EMTP">E-mail type (Required)</param>
		/// <param name="m3_EMKY">E-mail key value (Required)</param>
		/// <param name="m3_EMAL">Electronic mail address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_EMTP, 
			string m3_EMKY, 
			string m3_EMAL = null, 
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
			if (string.IsNullOrWhiteSpace(m3_EMTP))
				throw new ArgumentNullException("m3_EMTP");
			if (string.IsNullOrWhiteSpace(m3_EMKY))
				throw new ArgumentNullException("m3_EMKY");

			// Set mandatory parameters
			request
				.WithQueryParameter("EMTP", m3_EMTP.Trim())
				.WithQueryParameter("EMKY", m3_EMKY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EMAL))
				request.WithQueryParameter("EMAL", m3_EMAL.Trim());

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
		/// Name Change
		/// Description Change e-mail address
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_EMTP">E-mail type (Required)</param>
		/// <param name="m3_EMKY">E-mail key value (Required)</param>
		/// <param name="m3_EMAL">Change Electronic mail address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Change(
			string m3_EMTP, 
			string m3_EMKY, 
			string m3_EMAL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Change",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_EMTP))
				throw new ArgumentNullException("m3_EMTP");
			if (string.IsNullOrWhiteSpace(m3_EMKY))
				throw new ArgumentNullException("m3_EMKY");

			// Set mandatory parameters
			request
				.WithQueryParameter("EMTP", m3_EMTP.Trim())
				.WithQueryParameter("EMKY", m3_EMKY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EMAL))
				request.WithQueryParameter("EMAL", m3_EMAL.Trim());

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
		/// Name Delete
		/// Description Delete a specific address
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_EMTP">E-mail type (Required)</param>
		/// <param name="m3_EMKY">E-mail key value (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3_EMTP, 
			string m3_EMKY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Delete",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_EMTP))
				throw new ArgumentNullException("m3_EMTP");
			if (string.IsNullOrWhiteSpace(m3_EMKY))
				throw new ArgumentNullException("m3_EMKY");

			// Set mandatory parameters
			request
				.WithQueryParameter("EMTP", m3_EMTP.Trim())
				.WithQueryParameter("EMKY", m3_EMKY.Trim());

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
		/// Description Get specific address
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_EMTP">E-mail type (Required)</param>
		/// <param name="m3_EMKY">E-mail key value (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_EMTP, 
			string m3_EMKY, 
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
			if (string.IsNullOrWhiteSpace(m3_EMTP))
				throw new ArgumentNullException("m3_EMTP");
			if (string.IsNullOrWhiteSpace(m3_EMKY))
				throw new ArgumentNullException("m3_EMKY");

			// Set mandatory parameters
			request
				.WithQueryParameter("EMTP", m3_EMTP.Trim())
				.WithQueryParameter("EMKY", m3_EMKY.Trim());

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
		/// Description List available adresses
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_EMTP">E-mail type (Required)</param>
		/// <param name="m3_EMKY">E-mail key value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3_EMTP, 
			string m3_EMKY = null, 
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

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_EMTP))
				throw new ArgumentNullException("m3_EMTP");

			// Set mandatory parameters
			request
				.WithQueryParameter("EMTP", m3_EMTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EMKY))
				request.WithQueryParameter("EMKY", m3_EMKY.Trim());

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
		/// Name LstCustomers
		/// Description List customers
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCustomersResponse></returns>
		/// <exception cref="M3Exception<LstCustomersResponse>"></exception>
		public async Task<M3Response<LstCustomersResponse>> LstCustomers(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCustomers",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Execute the request
			var result = await Execute<LstCustomersResponse>(
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
		/// Name LstEmployees
		/// Description List Employees
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstEmployeesResponse></returns>
		/// <exception cref="M3Exception<LstEmployeesResponse>"></exception>
		public async Task<M3Response<LstEmployeesResponse>> LstEmployees(
			string m3_EMNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstEmployees",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());

			// Execute the request
			var result = await Execute<LstEmployeesResponse>(
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
		/// Name LstSuppliers
		/// Description List suppliers
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company number</param>
		/// <param name="m3_FRSU">From Supplier</param>
		/// <param name="m3_TOSU">To Supplier</param>
		/// <param name="m3_LMTS">Last import´s timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSuppliersResponse></returns>
		/// <exception cref="M3Exception<LstSuppliersResponse>"></exception>
		public async Task<M3Response<LstSuppliersResponse>> LstSuppliers(
			int? m3_CONO = null, 
			string m3_FRSU = null, 
			string m3_TOSU = null, 
			decimal? m3_LMTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSuppliers",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FRSU))
				request.WithQueryParameter("FRSU", m3_FRSU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOSU))
				request.WithQueryParameter("TOSU", m3_TOSU.Trim());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstSuppliersResponse>(
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
		/// Name SelUsers
		/// Description List selected users
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FDIV">From Division</param>
		/// <param name="m3_TDIV">To Division</param>
		/// <param name="m3_FRES">From User</param>
		/// <param name="m3_TRES">To User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelUsersResponse></returns>
		/// <exception cref="M3Exception<SelUsersResponse>"></exception>
		public async Task<M3Response<SelUsersResponse>> SelUsers(
			string m3_FDIV = null, 
			string m3_TDIV = null, 
			string m3_FRES = null, 
			string m3_TRES = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelUsers",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FDIV))
				request.WithQueryParameter("FDIV", m3_FDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TDIV))
				request.WithQueryParameter("TDIV", m3_TDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRES))
				request.WithQueryParameter("FRES", m3_FRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRES))
				request.WithQueryParameter("TRES", m3_TRES.Trim());

			// Execute the request
			var result = await Execute<SelUsersResponse>(
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
		/// Name TestMail
		/// Description TestMail
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_EMTP">E-mail type (Required)</param>
		/// <param name="m3_EMKY">E-mail key value (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> TestMail(
			string m3_EMTP, 
			string m3_EMKY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/TestMail",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_EMTP))
				throw new ArgumentNullException("m3_EMTP");
			if (string.IsNullOrWhiteSpace(m3_EMKY))
				throw new ArgumentNullException("m3_EMKY");

			// Set mandatory parameters
			request
				.WithQueryParameter("EMTP", m3_EMTP.Trim())
				.WithQueryParameter("EMKY", m3_EMKY.Trim());

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
