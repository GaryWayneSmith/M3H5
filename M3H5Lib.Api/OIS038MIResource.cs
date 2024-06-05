/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.OIS038MI;
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
	/// Name: OIS038MI
	/// Component Name: BusinessChain
	/// Description: Business chain structure interface
	/// Version Release: 5ea0
	///</summary>
	public partial class OIS038MIResource : M3BaseResourceEndpoint
	{
		public OIS038MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS038MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddBusChain
		/// Description Add Business Chain
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CHAI">Business chain (Required)</param>
		/// <param name="m3CHCT">Superior business chain</param>
		/// <param name="m3CHMB">Member number</param>
		/// <param name="m3MBST">Status - member</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBusChain(
			string m3CHAI, 
			string m3CHCT = null, 
			string m3CHMB = null, 
			int? m3MBST = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddBusChain",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CHAI))
				throw new ArgumentNullException(nameof(m3CHAI));

			// Set mandatory parameters
			request
				.WithQueryParameter("CHAI", m3CHAI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CHCT))
				request.WithQueryParameter("CHCT", m3CHCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHMB))
				request.WithQueryParameter("CHMB", m3CHMB.Trim());
			if (m3MBST.HasValue)
				request.WithQueryParameter("MBST", m3MBST.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddBusChainCust
		/// Description Add Customer in Business Chain
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CHCT">Superior business chain (Required)</param>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3CHMB">Member number</param>
		/// <param name="m3MBST">Status - member</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBusChainCust(
			string m3CHCT, 
			string m3CUNO, 
			DateTime? m3FVDT = null, 
			DateTime? m3LVDT = null, 
			string m3CHMB = null, 
			int? m3MBST = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddBusChainCust",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CHCT))
				throw new ArgumentNullException(nameof(m3CHCT));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CHCT", m3CHCT.Trim())
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CHMB))
				request.WithQueryParameter("CHMB", m3CHMB.Trim());
			if (m3MBST.HasValue)
				request.WithQueryParameter("MBST", m3MBST.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelBusChain
		/// Description Delete Business Chain
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CHAI">Business chain (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelBusChain(
			string m3CHAI, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelBusChain",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CHAI))
				throw new ArgumentNullException(nameof(m3CHAI));

			// Set mandatory parameters
			request
				.WithQueryParameter("CHAI", m3CHAI.Trim());

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
		/// Name DelBusChainCust
		/// Description Delete Customer in Business Chain
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CHCT">Superior business chain (Required)</param>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelBusChainCust(
			string m3CHCT, 
			string m3CUNO, 
			DateTime? m3FVDT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelBusChainCust",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CHCT))
				throw new ArgumentNullException(nameof(m3CHCT));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CHCT", m3CHCT.Trim())
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());

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
		/// Name LstBusChainCust
		/// Description List business chain to customer relations
		/// Version Release: 12
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CHCT">Superior business chain</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3DATE">Entry date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBusChainCustResponse></returns>
		/// <exception cref="M3Exception<LstBusChainCustResponse>"></exception>
		public async Task<M3Response<LstBusChainCustResponse>> LstBusChainCust(
			int? m3CONO = null, 
			string m3CHCT = null, 
			string m3CUNO = null, 
			DateTime? m3DATE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstBusChainCust",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHCT))
				request.WithQueryParameter("CHCT", m3CHCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3DATE.HasValue)
				request.WithQueryParameter("DATE", m3DATE.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstBusChainCustResponse>(
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
		/// Name LstBusChainStr
		/// Description List business chain structure
		/// Version Release: 12
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CHAI">Business chain</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBusChainStrResponse></returns>
		/// <exception cref="M3Exception<LstBusChainStrResponse>"></exception>
		public async Task<M3Response<LstBusChainStrResponse>> LstBusChainStr(
			int? m3CONO = null, 
			string m3CHAI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstBusChainStr",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHAI))
				request.WithQueryParameter("CHAI", m3CHAI.Trim());

			// Execute the request
			var result = await Execute<LstBusChainStrResponse>(
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
		/// Name UpdBusChain
		/// Description Update Business Chain
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CHAI">Business chain (Required)</param>
		/// <param name="m3CHCT">Superior business chain</param>
		/// <param name="m3CHMB">Member number</param>
		/// <param name="m3MBST">Status - member</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdBusChain(
			string m3CHAI, 
			string m3CHCT = null, 
			string m3CHMB = null, 
			int? m3MBST = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdBusChain",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CHAI))
				throw new ArgumentNullException(nameof(m3CHAI));

			// Set mandatory parameters
			request
				.WithQueryParameter("CHAI", m3CHAI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CHCT))
				request.WithQueryParameter("CHCT", m3CHCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHMB))
				request.WithQueryParameter("CHMB", m3CHMB.Trim());
			if (m3MBST.HasValue)
				request.WithQueryParameter("MBST", m3MBST.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdBusChainCust
		/// Description Update Customer in Business Chain
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CHCT">Superior business chain (Required)</param>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3CHMB">Member number</param>
		/// <param name="m3MBST">Status - member</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdBusChainCust(
			string m3CHCT, 
			string m3CUNO, 
			DateTime? m3FVDT = null, 
			DateTime? m3LVDT = null, 
			string m3CHMB = null, 
			int? m3MBST = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdBusChainCust",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CHCT))
				throw new ArgumentNullException(nameof(m3CHCT));
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CHCT", m3CHCT.Trim())
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CHMB))
				request.WithQueryParameter("CHMB", m3CHMB.Trim());
			if (m3MBST.HasValue)
				request.WithQueryParameter("MBST", m3MBST.Value.ToString(CultureInfo.CurrentCulture));

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
