/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.QMS500MI;
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
	/// Name: QMS500MI
	/// Component Name: Order Specification
	/// Description: Api:Order Specification Interface
	/// Version Release: 5ea0
	///</summary>
	public partial class QMS500MIResource : M3BaseResourceEndpoint
	{
		public QMS500MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QMS500MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddOrderSpec
		/// Description Add Order Specification
		/// Version Release: 
		/// </summary>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_STNO">Specification Item number</param>
		/// <param name="m3_SMGP">From Quality group</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_SPET">Spec type</param>
		/// <param name="m3_QSI1">Inactive date</param>
		/// <param name="m3_QSI2">Inactive time</param>
		/// <param name="m3_SPRE">LI specification manager</param>
		/// <param name="m3_SPAN">Laboratory manager</param>
		/// <param name="m3_NBEX">Number of copies</param>
		/// <param name="m3_SI01">Comments</param>
		/// <param name="m3_SI02">Comments</param>
		/// <param name="m3_SI03">Comments</param>
		/// <param name="m3_SI04">Comments</param>
		/// <param name="m3_SI05">Comments</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddOrderSpec(
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_SPEC = null, 
			string m3_ITNO = null, 
			string m3_STNO = null, 
			string m3_SMGP = null, 
			DateTime? m3_QSE1 = null, 
			int? m3_QSE2 = null, 
			string m3_TX40 = null, 
			int? m3_SPET = null, 
			DateTime? m3_QSI1 = null, 
			int? m3_QSI2 = null, 
			string m3_SPRE = null, 
			string m3_SPAN = null, 
			int? m3_NBEX = null, 
			string m3_SI01 = null, 
			string m3_SI02 = null, 
			string m3_SI03 = null, 
			string m3_SI04 = null, 
			string m3_SI05 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddOrderSpec",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STNO))
				request.WithQueryParameter("STNO", m3_STNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMGP))
				request.WithQueryParameter("SMGP", m3_SMGP.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (m3_SPET.HasValue)
				request.WithQueryParameter("SPET", m3_SPET.Value.ToString());
			if (m3_QSI1.HasValue)
				request.WithQueryParameter("QSI1", m3_QSI1.Value.ToM3String());
			if (m3_QSI2.HasValue)
				request.WithQueryParameter("QSI2", m3_QSI2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPRE))
				request.WithQueryParameter("SPRE", m3_SPRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPAN))
				request.WithQueryParameter("SPAN", m3_SPAN.Trim());
			if (m3_NBEX.HasValue)
				request.WithQueryParameter("NBEX", m3_NBEX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SI01))
				request.WithQueryParameter("SI01", m3_SI01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SI02))
				request.WithQueryParameter("SI02", m3_SI02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SI03))
				request.WithQueryParameter("SI03", m3_SI03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SI04))
				request.WithQueryParameter("SI04", m3_SI04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SI05))
				request.WithQueryParameter("SI05", m3_SI05.Trim());

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
		/// Name DltOrderSpec
		/// Description Delete Order Spec
		/// Version Release: 
		/// </summary>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltOrderSpec(
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_SPEC = null, 
			string m3_ITNO = null, 
			DateTime? m3_QSE1 = null, 
			int? m3_QSE2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltOrderSpec",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());

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
		/// Name GetOrderSpec
		/// Description Get Order Specification
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOrderSpecResponse></returns>
		/// <exception cref="M3Exception<GetOrderSpecResponse>"></exception>
		public async Task<M3Response<GetOrderSpecResponse>> GetOrderSpec(
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_SPEC = null, 
			string m3_ITNO = null, 
			DateTime? m3_QSE1 = null, 
			int? m3_QSE2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetOrderSpec",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());

			// Execute the request
			var result = await Execute<GetOrderSpecResponse>(
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
		/// Name LstOrderSpec
		/// Description List Order Specifications
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOrderSpecResponse></returns>
		/// <exception cref="M3Exception<LstOrderSpecResponse>"></exception>
		public async Task<M3Response<LstOrderSpecResponse>> LstOrderSpec(
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_SPEC = null, 
			string m3_ITNO = null, 
			DateTime? m3_QSE1 = null, 
			int? m3_QSE2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstOrderSpec",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());

			// Execute the request
			var result = await Execute<LstOrderSpecResponse>(
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
		/// Name UpdOrderSpec
		/// Description Update Order Specification
		/// Version Release: 
		/// </summary>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_SPEC">Specification</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_QSE1">Effective date</param>
		/// <param name="m3_QSE2">Effective time</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_SPET">Spec type</param>
		/// <param name="m3_QSI1">Inactive date</param>
		/// <param name="m3_QSI2">Inactive time</param>
		/// <param name="m3_SPRE">LI specification manager</param>
		/// <param name="m3_SPAN">Laboratory manager</param>
		/// <param name="m3_NBEX">Number of copies</param>
		/// <param name="m3_SI01">Comments</param>
		/// <param name="m3_SI02">Comments</param>
		/// <param name="m3_SI03">Comments</param>
		/// <param name="m3_SI04">Comments</param>
		/// <param name="m3_SI05">Comments</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdOrderSpec(
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_SPEC = null, 
			string m3_ITNO = null, 
			DateTime? m3_QSE1 = null, 
			int? m3_QSE2 = null, 
			string m3_TX40 = null, 
			int? m3_SPET = null, 
			DateTime? m3_QSI1 = null, 
			int? m3_QSI2 = null, 
			string m3_SPRE = null, 
			string m3_SPAN = null, 
			int? m3_NBEX = null, 
			string m3_SI01 = null, 
			string m3_SI02 = null, 
			string m3_SI03 = null, 
			string m3_SI04 = null, 
			string m3_SI05 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdOrderSpec",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPEC))
				request.WithQueryParameter("SPEC", m3_SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3_QSE1.Value.ToM3String());
			if (m3_QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3_QSE2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (m3_SPET.HasValue)
				request.WithQueryParameter("SPET", m3_SPET.Value.ToString());
			if (m3_QSI1.HasValue)
				request.WithQueryParameter("QSI1", m3_QSI1.Value.ToM3String());
			if (m3_QSI2.HasValue)
				request.WithQueryParameter("QSI2", m3_QSI2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPRE))
				request.WithQueryParameter("SPRE", m3_SPRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPAN))
				request.WithQueryParameter("SPAN", m3_SPAN.Trim());
			if (m3_NBEX.HasValue)
				request.WithQueryParameter("NBEX", m3_NBEX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SI01))
				request.WithQueryParameter("SI01", m3_SI01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SI02))
				request.WithQueryParameter("SI02", m3_SI02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SI03))
				request.WithQueryParameter("SI03", m3_SI03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SI04))
				request.WithQueryParameter("SI04", m3_SI04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SI05))
				request.WithQueryParameter("SI05", m3_SI05.Trim());

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
