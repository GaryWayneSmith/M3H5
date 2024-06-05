/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CRS022MI;
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
	/// Name: CRS022MI
	/// Component Name: SortingOrder
	/// Description: Sorting order interface
	/// Version Release: 5ea0
	///</summary>
	public partial class CRS022MIResource : M3BaseResourceEndpoint
	{
		public CRS022MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS022MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddLngTxt
		/// Description AddLngTxt
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PGNM">Program name (Required)</param>
		/// <param name="m3_QTTP">Sorting order (Required)</param>
		/// <param name="m3_LNCD">Language (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_FLDI">Field (Required)</param>
		/// <param name="m3_IBCA">Information browser category</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLngTxt(
			string m3_PGNM, 
			int m3_QTTP, 
			string m3_LNCD, 
			string m3_TX40, 
			string m3_FILE, 
			string m3_FLDI, 
			string m3_IBCA = null, 
			string m3_TX15 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLngTxt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");
			if (string.IsNullOrWhiteSpace(m3_LNCD))
				throw new ArgumentNullException("m3_LNCD");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FLDI))
				throw new ArgumentNullException("m3_FLDI");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim())
				.WithQueryParameter("QTTP", m3_QTTP.ToString())
				.WithQueryParameter("LNCD", m3_LNCD.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FLDI", m3_FLDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_IBCA))
				request.WithQueryParameter("IBCA", m3_IBCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());

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
		/// Name AddSortOrder
		/// Description Add Sorting Order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PGNM">Program name (Required)</param>
		/// <param name="m3_QTTP">Inquiry type (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_FILE">Table (Required)</param>
		/// <param name="m3_SOPT">Sorting option (Required)</param>
		/// <param name="m3_PAV1">View (Required)</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_NFTR">Number of filters</param>
		/// <param name="m3_PAV2">View</param>
		/// <param name="m3_PAV3">View</param>
		/// <param name="m3_PAV4">View</param>
		/// <param name="m3_PAV5">View</param>
		/// <param name="m3_PAV6">View</param>
		/// <param name="m3_PSEQ">Panel sequence</param>
		/// <param name="m3_TABL">Selection table</param>
		/// <param name="m3_AGGR">Aggregation</param>
		/// <param name="m3_OBK1">Key value</param>
		/// <param name="m3_OBK2">Key value</param>
		/// <param name="m3_OBK3">Key value</param>
		/// <param name="m3_OBK4">Key value</param>
		/// <param name="m3_OBK5">Key value</param>
		/// <param name="m3_OBK6">Key value</param>
		/// <param name="m3_OBK7">Key value</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_SOZ1">Sorting order zoom</param>
		/// <param name="m3_SOZ2">Sorting order zoom</param>
		/// <param name="m3_SOZ3">Sorting order zoom</param>
		/// <param name="m3_SOZ4">Sorting order zoom</param>
		/// <param name="m3_SOZ5">Sorting order zoom</param>
		/// <param name="m3_SOZ6">Sorting order zoom</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_USEQ">Panel sequence</param>
		/// <param name="m3_UPV1">User panel version</param>
		/// <param name="m3_UPV2">User panel version</param>
		/// <param name="m3_UPV3">User panel version</param>
		/// <param name="m3_UPV4">User panel version</param>
		/// <param name="m3_UPV5">User panel version</param>
		/// <param name="m3_UPV6">User panel version</param>
		/// <param name="m3_IBCA">Information browser category</param>
		/// <param name="m3_SNDI">Single division</param>
		/// <param name="m3_CHNF">Change filter</param>
		/// <param name="m3_CHAG">Change aggregation</param>
		/// <param name="m3_AGRG">Aggregation rule</param>
		/// <param name="m3_MXRE">Maximum number of records</param>
		/// <param name="m3_JNSO">Join sort</param>
		/// <param name="m3_SLF1">Selection field 1</param>
		/// <param name="m3_SLF2">Selection field 2</param>
		/// <param name="m3_SLF3">Selection field 3</param>
		/// <param name="m3_SUB1">Subtotal 1</param>
		/// <param name="m3_SUB2">Subtotal 2</param>
		/// <param name="m3_SUB3">Subtotal 3</param>
		/// <param name="m3_HLAL">Highlight aggregated lines</param>
		/// <param name="m3_SBFD">Sort-by field</param>
		/// <param name="m3_SDSN">Sort decending</param>
		/// <param name="m3_CON1">Key search id</param>
		/// <param name="m3_LUFN">Last used file name</param>
		/// <param name="m3_LUVE">Last used version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSortOrder(
			string m3_PGNM, 
			int m3_QTTP, 
			string m3_TX40, 
			string m3_FILE, 
			string m3_SOPT, 
			string m3_PAV1, 
			string m3_TX15 = null, 
			int? m3_NFTR = null, 
			string m3_PAV2 = null, 
			string m3_PAV3 = null, 
			string m3_PAV4 = null, 
			string m3_PAV5 = null, 
			string m3_PAV6 = null, 
			string m3_PSEQ = null, 
			string m3_TABL = null, 
			int? m3_AGGR = null, 
			string m3_OBK1 = null, 
			string m3_OBK2 = null, 
			string m3_OBK3 = null, 
			string m3_OBK4 = null, 
			string m3_OBK5 = null, 
			string m3_OBK6 = null, 
			string m3_OBK7 = null, 
			decimal? m3_TXID = null, 
			int? m3_SOZ1 = null, 
			int? m3_SOZ2 = null, 
			int? m3_SOZ3 = null, 
			int? m3_SOZ4 = null, 
			int? m3_SOZ5 = null, 
			int? m3_SOZ6 = null, 
			string m3_RESP = null, 
			string m3_USEQ = null, 
			string m3_UPV1 = null, 
			string m3_UPV2 = null, 
			string m3_UPV3 = null, 
			string m3_UPV4 = null, 
			string m3_UPV5 = null, 
			string m3_UPV6 = null, 
			string m3_IBCA = null, 
			int? m3_SNDI = null, 
			int? m3_CHNF = null, 
			int? m3_CHAG = null, 
			int? m3_AGRG = null, 
			int? m3_MXRE = null, 
			int? m3_JNSO = null, 
			string m3_SLF1 = null, 
			string m3_SLF2 = null, 
			string m3_SLF3 = null, 
			int? m3_SUB1 = null, 
			int? m3_SUB2 = null, 
			int? m3_SUB3 = null, 
			int? m3_HLAL = null, 
			string m3_SBFD = null, 
			int? m3_SDSN = null, 
			string m3_CON1 = null, 
			string m3_LUFN = null, 
			string m3_LUVE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSortOrder",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_SOPT))
				throw new ArgumentNullException("m3_SOPT");
			if (string.IsNullOrWhiteSpace(m3_PAV1))
				throw new ArgumentNullException("m3_PAV1");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim())
				.WithQueryParameter("QTTP", m3_QTTP.ToString())
				.WithQueryParameter("TX40", m3_TX40.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("SOPT", m3_SOPT.Trim())
				.WithQueryParameter("PAV1", m3_PAV1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3_NFTR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PAV2))
				request.WithQueryParameter("PAV2", m3_PAV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAV3))
				request.WithQueryParameter("PAV3", m3_PAV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAV4))
				request.WithQueryParameter("PAV4", m3_PAV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAV5))
				request.WithQueryParameter("PAV5", m3_PAV5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAV6))
				request.WithQueryParameter("PAV6", m3_PAV6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PSEQ))
				request.WithQueryParameter("PSEQ", m3_PSEQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TABL))
				request.WithQueryParameter("TABL", m3_TABL.Trim());
			if (m3_AGGR.HasValue)
				request.WithQueryParameter("AGGR", m3_AGGR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBK1))
				request.WithQueryParameter("OBK1", m3_OBK1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBK2))
				request.WithQueryParameter("OBK2", m3_OBK2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBK3))
				request.WithQueryParameter("OBK3", m3_OBK3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBK4))
				request.WithQueryParameter("OBK4", m3_OBK4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBK5))
				request.WithQueryParameter("OBK5", m3_OBK5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBK6))
				request.WithQueryParameter("OBK6", m3_OBK6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBK7))
				request.WithQueryParameter("OBK7", m3_OBK7.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_SOZ1.HasValue)
				request.WithQueryParameter("SOZ1", m3_SOZ1.Value.ToString());
			if (m3_SOZ2.HasValue)
				request.WithQueryParameter("SOZ2", m3_SOZ2.Value.ToString());
			if (m3_SOZ3.HasValue)
				request.WithQueryParameter("SOZ3", m3_SOZ3.Value.ToString());
			if (m3_SOZ4.HasValue)
				request.WithQueryParameter("SOZ4", m3_SOZ4.Value.ToString());
			if (m3_SOZ5.HasValue)
				request.WithQueryParameter("SOZ5", m3_SOZ5.Value.ToString());
			if (m3_SOZ6.HasValue)
				request.WithQueryParameter("SOZ6", m3_SOZ6.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USEQ))
				request.WithQueryParameter("USEQ", m3_USEQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UPV1))
				request.WithQueryParameter("UPV1", m3_UPV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UPV2))
				request.WithQueryParameter("UPV2", m3_UPV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UPV3))
				request.WithQueryParameter("UPV3", m3_UPV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UPV4))
				request.WithQueryParameter("UPV4", m3_UPV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UPV5))
				request.WithQueryParameter("UPV5", m3_UPV5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UPV6))
				request.WithQueryParameter("UPV6", m3_UPV6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IBCA))
				request.WithQueryParameter("IBCA", m3_IBCA.Trim());
			if (m3_SNDI.HasValue)
				request.WithQueryParameter("SNDI", m3_SNDI.Value.ToString());
			if (m3_CHNF.HasValue)
				request.WithQueryParameter("CHNF", m3_CHNF.Value.ToString());
			if (m3_CHAG.HasValue)
				request.WithQueryParameter("CHAG", m3_CHAG.Value.ToString());
			if (m3_AGRG.HasValue)
				request.WithQueryParameter("AGRG", m3_AGRG.Value.ToString());
			if (m3_MXRE.HasValue)
				request.WithQueryParameter("MXRE", m3_MXRE.Value.ToString());
			if (m3_JNSO.HasValue)
				request.WithQueryParameter("JNSO", m3_JNSO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SLF1))
				request.WithQueryParameter("SLF1", m3_SLF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLF2))
				request.WithQueryParameter("SLF2", m3_SLF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLF3))
				request.WithQueryParameter("SLF3", m3_SLF3.Trim());
			if (m3_SUB1.HasValue)
				request.WithQueryParameter("SUB1", m3_SUB1.Value.ToString());
			if (m3_SUB2.HasValue)
				request.WithQueryParameter("SUB2", m3_SUB2.Value.ToString());
			if (m3_SUB3.HasValue)
				request.WithQueryParameter("SUB3", m3_SUB3.Value.ToString());
			if (m3_HLAL.HasValue)
				request.WithQueryParameter("HLAL", m3_HLAL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SBFD))
				request.WithQueryParameter("SBFD", m3_SBFD.Trim());
			if (m3_SDSN.HasValue)
				request.WithQueryParameter("SDSN", m3_SDSN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CON1))
				request.WithQueryParameter("CON1", m3_CON1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LUFN))
				request.WithQueryParameter("LUFN", m3_LUFN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LUVE))
				request.WithQueryParameter("LUVE", m3_LUVE.Trim());

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
		/// Name AddStdPersView
		/// Description Add Standard Personal View
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_PGNM">Program name (Required)</param>
		/// <param name="m3_QTTP">Sorting order (Required)</param>
		/// <param name="m3_RESP">Responsible (Required)</param>
		/// <param name="m3_IBCA">Information browser category</param>
		/// <param name="m3_USEQ">Panel sequence</param>
		/// <param name="m3_UPV1">Personal view</param>
		/// <param name="m3_UPV2">Personal view</param>
		/// <param name="m3_UPV3">Personal view</param>
		/// <param name="m3_UPV4">Personal view</param>
		/// <param name="m3_UPV5">Personal view</param>
		/// <param name="m3_UPV6">Personal view</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddStdPersView(
			string m3_PGNM, 
			int m3_QTTP, 
			string m3_RESP, 
			string m3_IBCA = null, 
			string m3_USEQ = null, 
			string m3_UPV1 = null, 
			string m3_UPV2 = null, 
			string m3_UPV3 = null, 
			string m3_UPV4 = null, 
			string m3_UPV5 = null, 
			string m3_UPV6 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddStdPersView",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");
			if (string.IsNullOrWhiteSpace(m3_RESP))
				throw new ArgumentNullException("m3_RESP");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim())
				.WithQueryParameter("QTTP", m3_QTTP.ToString())
				.WithQueryParameter("RESP", m3_RESP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_IBCA))
				request.WithQueryParameter("IBCA", m3_IBCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USEQ))
				request.WithQueryParameter("USEQ", m3_USEQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UPV1))
				request.WithQueryParameter("UPV1", m3_UPV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UPV2))
				request.WithQueryParameter("UPV2", m3_UPV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UPV3))
				request.WithQueryParameter("UPV3", m3_UPV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UPV4))
				request.WithQueryParameter("UPV4", m3_UPV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UPV5))
				request.WithQueryParameter("UPV5", m3_UPV5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UPV6))
				request.WithQueryParameter("UPV6", m3_UPV6.Trim());

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
		/// Name ChgSortOrder
		/// Description Change Sorting Order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PGNM">Program name (Required)</param>
		/// <param name="m3_QTTP">Inquiry type (Required)</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_FILE">Table</param>
		/// <param name="m3_SOPT">Sorting option</param>
		/// <param name="m3_NFTR">Number of filters</param>
		/// <param name="m3_PAV1">View</param>
		/// <param name="m3_PAV2">View</param>
		/// <param name="m3_PAV3">View</param>
		/// <param name="m3_PAV4">View</param>
		/// <param name="m3_PAV5">View</param>
		/// <param name="m3_PAV6">View</param>
		/// <param name="m3_PSEQ">Panel sequence</param>
		/// <param name="m3_TABL">Selection table</param>
		/// <param name="m3_AGGR">Aggregation</param>
		/// <param name="m3_OBK1">Key value</param>
		/// <param name="m3_OBK2">Key value</param>
		/// <param name="m3_OBK3">Key value</param>
		/// <param name="m3_OBK4">Key value</param>
		/// <param name="m3_OBK5">Key value</param>
		/// <param name="m3_OBK6">Key value</param>
		/// <param name="m3_OBK7">Key value</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_SOZ1">Sorting order zoom</param>
		/// <param name="m3_SOZ2">Sorting order zoom</param>
		/// <param name="m3_SOZ3">Sorting order zoom</param>
		/// <param name="m3_SOZ4">Sorting order zoom</param>
		/// <param name="m3_SOZ5">Sorting order zoom</param>
		/// <param name="m3_SOZ6">Sorting order zoom</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_USEQ">Panel sequence</param>
		/// <param name="m3_UPV1">User panel version</param>
		/// <param name="m3_UPV2">User panel version</param>
		/// <param name="m3_UPV3">User panel version</param>
		/// <param name="m3_UPV4">User panel version</param>
		/// <param name="m3_UPV5">User panel version</param>
		/// <param name="m3_UPV6">User panel version</param>
		/// <param name="m3_IBCA">Information browser category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgSortOrder(
			string m3_PGNM, 
			int m3_QTTP, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_FILE = null, 
			string m3_SOPT = null, 
			int? m3_NFTR = null, 
			string m3_PAV1 = null, 
			string m3_PAV2 = null, 
			string m3_PAV3 = null, 
			string m3_PAV4 = null, 
			string m3_PAV5 = null, 
			string m3_PAV6 = null, 
			string m3_PSEQ = null, 
			string m3_TABL = null, 
			int? m3_AGGR = null, 
			string m3_OBK1 = null, 
			string m3_OBK2 = null, 
			string m3_OBK3 = null, 
			string m3_OBK4 = null, 
			string m3_OBK5 = null, 
			string m3_OBK6 = null, 
			string m3_OBK7 = null, 
			decimal? m3_TXID = null, 
			int? m3_SOZ1 = null, 
			int? m3_SOZ2 = null, 
			int? m3_SOZ3 = null, 
			int? m3_SOZ4 = null, 
			int? m3_SOZ5 = null, 
			int? m3_SOZ6 = null, 
			string m3_RESP = null, 
			string m3_USEQ = null, 
			string m3_UPV1 = null, 
			string m3_UPV2 = null, 
			string m3_UPV3 = null, 
			string m3_UPV4 = null, 
			string m3_UPV5 = null, 
			string m3_UPV6 = null, 
			string m3_IBCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgSortOrder",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim())
				.WithQueryParameter("QTTP", m3_QTTP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SOPT))
				request.WithQueryParameter("SOPT", m3_SOPT.Trim());
			if (m3_NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3_NFTR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PAV1))
				request.WithQueryParameter("PAV1", m3_PAV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAV2))
				request.WithQueryParameter("PAV2", m3_PAV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAV3))
				request.WithQueryParameter("PAV3", m3_PAV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAV4))
				request.WithQueryParameter("PAV4", m3_PAV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAV5))
				request.WithQueryParameter("PAV5", m3_PAV5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAV6))
				request.WithQueryParameter("PAV6", m3_PAV6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PSEQ))
				request.WithQueryParameter("PSEQ", m3_PSEQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TABL))
				request.WithQueryParameter("TABL", m3_TABL.Trim());
			if (m3_AGGR.HasValue)
				request.WithQueryParameter("AGGR", m3_AGGR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBK1))
				request.WithQueryParameter("OBK1", m3_OBK1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBK2))
				request.WithQueryParameter("OBK2", m3_OBK2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBK3))
				request.WithQueryParameter("OBK3", m3_OBK3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBK4))
				request.WithQueryParameter("OBK4", m3_OBK4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBK5))
				request.WithQueryParameter("OBK5", m3_OBK5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBK6))
				request.WithQueryParameter("OBK6", m3_OBK6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBK7))
				request.WithQueryParameter("OBK7", m3_OBK7.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_SOZ1.HasValue)
				request.WithQueryParameter("SOZ1", m3_SOZ1.Value.ToString());
			if (m3_SOZ2.HasValue)
				request.WithQueryParameter("SOZ2", m3_SOZ2.Value.ToString());
			if (m3_SOZ3.HasValue)
				request.WithQueryParameter("SOZ3", m3_SOZ3.Value.ToString());
			if (m3_SOZ4.HasValue)
				request.WithQueryParameter("SOZ4", m3_SOZ4.Value.ToString());
			if (m3_SOZ5.HasValue)
				request.WithQueryParameter("SOZ5", m3_SOZ5.Value.ToString());
			if (m3_SOZ6.HasValue)
				request.WithQueryParameter("SOZ6", m3_SOZ6.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USEQ))
				request.WithQueryParameter("USEQ", m3_USEQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UPV1))
				request.WithQueryParameter("UPV1", m3_UPV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UPV2))
				request.WithQueryParameter("UPV2", m3_UPV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UPV3))
				request.WithQueryParameter("UPV3", m3_UPV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UPV4))
				request.WithQueryParameter("UPV4", m3_UPV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UPV5))
				request.WithQueryParameter("UPV5", m3_UPV5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UPV6))
				request.WithQueryParameter("UPV6", m3_UPV6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IBCA))
				request.WithQueryParameter("IBCA", m3_IBCA.Trim());

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
		/// Name CpySortOrder
		/// Description Copy Sorting Order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PGNM">Program name (Required)</param>
		/// <param name="m3_QTTP">Inquiry type (Required)</param>
		/// <param name="m3_TTTP">To Inquiry type (Required)</param>
		/// <param name="m3_IBCA">Information browser category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpySortOrder(
			string m3_PGNM, 
			int m3_QTTP, 
			int m3_TTTP, 
			string m3_IBCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CpySortOrder",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim())
				.WithQueryParameter("QTTP", m3_QTTP.ToString())
				.WithQueryParameter("TTTP", m3_TTTP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_IBCA))
				request.WithQueryParameter("IBCA", m3_IBCA.Trim());

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
		/// Name DelLngTxt
		/// Description DelLngTxt
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PGNM">Program name (Required)</param>
		/// <param name="m3_QTTP">Sorting order (Required)</param>
		/// <param name="m3_IBCA">Information browser category</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelLngTxt(
			string m3_PGNM, 
			int m3_QTTP, 
			string m3_IBCA = null, 
			string m3_LNCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelLngTxt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim())
				.WithQueryParameter("QTTP", m3_QTTP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_IBCA))
				request.WithQueryParameter("IBCA", m3_IBCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());

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
		/// Name DelSortOrder
		/// Description Delete Sorting Order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PGNM">Program name (Required)</param>
		/// <param name="m3_QTTP">Inquiry type (Required)</param>
		/// <param name="m3_IBCA">Information browser category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelSortOrder(
			string m3_PGNM, 
			int m3_QTTP, 
			string m3_IBCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelSortOrder",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim())
				.WithQueryParameter("QTTP", m3_QTTP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_IBCA))
				request.WithQueryParameter("IBCA", m3_IBCA.Trim());

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
		/// Name DelStdPersView
		/// Description Delete Standard Personal View
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_PGNM">Program name (Required)</param>
		/// <param name="m3_QTTP">Sorting order (Required)</param>
		/// <param name="m3_RESP">Responsible (Required)</param>
		/// <param name="m3_IBCA">Information browser category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelStdPersView(
			string m3_PGNM, 
			int m3_QTTP, 
			string m3_RESP, 
			string m3_IBCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelStdPersView",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");
			if (string.IsNullOrWhiteSpace(m3_RESP))
				throw new ArgumentNullException("m3_RESP");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim())
				.WithQueryParameter("QTTP", m3_QTTP.ToString())
				.WithQueryParameter("RESP", m3_RESP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_IBCA))
				request.WithQueryParameter("IBCA", m3_IBCA.Trim());

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
		/// Name GetSortOrder
		/// Description Get Sorting Order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PGNM">Program name (Required)</param>
		/// <param name="m3_QTTP">Inquiry type (Required)</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_IBCA">Information browser category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSortOrderResponse></returns>
		/// <exception cref="M3Exception<GetSortOrderResponse>"></exception>
		public async Task<M3Response<GetSortOrderResponse>> GetSortOrder(
			string m3_PGNM, 
			int m3_QTTP, 
			string m3_RESP = null, 
			string m3_IBCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSortOrder",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PGNM))
				throw new ArgumentNullException("m3_PGNM");

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3_PGNM.Trim())
				.WithQueryParameter("QTTP", m3_QTTP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IBCA))
				request.WithQueryParameter("IBCA", m3_IBCA.Trim());

			// Execute the request
			var result = await Execute<GetSortOrderResponse>(
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
		/// Name LstSortOrder
		/// Description List Sorting Order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PGNM">Program name</param>
		/// <param name="m3_QTTP">Inquiry type</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_IBCA">Information browser category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSortOrderResponse></returns>
		/// <exception cref="M3Exception<LstSortOrderResponse>"></exception>
		public async Task<M3Response<LstSortOrderResponse>> LstSortOrder(
			string m3_PGNM = null, 
			int? m3_QTTP = null, 
			string m3_RESP = null, 
			string m3_IBCA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSortOrder",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PGNM))
				request.WithQueryParameter("PGNM", m3_PGNM.Trim());
			if (m3_QTTP.HasValue)
				request.WithQueryParameter("QTTP", m3_QTTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IBCA))
				request.WithQueryParameter("IBCA", m3_IBCA.Trim());

			// Execute the request
			var result = await Execute<LstSortOrderResponse>(
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
