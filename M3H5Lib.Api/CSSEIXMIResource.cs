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
	/// Name: CSSEIXMI
	/// Component Name: Sales
	/// Description: Api: External Supplier Information Temporary orders
	/// Version Release: 
	///</summary>
	public partial class CSSEIXMIResource : M3BaseResourceEndpoint
	{
		public CSSEIXMIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CSSEIXMI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name UpdExtInfSts15
		/// Description Update External Information Status 15
		/// Version Release: 
		/// </summary>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="m3ALI1">Transaction number</param>
		/// <param name="m3EREF">External reference</param>
		/// <param name="m3IATH">Item authorized</param>
		/// <param name="m3ATHL">Authorization level</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdExtInfSts15(
			string m3ORCA = null, 
			string m3RIDN = null, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
			int? m3ALI1 = null, 
			string m3EREF = null, 
			string m3IATH = null, 
			string m3ATHL = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdExtInfSts15",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALI1.HasValue)
				request.WithQueryParameter("ALI1", m3ALI1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EREF))
				request.WithQueryParameter("EREF", m3EREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3IATH))
				request.WithQueryParameter("IATH", m3IATH.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATHL))
				request.WithQueryParameter("ATHL", m3ATHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());

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
