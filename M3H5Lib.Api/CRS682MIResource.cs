/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.CRS682MI;
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
	/// Name: CRS682MI
	/// Component Name: Insurance ID
	/// Description: Insurance ID
	/// Version Release: 5ea0
	///</summary>
	public partial class CRS682MIResource : M3BaseResourceEndpoint
	{
		public CRS682MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS682MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Enter Insurance data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3ITRQ">Insurance type (Required)</param>
		/// <param name="m3CIID">Insurance ID (Required)</param>
		/// <param name="m3INFD">Insured from date (Required)</param>
		/// <param name="m3INTD">Insured to date (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3INRQ">Insurance required</param>
		/// <param name="m3INFA">Insured for amount</param>
		/// <param name="m3IPOL">Insurance policy no</param>
		/// <param name="m3IVEN">Insurance vendor</param>
		/// <param name="m3NOT1">Note</param>
		/// <param name="m3NOT2">Note</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3CUNO, 
			int m3ITRQ, 
			string m3CIID, 
			DateTime m3INFD, 
			DateTime m3INTD, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			int? m3INRQ = null, 
			decimal? m3INFA = null, 
			string m3IPOL = null, 
			string m3IVEN = null, 
			string m3NOT1 = null, 
			string m3NOT2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3CIID))
				throw new ArgumentNullException(nameof(m3CIID));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("ITRQ", m3ITRQ.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CIID", m3CIID.Trim())
				.WithQueryParameter("INFD", m3INFD.ToM3String())
				.WithQueryParameter("INTD", m3INTD.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3INRQ.HasValue)
				request.WithQueryParameter("INRQ", m3INRQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INFA.HasValue)
				request.WithQueryParameter("INFA", m3INFA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3IPOL))
				request.WithQueryParameter("IPOL", m3IPOL.Trim());
			if (!string.IsNullOrWhiteSpace(m3IVEN))
				request.WithQueryParameter("IVEN", m3IVEN.Trim());
			if (!string.IsNullOrWhiteSpace(m3NOT1))
				request.WithQueryParameter("NOT1", m3NOT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3NOT2))
				request.WithQueryParameter("NOT2", m3NOT2.Trim());

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
		/// Name Delete
		/// Description Delete  Insurance data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3ITRQ">Insurance type (Required)</param>
		/// <param name="m3CIID">Insurance ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3CUNO, 
			int m3ITRQ, 
			string m3CIID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Delete",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3CIID))
				throw new ArgumentNullException(nameof(m3CIID));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("ITRQ", m3ITRQ.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CIID", m3CIID.Trim());

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
		/// Name Get
		/// Description Get  Insurance data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3ITRQ">Insurance type (Required)</param>
		/// <param name="m3CIID">Insurance ID (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3CUNO, 
			int m3ITRQ, 
			string m3CIID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3CIID))
				throw new ArgumentNullException(nameof(m3CIID));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("ITRQ", m3ITRQ.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CIID", m3CIID.Trim());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name Lst
		/// Description List  Insurance data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3CUNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Lst",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Execute the request
			var result = await Execute<LstResponse>(
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
		/// Name Upd
		/// Description Update Insurance data
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3ITRQ">Insurance type (Required)</param>
		/// <param name="m3CIID">Insurance ID (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3INRQ">Insurance required</param>
		/// <param name="m3INFD">Insured from date</param>
		/// <param name="m3INTD">Insured to date</param>
		/// <param name="m3INFA">Insured for amount</param>
		/// <param name="m3IPOL">Insurance policy no</param>
		/// <param name="m3IVEN">Insurance vendor</param>
		/// <param name="m3NOT1">Note</param>
		/// <param name="m3NOT2">Note</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3CUNO, 
			int m3ITRQ, 
			string m3CIID, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			int? m3INRQ = null, 
			DateTime? m3INFD = null, 
			DateTime? m3INTD = null, 
			decimal? m3INFA = null, 
			string m3IPOL = null, 
			string m3IVEN = null, 
			string m3NOT1 = null, 
			string m3NOT2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Upd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3CIID))
				throw new ArgumentNullException(nameof(m3CIID));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("ITRQ", m3ITRQ.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CIID", m3CIID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3INRQ.HasValue)
				request.WithQueryParameter("INRQ", m3INRQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INFD.HasValue)
				request.WithQueryParameter("INFD", m3INFD.Value.ToM3String());
			if (m3INTD.HasValue)
				request.WithQueryParameter("INTD", m3INTD.Value.ToM3String());
			if (m3INFA.HasValue)
				request.WithQueryParameter("INFA", m3INFA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3IPOL))
				request.WithQueryParameter("IPOL", m3IPOL.Trim());
			if (!string.IsNullOrWhiteSpace(m3IVEN))
				request.WithQueryParameter("IVEN", m3IVEN.Trim());
			if (!string.IsNullOrWhiteSpace(m3NOT1))
				request.WithQueryParameter("NOT1", m3NOT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3NOT2))
				request.WithQueryParameter("NOT2", m3NOT2.Trim());

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
