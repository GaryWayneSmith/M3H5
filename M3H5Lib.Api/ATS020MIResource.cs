/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.ATS020MI;
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
	/// Name: ATS020MI
	/// Component Name: Planning and Manufacturing
	/// Description: Attribute values matrix
	/// Version Release: 14.x
	///</summary>
	public partial class ATS020MIResource : M3BaseResourceEndpoint
	{
		public ATS020MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "ATS020MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAttrMatrix
		/// Description This transaction adds Attribute Matrix
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATID">Attribute identity (Required)</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBJ1">Field</param>
		/// <param name="m3_OBJ2">Field</param>
		/// <param name="m3_OBJ3">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAttrMatrix(
			string m3_ATID, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBJ1 = null, 
			string m3_OBJ2 = null, 
			string m3_OBJ3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAttrMatrix",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3_ATID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBJ1))
				request.WithQueryParameter("OBJ1", m3_OBJ1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBJ2))
				request.WithQueryParameter("OBJ2", m3_OBJ2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBJ3))
				request.WithQueryParameter("OBJ3", m3_OBJ3.Trim());

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
		/// Name AddAttrValue
		/// Description This transaction adds Attribute Value
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATID">Attribute identity (Required)</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_ANSQ">Attribute sequence number</param>
		/// <param name="m3_AALF">From attribute value</param>
		/// <param name="m3_AALT">To attribute value</param>
		/// <param name="m3_NRMU">Numeric range multiple</param>
		/// <param name="m3_DCOD">Discontinued date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAttrValue(
			string m3_ATID, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			int? m3_ANSQ = null, 
			string m3_AALF = null, 
			string m3_AALT = null, 
			decimal? m3_NRMU = null, 
			DateTime? m3_DCOD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAttrValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3_ATID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (m3_ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3_ANSQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AALF))
				request.WithQueryParameter("AALF", m3_AALF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AALT))
				request.WithQueryParameter("AALT", m3_AALT.Trim());
			if (m3_NRMU.HasValue)
				request.WithQueryParameter("NRMU", m3_NRMU.Value.ToString());
			if (m3_DCOD.HasValue)
				request.WithQueryParameter("DCOD", m3_DCOD.Value.ToM3String());

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
		/// Name DelAttrMatrix
		/// Description This transaction deletes the Attribute Matrix
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATID">Attribute identity (Required)</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAttrMatrix(
			string m3_ATID, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelAttrMatrix",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3_ATID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());

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
		/// Name DelAttrValue
		/// Description This transaction deletes Attaribute Value
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATID">Attribute identity (Required)</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_AALF">From attribute value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAttrValue(
			string m3_ATID, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_AALF = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelAttrValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3_ATID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AALF))
				request.WithQueryParameter("AALF", m3_AALF.Trim());

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
		/// Name LstAttrMatrix
		/// Description This transaction lists Attribute Matrix
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATID">Attribute identity (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrMatrixResponse></returns>
		/// <exception cref="M3Exception<LstAttrMatrixResponse>"></exception>
		public async Task<M3Response<LstAttrMatrixResponse>> LstAttrMatrix(
			string m3_ATID, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAttrMatrix",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3_ATID.Trim());

			// Execute the request
			var result = await Execute<LstAttrMatrixResponse>(
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
		/// Name LstAttrValue
		/// Description This transaction displays Attribute Value
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATID">Attribute identity (Required)</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAttrValueResponse></returns>
		/// <exception cref="M3Exception<LstAttrValueResponse>"></exception>
		public async Task<M3Response<LstAttrValueResponse>> LstAttrValue(
			string m3_ATID, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAttrValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3_ATID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());

			// Execute the request
			var result = await Execute<LstAttrValueResponse>(
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
		/// Name SelAttrValue
		/// Description This transaction displays Attribute Value
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATID">Attribute identity (Required)</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelAttrValueResponse></returns>
		/// <exception cref="M3Exception<SelAttrValueResponse>"></exception>
		public async Task<M3Response<SelAttrValueResponse>> SelAttrValue(
			string m3_ATID, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelAttrValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3_ATID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());

			// Execute the request
			var result = await Execute<SelAttrValueResponse>(
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
		/// Name UpdAttrValue
		/// Description This transaction updates Attribute Value
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ATID">Attribute identity (Required)</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_AALF">From attribute value</param>
		/// <param name="m3_AALT">To attribute value</param>
		/// <param name="m3_NRMU">Numeric range multiple</param>
		/// <param name="m3_DCOD">Discontinued date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAttrValue(
			string m3_ATID, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_AALF = null, 
			string m3_AALT = null, 
			decimal? m3_NRMU = null, 
			DateTime? m3_DCOD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdAttrValue",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ATID))
				throw new ArgumentNullException("m3_ATID");

			// Set mandatory parameters
			request
				.WithQueryParameter("ATID", m3_ATID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AALF))
				request.WithQueryParameter("AALF", m3_AALF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AALT))
				request.WithQueryParameter("AALT", m3_AALT.Trim());
			if (m3_NRMU.HasValue)
				request.WithQueryParameter("NRMU", m3_NRMU.Value.ToString());
			if (m3_DCOD.HasValue)
				request.WithQueryParameter("DCOD", m3_DCOD.Value.ToM3String());

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
