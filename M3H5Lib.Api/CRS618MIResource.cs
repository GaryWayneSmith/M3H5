/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add Contact Person
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CNPE">Contact (Required)</param>
		/// <param name="m3STAT">Status (Required)</param>
		/// <param name="m3TX50">Name (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TITL">Title</param>
		/// <param name="m3SALU">Salutation</param>
		/// <param name="m3NAMF">First name</param>
		/// <param name="m3NAMM">Middle name</param>
		/// <param name="m3NAMS">Surname</param>
		/// <param name="m3NAMX">Suffix name</param>
		/// <param name="m3GEND">Gender</param>
		/// <param name="m3LHCD">Language</param>
		/// <param name="m3JTIT">Job title</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3RFTP">Contact type</param>
		/// <param name="m3ERTP">Employerreferencetype</param>
		/// <param name="m3EMRE">Employerreference</param>
		/// <param name="m3EMAL">Electronic mail address</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3PHN2">Telephone number 2</param>
		/// <param name="m3CUA1">Address line 1</param>
		/// <param name="m3CUA2">Address line 2</param>
		/// <param name="m3CUA3">Address line 3</param>
		/// <param name="m3CUA4">Address line 4</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3PONO">Postal code</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3CESA">Marketing ID - M3 SMS</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddResponse></returns>
		/// <exception cref="M3Exception<AddResponse>"></exception>
		public async Task<M3Response<AddResponse>> Add(
			string m3CNPE, 
			string m3STAT, 
			string m3TX50, 
			string m3TX40 = null, 
			string m3TITL = null, 
			string m3SALU = null, 
			string m3NAMF = null, 
			string m3NAMM = null, 
			string m3NAMS = null, 
			string m3NAMX = null, 
			int? m3GEND = null, 
			string m3LHCD = null, 
			string m3JTIT = null, 
			string m3DEPT = null, 
			string m3RFTP = null, 
			int? m3ERTP = null, 
			string m3EMRE = null, 
			string m3EMAL = null, 
			string m3PHNO = null, 
			string m3PHN2 = null, 
			string m3CUA1 = null, 
			string m3CUA2 = null, 
			string m3CUA3 = null, 
			string m3CUA4 = null, 
			string m3TOWN = null, 
			string m3PONO = null, 
			string m3ECAR = null, 
			string m3CSCD = null, 
			string m3CESA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CNPE))
				throw new ArgumentNullException(nameof(m3CNPE));
			if (string.IsNullOrWhiteSpace(m3STAT))
				throw new ArgumentNullException(nameof(m3STAT));
			if (string.IsNullOrWhiteSpace(m3TX50))
				throw new ArgumentNullException(nameof(m3TX50));

			// Set mandatory parameters
			request
				.WithQueryParameter("CNPE", m3CNPE.Trim())
				.WithQueryParameter("STAT", m3STAT.Trim())
				.WithQueryParameter("TX50", m3TX50.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TITL))
				request.WithQueryParameter("TITL", m3TITL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SALU))
				request.WithQueryParameter("SALU", m3SALU.Trim());
			if (!string.IsNullOrWhiteSpace(m3NAMF))
				request.WithQueryParameter("NAMF", m3NAMF.Trim());
			if (!string.IsNullOrWhiteSpace(m3NAMM))
				request.WithQueryParameter("NAMM", m3NAMM.Trim());
			if (!string.IsNullOrWhiteSpace(m3NAMS))
				request.WithQueryParameter("NAMS", m3NAMS.Trim());
			if (!string.IsNullOrWhiteSpace(m3NAMX))
				request.WithQueryParameter("NAMX", m3NAMX.Trim());
			if (m3GEND.HasValue)
				request.WithQueryParameter("GEND", m3GEND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LHCD))
				request.WithQueryParameter("LHCD", m3LHCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3JTIT))
				request.WithQueryParameter("JTIT", m3JTIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFTP))
				request.WithQueryParameter("RFTP", m3RFTP.Trim());
			if (m3ERTP.HasValue)
				request.WithQueryParameter("ERTP", m3ERTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EMRE))
				request.WithQueryParameter("EMRE", m3EMRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMAL))
				request.WithQueryParameter("EMAL", m3EMAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHN2))
				request.WithQueryParameter("PHN2", m3PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA1))
				request.WithQueryParameter("CUA1", m3CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA2))
				request.WithQueryParameter("CUA2", m3CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA3))
				request.WithQueryParameter("CUA3", m3CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA4))
				request.WithQueryParameter("CUA4", m3CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CESA))
				request.WithQueryParameter("CESA", m3CESA.Trim());

			// Execute the request
			var result = await Execute<AddResponse>(
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
		/// Name Dlt
		/// Description Delete Contact Person
		/// Version Release: 15
		/// </summary>
		/// <param name="m3CNPE">Contact (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Dlt(
			string m3CNPE, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Dlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CNPE))
				throw new ArgumentNullException(nameof(m3CNPE));

			// Set mandatory parameters
			request
				.WithQueryParameter("CNPE", m3CNPE.Trim());

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
		/// Description Get Contact Person
		/// Version Release: 15
		/// </summary>
		/// <param name="m3CNPE">Contact (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3CNPE, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CNPE))
				throw new ArgumentNullException(nameof(m3CNPE));

			// Set mandatory parameters
			request
				.WithQueryParameter("CNPE", m3CNPE.Trim());

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
		/// Name Lst
		/// Description List Contact Persons
		/// Version Release: 15
		/// </summary>
		/// <param name="m3CNPE">Contact</param>
		/// <param name="m3RFTP">Contact Type</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3CNPE = null, 
			string m3RFTP = null, 
			string m3DEPT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Lst",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CNPE))
				request.WithQueryParameter("CNPE", m3CNPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFTP))
				request.WithQueryParameter("RFTP", m3RFTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());

			// Execute the request
			var result = await Execute<LstResponse>(
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
		/// Description Update Contact Person
		/// Version Release: 15
		/// </summary>
		/// <param name="m3CNPE">Contact</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX50">Name</param>
		/// <param name="m3TITL">Title</param>
		/// <param name="m3SALU">Salutation</param>
		/// <param name="m3NAMF">First name</param>
		/// <param name="m3NAMM">Middle name</param>
		/// <param name="m3NAMS">Surname</param>
		/// <param name="m3NAMX">Suffix name</param>
		/// <param name="m3GEND">Gender</param>
		/// <param name="m3LHCD">Language</param>
		/// <param name="m3JTIT">Job title</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3RFTP">Contact Type</param>
		/// <param name="m3ERTP">Employerreferencetype</param>
		/// <param name="m3EMRE">Employerreference</param>
		/// <param name="m3EMAL">Electronic mail address</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3PHN2">Telephone number 2</param>
		/// <param name="m3CUA1">Address line 1</param>
		/// <param name="m3CUA2">Address line 2</param>
		/// <param name="m3CUA3">Address line 3</param>
		/// <param name="m3CUA4">Address line 4</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3PONO">Postal code</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3CESA">Marketing ID - M3 SMS</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3CNPE = null, 
			string m3STAT = null, 
			string m3TX40 = null, 
			string m3TX50 = null, 
			string m3TITL = null, 
			string m3SALU = null, 
			string m3NAMF = null, 
			string m3NAMM = null, 
			string m3NAMS = null, 
			string m3NAMX = null, 
			int? m3GEND = null, 
			string m3LHCD = null, 
			string m3JTIT = null, 
			string m3DEPT = null, 
			string m3RFTP = null, 
			int? m3ERTP = null, 
			string m3EMRE = null, 
			string m3EMAL = null, 
			string m3PHNO = null, 
			string m3PHN2 = null, 
			string m3CUA1 = null, 
			string m3CUA2 = null, 
			string m3CUA3 = null, 
			string m3CUA4 = null, 
			string m3TOWN = null, 
			string m3PONO = null, 
			string m3ECAR = null, 
			string m3CSCD = null, 
			string m3CESA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Upd",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CNPE))
				request.WithQueryParameter("CNPE", m3CNPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX50))
				request.WithQueryParameter("TX50", m3TX50.Trim());
			if (!string.IsNullOrWhiteSpace(m3TITL))
				request.WithQueryParameter("TITL", m3TITL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SALU))
				request.WithQueryParameter("SALU", m3SALU.Trim());
			if (!string.IsNullOrWhiteSpace(m3NAMF))
				request.WithQueryParameter("NAMF", m3NAMF.Trim());
			if (!string.IsNullOrWhiteSpace(m3NAMM))
				request.WithQueryParameter("NAMM", m3NAMM.Trim());
			if (!string.IsNullOrWhiteSpace(m3NAMS))
				request.WithQueryParameter("NAMS", m3NAMS.Trim());
			if (!string.IsNullOrWhiteSpace(m3NAMX))
				request.WithQueryParameter("NAMX", m3NAMX.Trim());
			if (m3GEND.HasValue)
				request.WithQueryParameter("GEND", m3GEND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LHCD))
				request.WithQueryParameter("LHCD", m3LHCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3JTIT))
				request.WithQueryParameter("JTIT", m3JTIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3RFTP))
				request.WithQueryParameter("RFTP", m3RFTP.Trim());
			if (m3ERTP.HasValue)
				request.WithQueryParameter("ERTP", m3ERTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EMRE))
				request.WithQueryParameter("EMRE", m3EMRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMAL))
				request.WithQueryParameter("EMAL", m3EMAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHN2))
				request.WithQueryParameter("PHN2", m3PHN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA1))
				request.WithQueryParameter("CUA1", m3CUA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA2))
				request.WithQueryParameter("CUA2", m3CUA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA3))
				request.WithQueryParameter("CUA3", m3CUA3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUA4))
				request.WithQueryParameter("CUA4", m3CUA4.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CESA))
				request.WithQueryParameter("CESA", m3CESA.Trim());

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
