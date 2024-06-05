/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.ECS003MI;
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
	/// Name: ECS003MI
	/// Component Name: Service Revision
	/// Description: Material/Op. Connect Feature/Options
	/// Version Release: 5ea0
	///</summary>
	public partial class ECS003MIResource : M3BaseResourceEndpoint
	{
		public ECS003MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "ECS003MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add Option Feature
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_ECVE">Revision number (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_OTYP">Selection type</param>
		/// <param name="m3_FTID">Selection identity</param>
		/// <param name="m3_OPTN">Option</param>
		/// <param name="m3_INCE">Include/exclude product strukture line</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_FACI, 
			string m3_SUFI, 
			string m3_ECVE, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_MSEQ = null, 
			int? m3_OPNO = null, 
			string m3_OTYP = null, 
			string m3_FTID = null, 
			string m3_OPTN = null, 
			string m3_INCE = null, 
			decimal? m3_TXID = null, 
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
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");
			if (string.IsNullOrWhiteSpace(m3_ECVE))
				throw new ArgumentNullException("m3_ECVE");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("ECVE", m3_ECVE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OTYP))
				request.WithQueryParameter("OTYP", m3_OTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FTID))
				request.WithQueryParameter("FTID", m3_FTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTN))
				request.WithQueryParameter("OPTN", m3_OPTN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INCE))
				request.WithQueryParameter("INCE", m3_INCE.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
		/// Name Del
		/// Description Delete Option Feature
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_ECVE">Revision number (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_OTYP">Selection type</param>
		/// <param name="m3_FTID">Selection identity</param>
		/// <param name="m3_OPTN">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			string m3_FACI, 
			string m3_SUFI, 
			string m3_ECVE, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_MSEQ = null, 
			int? m3_OPNO = null, 
			string m3_OTYP = null, 
			string m3_FTID = null, 
			string m3_OPTN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Del",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");
			if (string.IsNullOrWhiteSpace(m3_ECVE))
				throw new ArgumentNullException("m3_ECVE");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("ECVE", m3_ECVE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OTYP))
				request.WithQueryParameter("OTYP", m3_OTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FTID))
				request.WithQueryParameter("FTID", m3_FTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTN))
				request.WithQueryParameter("OPTN", m3_OPTN.Trim());

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
		/// Name Get
		/// Description Get Option Feature
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_ECVE">Revision number (Required)</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_OTYP">Selection type</param>
		/// <param name="m3_FTID">Selection identity</param>
		/// <param name="m3_OPTN">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_SUFI, 
			string m3_ECVE, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_MSEQ = null, 
			int? m3_OPNO = null, 
			string m3_OTYP = null, 
			string m3_FTID = null, 
			string m3_OPTN = null, 
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
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");
			if (string.IsNullOrWhiteSpace(m3_ECVE))
				throw new ArgumentNullException("m3_ECVE");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("ECVE", m3_ECVE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OTYP))
				request.WithQueryParameter("OTYP", m3_OTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FTID))
				request.WithQueryParameter("FTID", m3_FTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTN))
				request.WithQueryParameter("OPTN", m3_OPTN.Trim());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name LstService
		/// Description List Option Feature for Service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_OTYP">Selection type</param>
		/// <param name="m3_FTID">Selection identity</param>
		/// <param name="m3_OPTN">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstServiceResponse></returns>
		/// <exception cref="M3Exception<LstServiceResponse>"></exception>
		public async Task<M3Response<LstServiceResponse>> LstService(
			string m3_FACI, 
			string m3_SUFI, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_ECVE = null, 
			int? m3_MSEQ = null, 
			int? m3_OPNO = null, 
			string m3_OTYP = null, 
			string m3_FTID = null, 
			string m3_OPTN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstService",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("SUFI", m3_SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OTYP))
				request.WithQueryParameter("OTYP", m3_OTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FTID))
				request.WithQueryParameter("FTID", m3_FTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OPTN))
				request.WithQueryParameter("OPTN", m3_OPTN.Trim());

			// Execute the request
			var result = await Execute<LstServiceResponse>(
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
