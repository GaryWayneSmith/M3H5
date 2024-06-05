/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.AUTCHKMI;
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
	/// Name: AUTCHKMI
	/// Component Name: Authority Check
	/// Description: Check authority
	/// Version Release: 5ea1
	///</summary>
	public partial class AUTCHKMIResource : M3BaseResourceEndpoint
	{
		public AUTCHKMIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "AUTCHKMI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ChkAutTblRcd
		/// Description Check Authority Table Record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FILE">Table</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ACGR">Object access group</param>
		/// <param name="m3AIT1">Accounting dimension 1</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChkAutTblRcdResponse></returns>
		/// <exception cref="M3Exception<ChkAutTblRcdResponse>"></exception>
		public async Task<M3Response<ChkAutTblRcdResponse>> ChkAutTblRcd(
			string m3FILE = null, 
			string m3DIVI = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			string m3ACGR = null, 
			string m3AIT1 = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChkAutTblRcd",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACGR))
				request.WithQueryParameter("ACGR", m3ACGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT1))
				request.WithQueryParameter("AIT1", m3AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT2))
				request.WithQueryParameter("AIT2", m3AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT3))
				request.WithQueryParameter("AIT3", m3AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT4))
				request.WithQueryParameter("AIT4", m3AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT5))
				request.WithQueryParameter("AIT5", m3AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT6))
				request.WithQueryParameter("AIT6", m3AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT7))
				request.WithQueryParameter("AIT7", m3AIT7.Trim());

			// Execute the request
			var result = await Execute<ChkAutTblRcdResponse>(
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
		/// Name ChkAuthority
		/// Description Check Authority for program, option and funnktion keys
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3APGM">Check program</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ChkAuthorityResponse></returns>
		/// <exception cref="M3Exception<ChkAuthorityResponse>"></exception>
		public async Task<M3Response<ChkAuthorityResponse>> ChkAuthority(
			string m3APGM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChkAuthority",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3APGM))
				request.WithQueryParameter("APGM", m3APGM.Trim());

			// Execute the request
			var result = await Execute<ChkAuthorityResponse>(
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
		/// Name SelRolePerm
		/// Description List role permissions
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3FNID">Function (Required)</param>
		/// <param name="m3ROLL">Role (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelRolePermResponse></returns>
		/// <exception cref="M3Exception<SelRolePermResponse>"></exception>
		public async Task<M3Response<SelRolePermResponse>> SelRolePerm(
			string m3FNID, 
			string m3ROLL, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelRolePerm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FNID))
				throw new ArgumentNullException(nameof(m3FNID));
			if (string.IsNullOrWhiteSpace(m3ROLL))
				throw new ArgumentNullException(nameof(m3ROLL));

			// Set mandatory parameters
			request
				.WithQueryParameter("FNID", m3FNID.Trim())
				.WithQueryParameter("ROLL", m3ROLL.Trim());

			// Execute the request
			var result = await Execute<SelRolePermResponse>(
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
