/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name DltPayTrans
		/// Description Delete Payroll Transactions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FCOM">From company</param>
		/// <param name="m3TCOM">To company</param>
		/// <param name="m3FDIV">From division</param>
		/// <param name="m3TDIV">To division</param>
		/// <param name="m3FEMN">From employee</param>
		/// <param name="m3TEMN">To employee</param>
		/// <param name="m3TDAF">From date</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltPayTrans(
			int? m3FCOM = null, 
			int? m3TCOM = null, 
			string m3FDIV = null, 
			string m3TDIV = null, 
			string m3FEMN = null, 
			string m3TEMN = null, 
			DateTime? m3TDAF = null, 
			DateTime? m3TDAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltPayTrans",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3FCOM.HasValue)
				request.WithQueryParameter("FCOM", m3FCOM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TCOM.HasValue)
				request.WithQueryParameter("TCOM", m3TCOM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FDIV))
				request.WithQueryParameter("FDIV", m3FDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3TDIV))
				request.WithQueryParameter("TDIV", m3TDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3FEMN))
				request.WithQueryParameter("FEMN", m3FEMN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEMN))
				request.WithQueryParameter("TEMN", m3TEMN.Trim());
			if (m3TDAF.HasValue)
				request.WithQueryParameter("TDAF", m3TDAF.Value.ToM3String());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());

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
		/// Name LstCalTrans
		/// Description List Calender Transactions
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FCOM">From company</param>
		/// <param name="m3TCOM">To company</param>
		/// <param name="m3FDIV">From division</param>
		/// <param name="m3TDIV">To division</param>
		/// <param name="m3FEMN">From employee</param>
		/// <param name="m3TEMN">To employee</param>
		/// <param name="m3TDAF">From date</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCalTransResponse></returns>
		/// <exception cref="M3Exception<LstCalTransResponse>"></exception>
		public async Task<M3Response<LstCalTransResponse>> LstCalTrans(
			int? m3FCOM = null, 
			int? m3TCOM = null, 
			string m3FDIV = null, 
			string m3TDIV = null, 
			string m3FEMN = null, 
			string m3TEMN = null, 
			DateTime? m3TDAF = null, 
			DateTime? m3TDAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstCalTrans",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3FCOM.HasValue)
				request.WithQueryParameter("FCOM", m3FCOM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TCOM.HasValue)
				request.WithQueryParameter("TCOM", m3TCOM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FDIV))
				request.WithQueryParameter("FDIV", m3FDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3TDIV))
				request.WithQueryParameter("TDIV", m3TDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3FEMN))
				request.WithQueryParameter("FEMN", m3FEMN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEMN))
				request.WithQueryParameter("TEMN", m3TEMN.Trim());
			if (m3TDAF.HasValue)
				request.WithQueryParameter("TDAF", m3TDAF.Value.ToM3String());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstCalTransResponse>(
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
		/// Name LstPayTrans
		/// Description List Payroll Transactions
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FCOM">From company</param>
		/// <param name="m3TCOM">To company</param>
		/// <param name="m3FDIV">From division</param>
		/// <param name="m3TDIV">To division</param>
		/// <param name="m3FEMN">From employee</param>
		/// <param name="m3TEMN">To employee</param>
		/// <param name="m3TDAF">From date</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPayTransResponse></returns>
		/// <exception cref="M3Exception<LstPayTransResponse>"></exception>
		public async Task<M3Response<LstPayTransResponse>> LstPayTrans(
			int? m3FCOM = null, 
			int? m3TCOM = null, 
			string m3FDIV = null, 
			string m3TDIV = null, 
			string m3FEMN = null, 
			string m3TEMN = null, 
			DateTime? m3TDAF = null, 
			DateTime? m3TDAT = null, 
			string m3STAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPayTrans",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3FCOM.HasValue)
				request.WithQueryParameter("FCOM", m3FCOM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TCOM.HasValue)
				request.WithQueryParameter("TCOM", m3TCOM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FDIV))
				request.WithQueryParameter("FDIV", m3FDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3TDIV))
				request.WithQueryParameter("TDIV", m3TDIV.Trim());
			if (!string.IsNullOrWhiteSpace(m3FEMN))
				request.WithQueryParameter("FEMN", m3FEMN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEMN))
				request.WithQueryParameter("TEMN", m3TEMN.Trim());
			if (m3TDAF.HasValue)
				request.WithQueryParameter("TDAF", m3TDAF.Value.ToM3String());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());

			// Execute the request
			var result = await Execute<LstPayTransResponse>(
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
