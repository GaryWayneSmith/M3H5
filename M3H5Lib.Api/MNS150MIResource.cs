/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_USID">User (Required)</param>
		/// <param name="m3_NAME">Name (Required)</param>
		/// <param name="m3_DFCO">Company (Required)</param>
		/// <param name="m3_DFDI">Division</param>
		/// <param name="m3_USTP">User type</param>
		/// <param name="m3_USIG">User group - object access</param>
		/// <param name="m3_ADK1">Address key 1</param>
		/// <param name="m3_DCFM">Decimal format</param>
		/// <param name="m3_DTFM">Date format</param>
		/// <param name="m3_TIZO">Time zone</param>
		/// <param name="m3_LANC">System language</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_MNVR">Menu version</param>
		/// <param name="m3_DFMN">Start menu</param>
		/// <param name="m3_EQAL">Equipment alias search sequense</param>
		/// <param name="m3_USTA">User status</param>
		/// <param name="m3_FRF6">Free field 1</param>
		/// <param name="m3_FRF7">Free field 2</param>
		/// <param name="m3_FRF8">Free field 3</param>
		/// <param name="m3_EUID">External user id</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_USID, 
			string m3_NAME, 
			int m3_DFCO, 
			string m3_DFDI = null, 
			string m3_USTP = null, 
			string m3_USIG = null, 
			string m3_ADK1 = null, 
			string m3_DCFM = null, 
			string m3_DTFM = null, 
			string m3_TIZO = null, 
			string m3_LANC = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			string m3_MNVR = null, 
			string m3_DFMN = null, 
			string m3_EQAL = null, 
			string m3_USTA = null, 
			string m3_FRF6 = null, 
			string m3_FRF7 = null, 
			decimal? m3_FRF8 = null, 
			string m3_EUID = null, 
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
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");
			if (string.IsNullOrWhiteSpace(m3_NAME))
				throw new ArgumentNullException("m3_NAME");

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3_USID.Trim())
				.WithQueryParameter("NAME", m3_NAME.Trim())
				.WithQueryParameter("DFCO", m3_DFCO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DFDI))
				request.WithQueryParameter("DFDI", m3_DFDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USTP))
				request.WithQueryParameter("USTP", m3_USTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USIG))
				request.WithQueryParameter("USIG", m3_USIG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADK1))
				request.WithQueryParameter("ADK1", m3_ADK1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DCFM))
				request.WithQueryParameter("DCFM", m3_DCFM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DTFM))
				request.WithQueryParameter("DTFM", m3_DTFM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIZO))
				request.WithQueryParameter("TIZO", m3_TIZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LANC))
				request.WithQueryParameter("LANC", m3_LANC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MNVR))
				request.WithQueryParameter("MNVR", m3_MNVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DFMN))
				request.WithQueryParameter("DFMN", m3_DFMN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQAL))
				request.WithQueryParameter("EQAL", m3_EQAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USTA))
				request.WithQueryParameter("USTA", m3_USTA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRF6))
				request.WithQueryParameter("FRF6", m3_FRF6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRF7))
				request.WithQueryParameter("FRF7", m3_FRF7.Trim());
			if (m3_FRF8.HasValue)
				request.WithQueryParameter("FRF8", m3_FRF8.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EUID))
				request.WithQueryParameter("EUID", m3_EUID.Trim());

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
		/// Name AddUsrPerCmpDiv
		/// Description Add User Per Cmp & Divi
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_USID">User (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddUsrPerCmpDiv(
			string m3_USID, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
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
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3_USID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

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
		/// Name ChgDefaultValue
		/// Description Change defaut values for an user
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_USID">User (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_LANC">Language</param>
		/// <param name="m3_DTFM">Date format</param>
		/// <param name="m3_DCFM">Decimal format</param>
		/// <param name="m3_TIZO">Time zone</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_DEPT">Department</param>
		/// <param name="m3_NAME">Name</param>
		/// <param name="m3_EQAL">Equipment alias search sequense</param>
		/// <param name="m3_USTA">User status</param>
		/// <param name="m3_EUID">External user id</param>
		/// <param name="m3_FRF6">User-defined field 1</param>
		/// <param name="m3_FRF7">User-defined field 2</param>
		/// <param name="m3_FRF8">User-defined field 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgDefaultValue(
			string m3_USID, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_LANC = null, 
			string m3_DTFM = null, 
			string m3_DCFM = null, 
			string m3_TIZO = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			string m3_CUNO = null, 
			string m3_DEPT = null, 
			string m3_NAME = null, 
			string m3_EQAL = null, 
			string m3_USTA = null, 
			string m3_EUID = null, 
			string m3_FRF6 = null, 
			string m3_FRF7 = null, 
			decimal? m3_FRF8 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3_USID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LANC))
				request.WithQueryParameter("LANC", m3_LANC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DTFM))
				request.WithQueryParameter("DTFM", m3_DTFM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DCFM))
				request.WithQueryParameter("DCFM", m3_DCFM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIZO))
				request.WithQueryParameter("TIZO", m3_TIZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEPT))
				request.WithQueryParameter("DEPT", m3_DEPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_NAME))
				request.WithQueryParameter("NAME", m3_NAME.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQAL))
				request.WithQueryParameter("EQAL", m3_EQAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USTA))
				request.WithQueryParameter("USTA", m3_USTA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EUID))
				request.WithQueryParameter("EUID", m3_EUID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRF6))
				request.WithQueryParameter("FRF6", m3_FRF6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRF7))
				request.WithQueryParameter("FRF7", m3_FRF7.Trim());
			if (m3_FRF8.HasValue)
				request.WithQueryParameter("FRF8", m3_FRF8.Value.ToString());

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
		/// Name ChgUsrPerCmpDiv
		/// Description Change User Per Cmp and Div
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_USID">User (Required)</param>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_RENM">Name</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_DTFM">Date format</param>
		/// <param name="m3_TIZO">Time zone</param>
		/// <param name="m3_AUPF">User group - function access</param>
		/// <param name="m3_REPF">Display item name in own language</param>
		/// <param name="m3_LANC">System language</param>
		/// <param name="m3_USIG">User group - object access</param>
		/// <param name="m3_MNVR">Menu version</param>
		/// <param name="m3_DFMN">Start menu</param>
		/// <param name="m3_MNMN">Menu maintenance</param>
		/// <param name="m3_LLID">Library list</param>
		/// <param name="m3_SFID">Shared file</param>
		/// <param name="m3_UOID">Option group</param>
		/// <param name="m3_PYAD">Our invoicing address</param>
		/// <param name="m3_EQAL">Equipment alias search sequence</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgUsrPerCmpDiv(
			string m3_USID, 
			int m3_CONO, 
			string m3_DIVI, 
			string m3_RENM = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			string m3_DTFM = null, 
			string m3_TIZO = null, 
			string m3_AUPF = null, 
			int? m3_REPF = null, 
			string m3_LANC = null, 
			string m3_USIG = null, 
			string m3_MNVR = null, 
			string m3_DFMN = null, 
			int? m3_MNMN = null, 
			string m3_LLID = null, 
			string m3_SFID = null, 
			string m3_UOID = null, 
			string m3_PYAD = null, 
			string m3_EQAL = null, 
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
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3_USID.Trim())
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RENM))
				request.WithQueryParameter("RENM", m3_RENM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DTFM))
				request.WithQueryParameter("DTFM", m3_DTFM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIZO))
				request.WithQueryParameter("TIZO", m3_TIZO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AUPF))
				request.WithQueryParameter("AUPF", m3_AUPF.Trim());
			if (m3_REPF.HasValue)
				request.WithQueryParameter("REPF", m3_REPF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LANC))
				request.WithQueryParameter("LANC", m3_LANC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USIG))
				request.WithQueryParameter("USIG", m3_USIG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MNVR))
				request.WithQueryParameter("MNVR", m3_MNVR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DFMN))
				request.WithQueryParameter("DFMN", m3_DFMN.Trim());
			if (m3_MNMN.HasValue)
				request.WithQueryParameter("MNMN", m3_MNMN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LLID))
				request.WithQueryParameter("LLID", m3_LLID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SFID))
				request.WithQueryParameter("SFID", m3_SFID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UOID))
				request.WithQueryParameter("UOID", m3_UOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYAD))
				request.WithQueryParameter("PYAD", m3_PYAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EQAL))
				request.WithQueryParameter("EQAL", m3_EQAL.Trim());

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
		/// Name CopyUser
		/// Description Copy an user to a new user
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_USID">New user (Required)</param>
		/// <param name="m3_NAME">New user name (Required)</param>
		/// <param name="m3_FRUS">Copy from user (Required)</param>
		/// <param name="m3_EUID">New External user id</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CopyUser(
			string m3_USID, 
			string m3_NAME, 
			string m3_FRUS, 
			string m3_EUID = null, 
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
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");
			if (string.IsNullOrWhiteSpace(m3_NAME))
				throw new ArgumentNullException("m3_NAME");
			if (string.IsNullOrWhiteSpace(m3_FRUS))
				throw new ArgumentNullException("m3_FRUS");

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3_USID.Trim())
				.WithQueryParameter("NAME", m3_NAME.Trim())
				.WithQueryParameter("FRUS", m3_FRUS.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_EUID))
				request.WithQueryParameter("EUID", m3_EUID.Trim());

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
		/// Name CpyUsrPerCmpDiv
		/// Description Copy User Per Cmp Div
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CONO">Copy from Company (Required)</param>
		/// <param name="m3_DIVI">Copy from Division (Required)</param>
		/// <param name="m3_USID">Copy from User (Required)</param>
		/// <param name="m3_CCMP">Copy to Company (Required)</param>
		/// <param name="m3_CDIV">Copy to Division (Required)</param>
		/// <param name="m3_CUSR">Copy to User (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpyUsrPerCmpDiv(
			int m3_CONO, 
			string m3_DIVI, 
			string m3_USID, 
			int m3_CCMP, 
			string m3_CDIV, 
			string m3_CUSR, 
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
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");
			if (string.IsNullOrWhiteSpace(m3_CDIV))
				throw new ArgumentNullException("m3_CDIV");
			if (string.IsNullOrWhiteSpace(m3_CUSR))
				throw new ArgumentNullException("m3_CUSR");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("USID", m3_USID.Trim())
				.WithQueryParameter("CCMP", m3_CCMP.ToString())
				.WithQueryParameter("CDIV", m3_CDIV.Trim())
				.WithQueryParameter("CUSR", m3_CUSR.Trim());

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
		/// Name DelUser
		/// Description Delete User
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_USID">User (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelUser(
			string m3_USID, 
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
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3_USID.Trim());

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
		/// Name DelUsrPerCmpDiv
		/// Description Delete User Per Cmp & Divi
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_USID">User (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelUsrPerCmpDiv(
			string m3_USID, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
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
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3_USID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

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
		/// Name GetUserByEuid
		/// Description Select Users by external user id
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_EUID">External user id (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetUserByEuidResponse></returns>
		/// <exception cref="M3Exception<GetUserByEuidResponse>"></exception>
		public async Task<M3Response<GetUserByEuidResponse>> GetUserByEuid(
			string m3_EUID, 
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
			if (string.IsNullOrWhiteSpace(m3_EUID))
				throw new ArgumentNullException("m3_EUID");

			// Set mandatory parameters
			request
				.WithQueryParameter("EUID", m3_EUID.Trim());

			// Execute the request
			var result = await Execute<GetUserByEuidResponse>(
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
		/// Name GetUserData
		/// Description Select Users
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_USID">User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetUserDataResponse></returns>
		/// <exception cref="M3Exception<GetUserDataResponse>"></exception>
		public async Task<M3Response<GetUserDataResponse>> GetUserData(
			string m3_USID = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());

			// Execute the request
			var result = await Execute<GetUserDataResponse>(
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
		/// Name LstCmpDivi
		/// Description List company and division for an user
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_USID">User (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCmpDiviResponse></returns>
		/// <exception cref="M3Exception<LstCmpDiviResponse>"></exception>
		public async Task<M3Response<LstCmpDiviResponse>> LstCmpDivi(
			string m3_USID, 
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
			if (string.IsNullOrWhiteSpace(m3_USID))
				throw new ArgumentNullException("m3_USID");

			// Set mandatory parameters
			request
				.WithQueryParameter("USID", m3_USID.Trim());

			// Execute the request
			var result = await Execute<LstCmpDiviResponse>(
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
		/// Name LstUserData
		/// Description List user data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_USID">User</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstUserDataResponse></returns>
		/// <exception cref="M3Exception<LstUserDataResponse>"></exception>
		public async Task<M3Response<LstUserDataResponse>> LstUserData(
			string m3_USID = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());

			// Execute the request
			var result = await Execute<LstUserDataResponse>(
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
	}
}
// EOF
