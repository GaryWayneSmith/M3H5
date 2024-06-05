/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name PrintConfirm
		/// Description PrintConfirmation
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3FRLDT">Requested delivery date from</param>
		/// <param name="m3TRLDT">Requested delivery date to</param>
		/// <param name="m3FORNO">Customer order number from</param>
		/// <param name="m3FPONR">Order line number from</param>
		/// <param name="m3TORNO">Customer order number to</param>
		/// <param name="m3TPONR">Order line number to</param>
		/// <param name="m3FCUNO">Customer from</param>
		/// <param name="m3TCUNO">Customer to</param>
		/// <param name="m3FMODL">Delivery method from</param>
		/// <param name="m3TMODL">Delivery method to</param>
		/// <param name="m3FAOTY">Order type from</param>
		/// <param name="m3TAOTY">Order type tp</param>
		/// <param name="m3FFACI">Facility from</param>
		/// <param name="m3TFACI">Facility to</param>
		/// <param name="m3FOPRI">Priority from</param>
		/// <param name="m3TOPRI">Priority to</param>
		/// <param name="m3CPPL">Copy</param>
		/// <param name="m3ORN1">Customer order number 1</param>
		/// <param name="m3ORN2">Customer order number 2</param>
		/// <param name="m3ORN3">Customer order number 3</param>
		/// <param name="m3ORN4">Customer order number 4</param>
		/// <param name="m3ORN5">Customer order number 5</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrintConfirm(
			DateTime? m3FRLDT = null, 
			DateTime? m3TRLDT = null, 
			string m3FORNO = null, 
			int? m3FPONR = null, 
			string m3TORNO = null, 
			int? m3TPONR = null, 
			string m3FCUNO = null, 
			string m3TCUNO = null, 
			string m3FMODL = null, 
			string m3TMODL = null, 
			string m3FAOTY = null, 
			string m3TAOTY = null, 
			string m3FFACI = null, 
			string m3TFACI = null, 
			int? m3FOPRI = null, 
			int? m3TOPRI = null, 
			int? m3CPPL = null, 
			string m3ORN1 = null, 
			string m3ORN2 = null, 
			string m3ORN3 = null, 
			string m3ORN4 = null, 
			string m3ORN5 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/PrintConfirm",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3FRLDT.HasValue)
				request.WithQueryParameter("FRLDT", m3FRLDT.Value.ToM3String());
			if (m3TRLDT.HasValue)
				request.WithQueryParameter("TRLDT", m3TRLDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3FORNO))
				request.WithQueryParameter("FORNO", m3FORNO.Trim());
			if (m3FPONR.HasValue)
				request.WithQueryParameter("FPONR", m3FPONR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TORNO))
				request.WithQueryParameter("TORNO", m3TORNO.Trim());
			if (m3TPONR.HasValue)
				request.WithQueryParameter("TPONR", m3TPONR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FCUNO))
				request.WithQueryParameter("FCUNO", m3FCUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TCUNO))
				request.WithQueryParameter("TCUNO", m3TCUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMODL))
				request.WithQueryParameter("FMODL", m3FMODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TMODL))
				request.WithQueryParameter("TMODL", m3TMODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3FAOTY))
				request.WithQueryParameter("FAOTY", m3FAOTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAOTY))
				request.WithQueryParameter("TAOTY", m3TAOTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFACI))
				request.WithQueryParameter("FFACI", m3FFACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFACI))
				request.WithQueryParameter("TFACI", m3TFACI.Trim());
			if (m3FOPRI.HasValue)
				request.WithQueryParameter("FOPRI", m3FOPRI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOPRI.HasValue)
				request.WithQueryParameter("TOPRI", m3TOPRI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3CPPL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORN1))
				request.WithQueryParameter("ORN1", m3ORN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORN2))
				request.WithQueryParameter("ORN2", m3ORN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORN3))
				request.WithQueryParameter("ORN3", m3ORN3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORN4))
				request.WithQueryParameter("ORN4", m3ORN4.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORN5))
				request.WithQueryParameter("ORN5", m3ORN5.Trim());

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
