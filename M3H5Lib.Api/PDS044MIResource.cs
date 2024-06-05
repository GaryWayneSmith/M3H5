/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.PDS044MI;
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
	/// Name: PDS044MI
	/// Component Name: ProductOption
	/// Description: Product option interface
	/// Version Release: 5e90
	///</summary>
	public partial class PDS044MIResource : M3BaseResourceEndpoint
	{
		public PDS044MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PDS044MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Create Option Record
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DICE">Disturbance type (Required)</param>
		/// <param name="m3TX30">Text (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3MSG1">Text</param>
		/// <param name="m3MSG2">Text</param>
		/// <param name="m3MSG3">Text</param>
		/// <param name="m3PRDS">Production stop</param>
		/// <param name="m3SNUM">Send user message</param>
		/// <param name="m3SMAI">Send user mail</param>
		/// <param name="m3LSID">User</param>
		/// <param name="m3LSAD">Address</param>
		/// <param name="m3DLI1">Distribution list part 1</param>
		/// <param name="m3DLI2">Distribution list part 2</param>
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
		public async Task<M3Response<M3Record>> Add(
			string m3DICE, 
			string m3TX30, 
			string m3TX15 = null, 
			string m3MSG1 = null, 
			string m3MSG2 = null, 
			string m3MSG3 = null, 
			int? m3PRDS = null, 
			int? m3SNUM = null, 
			int? m3SMAI = null, 
			string m3LSID = null, 
			string m3LSAD = null, 
			string m3DLI1 = null, 
			string m3DLI2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DICE))
				throw new ArgumentNullException(nameof(m3DICE));
			if (string.IsNullOrWhiteSpace(m3TX30))
				throw new ArgumentNullException(nameof(m3TX30));

			// Set mandatory parameters
			request
				.WithQueryParameter("DICE", m3DICE.Trim())
				.WithQueryParameter("TX30", m3TX30.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSG1))
				request.WithQueryParameter("MSG1", m3MSG1.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSG2))
				request.WithQueryParameter("MSG2", m3MSG2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSG3))
				request.WithQueryParameter("MSG3", m3MSG3.Trim());
			if (m3PRDS.HasValue)
				request.WithQueryParameter("PRDS", m3PRDS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SNUM.HasValue)
				request.WithQueryParameter("SNUM", m3SNUM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SMAI.HasValue)
				request.WithQueryParameter("SMAI", m3SMAI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LSID))
				request.WithQueryParameter("LSID", m3LSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3LSAD))
				request.WithQueryParameter("LSAD", m3LSAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLI1))
				request.WithQueryParameter("DLI1", m3DLI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLI2))
				request.WithQueryParameter("DLI2", m3DLI2.Trim());
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
		/// Name Delete
		/// Description Delete Option Record
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DICE">Disturbance type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3DICE, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Delete",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DICE))
				throw new ArgumentNullException(nameof(m3DICE));

			// Set mandatory parameters
			request
				.WithQueryParameter("DICE", m3DICE.Trim());

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
		/// Description Retrieve Option Record
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DICE">Disturbance type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3DICE, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DICE))
				throw new ArgumentNullException(nameof(m3DICE));

			// Set mandatory parameters
			request
				.WithQueryParameter("DICE", m3DICE.Trim());

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
		/// Name List
		/// Description List Option Record
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DICE">Disturbance type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3DICE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/List",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DICE))
				request.WithQueryParameter("DICE", m3DICE.Trim());

			// Execute the request
			var result = await Execute<ListResponse>(
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
		/// Name Update
		/// Description Update Option Record
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DICE">Disturbance type (Required)</param>
		/// <param name="m3TX30">Text</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3MSG1">Text</param>
		/// <param name="m3MSG2">Text</param>
		/// <param name="m3MSG3">Text</param>
		/// <param name="m3PRDS">Production stop</param>
		/// <param name="m3SNUM">Send user message</param>
		/// <param name="m3SMAI">Send user mail</param>
		/// <param name="m3LSID">User</param>
		/// <param name="m3LSAD">Address</param>
		/// <param name="m3DLI1">Distribution list part 1</param>
		/// <param name="m3DLI2">Distribution list part 2</param>
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
		public async Task<M3Response<M3Record>> Update(
			string m3DICE, 
			string m3TX30 = null, 
			string m3TX15 = null, 
			string m3MSG1 = null, 
			string m3MSG2 = null, 
			string m3MSG3 = null, 
			int? m3PRDS = null, 
			int? m3SNUM = null, 
			int? m3SMAI = null, 
			string m3LSID = null, 
			string m3LSAD = null, 
			string m3DLI1 = null, 
			string m3DLI2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Update",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DICE))
				throw new ArgumentNullException(nameof(m3DICE));

			// Set mandatory parameters
			request
				.WithQueryParameter("DICE", m3DICE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX30))
				request.WithQueryParameter("TX30", m3TX30.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSG1))
				request.WithQueryParameter("MSG1", m3MSG1.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSG2))
				request.WithQueryParameter("MSG2", m3MSG2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSG3))
				request.WithQueryParameter("MSG3", m3MSG3.Trim());
			if (m3PRDS.HasValue)
				request.WithQueryParameter("PRDS", m3PRDS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SNUM.HasValue)
				request.WithQueryParameter("SNUM", m3SNUM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SMAI.HasValue)
				request.WithQueryParameter("SMAI", m3SMAI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LSID))
				request.WithQueryParameter("LSID", m3LSID.Trim());
			if (!string.IsNullOrWhiteSpace(m3LSAD))
				request.WithQueryParameter("LSAD", m3LSAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLI1))
				request.WithQueryParameter("DLI1", m3DLI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3DLI2))
				request.WithQueryParameter("DLI2", m3DLI2.Trim());
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
