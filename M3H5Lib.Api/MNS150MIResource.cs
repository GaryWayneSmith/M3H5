/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.MNS150MI;
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
	/// Name: MNS150MI
	/// Component Name: MovexUser
	/// Description: Api: User
	/// Version Release: 5ea2
	///</summary>
	public partial class MNS150MIResource : M3BaseResourceEndpoint
	{
		public MNS150MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MNS150MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add users
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3USID">User (Required)</param>
		/// <param name="m3NAME">Name (Required)</param>
		/// <param name="m3DFCO">Company (Required)</param>
		/// <param name="m3DFDI">Division</param>
		/// <param name="m3USTP">User type</param>
		/// <param name="m3USIG">User group - object access</param>
		/// <param name="m3ADK1">Address key 1</param>
		/// <param name="m3DCFM">Decimal format</param>
		/// <param name="m3DTFM">Date format</param>
		/// <param name="m3TIZO">Time zone</param>
		/// <param name="m3LANC">System language</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3MNVR">Menu version</param>
		/// <param name="m3DFMN">Start menu</param>
		/// <param name="m3EQAL">Equipment alias search sequense</param>
		/// <param name="m3USTA">User status</param>
		/// <param name="m3FRF6">Free field 1</param>
		/// <param name="m3FRF7">Free field 2</param>
		/// <param name="m3FRF8">Free field 3</param>
		/// <param name="m3EUID">External user id</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3USID, 
			string m3NAME, 
			int m3DFCO, 
			string m3DFDI = null, 
			string m3USTP = null, 
			string m3USIG = null, 
			string m3ADK1 = null, 
			string m3DCFM = null, 
			string m3DTFM = null, 
			string m3TIZO = null, 
			string m3LANC = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			string m3MNVR = null, 
			string m3DFMN = null, 
			string m3EQAL = null, 
			string m3USTA = null, 
			string m3FRF6 = null, 
			string m3FRF7 = null, 
			decimal? m3FRF8 = null, 
			string m3EUID = null, 
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
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));
			if (string.IsNullOrWhiteSpace(m3NAME))
				throw new ArgumentNullException(nameof(m3NAME));

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3USID.Trim())
				.WithQueryParameter("NAME", m3NAME.Trim())
				.WithQueryParameter("DFCO", m3DFCO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DFDI))
				request.WithQueryParameter("DFDI", m3DFDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3USTP))
				request.WithQueryParameter("USTP", m3USTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3USIG))
				request.WithQueryParameter("USIG", m3USIG.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADK1))
				request.WithQueryParameter("ADK1", m3ADK1.Trim());
			if (!string.IsNullOrWhiteSpace(m3DCFM))
				request.WithQueryParameter("DCFM", m3DCFM.Trim());
			if (!string.IsNullOrWhiteSpace(m3DTFM))
				request.WithQueryParameter("DTFM", m3DTFM.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIZO))
				request.WithQueryParameter("TIZO", m3TIZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3LANC))
				request.WithQueryParameter("LANC", m3LANC.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MNVR))
				request.WithQueryParameter("MNVR", m3MNVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DFMN))
				request.WithQueryParameter("DFMN", m3DFMN.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQAL))
				request.WithQueryParameter("EQAL", m3EQAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3USTA))
				request.WithQueryParameter("USTA", m3USTA.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRF6))
				request.WithQueryParameter("FRF6", m3FRF6.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRF7))
				request.WithQueryParameter("FRF7", m3FRF7.Trim());
			if (m3FRF8.HasValue)
				request.WithQueryParameter("FRF8", m3FRF8.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EUID))
				request.WithQueryParameter("EUID", m3EUID.Trim());

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
		/// Name AddUsrPerCmpDiv
		/// Description Add User Per Cmp & Divi
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3USID">User (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddUsrPerCmpDiv(
			string m3USID, 
			int? m3CONO = null, 
			string m3DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddUsrPerCmpDiv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3USID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

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
		/// Name ChgDefaultValue
		/// Description Change defaut values for an user
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3USID">User (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3LANC">Language</param>
		/// <param name="m3DTFM">Date format</param>
		/// <param name="m3DCFM">Decimal format</param>
		/// <param name="m3TIZO">Time zone</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3DEPT">Department</param>
		/// <param name="m3NAME">Name</param>
		/// <param name="m3EQAL">Equipment alias search sequense</param>
		/// <param name="m3USTA">User status</param>
		/// <param name="m3EUID">External user id</param>
		/// <param name="m3FRF6">User-defined field 1</param>
		/// <param name="m3FRF7">User-defined field 2</param>
		/// <param name="m3FRF8">User-defined field 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgDefaultValue(
			string m3USID, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3LANC = null, 
			string m3DTFM = null, 
			string m3DCFM = null, 
			string m3TIZO = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			string m3CUNO = null, 
			string m3DEPT = null, 
			string m3NAME = null, 
			string m3EQAL = null, 
			string m3USTA = null, 
			string m3EUID = null, 
			string m3FRF6 = null, 
			string m3FRF7 = null, 
			decimal? m3FRF8 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgDefaultValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3USID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3LANC))
				request.WithQueryParameter("LANC", m3LANC.Trim());
			if (!string.IsNullOrWhiteSpace(m3DTFM))
				request.WithQueryParameter("DTFM", m3DTFM.Trim());
			if (!string.IsNullOrWhiteSpace(m3DCFM))
				request.WithQueryParameter("DCFM", m3DCFM.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIZO))
				request.WithQueryParameter("TIZO", m3TIZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEPT))
				request.WithQueryParameter("DEPT", m3DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3NAME))
				request.WithQueryParameter("NAME", m3NAME.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQAL))
				request.WithQueryParameter("EQAL", m3EQAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3USTA))
				request.WithQueryParameter("USTA", m3USTA.Trim());
			if (!string.IsNullOrWhiteSpace(m3EUID))
				request.WithQueryParameter("EUID", m3EUID.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRF6))
				request.WithQueryParameter("FRF6", m3FRF6.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRF7))
				request.WithQueryParameter("FRF7", m3FRF7.Trim());
			if (m3FRF8.HasValue)
				request.WithQueryParameter("FRF8", m3FRF8.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgUsrPerCmpDiv
		/// Description Change User Per Cmp and Div
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3USID">User (Required)</param>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3RENM">Name</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3DTFM">Date format</param>
		/// <param name="m3TIZO">Time zone</param>
		/// <param name="m3AUPF">User group - function access</param>
		/// <param name="m3REPF">Display item name in own language</param>
		/// <param name="m3LANC">System language</param>
		/// <param name="m3USIG">User group - object access</param>
		/// <param name="m3MNVR">Menu version</param>
		/// <param name="m3DFMN">Start menu</param>
		/// <param name="m3MNMN">Menu maintenance</param>
		/// <param name="m3LLID">Library list</param>
		/// <param name="m3SFID">Shared file</param>
		/// <param name="m3UOID">Option group</param>
		/// <param name="m3PYAD">Our invoicing address</param>
		/// <param name="m3EQAL">Equipment alias search sequence</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgUsrPerCmpDiv(
			string m3USID, 
			int m3CONO, 
			string m3DIVI, 
			string m3RENM = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			string m3DTFM = null, 
			string m3TIZO = null, 
			string m3AUPF = null, 
			int? m3REPF = null, 
			string m3LANC = null, 
			string m3USIG = null, 
			string m3MNVR = null, 
			string m3DFMN = null, 
			int? m3MNMN = null, 
			string m3LLID = null, 
			string m3SFID = null, 
			string m3UOID = null, 
			string m3PYAD = null, 
			string m3EQAL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgUsrPerCmpDiv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3USID.Trim())
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RENM))
				request.WithQueryParameter("RENM", m3RENM.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DTFM))
				request.WithQueryParameter("DTFM", m3DTFM.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIZO))
				request.WithQueryParameter("TIZO", m3TIZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AUPF))
				request.WithQueryParameter("AUPF", m3AUPF.Trim());
			if (m3REPF.HasValue)
				request.WithQueryParameter("REPF", m3REPF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LANC))
				request.WithQueryParameter("LANC", m3LANC.Trim());
			if (!string.IsNullOrWhiteSpace(m3USIG))
				request.WithQueryParameter("USIG", m3USIG.Trim());
			if (!string.IsNullOrWhiteSpace(m3MNVR))
				request.WithQueryParameter("MNVR", m3MNVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3DFMN))
				request.WithQueryParameter("DFMN", m3DFMN.Trim());
			if (m3MNMN.HasValue)
				request.WithQueryParameter("MNMN", m3MNMN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LLID))
				request.WithQueryParameter("LLID", m3LLID.Trim());
			if (!string.IsNullOrWhiteSpace(m3SFID))
				request.WithQueryParameter("SFID", m3SFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3UOID))
				request.WithQueryParameter("UOID", m3UOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYAD))
				request.WithQueryParameter("PYAD", m3PYAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3EQAL))
				request.WithQueryParameter("EQAL", m3EQAL.Trim());

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
		/// Name CopyUser
		/// Description Copy an user to a new user
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3USID">New user (Required)</param>
		/// <param name="m3NAME">New user name (Required)</param>
		/// <param name="m3FRUS">Copy from user (Required)</param>
		/// <param name="m3EUID">New External user id</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CopyUser(
			string m3USID, 
			string m3NAME, 
			string m3FRUS, 
			string m3EUID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CopyUser",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));
			if (string.IsNullOrWhiteSpace(m3NAME))
				throw new ArgumentNullException(nameof(m3NAME));
			if (string.IsNullOrWhiteSpace(m3FRUS))
				throw new ArgumentNullException(nameof(m3FRUS));

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3USID.Trim())
				.WithQueryParameter("NAME", m3NAME.Trim())
				.WithQueryParameter("FRUS", m3FRUS.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EUID))
				request.WithQueryParameter("EUID", m3EUID.Trim());

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
		/// Name CpyUsrPerCmpDiv
		/// Description Copy User Per Cmp Div
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CONO">Copy from Company (Required)</param>
		/// <param name="m3DIVI">Copy from Division (Required)</param>
		/// <param name="m3USID">Copy from User (Required)</param>
		/// <param name="m3CCMP">Copy to Company (Required)</param>
		/// <param name="m3CDIV">Copy to Division (Required)</param>
		/// <param name="m3CUSR">Copy to User (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyUsrPerCmpDiv(
			int m3CONO, 
			string m3DIVI, 
			string m3USID, 
			int m3CCMP, 
			string m3CDIV, 
			string m3CUSR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpyUsrPerCmpDiv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));
			if (string.IsNullOrWhiteSpace(m3CDIV))
				throw new ArgumentNullException(nameof(m3CDIV));
			if (string.IsNullOrWhiteSpace(m3CUSR))
				throw new ArgumentNullException(nameof(m3CUSR));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("USID", m3USID.Trim())
				.WithQueryParameter("CCMP", m3CCMP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CDIV", m3CDIV.Trim())
				.WithQueryParameter("CUSR", m3CUSR.Trim());

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
		/// Name DelUser
		/// Description Delete User
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3USID">User (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelUser(
			string m3USID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelUser",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3USID.Trim());

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
		/// Name DelUsrPerCmpDiv
		/// Description Delete User Per Cmp & Divi
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3USID">User (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelUsrPerCmpDiv(
			string m3USID, 
			int? m3CONO = null, 
			string m3DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelUsrPerCmpDiv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3USID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

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
		/// Name GetUserByEuid
		/// Description Select Users by external user id
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3EUID">External user id (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetUserByEuidResponse></returns>
		/// <exception cref="M3Exception<GetUserByEuidResponse>"></exception>
		public async Task<M3Response<GetUserByEuidResponse>> GetUserByEuid(
			string m3EUID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetUserByEuid",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EUID))
				throw new ArgumentNullException(nameof(m3EUID));

			// Set mandatory parameters
			request
				.WithQueryParameter("EUID", m3EUID.Trim());

			// Execute the request
			var result = await Execute<GetUserByEuidResponse>(
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
		/// Name GetUserData
		/// Description Select Users
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3USID">User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetUserDataResponse></returns>
		/// <exception cref="M3Exception<GetUserDataResponse>"></exception>
		public async Task<M3Response<GetUserDataResponse>> GetUserData(
			string m3USID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetUserData",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());

			// Execute the request
			var result = await Execute<GetUserDataResponse>(
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
		/// Name LstCmpDivi
		/// Description List company and division for an user
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3USID">User (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCmpDiviResponse></returns>
		/// <exception cref="M3Exception<LstCmpDiviResponse>"></exception>
		public async Task<M3Response<LstCmpDiviResponse>> LstCmpDivi(
			string m3USID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCmpDivi",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3USID))
				throw new ArgumentNullException(nameof(m3USID));

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3USID.Trim());

			// Execute the request
			var result = await Execute<LstCmpDiviResponse>(
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
		/// Name LstUserData
		/// Description List user data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3USID">User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstUserDataResponse></returns>
		/// <exception cref="M3Exception<LstUserDataResponse>"></exception>
		public async Task<M3Response<LstUserDataResponse>> LstUserData(
			string m3USID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstUserData",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());

			// Execute the request
			var result = await Execute<LstUserDataResponse>(
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
		/// Name SelUsers
		/// Description List selected users
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FDIV">From Division</param>
		/// <param name="m3TDIV">To Division</param>
		/// <param name="m3FRES">From User</param>
		/// <param name="m3TRES">To User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelUsersResponse></returns>
		/// <exception cref="M3Exception<SelUsersResponse>"></exception>
		public async Task<M3Response<SelUsersResponse>> SelUsers(
			string m3FDIV = null, 
			string m3TDIV = null, 
			string m3FRES = null, 
			string m3TRES = null, 
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
			if (!string.IsNullOrWhiteSpace(m3FDIV))
				request.WithQueryParameter("FDIV", m3FDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3TDIV))
				request.WithQueryParameter("TDIV", m3TDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRES))
				request.WithQueryParameter("FRES", m3FRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRES))
				request.WithQueryParameter("TRES", m3TRES.Trim());

			// Execute the request
			var result = await Execute<SelUsersResponse>(
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
