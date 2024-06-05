/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3STNO">Specification Item number</param>
		/// <param name="m3SMGP">From Quality group</param>
		/// <param name="m3QSE1">Effective date</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3SPET">Spec type</param>
		/// <param name="m3QSI1">Inactive date</param>
		/// <param name="m3QSI2">Inactive time</param>
		/// <param name="m3SPRE">LI specification manager</param>
		/// <param name="m3SPAN">Laboratory manager</param>
		/// <param name="m3NBEX">Number of copies</param>
		/// <param name="m3SI01">Comments</param>
		/// <param name="m3SI02">Comments</param>
		/// <param name="m3SI03">Comments</param>
		/// <param name="m3SI04">Comments</param>
		/// <param name="m3SI05">Comments</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddOrderSpec(
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3SPEC = null, 
			string m3ITNO = null, 
			string m3STNO = null, 
			string m3SMGP = null, 
			DateTime? m3QSE1 = null, 
			int? m3QSE2 = null, 
			string m3TX40 = null, 
			int? m3SPET = null, 
			DateTime? m3QSI1 = null, 
			int? m3QSI2 = null, 
			string m3SPRE = null, 
			string m3SPAN = null, 
			int? m3NBEX = null, 
			string m3SI01 = null, 
			string m3SI02 = null, 
			string m3SI03 = null, 
			string m3SI04 = null, 
			string m3SI05 = null, 
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
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STNO))
				request.WithQueryParameter("STNO", m3STNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMGP))
				request.WithQueryParameter("SMGP", m3SMGP.Trim());
			if (m3QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3QSE1.Value.ToM3String());
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (m3SPET.HasValue)
				request.WithQueryParameter("SPET", m3SPET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QSI1.HasValue)
				request.WithQueryParameter("QSI1", m3QSI1.Value.ToM3String());
			if (m3QSI2.HasValue)
				request.WithQueryParameter("QSI2", m3QSI2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPRE))
				request.WithQueryParameter("SPRE", m3SPRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPAN))
				request.WithQueryParameter("SPAN", m3SPAN.Trim());
			if (m3NBEX.HasValue)
				request.WithQueryParameter("NBEX", m3NBEX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SI01))
				request.WithQueryParameter("SI01", m3SI01.Trim());
			if (!string.IsNullOrWhiteSpace(m3SI02))
				request.WithQueryParameter("SI02", m3SI02.Trim());
			if (!string.IsNullOrWhiteSpace(m3SI03))
				request.WithQueryParameter("SI03", m3SI03.Trim());
			if (!string.IsNullOrWhiteSpace(m3SI04))
				request.WithQueryParameter("SI04", m3SI04.Trim());
			if (!string.IsNullOrWhiteSpace(m3SI05))
				request.WithQueryParameter("SI05", m3SI05.Trim());

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
		/// Name DltOrderSpec
		/// Description Delete Order Spec
		/// Version Release: 
		/// </summary>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3QSE1">Effective date</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltOrderSpec(
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3SPEC = null, 
			string m3ITNO = null, 
			DateTime? m3QSE1 = null, 
			int? m3QSE2 = null, 
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
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3QSE1.Value.ToM3String());
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetOrderSpec
		/// Description Get Order Specification
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3QSE1">Effective date</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOrderSpecResponse></returns>
		/// <exception cref="M3Exception<GetOrderSpecResponse>"></exception>
		public async Task<M3Response<GetOrderSpecResponse>> GetOrderSpec(
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3SPEC = null, 
			string m3ITNO = null, 
			DateTime? m3QSE1 = null, 
			int? m3QSE2 = null, 
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
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3QSE1.Value.ToM3String());
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetOrderSpecResponse>(
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
		/// Name LstOrderSpec
		/// Description List Order Specifications
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3QSE1">Effective date</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOrderSpecResponse></returns>
		/// <exception cref="M3Exception<LstOrderSpecResponse>"></exception>
		public async Task<M3Response<LstOrderSpecResponse>> LstOrderSpec(
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3SPEC = null, 
			string m3ITNO = null, 
			DateTime? m3QSE1 = null, 
			int? m3QSE2 = null, 
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
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3QSE1.Value.ToM3String());
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstOrderSpecResponse>(
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
		/// Name UpdOrderSpec
		/// Description Update Order Specification
		/// Version Release: 
		/// </summary>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3SPEC">Specification</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3QSE1">Effective date</param>
		/// <param name="m3QSE2">Effective time</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3SPET">Spec type</param>
		/// <param name="m3QSI1">Inactive date</param>
		/// <param name="m3QSI2">Inactive time</param>
		/// <param name="m3SPRE">LI specification manager</param>
		/// <param name="m3SPAN">Laboratory manager</param>
		/// <param name="m3NBEX">Number of copies</param>
		/// <param name="m3SI01">Comments</param>
		/// <param name="m3SI02">Comments</param>
		/// <param name="m3SI03">Comments</param>
		/// <param name="m3SI04">Comments</param>
		/// <param name="m3SI05">Comments</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdOrderSpec(
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3SPEC = null, 
			string m3ITNO = null, 
			DateTime? m3QSE1 = null, 
			int? m3QSE2 = null, 
			string m3TX40 = null, 
			int? m3SPET = null, 
			DateTime? m3QSI1 = null, 
			int? m3QSI2 = null, 
			string m3SPRE = null, 
			string m3SPAN = null, 
			int? m3NBEX = null, 
			string m3SI01 = null, 
			string m3SI02 = null, 
			string m3SI03 = null, 
			string m3SI04 = null, 
			string m3SI05 = null, 
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
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPEC))
				request.WithQueryParameter("SPEC", m3SPEC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3QSE1.HasValue)
				request.WithQueryParameter("QSE1", m3QSE1.Value.ToM3String());
			if (m3QSE2.HasValue)
				request.WithQueryParameter("QSE2", m3QSE2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (m3SPET.HasValue)
				request.WithQueryParameter("SPET", m3SPET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QSI1.HasValue)
				request.WithQueryParameter("QSI1", m3QSI1.Value.ToM3String());
			if (m3QSI2.HasValue)
				request.WithQueryParameter("QSI2", m3QSI2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPRE))
				request.WithQueryParameter("SPRE", m3SPRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPAN))
				request.WithQueryParameter("SPAN", m3SPAN.Trim());
			if (m3NBEX.HasValue)
				request.WithQueryParameter("NBEX", m3NBEX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SI01))
				request.WithQueryParameter("SI01", m3SI01.Trim());
			if (!string.IsNullOrWhiteSpace(m3SI02))
				request.WithQueryParameter("SI02", m3SI02.Trim());
			if (!string.IsNullOrWhiteSpace(m3SI03))
				request.WithQueryParameter("SI03", m3SI03.Trim());
			if (!string.IsNullOrWhiteSpace(m3SI04))
				request.WithQueryParameter("SI04", m3SI04.Trim());
			if (!string.IsNullOrWhiteSpace(m3SI05))
				request.WithQueryParameter("SI05", m3SI05.Trim());

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
