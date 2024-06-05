/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CMS880MI;
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
	/// Name: CMS880MI
	/// Component Name: SupplierInvoiceBatch
	/// Description: Supplier invoice batch interface
	/// Version Release: 5ea0
	///</summary>
	public partial class CMS880MIResource : M3BaseResourceEndpoint
	{
		public CMS880MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS880MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddMsgMapDet
		/// Description Add Business Message Mapping Detail
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_BMSG">Business message (Required)</param>
		/// <param name="m3_ELMP">Parent element(s) (Required)</param>
		/// <param name="m3_ELMD">Data element (Required)</param>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_MVLF">M3 value From (Required)</param>
		/// <param name="m3_MVLT">M3 value To (Required)</param>
		/// <param name="m3_DELV">Data element value (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddMsgMapDet(
			string m3_BMSG, 
			string m3_ELMP, 
			string m3_ELMD, 
			string m3_BSCD, 
			string m3_MVLF, 
			string m3_MVLT, 
			string m3_DELV, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddMsgMapDet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BMSG))
				throw new ArgumentNullException("m3_BMSG");
			if (string.IsNullOrWhiteSpace(m3_ELMP))
				throw new ArgumentNullException("m3_ELMP");
			if (string.IsNullOrWhiteSpace(m3_ELMD))
				throw new ArgumentNullException("m3_ELMD");
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");
			if (string.IsNullOrWhiteSpace(m3_MVLF))
				throw new ArgumentNullException("m3_MVLF");
			if (string.IsNullOrWhiteSpace(m3_MVLT))
				throw new ArgumentNullException("m3_MVLT");
			if (string.IsNullOrWhiteSpace(m3_DELV))
				throw new ArgumentNullException("m3_DELV");

			// Set mandatory parameters
			request
				.WithQueryParameter("BMSG", m3_BMSG.Trim())
				.WithQueryParameter("ELMP", m3_ELMP.Trim())
				.WithQueryParameter("ELMD", m3_ELMD.Trim())
				.WithQueryParameter("BSCD", m3_BSCD.Trim())
				.WithQueryParameter("MVLF", m3_MVLF.Trim())
				.WithQueryParameter("MVLT", m3_MVLT.Trim())
				.WithQueryParameter("DELV", m3_DELV.Trim());

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
		/// Name DltMsgMapDet
		/// Description Delete Business Message Mapping Detail
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_BMSG">Business message (Required)</param>
		/// <param name="m3_ELMP">Parent element(s) (Required)</param>
		/// <param name="m3_ELMD">Data element (Required)</param>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_MVLF">M3 value From (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltMsgMapDet(
			string m3_BMSG, 
			string m3_ELMP, 
			string m3_ELMD, 
			string m3_BSCD, 
			string m3_MVLF, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltMsgMapDet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BMSG))
				throw new ArgumentNullException("m3_BMSG");
			if (string.IsNullOrWhiteSpace(m3_ELMP))
				throw new ArgumentNullException("m3_ELMP");
			if (string.IsNullOrWhiteSpace(m3_ELMD))
				throw new ArgumentNullException("m3_ELMD");
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");
			if (string.IsNullOrWhiteSpace(m3_MVLF))
				throw new ArgumentNullException("m3_MVLF");

			// Set mandatory parameters
			request
				.WithQueryParameter("BMSG", m3_BMSG.Trim())
				.WithQueryParameter("ELMP", m3_ELMP.Trim())
				.WithQueryParameter("ELMD", m3_ELMD.Trim())
				.WithQueryParameter("BSCD", m3_BSCD.Trim())
				.WithQueryParameter("MVLF", m3_MVLF.Trim());

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
		/// Name GetMsgMapDet
		/// Description Get Business Message Mapping Detail
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_BMSG">Business message (Required)</param>
		/// <param name="m3_ELMP">Parent element(s) (Required)</param>
		/// <param name="m3_ELMD">Data element (Required)</param>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_MVLF">M3 value From (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMsgMapDetResponse></returns>
		/// <exception cref="M3Exception<GetMsgMapDetResponse>"></exception>
		public async Task<M3Response<GetMsgMapDetResponse>> GetMsgMapDet(
			string m3_BMSG, 
			string m3_ELMP, 
			string m3_ELMD, 
			string m3_BSCD, 
			string m3_MVLF, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMsgMapDet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BMSG))
				throw new ArgumentNullException("m3_BMSG");
			if (string.IsNullOrWhiteSpace(m3_ELMP))
				throw new ArgumentNullException("m3_ELMP");
			if (string.IsNullOrWhiteSpace(m3_ELMD))
				throw new ArgumentNullException("m3_ELMD");
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");
			if (string.IsNullOrWhiteSpace(m3_MVLF))
				throw new ArgumentNullException("m3_MVLF");

			// Set mandatory parameters
			request
				.WithQueryParameter("BMSG", m3_BMSG.Trim())
				.WithQueryParameter("ELMP", m3_ELMP.Trim())
				.WithQueryParameter("ELMD", m3_ELMD.Trim())
				.WithQueryParameter("BSCD", m3_BSCD.Trim())
				.WithQueryParameter("MVLF", m3_MVLF.Trim());

			// Execute the request
			var result = await Execute<GetMsgMapDetResponse>(
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
		/// Name LstMsgMapDet
		/// Description List Business Message Mapping Detail
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_BMSG">Business message (Required)</param>
		/// <param name="m3_ELMP">Parent element(s) (Required)</param>
		/// <param name="m3_ELMD">Data element (Required)</param>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_MVLF">M3 value From</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMsgMapDetResponse></returns>
		/// <exception cref="M3Exception<LstMsgMapDetResponse>"></exception>
		public async Task<M3Response<LstMsgMapDetResponse>> LstMsgMapDet(
			string m3_BMSG, 
			string m3_ELMP, 
			string m3_ELMD, 
			string m3_BSCD, 
			string m3_MVLF = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMsgMapDet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BMSG))
				throw new ArgumentNullException("m3_BMSG");
			if (string.IsNullOrWhiteSpace(m3_ELMP))
				throw new ArgumentNullException("m3_ELMP");
			if (string.IsNullOrWhiteSpace(m3_ELMD))
				throw new ArgumentNullException("m3_ELMD");
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("BMSG", m3_BMSG.Trim())
				.WithQueryParameter("ELMP", m3_ELMP.Trim())
				.WithQueryParameter("ELMD", m3_ELMD.Trim())
				.WithQueryParameter("BSCD", m3_BSCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MVLF))
				request.WithQueryParameter("MVLF", m3_MVLF.Trim());

			// Execute the request
			var result = await Execute<LstMsgMapDetResponse>(
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
		/// Name UpdMsgMapDet
		/// Description Update Business Message Mapping Detail
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_BMSG">Business message (Required)</param>
		/// <param name="m3_ELMP">Parent element(s) (Required)</param>
		/// <param name="m3_ELMD">Data element (Required)</param>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_MVLF">M3 value From (Required)</param>
		/// <param name="m3_MVLT">M3 value To (Required)</param>
		/// <param name="m3_DELV">Data element value (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdMsgMapDet(
			string m3_BMSG, 
			string m3_ELMP, 
			string m3_ELMD, 
			string m3_BSCD, 
			string m3_MVLF, 
			string m3_MVLT, 
			string m3_DELV, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdMsgMapDet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BMSG))
				throw new ArgumentNullException("m3_BMSG");
			if (string.IsNullOrWhiteSpace(m3_ELMP))
				throw new ArgumentNullException("m3_ELMP");
			if (string.IsNullOrWhiteSpace(m3_ELMD))
				throw new ArgumentNullException("m3_ELMD");
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");
			if (string.IsNullOrWhiteSpace(m3_MVLF))
				throw new ArgumentNullException("m3_MVLF");
			if (string.IsNullOrWhiteSpace(m3_MVLT))
				throw new ArgumentNullException("m3_MVLT");
			if (string.IsNullOrWhiteSpace(m3_DELV))
				throw new ArgumentNullException("m3_DELV");

			// Set mandatory parameters
			request
				.WithQueryParameter("BMSG", m3_BMSG.Trim())
				.WithQueryParameter("ELMP", m3_ELMP.Trim())
				.WithQueryParameter("ELMD", m3_ELMD.Trim())
				.WithQueryParameter("BSCD", m3_BSCD.Trim())
				.WithQueryParameter("MVLF", m3_MVLF.Trim())
				.WithQueryParameter("MVLT", m3_MVLT.Trim())
				.WithQueryParameter("DELV", m3_DELV.Trim());

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
		/// Name UpdMsgMapHead
		/// Description Update Business Message Mapping Header
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_BMSG">Business message (Required)</param>
		/// <param name="m3_ELMP">Parent element(s) (Required)</param>
		/// <param name="m3_ELMD">Data element (Required)</param>
		/// <param name="m3_BSCD">Base country (Required)</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdMsgMapHead(
			string m3_BMSG, 
			string m3_ELMP, 
			string m3_ELMD, 
			string m3_BSCD, 
			string m3_TX15 = null, 
			string m3_TX40 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdMsgMapHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BMSG))
				throw new ArgumentNullException("m3_BMSG");
			if (string.IsNullOrWhiteSpace(m3_ELMP))
				throw new ArgumentNullException("m3_ELMP");
			if (string.IsNullOrWhiteSpace(m3_ELMD))
				throw new ArgumentNullException("m3_ELMD");
			if (string.IsNullOrWhiteSpace(m3_BSCD))
				throw new ArgumentNullException("m3_BSCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("BMSG", m3_BMSG.Trim())
				.WithQueryParameter("ELMP", m3_ELMP.Trim())
				.WithQueryParameter("ELMD", m3_ELMD.Trim())
				.WithQueryParameter("BSCD", m3_BSCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());

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
