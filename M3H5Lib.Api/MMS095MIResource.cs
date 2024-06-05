/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.MMS095MI;
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
	/// Name: MMS095MI
	/// Component Name: ItemStatisticRelation
	/// Description: Copy item statistics interface
	/// Version Release: 15.1
	///</summary>
	public partial class MMS095MIResource : M3BaseResourceEndpoint
	{
		public MMS095MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS095MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add item statistics relation
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3FWHL">From warehouse (Required)</param>
		/// <param name="m3FITN">From item number (Required)</param>
		/// <param name="m3CUCO">Replace statistics (Required)</param>
		/// <param name="m3FPER">Period</param>
		/// <param name="m3TPER">Period</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3WHLO, 
			string m3ITNO, 
			string m3FWHL, 
			string m3FITN, 
			int m3CUCO, 
			int? m3FPER = null, 
			int? m3TPER = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3FWHL))
				throw new ArgumentNullException(nameof(m3FWHL));
			if (string.IsNullOrWhiteSpace(m3FITN))
				throw new ArgumentNullException(nameof(m3FITN));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("FWHL", m3FWHL.Trim())
				.WithQueryParameter("FITN", m3FITN.Trim())
				.WithQueryParameter("CUCO", m3CUCO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3FPER.HasValue)
				request.WithQueryParameter("FPER", m3FPER.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TPER.HasValue)
				request.WithQueryParameter("TPER", m3TPER.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Del
		/// Description Delete item statistics relation
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3FWHL">From warehouse (Required)</param>
		/// <param name="m3FITN">From item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DelResponse></returns>
		/// <exception cref="M3Exception<DelResponse>"></exception>
		public async Task<M3Response<DelResponse>> Del(
			string m3WHLO, 
			string m3ITNO, 
			string m3FWHL, 
			string m3FITN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Del",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3FWHL))
				throw new ArgumentNullException(nameof(m3FWHL));
			if (string.IsNullOrWhiteSpace(m3FITN))
				throw new ArgumentNullException(nameof(m3FITN));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("FWHL", m3FWHL.Trim())
				.WithQueryParameter("FITN", m3FITN.Trim());

			// Execute the request
			var result = await Execute<DelResponse>(
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
		/// Name Imp
		/// Description Implement item statistics relation
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3FWHL">From warehouse (Required)</param>
		/// <param name="m3FITN">From item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ImpResponse></returns>
		/// <exception cref="M3Exception<ImpResponse>"></exception>
		public async Task<M3Response<ImpResponse>> Imp(
			string m3WHLO, 
			string m3ITNO, 
			string m3FWHL, 
			string m3FITN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Imp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3FWHL))
				throw new ArgumentNullException(nameof(m3FWHL));
			if (string.IsNullOrWhiteSpace(m3FITN))
				throw new ArgumentNullException(nameof(m3FITN));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("FWHL", m3FWHL.Trim())
				.WithQueryParameter("FITN", m3FITN.Trim());

			// Execute the request
			var result = await Execute<ImpResponse>(
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
		/// Name ImpAll
		/// Description Implement all item statistic realtions
		/// Version Release: 15.1
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ImpAllResponse></returns>
		/// <exception cref="M3Exception<ImpAllResponse>"></exception>
		public async Task<M3Response<ImpAllResponse>> ImpAll(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ImpAll",
			};

			// Execute the request
			var result = await Execute<ImpAllResponse>(
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
