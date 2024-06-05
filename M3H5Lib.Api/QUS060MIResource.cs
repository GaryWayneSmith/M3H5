/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.QUS060MI;
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
	/// Name: QUS060MI
	/// Component Name: Attribute
	/// Description: Attribute Template
	/// Version Release: 5e90
	///</summary>
	public partial class QUS060MIResource : M3BaseResourceEndpoint
	{
		public QUS060MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "QUS060MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAtte
		/// Description Add a attribute template
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3ATTE">Attribute template (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3ATID">Attribute identity (Required)</param>
		/// <param name="m3ATVA">Attribute value (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAtte(
			string m3ATTE, 
			string m3TX40, 
			string m3ATID, 
			string m3ATVA, 
			string m3TX15 = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddAtte",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ATTE))
				throw new ArgumentNullException(nameof(m3ATTE));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));
			if (string.IsNullOrWhiteSpace(m3ATID))
				throw new ArgumentNullException(nameof(m3ATID));
			if (string.IsNullOrWhiteSpace(m3ATVA))
				throw new ArgumentNullException(nameof(m3ATVA));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATTE", m3ATTE.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim())
				.WithQueryParameter("ATID", m3ATID.Trim())
				.WithQueryParameter("ATVA", m3ATVA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());

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
		/// Name DltAtte
		/// Description Delete a attribute template
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3ATTE">Attribute template (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltAtte(
			string m3ATTE, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltAtte",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ATTE))
				throw new ArgumentNullException(nameof(m3ATTE));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATTE", m3ATTE.Trim());

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
		/// Name GetAtte
		/// Description Get data for a attribute template
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3ATTE">Attribute template (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAtteResponse></returns>
		/// <exception cref="M3Exception<GetAtteResponse>"></exception>
		public async Task<M3Response<GetAtteResponse>> GetAtte(
			string m3ATTE, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAtte",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ATTE))
				throw new ArgumentNullException(nameof(m3ATTE));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATTE", m3ATTE.Trim());

			// Execute the request
			var result = await Execute<GetAtteResponse>(
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
		/// Name LstAtte
		/// Description List data for attribute template
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3ATTE">Attribute template</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAtteResponse></returns>
		/// <exception cref="M3Exception<LstAtteResponse>"></exception>
		public async Task<M3Response<LstAtteResponse>> LstAtte(
			string m3ATTE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAtte",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ATTE))
				request.WithQueryParameter("ATTE", m3ATTE.Trim());

			// Execute the request
			var result = await Execute<LstAtteResponse>(
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
		/// Name UpdAtte
		/// Description Update data for a attribute template
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3ATTE">Attribute template (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3ATID">Attribute identity</param>
		/// <param name="m3ATVA">Attribute value</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAtte(
			string m3ATTE, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3ATID = null, 
			string m3ATVA = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdAtte",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ATTE))
				throw new ArgumentNullException(nameof(m3ATTE));

			// Set mandatory parameters
			request
				.WithQueryParameter("ATTE", m3ATTE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATID))
				request.WithQueryParameter("ATID", m3ATID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATVA))
				request.WithQueryParameter("ATVA", m3ATVA.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());

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
