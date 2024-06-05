/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
	/// Name: APS455MI
	/// Component Name: SupplierInvoiceBatch
	/// Description: Supplier invoice batch - submitted
	/// Version Release: 15.1
	///</summary>
	public partial class APS455MIResource : M3BaseResourceEndpoint
	{
		public APS455MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "APS455MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ValidByBatchNo
		/// Description Validate by batch number
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3INBN">Invoice batch number (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ValidByBatchNo(
			long m3INBN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ValidByBatchNo",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("INBN", m3INBN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
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
		/// Name ValidBySelect
		/// Description Validate by selection
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3FSIN">Supplier invoice number</param>
		/// <param name="m3TSIN">Supplier invoice number</param>
		/// <param name="m3FINB">Invoice batch number</param>
		/// <param name="m3TINB">Invoice batch number</param>
		/// <param name="m3FIBT">Invoice batch type</param>
		/// <param name="m3TIBT">Invoice batch type</param>
		/// <param name="m3FSUP">Invoice status</param>
		/// <param name="m3TSUP">Invoice status</param>
		/// <param name="m3FSUN">Supplier</param>
		/// <param name="m3TSUN">Supplier</param>
		/// <param name="m3FIVD">Invoice date</param>
		/// <param name="m3TIVD">Invoice date</param>
		/// <param name="m3FAPC">Authorized user</param>
		/// <param name="m3TAPC">Authorized user</param>
		/// <param name="m3FIBH">Invoice batch head error</param>
		/// <param name="m3TIBH">Invoice batch head error</param>
		/// <param name="m3FIBL">Invoice batch line error</param>
		/// <param name="m3TIBL">Invoice batch line error</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ValidBySelect(
			string m3DIVI = null, 
			string m3FSIN = null, 
			string m3TSIN = null, 
			long? m3FINB = null, 
			long? m3TINB = null, 
			string m3FIBT = null, 
			string m3TIBT = null, 
			int? m3FSUP = null, 
			int? m3TSUP = null, 
			string m3FSUN = null, 
			string m3TSUN = null, 
			DateTime? m3FIVD = null, 
			DateTime? m3TIVD = null, 
			string m3FAPC = null, 
			string m3TAPC = null, 
			int? m3FIBH = null, 
			int? m3TIBH = null, 
			int? m3FIBL = null, 
			int? m3TIBL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ValidBySelect",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FSIN))
				request.WithQueryParameter("FSIN", m3FSIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSIN))
				request.WithQueryParameter("TSIN", m3TSIN.Trim());
			if (m3FINB.HasValue)
				request.WithQueryParameter("FINB", m3FINB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TINB.HasValue)
				request.WithQueryParameter("TINB", m3TINB.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FIBT))
				request.WithQueryParameter("FIBT", m3FIBT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TIBT))
				request.WithQueryParameter("TIBT", m3TIBT.Trim());
			if (m3FSUP.HasValue)
				request.WithQueryParameter("FSUP", m3FSUP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TSUP.HasValue)
				request.WithQueryParameter("TSUP", m3TSUP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FSUN))
				request.WithQueryParameter("FSUN", m3FSUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSUN))
				request.WithQueryParameter("TSUN", m3TSUN.Trim());
			if (m3FIVD.HasValue)
				request.WithQueryParameter("FIVD", m3FIVD.Value.ToM3String());
			if (m3TIVD.HasValue)
				request.WithQueryParameter("TIVD", m3TIVD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3FAPC))
				request.WithQueryParameter("FAPC", m3FAPC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAPC))
				request.WithQueryParameter("TAPC", m3TAPC.Trim());
			if (m3FIBH.HasValue)
				request.WithQueryParameter("FIBH", m3FIBH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TIBH.HasValue)
				request.WithQueryParameter("TIBH", m3TIBH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FIBL.HasValue)
				request.WithQueryParameter("FIBL", m3FIBL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TIBL.HasValue)
				request.WithQueryParameter("TIBL", m3TIBL.Value.ToString(CultureInfo.CurrentCulture));

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
