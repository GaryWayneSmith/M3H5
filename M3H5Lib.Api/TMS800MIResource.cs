/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.TMS800MI;
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
	/// Name: TMS800MI
	/// Component Name: PayrollTransaction
	/// Description: Payroll Transaction interface
	/// Version Release: 5ea0
	///</summary>
	public partial class TMS800MIResource : M3BaseResourceEndpoint
	{
		public TMS800MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "TMS800MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name DltPayTrans
		/// Description Delete Payroll Transactions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FCOM">From company</param>
		/// <param name="m3_TCOM">To company</param>
		/// <param name="m3_FDIV">From division</param>
		/// <param name="m3_TDIV">To division</param>
		/// <param name="m3_FEMN">From employee</param>
		/// <param name="m3_TEMN">To employee</param>
		/// <param name="m3_TDAF">From date</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltPayTrans(
			int? m3_FCOM = null, 
			int? m3_TCOM = null, 
			string m3_FDIV = null, 
			string m3_TDIV = null, 
			string m3_FEMN = null, 
			string m3_TEMN = null, 
			DateTime? m3_TDAF = null, 
			DateTime? m3_TDAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltPayTrans",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_FCOM.HasValue)
				request.WithQueryParameter("FCOM", m3_FCOM.Value.ToString());
			if (m3_TCOM.HasValue)
				request.WithQueryParameter("TCOM", m3_TCOM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FDIV))
				request.WithQueryParameter("FDIV", m3_FDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TDIV))
				request.WithQueryParameter("TDIV", m3_TDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FEMN))
				request.WithQueryParameter("FEMN", m3_FEMN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEMN))
				request.WithQueryParameter("TEMN", m3_TEMN.Trim());
			if (m3_TDAF.HasValue)
				request.WithQueryParameter("TDAF", m3_TDAF.Value.ToM3String());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());

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
		/// Name LstCalTrans
		/// Description List Calender Transactions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FCOM">From company</param>
		/// <param name="m3_TCOM">To company</param>
		/// <param name="m3_FDIV">From division</param>
		/// <param name="m3_TDIV">To division</param>
		/// <param name="m3_FEMN">From employee</param>
		/// <param name="m3_TEMN">To employee</param>
		/// <param name="m3_TDAF">From date</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCalTransResponse></returns>
		/// <exception cref="M3Exception<LstCalTransResponse>"></exception>
		public async Task<M3Response<LstCalTransResponse>> LstCalTrans(
			int? m3_FCOM = null, 
			int? m3_TCOM = null, 
			string m3_FDIV = null, 
			string m3_TDIV = null, 
			string m3_FEMN = null, 
			string m3_TEMN = null, 
			DateTime? m3_TDAF = null, 
			DateTime? m3_TDAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCalTrans",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_FCOM.HasValue)
				request.WithQueryParameter("FCOM", m3_FCOM.Value.ToString());
			if (m3_TCOM.HasValue)
				request.WithQueryParameter("TCOM", m3_TCOM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FDIV))
				request.WithQueryParameter("FDIV", m3_FDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TDIV))
				request.WithQueryParameter("TDIV", m3_TDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FEMN))
				request.WithQueryParameter("FEMN", m3_FEMN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEMN))
				request.WithQueryParameter("TEMN", m3_TEMN.Trim());
			if (m3_TDAF.HasValue)
				request.WithQueryParameter("TDAF", m3_TDAF.Value.ToM3String());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstCalTransResponse>(
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
		/// Name LstPayTrans
		/// Description List Payroll Transactions
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FCOM">From company</param>
		/// <param name="m3_TCOM">To company</param>
		/// <param name="m3_FDIV">From division</param>
		/// <param name="m3_TDIV">To division</param>
		/// <param name="m3_FEMN">From employee</param>
		/// <param name="m3_TEMN">To employee</param>
		/// <param name="m3_TDAF">From date</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPayTransResponse></returns>
		/// <exception cref="M3Exception<LstPayTransResponse>"></exception>
		public async Task<M3Response<LstPayTransResponse>> LstPayTrans(
			int? m3_FCOM = null, 
			int? m3_TCOM = null, 
			string m3_FDIV = null, 
			string m3_TDIV = null, 
			string m3_FEMN = null, 
			string m3_TEMN = null, 
			DateTime? m3_TDAF = null, 
			DateTime? m3_TDAT = null, 
			string m3_STAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPayTrans",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_FCOM.HasValue)
				request.WithQueryParameter("FCOM", m3_FCOM.Value.ToString());
			if (m3_TCOM.HasValue)
				request.WithQueryParameter("TCOM", m3_TCOM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FDIV))
				request.WithQueryParameter("FDIV", m3_FDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TDIV))
				request.WithQueryParameter("TDIV", m3_TDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FEMN))
				request.WithQueryParameter("FEMN", m3_FEMN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEMN))
				request.WithQueryParameter("TEMN", m3_TEMN.Trim());
			if (m3_TDAF.HasValue)
				request.WithQueryParameter("TDAF", m3_TDAF.Value.ToM3String());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());

			// Execute the request
			var result = await Execute<LstPayTransResponse>(
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
