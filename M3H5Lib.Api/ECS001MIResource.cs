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
	/// Name: ECS001MI
	/// Component Name: Cad integration - Head
	/// Description: CAD integration - Head
	/// Version Release: 11.3
	///</summary>
	public partial class ECS001MIResource : M3BaseResourceEndpoint
	{
		public ECS001MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "ECS001MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddHead
		/// Description CAD Integration - head
		/// Version Release: 11,3
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddHead(
			string m3_FACI, 
			string m3_PRNO, 
			int? m3_CONO = null, 
			string m3_STRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());

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
		/// Name AddLines
		/// Description CAD Integration - head
		/// Version Release: 11,3
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_MSEQ">Sequence number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_MTNO">Component number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_DWPO">Drawing position</param>
		/// <param name="m3_FMT1">Text1</param>
		/// <param name="m3_FMT2">Text2</param>
		/// <param name="m3_CNQT">Quantity</param>
		/// <param name="m3_DCCD">Number of decimal plac</param>
		/// <param name="m3_CCQT">Quantity on drawing</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLines(
			string m3_FACI, 
			string m3_PRNO, 
			int m3_MSEQ, 
			int? m3_CONO = null, 
			string m3_MTNO = null, 
			string m3_STRT = null, 
			int? m3_OPNO = null, 
			string m3_DWPO = null, 
			string m3_FMT1 = null, 
			string m3_FMT2 = null, 
			decimal? m3_CNQT = null, 
			int? m3_DCCD = null, 
			decimal? m3_CCQT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("MSEQ", m3_MSEQ.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MTNO))
				request.WithQueryParameter("MTNO", m3_MTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DWPO))
				request.WithQueryParameter("DWPO", m3_DWPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMT1))
				request.WithQueryParameter("FMT1", m3_FMT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMT2))
				request.WithQueryParameter("FMT2", m3_FMT2.Trim());
			if (m3_CNQT.HasValue)
				request.WithQueryParameter("CNQT", m3_CNQT.Value.ToString());
			if (m3_DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3_DCCD.Value.ToString());
			if (m3_CCQT.HasValue)
				request.WithQueryParameter("CCQT", m3_CCQT.Value.ToString());

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
