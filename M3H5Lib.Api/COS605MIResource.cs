/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
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
	/// Name: COS605MI
	/// Component Name: MAI
	/// Description: Order Confirmation
	/// Version Release: 5ea0
	///</summary>
	public partial class COS605MIResource : M3BaseResourceEndpoint
	{
		public COS605MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "COS605MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name PrintConfirm
		/// Description PrintConfirmation
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_FRLDT">Requested delivery date from</param>
		/// <param name="m3_TRLDT">Requested delivery date to</param>
		/// <param name="m3_FORNO">Customer order number from</param>
		/// <param name="m3_FPONR">Order line number from</param>
		/// <param name="m3_TORNO">Customer order number to</param>
		/// <param name="m3_TPONR">Order line number to</param>
		/// <param name="m3_FCUNO">Customer from</param>
		/// <param name="m3_TCUNO">Customer to</param>
		/// <param name="m3_FMODL">Delivery method from</param>
		/// <param name="m3_TMODL">Delivery method to</param>
		/// <param name="m3_FAOTY">Order type from</param>
		/// <param name="m3_TAOTY">Order type tp</param>
		/// <param name="m3_FFACI">Facility from</param>
		/// <param name="m3_TFACI">Facility to</param>
		/// <param name="m3_FOPRI">Priority from</param>
		/// <param name="m3_TOPRI">Priority to</param>
		/// <param name="m3_CPPL">Copy</param>
		/// <param name="m3_ORN1">Customer order number 1</param>
		/// <param name="m3_ORN2">Customer order number 2</param>
		/// <param name="m3_ORN3">Customer order number 3</param>
		/// <param name="m3_ORN4">Customer order number 4</param>
		/// <param name="m3_ORN5">Customer order number 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrintConfirm(
			DateTime? m3_FRLDT = null, 
			DateTime? m3_TRLDT = null, 
			string m3_FORNO = null, 
			int? m3_FPONR = null, 
			string m3_TORNO = null, 
			int? m3_TPONR = null, 
			string m3_FCUNO = null, 
			string m3_TCUNO = null, 
			string m3_FMODL = null, 
			string m3_TMODL = null, 
			string m3_FAOTY = null, 
			string m3_TAOTY = null, 
			string m3_FFACI = null, 
			string m3_TFACI = null, 
			int? m3_FOPRI = null, 
			int? m3_TOPRI = null, 
			int? m3_CPPL = null, 
			string m3_ORN1 = null, 
			string m3_ORN2 = null, 
			string m3_ORN3 = null, 
			string m3_ORN4 = null, 
			string m3_ORN5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrintConfirm",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_FRLDT.HasValue)
				request.WithQueryParameter("FRLDT", m3_FRLDT.Value.ToM3String());
			if (m3_TRLDT.HasValue)
				request.WithQueryParameter("TRLDT", m3_TRLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_FORNO))
				request.WithQueryParameter("FORNO", m3_FORNO.Trim());
			if (m3_FPONR.HasValue)
				request.WithQueryParameter("FPONR", m3_FPONR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TORNO))
				request.WithQueryParameter("TORNO", m3_TORNO.Trim());
			if (m3_TPONR.HasValue)
				request.WithQueryParameter("TPONR", m3_TPONR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FCUNO))
				request.WithQueryParameter("FCUNO", m3_FCUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TCUNO))
				request.WithQueryParameter("TCUNO", m3_TCUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMODL))
				request.WithQueryParameter("FMODL", m3_FMODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TMODL))
				request.WithQueryParameter("TMODL", m3_TMODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FAOTY))
				request.WithQueryParameter("FAOTY", m3_FAOTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAOTY))
				request.WithQueryParameter("TAOTY", m3_TAOTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFACI))
				request.WithQueryParameter("FFACI", m3_FFACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFACI))
				request.WithQueryParameter("TFACI", m3_TFACI.Trim());
			if (m3_FOPRI.HasValue)
				request.WithQueryParameter("FOPRI", m3_FOPRI.Value.ToString());
			if (m3_TOPRI.HasValue)
				request.WithQueryParameter("TOPRI", m3_TOPRI.Value.ToString());
			if (m3_CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3_CPPL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORN1))
				request.WithQueryParameter("ORN1", m3_ORN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORN2))
				request.WithQueryParameter("ORN2", m3_ORN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORN3))
				request.WithQueryParameter("ORN3", m3_ORN3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORN4))
				request.WithQueryParameter("ORN4", m3_ORN4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORN5))
				request.WithQueryParameter("ORN5", m3_ORN5.Trim());

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
