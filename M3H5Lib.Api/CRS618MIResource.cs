/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS618MI;
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
	/// Name: CRS618MI
	/// Component Name: Contact Person
	/// Description: Contact Person
	/// Version Release: 5ea0
	///</summary>
	public partial class CRS618MIResource : M3BaseResourceEndpoint
	{
		public CRS618MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS618MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add Contact Person
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CNPE">Contact (Required)</param>
		/// <param name="m3_STAT">Status (Required)</param>
		/// <param name="m3_TX50">Name (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TITL">Title</param>
		/// <param name="m3_SALU">Salutation</param>
		/// <param name="m3_NAMF">First name</param>
		/// <param name="m3_NAMM">Middle name</param>
		/// <param name="m3_NAMS">Surname</param>
		/// <param name="m3_NAMX">Suffix name</param>
		/// <param name="m3_GEND">Gender</param>
		/// <param name="m3_LHCD">Language</param>
		/// <param name="m3_JTIT">Job title</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_RFTP">Contact type</param>
		/// <param name="m3_ERTP">Employerreferencetype</param>
		/// <param name="m3_EMRE">Employerreference</param>
		/// <param name="m3_EMAL">Electronic mail address</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_PHN2">Telephone number 2</param>
		/// <param name="m3_CUA1">Address line 1</param>
		/// <param name="m3_CUA2">Address line 2</param>
		/// <param name="m3_CUA3">Address line 3</param>
		/// <param name="m3_CUA4">Address line 4</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_PONO">Postal code</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_CESA">Marketing ID - M3 SMS</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddResponse></returns>
		/// <exception cref="M3Exception<AddResponse>"></exception>
		public async Task<M3Response<AddResponse>> Add(
			string m3_CNPE, 
			string m3_STAT, 
			string m3_TX50, 
			string m3_TX40 = null, 
			string m3_TITL = null, 
			string m3_SALU = null, 
			string m3_NAMF = null, 
			string m3_NAMM = null, 
			string m3_NAMS = null, 
			string m3_NAMX = null, 
			int? m3_GEND = null, 
			string m3_LHCD = null, 
			string m3_JTIT = null, 
			string m3_DEPT = null, 
			string m3_RFTP = null, 
			int? m3_ERTP = null, 
			string m3_EMRE = null, 
			string m3_EMAL = null, 
			string m3_PHNO = null, 
			string m3_PHN2 = null, 
			string m3_CUA1 = null, 
			string m3_CUA2 = null, 
			string m3_CUA3 = null, 
			string m3_CUA4 = null, 
			string m3_TOWN = null, 
			string m3_PONO = null, 
			string m3_ECAR = null, 
			string m3_CSCD = null, 
			string m3_CESA = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CNPE))
				throw new ArgumentNullException("m3_CNPE");
			if (string.IsNullOrWhiteSpace(m3_STAT))
				throw new ArgumentNullException("m3_STAT");
			if (string.IsNullOrWhiteSpace(m3_TX50))
				throw new ArgumentNullException("m3_TX50");

			// Set mandatory parameters
			request
				.WithQueryParameter("CNPE", m3_CNPE.Trim())
				.WithQueryParameter("STAT", m3_STAT.Trim())
				.WithQueryParameter("TX50", m3_TX50.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TITL))
				request.WithQueryParameter("TITL", m3_TITL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SALU))
				request.WithQueryParameter("SALU", m3_SALU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NAMF))
				request.WithQueryParameter("NAMF", m3_NAMF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NAMM))
				request.WithQueryParameter("NAMM", m3_NAMM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NAMS))
				request.WithQueryParameter("NAMS", m3_NAMS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NAMX))
				request.WithQueryParameter("NAMX", m3_NAMX.Trim());
			if (m3_GEND.HasValue)
				request.WithQueryParameter("GEND", m3_GEND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LHCD))
				request.WithQueryParameter("LHCD", m3_LHCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_JTIT))
				request.WithQueryParameter("JTIT", m3_JTIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFTP))
				request.WithQueryParameter("RFTP", m3_RFTP.Trim());
			if (m3_ERTP.HasValue)
				request.WithQueryParameter("ERTP", m3_ERTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EMRE))
				request.WithQueryParameter("EMRE", m3_EMRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMAL))
				request.WithQueryParameter("EMAL", m3_EMAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHN2))
				request.WithQueryParameter("PHN2", m3_PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA1))
				request.WithQueryParameter("CUA1", m3_CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA2))
				request.WithQueryParameter("CUA2", m3_CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA3))
				request.WithQueryParameter("CUA3", m3_CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA4))
				request.WithQueryParameter("CUA4", m3_CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CESA))
				request.WithQueryParameter("CESA", m3_CESA.Trim());

			// Execute the request
			var result = await Execute<AddResponse>(
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
		/// Name Dlt
		/// Description Delete Contact Person
		/// Version Release: 15
		/// </summary>
		/// <param name="m3_CNPE">Contact (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Dlt(
			string m3_CNPE, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Dlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CNPE))
				throw new ArgumentNullException("m3_CNPE");

			// Set mandatory parameters
			request
				.WithQueryParameter("CNPE", m3_CNPE.Trim());

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
		/// Description Get Contact Person
		/// Version Release: 15
		/// </summary>
		/// <param name="m3_CNPE">Contact (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_CNPE, 
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
			if (string.IsNullOrWhiteSpace(m3_CNPE))
				throw new ArgumentNullException("m3_CNPE");

			// Set mandatory parameters
			request
				.WithQueryParameter("CNPE", m3_CNPE.Trim());

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
		/// Name Lst
		/// Description List Contact Persons
		/// Version Release: 15
		/// </summary>
		/// <param name="m3_CNPE">Contact</param>
		/// <param name="m3_RFTP">Contact Type</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3_CNPE = null, 
			string m3_RFTP = null, 
			string m3_DEPT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Lst",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CNPE))
				request.WithQueryParameter("CNPE", m3_CNPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFTP))
				request.WithQueryParameter("RFTP", m3_RFTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());

			// Execute the request
			var result = await Execute<LstResponse>(
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
		/// Description Update Contact Person
		/// Version Release: 15
		/// </summary>
		/// <param name="m3_CNPE">Contact</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX50">Name</param>
		/// <param name="m3_TITL">Title</param>
		/// <param name="m3_SALU">Salutation</param>
		/// <param name="m3_NAMF">First name</param>
		/// <param name="m3_NAMM">Middle name</param>
		/// <param name="m3_NAMS">Surname</param>
		/// <param name="m3_NAMX">Suffix name</param>
		/// <param name="m3_GEND">Gender</param>
		/// <param name="m3_LHCD">Language</param>
		/// <param name="m3_JTIT">Job title</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_RFTP">Contact Type</param>
		/// <param name="m3_ERTP">Employerreferencetype</param>
		/// <param name="m3_EMRE">Employerreference</param>
		/// <param name="m3_EMAL">Electronic mail address</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_PHN2">Telephone number 2</param>
		/// <param name="m3_CUA1">Address line 1</param>
		/// <param name="m3_CUA2">Address line 2</param>
		/// <param name="m3_CUA3">Address line 3</param>
		/// <param name="m3_CUA4">Address line 4</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_PONO">Postal code</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_CESA">Marketing ID - M3 SMS</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3_CNPE = null, 
			string m3_STAT = null, 
			string m3_TX40 = null, 
			string m3_TX50 = null, 
			string m3_TITL = null, 
			string m3_SALU = null, 
			string m3_NAMF = null, 
			string m3_NAMM = null, 
			string m3_NAMS = null, 
			string m3_NAMX = null, 
			int? m3_GEND = null, 
			string m3_LHCD = null, 
			string m3_JTIT = null, 
			string m3_DEPT = null, 
			string m3_RFTP = null, 
			int? m3_ERTP = null, 
			string m3_EMRE = null, 
			string m3_EMAL = null, 
			string m3_PHNO = null, 
			string m3_PHN2 = null, 
			string m3_CUA1 = null, 
			string m3_CUA2 = null, 
			string m3_CUA3 = null, 
			string m3_CUA4 = null, 
			string m3_TOWN = null, 
			string m3_PONO = null, 
			string m3_ECAR = null, 
			string m3_CSCD = null, 
			string m3_CESA = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CNPE))
				request.WithQueryParameter("CNPE", m3_CNPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX50))
				request.WithQueryParameter("TX50", m3_TX50.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TITL))
				request.WithQueryParameter("TITL", m3_TITL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SALU))
				request.WithQueryParameter("SALU", m3_SALU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NAMF))
				request.WithQueryParameter("NAMF", m3_NAMF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NAMM))
				request.WithQueryParameter("NAMM", m3_NAMM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NAMS))
				request.WithQueryParameter("NAMS", m3_NAMS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NAMX))
				request.WithQueryParameter("NAMX", m3_NAMX.Trim());
			if (m3_GEND.HasValue)
				request.WithQueryParameter("GEND", m3_GEND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LHCD))
				request.WithQueryParameter("LHCD", m3_LHCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_JTIT))
				request.WithQueryParameter("JTIT", m3_JTIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFTP))
				request.WithQueryParameter("RFTP", m3_RFTP.Trim());
			if (m3_ERTP.HasValue)
				request.WithQueryParameter("ERTP", m3_ERTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EMRE))
				request.WithQueryParameter("EMRE", m3_EMRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMAL))
				request.WithQueryParameter("EMAL", m3_EMAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHN2))
				request.WithQueryParameter("PHN2", m3_PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA1))
				request.WithQueryParameter("CUA1", m3_CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA2))
				request.WithQueryParameter("CUA2", m3_CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA3))
				request.WithQueryParameter("CUA3", m3_CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUA4))
				request.WithQueryParameter("CUA4", m3_CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CESA))
				request.WithQueryParameter("CESA", m3_CESA.Trim());

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
