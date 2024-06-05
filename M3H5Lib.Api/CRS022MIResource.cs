/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3PGNM">Program name (Required)</param>
		/// <param name="m3QTTP">Sorting order (Required)</param>
		/// <param name="m3LNCD">Language (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3FLDI">Field (Required)</param>
		/// <param name="m3IBCA">Information browser category</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLngTxt(
			string m3PGNM, 
			int m3QTTP, 
			string m3LNCD, 
			string m3TX40, 
			string m3FILE, 
			string m3FLDI, 
			string m3IBCA = null, 
			string m3TX15 = null, 
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
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));
			if (string.IsNullOrWhiteSpace(m3LNCD))
				throw new ArgumentNullException(nameof(m3LNCD));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FLDI))
				throw new ArgumentNullException(nameof(m3FLDI));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim())
				.WithQueryParameter("QTTP", m3QTTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("LNCD", m3LNCD.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FLDI", m3FLDI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3IBCA))
				request.WithQueryParameter("IBCA", m3IBCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());

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
		/// Name AddSortOrder
		/// Description Add Sorting Order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PGNM">Program name (Required)</param>
		/// <param name="m3QTTP">Inquiry type (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3FILE">Table (Required)</param>
		/// <param name="m3SOPT">Sorting option (Required)</param>
		/// <param name="m3PAV1">View (Required)</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3NFTR">Number of filters</param>
		/// <param name="m3PAV2">View</param>
		/// <param name="m3PAV3">View</param>
		/// <param name="m3PAV4">View</param>
		/// <param name="m3PAV5">View</param>
		/// <param name="m3PAV6">View</param>
		/// <param name="m3PSEQ">Panel sequence</param>
		/// <param name="m3TABL">Selection table</param>
		/// <param name="m3AGGR">Aggregation</param>
		/// <param name="m3OBK1">Key value</param>
		/// <param name="m3OBK2">Key value</param>
		/// <param name="m3OBK3">Key value</param>
		/// <param name="m3OBK4">Key value</param>
		/// <param name="m3OBK5">Key value</param>
		/// <param name="m3OBK6">Key value</param>
		/// <param name="m3OBK7">Key value</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3SOZ1">Sorting order zoom</param>
		/// <param name="m3SOZ2">Sorting order zoom</param>
		/// <param name="m3SOZ3">Sorting order zoom</param>
		/// <param name="m3SOZ4">Sorting order zoom</param>
		/// <param name="m3SOZ5">Sorting order zoom</param>
		/// <param name="m3SOZ6">Sorting order zoom</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3USEQ">Panel sequence</param>
		/// <param name="m3UPV1">User panel version</param>
		/// <param name="m3UPV2">User panel version</param>
		/// <param name="m3UPV3">User panel version</param>
		/// <param name="m3UPV4">User panel version</param>
		/// <param name="m3UPV5">User panel version</param>
		/// <param name="m3UPV6">User panel version</param>
		/// <param name="m3IBCA">Information browser category</param>
		/// <param name="m3SNDI">Single division</param>
		/// <param name="m3CHNF">Change filter</param>
		/// <param name="m3CHAG">Change aggregation</param>
		/// <param name="m3AGRG">Aggregation rule</param>
		/// <param name="m3MXRE">Maximum number of records</param>
		/// <param name="m3JNSO">Join sort</param>
		/// <param name="m3SLF1">Selection field 1</param>
		/// <param name="m3SLF2">Selection field 2</param>
		/// <param name="m3SLF3">Selection field 3</param>
		/// <param name="m3SUB1">Subtotal 1</param>
		/// <param name="m3SUB2">Subtotal 2</param>
		/// <param name="m3SUB3">Subtotal 3</param>
		/// <param name="m3HLAL">Highlight aggregated lines</param>
		/// <param name="m3SBFD">Sort-by field</param>
		/// <param name="m3SDSN">Sort decending</param>
		/// <param name="m3CON1">Key search id</param>
		/// <param name="m3LUFN">Last used file name</param>
		/// <param name="m3LUVE">Last used version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSortOrder(
			string m3PGNM, 
			int m3QTTP, 
			string m3TX40, 
			string m3FILE, 
			string m3SOPT, 
			string m3PAV1, 
			string m3TX15 = null, 
			int? m3NFTR = null, 
			string m3PAV2 = null, 
			string m3PAV3 = null, 
			string m3PAV4 = null, 
			string m3PAV5 = null, 
			string m3PAV6 = null, 
			string m3PSEQ = null, 
			string m3TABL = null, 
			int? m3AGGR = null, 
			string m3OBK1 = null, 
			string m3OBK2 = null, 
			string m3OBK3 = null, 
			string m3OBK4 = null, 
			string m3OBK5 = null, 
			string m3OBK6 = null, 
			string m3OBK7 = null, 
			decimal? m3TXID = null, 
			int? m3SOZ1 = null, 
			int? m3SOZ2 = null, 
			int? m3SOZ3 = null, 
			int? m3SOZ4 = null, 
			int? m3SOZ5 = null, 
			int? m3SOZ6 = null, 
			string m3RESP = null, 
			string m3USEQ = null, 
			string m3UPV1 = null, 
			string m3UPV2 = null, 
			string m3UPV3 = null, 
			string m3UPV4 = null, 
			string m3UPV5 = null, 
			string m3UPV6 = null, 
			string m3IBCA = null, 
			int? m3SNDI = null, 
			int? m3CHNF = null, 
			int? m3CHAG = null, 
			int? m3AGRG = null, 
			int? m3MXRE = null, 
			int? m3JNSO = null, 
			string m3SLF1 = null, 
			string m3SLF2 = null, 
			string m3SLF3 = null, 
			int? m3SUB1 = null, 
			int? m3SUB2 = null, 
			int? m3SUB3 = null, 
			int? m3HLAL = null, 
			string m3SBFD = null, 
			int? m3SDSN = null, 
			string m3CON1 = null, 
			string m3LUFN = null, 
			string m3LUVE = null, 
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
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3SOPT))
				throw new ArgumentNullException(nameof(m3SOPT));
			if (string.IsNullOrWhiteSpace(m3PAV1))
				throw new ArgumentNullException(nameof(m3PAV1));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim())
				.WithQueryParameter("QTTP", m3QTTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TX40", m3TX40.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("SOPT", m3SOPT.Trim())
				.WithQueryParameter("PAV1", m3PAV1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3NFTR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PAV2))
				request.WithQueryParameter("PAV2", m3PAV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAV3))
				request.WithQueryParameter("PAV3", m3PAV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAV4))
				request.WithQueryParameter("PAV4", m3PAV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAV5))
				request.WithQueryParameter("PAV5", m3PAV5.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAV6))
				request.WithQueryParameter("PAV6", m3PAV6.Trim());
			if (!string.IsNullOrWhiteSpace(m3PSEQ))
				request.WithQueryParameter("PSEQ", m3PSEQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3TABL))
				request.WithQueryParameter("TABL", m3TABL.Trim());
			if (m3AGGR.HasValue)
				request.WithQueryParameter("AGGR", m3AGGR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBK1))
				request.WithQueryParameter("OBK1", m3OBK1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBK2))
				request.WithQueryParameter("OBK2", m3OBK2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBK3))
				request.WithQueryParameter("OBK3", m3OBK3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBK4))
				request.WithQueryParameter("OBK4", m3OBK4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBK5))
				request.WithQueryParameter("OBK5", m3OBK5.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBK6))
				request.WithQueryParameter("OBK6", m3OBK6.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBK7))
				request.WithQueryParameter("OBK7", m3OBK7.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SOZ1.HasValue)
				request.WithQueryParameter("SOZ1", m3SOZ1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SOZ2.HasValue)
				request.WithQueryParameter("SOZ2", m3SOZ2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SOZ3.HasValue)
				request.WithQueryParameter("SOZ3", m3SOZ3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SOZ4.HasValue)
				request.WithQueryParameter("SOZ4", m3SOZ4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SOZ5.HasValue)
				request.WithQueryParameter("SOZ5", m3SOZ5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SOZ6.HasValue)
				request.WithQueryParameter("SOZ6", m3SOZ6.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3USEQ))
				request.WithQueryParameter("USEQ", m3USEQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3UPV1))
				request.WithQueryParameter("UPV1", m3UPV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3UPV2))
				request.WithQueryParameter("UPV2", m3UPV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3UPV3))
				request.WithQueryParameter("UPV3", m3UPV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3UPV4))
				request.WithQueryParameter("UPV4", m3UPV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3UPV5))
				request.WithQueryParameter("UPV5", m3UPV5.Trim());
			if (!string.IsNullOrWhiteSpace(m3UPV6))
				request.WithQueryParameter("UPV6", m3UPV6.Trim());
			if (!string.IsNullOrWhiteSpace(m3IBCA))
				request.WithQueryParameter("IBCA", m3IBCA.Trim());
			if (m3SNDI.HasValue)
				request.WithQueryParameter("SNDI", m3SNDI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHNF.HasValue)
				request.WithQueryParameter("CHNF", m3CHNF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHAG.HasValue)
				request.WithQueryParameter("CHAG", m3CHAG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGRG.HasValue)
				request.WithQueryParameter("AGRG", m3AGRG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MXRE.HasValue)
				request.WithQueryParameter("MXRE", m3MXRE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3JNSO.HasValue)
				request.WithQueryParameter("JNSO", m3JNSO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SLF1))
				request.WithQueryParameter("SLF1", m3SLF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLF2))
				request.WithQueryParameter("SLF2", m3SLF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLF3))
				request.WithQueryParameter("SLF3", m3SLF3.Trim());
			if (m3SUB1.HasValue)
				request.WithQueryParameter("SUB1", m3SUB1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUB2.HasValue)
				request.WithQueryParameter("SUB2", m3SUB2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SUB3.HasValue)
				request.WithQueryParameter("SUB3", m3SUB3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HLAL.HasValue)
				request.WithQueryParameter("HLAL", m3HLAL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SBFD))
				request.WithQueryParameter("SBFD", m3SBFD.Trim());
			if (m3SDSN.HasValue)
				request.WithQueryParameter("SDSN", m3SDSN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CON1))
				request.WithQueryParameter("CON1", m3CON1.Trim());
			if (!string.IsNullOrWhiteSpace(m3LUFN))
				request.WithQueryParameter("LUFN", m3LUFN.Trim());
			if (!string.IsNullOrWhiteSpace(m3LUVE))
				request.WithQueryParameter("LUVE", m3LUVE.Trim());

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
		/// Name AddStdPersView
		/// Description Add Standard Personal View
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3PGNM">Program name (Required)</param>
		/// <param name="m3QTTP">Sorting order (Required)</param>
		/// <param name="m3RESP">Responsible (Required)</param>
		/// <param name="m3IBCA">Information browser category</param>
		/// <param name="m3USEQ">Panel sequence</param>
		/// <param name="m3UPV1">Personal view</param>
		/// <param name="m3UPV2">Personal view</param>
		/// <param name="m3UPV3">Personal view</param>
		/// <param name="m3UPV4">Personal view</param>
		/// <param name="m3UPV5">Personal view</param>
		/// <param name="m3UPV6">Personal view</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddStdPersView(
			string m3PGNM, 
			int m3QTTP, 
			string m3RESP, 
			string m3IBCA = null, 
			string m3USEQ = null, 
			string m3UPV1 = null, 
			string m3UPV2 = null, 
			string m3UPV3 = null, 
			string m3UPV4 = null, 
			string m3UPV5 = null, 
			string m3UPV6 = null, 
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
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));
			if (string.IsNullOrWhiteSpace(m3RESP))
				throw new ArgumentNullException(nameof(m3RESP));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim())
				.WithQueryParameter("QTTP", m3QTTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RESP", m3RESP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3IBCA))
				request.WithQueryParameter("IBCA", m3IBCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3USEQ))
				request.WithQueryParameter("USEQ", m3USEQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3UPV1))
				request.WithQueryParameter("UPV1", m3UPV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3UPV2))
				request.WithQueryParameter("UPV2", m3UPV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3UPV3))
				request.WithQueryParameter("UPV3", m3UPV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3UPV4))
				request.WithQueryParameter("UPV4", m3UPV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3UPV5))
				request.WithQueryParameter("UPV5", m3UPV5.Trim());
			if (!string.IsNullOrWhiteSpace(m3UPV6))
				request.WithQueryParameter("UPV6", m3UPV6.Trim());

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
		/// Name ChgSortOrder
		/// Description Change Sorting Order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PGNM">Program name (Required)</param>
		/// <param name="m3QTTP">Inquiry type (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3FILE">Table</param>
		/// <param name="m3SOPT">Sorting option</param>
		/// <param name="m3NFTR">Number of filters</param>
		/// <param name="m3PAV1">View</param>
		/// <param name="m3PAV2">View</param>
		/// <param name="m3PAV3">View</param>
		/// <param name="m3PAV4">View</param>
		/// <param name="m3PAV5">View</param>
		/// <param name="m3PAV6">View</param>
		/// <param name="m3PSEQ">Panel sequence</param>
		/// <param name="m3TABL">Selection table</param>
		/// <param name="m3AGGR">Aggregation</param>
		/// <param name="m3OBK1">Key value</param>
		/// <param name="m3OBK2">Key value</param>
		/// <param name="m3OBK3">Key value</param>
		/// <param name="m3OBK4">Key value</param>
		/// <param name="m3OBK5">Key value</param>
		/// <param name="m3OBK6">Key value</param>
		/// <param name="m3OBK7">Key value</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3SOZ1">Sorting order zoom</param>
		/// <param name="m3SOZ2">Sorting order zoom</param>
		/// <param name="m3SOZ3">Sorting order zoom</param>
		/// <param name="m3SOZ4">Sorting order zoom</param>
		/// <param name="m3SOZ5">Sorting order zoom</param>
		/// <param name="m3SOZ6">Sorting order zoom</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3USEQ">Panel sequence</param>
		/// <param name="m3UPV1">User panel version</param>
		/// <param name="m3UPV2">User panel version</param>
		/// <param name="m3UPV3">User panel version</param>
		/// <param name="m3UPV4">User panel version</param>
		/// <param name="m3UPV5">User panel version</param>
		/// <param name="m3UPV6">User panel version</param>
		/// <param name="m3IBCA">Information browser category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgSortOrder(
			string m3PGNM, 
			int m3QTTP, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3FILE = null, 
			string m3SOPT = null, 
			int? m3NFTR = null, 
			string m3PAV1 = null, 
			string m3PAV2 = null, 
			string m3PAV3 = null, 
			string m3PAV4 = null, 
			string m3PAV5 = null, 
			string m3PAV6 = null, 
			string m3PSEQ = null, 
			string m3TABL = null, 
			int? m3AGGR = null, 
			string m3OBK1 = null, 
			string m3OBK2 = null, 
			string m3OBK3 = null, 
			string m3OBK4 = null, 
			string m3OBK5 = null, 
			string m3OBK6 = null, 
			string m3OBK7 = null, 
			decimal? m3TXID = null, 
			int? m3SOZ1 = null, 
			int? m3SOZ2 = null, 
			int? m3SOZ3 = null, 
			int? m3SOZ4 = null, 
			int? m3SOZ5 = null, 
			int? m3SOZ6 = null, 
			string m3RESP = null, 
			string m3USEQ = null, 
			string m3UPV1 = null, 
			string m3UPV2 = null, 
			string m3UPV3 = null, 
			string m3UPV4 = null, 
			string m3UPV5 = null, 
			string m3UPV6 = null, 
			string m3IBCA = null, 
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
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim())
				.WithQueryParameter("QTTP", m3QTTP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SOPT))
				request.WithQueryParameter("SOPT", m3SOPT.Trim());
			if (m3NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3NFTR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PAV1))
				request.WithQueryParameter("PAV1", m3PAV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAV2))
				request.WithQueryParameter("PAV2", m3PAV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAV3))
				request.WithQueryParameter("PAV3", m3PAV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAV4))
				request.WithQueryParameter("PAV4", m3PAV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAV5))
				request.WithQueryParameter("PAV5", m3PAV5.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAV6))
				request.WithQueryParameter("PAV6", m3PAV6.Trim());
			if (!string.IsNullOrWhiteSpace(m3PSEQ))
				request.WithQueryParameter("PSEQ", m3PSEQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3TABL))
				request.WithQueryParameter("TABL", m3TABL.Trim());
			if (m3AGGR.HasValue)
				request.WithQueryParameter("AGGR", m3AGGR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBK1))
				request.WithQueryParameter("OBK1", m3OBK1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBK2))
				request.WithQueryParameter("OBK2", m3OBK2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBK3))
				request.WithQueryParameter("OBK3", m3OBK3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBK4))
				request.WithQueryParameter("OBK4", m3OBK4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBK5))
				request.WithQueryParameter("OBK5", m3OBK5.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBK6))
				request.WithQueryParameter("OBK6", m3OBK6.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBK7))
				request.WithQueryParameter("OBK7", m3OBK7.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SOZ1.HasValue)
				request.WithQueryParameter("SOZ1", m3SOZ1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SOZ2.HasValue)
				request.WithQueryParameter("SOZ2", m3SOZ2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SOZ3.HasValue)
				request.WithQueryParameter("SOZ3", m3SOZ3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SOZ4.HasValue)
				request.WithQueryParameter("SOZ4", m3SOZ4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SOZ5.HasValue)
				request.WithQueryParameter("SOZ5", m3SOZ5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SOZ6.HasValue)
				request.WithQueryParameter("SOZ6", m3SOZ6.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3USEQ))
				request.WithQueryParameter("USEQ", m3USEQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3UPV1))
				request.WithQueryParameter("UPV1", m3UPV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3UPV2))
				request.WithQueryParameter("UPV2", m3UPV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3UPV3))
				request.WithQueryParameter("UPV3", m3UPV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3UPV4))
				request.WithQueryParameter("UPV4", m3UPV4.Trim());
			if (!string.IsNullOrWhiteSpace(m3UPV5))
				request.WithQueryParameter("UPV5", m3UPV5.Trim());
			if (!string.IsNullOrWhiteSpace(m3UPV6))
				request.WithQueryParameter("UPV6", m3UPV6.Trim());
			if (!string.IsNullOrWhiteSpace(m3IBCA))
				request.WithQueryParameter("IBCA", m3IBCA.Trim());

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
		/// Name CpySortOrder
		/// Description Copy Sorting Order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PGNM">Program name (Required)</param>
		/// <param name="m3QTTP">Inquiry type (Required)</param>
		/// <param name="m3TTTP">To Inquiry type (Required)</param>
		/// <param name="m3IBCA">Information browser category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CpySortOrder(
			string m3PGNM, 
			int m3QTTP, 
			int m3TTTP, 
			string m3IBCA = null, 
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
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim())
				.WithQueryParameter("QTTP", m3QTTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TTTP", m3TTTP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3IBCA))
				request.WithQueryParameter("IBCA", m3IBCA.Trim());

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
		/// Name DelLngTxt
		/// Description DelLngTxt
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PGNM">Program name (Required)</param>
		/// <param name="m3QTTP">Sorting order (Required)</param>
		/// <param name="m3IBCA">Information browser category</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelLngTxt(
			string m3PGNM, 
			int m3QTTP, 
			string m3IBCA = null, 
			string m3LNCD = null, 
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
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim())
				.WithQueryParameter("QTTP", m3QTTP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3IBCA))
				request.WithQueryParameter("IBCA", m3IBCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());

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
		/// Name DelSortOrder
		/// Description Delete Sorting Order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PGNM">Program name (Required)</param>
		/// <param name="m3QTTP">Inquiry type (Required)</param>
		/// <param name="m3IBCA">Information browser category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelSortOrder(
			string m3PGNM, 
			int m3QTTP, 
			string m3IBCA = null, 
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
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim())
				.WithQueryParameter("QTTP", m3QTTP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3IBCA))
				request.WithQueryParameter("IBCA", m3IBCA.Trim());

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
		/// Name DelStdPersView
		/// Description Delete Standard Personal View
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3PGNM">Program name (Required)</param>
		/// <param name="m3QTTP">Sorting order (Required)</param>
		/// <param name="m3RESP">Responsible (Required)</param>
		/// <param name="m3IBCA">Information browser category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelStdPersView(
			string m3PGNM, 
			int m3QTTP, 
			string m3RESP, 
			string m3IBCA = null, 
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
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));
			if (string.IsNullOrWhiteSpace(m3RESP))
				throw new ArgumentNullException(nameof(m3RESP));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim())
				.WithQueryParameter("QTTP", m3QTTP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RESP", m3RESP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3IBCA))
				request.WithQueryParameter("IBCA", m3IBCA.Trim());

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
		/// Name GetSortOrder
		/// Description Get Sorting Order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PGNM">Program name (Required)</param>
		/// <param name="m3QTTP">Inquiry type (Required)</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3IBCA">Information browser category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSortOrderResponse></returns>
		/// <exception cref="M3Exception<GetSortOrderResponse>"></exception>
		public async Task<M3Response<GetSortOrderResponse>> GetSortOrder(
			string m3PGNM, 
			int m3QTTP, 
			string m3RESP = null, 
			string m3IBCA = null, 
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
			if (string.IsNullOrWhiteSpace(m3PGNM))
				throw new ArgumentNullException(nameof(m3PGNM));

			// Set mandatory parameters
			request
				.WithQueryParameter("PGNM", m3PGNM.Trim())
				.WithQueryParameter("QTTP", m3QTTP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3IBCA))
				request.WithQueryParameter("IBCA", m3IBCA.Trim());

			// Execute the request
			var result = await Execute<GetSortOrderResponse>(
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
		/// Name LstSortOrder
		/// Description List Sorting Order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PGNM">Program name</param>
		/// <param name="m3QTTP">Inquiry type</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3IBCA">Information browser category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSortOrderResponse></returns>
		/// <exception cref="M3Exception<LstSortOrderResponse>"></exception>
		public async Task<M3Response<LstSortOrderResponse>> LstSortOrder(
			string m3PGNM = null, 
			int? m3QTTP = null, 
			string m3RESP = null, 
			string m3IBCA = null, 
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
			if (!string.IsNullOrWhiteSpace(m3PGNM))
				request.WithQueryParameter("PGNM", m3PGNM.Trim());
			if (m3QTTP.HasValue)
				request.WithQueryParameter("QTTP", m3QTTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3IBCA))
				request.WithQueryParameter("IBCA", m3IBCA.Trim());

			// Execute the request
			var result = await Execute<LstSortOrderResponse>(
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
