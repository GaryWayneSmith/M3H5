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
		/// <param name="m3_INBN">Invoice batch number (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ValidByBatchNo(
			long m3_INBN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ValidByBatchNo",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("INBN", m3_INBN.ToString());

			// Set optional parameters, checking for null/blank data for each element
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
		/// Name ValidBySelect
		/// Description Validate by selection
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_FSIN">Supplier invoice number</param>
		/// <param name="m3_TSIN">Supplier invoice number</param>
		/// <param name="m3_FINB">Invoice batch number</param>
		/// <param name="m3_TINB">Invoice batch number</param>
		/// <param name="m3_FIBT">Invoice batch type</param>
		/// <param name="m3_TIBT">Invoice batch type</param>
		/// <param name="m3_FSUP">Invoice status</param>
		/// <param name="m3_TSUP">Invoice status</param>
		/// <param name="m3_FSUN">Supplier</param>
		/// <param name="m3_TSUN">Supplier</param>
		/// <param name="m3_FIVD">Invoice date</param>
		/// <param name="m3_TIVD">Invoice date</param>
		/// <param name="m3_FAPC">Authorized user</param>
		/// <param name="m3_TAPC">Authorized user</param>
		/// <param name="m3_FIBH">Invoice batch head error</param>
		/// <param name="m3_TIBH">Invoice batch head error</param>
		/// <param name="m3_FIBL">Invoice batch line error</param>
		/// <param name="m3_TIBL">Invoice batch line error</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ValidBySelect(
			string m3_DIVI = null, 
			string m3_FSIN = null, 
			string m3_TSIN = null, 
			long? m3_FINB = null, 
			long? m3_TINB = null, 
			string m3_FIBT = null, 
			string m3_TIBT = null, 
			int? m3_FSUP = null, 
			int? m3_TSUP = null, 
			string m3_FSUN = null, 
			string m3_TSUN = null, 
			DateTime? m3_FIVD = null, 
			DateTime? m3_TIVD = null, 
			string m3_FAPC = null, 
			string m3_TAPC = null, 
			int? m3_FIBH = null, 
			int? m3_TIBH = null, 
			int? m3_FIBL = null, 
			int? m3_TIBL = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FSIN))
				request.WithQueryParameter("FSIN", m3_FSIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSIN))
				request.WithQueryParameter("TSIN", m3_TSIN.Trim());
			if (m3_FINB.HasValue)
				request.WithQueryParameter("FINB", m3_FINB.Value.ToString());
			if (m3_TINB.HasValue)
				request.WithQueryParameter("TINB", m3_TINB.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FIBT))
				request.WithQueryParameter("FIBT", m3_FIBT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TIBT))
				request.WithQueryParameter("TIBT", m3_TIBT.Trim());
			if (m3_FSUP.HasValue)
				request.WithQueryParameter("FSUP", m3_FSUP.Value.ToString());
			if (m3_TSUP.HasValue)
				request.WithQueryParameter("TSUP", m3_TSUP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FSUN))
				request.WithQueryParameter("FSUN", m3_FSUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSUN))
				request.WithQueryParameter("TSUN", m3_TSUN.Trim());
			if (m3_FIVD.HasValue)
				request.WithQueryParameter("FIVD", m3_FIVD.Value.ToM3String());
			if (m3_TIVD.HasValue)
				request.WithQueryParameter("TIVD", m3_TIVD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_FAPC))
				request.WithQueryParameter("FAPC", m3_FAPC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAPC))
				request.WithQueryParameter("TAPC", m3_TAPC.Trim());
			if (m3_FIBH.HasValue)
				request.WithQueryParameter("FIBH", m3_FIBH.Value.ToString());
			if (m3_TIBH.HasValue)
				request.WithQueryParameter("TIBH", m3_TIBH.Value.ToString());
			if (m3_FIBL.HasValue)
				request.WithQueryParameter("FIBL", m3_FIBL.Value.ToString());
			if (m3_TIBL.HasValue)
				request.WithQueryParameter("TIBL", m3_TIBL.Value.ToString());

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
