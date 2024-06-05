/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CSS006MI;
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
	/// Name: CSS006MI
	/// Component Name: Machine/Engine pricing API
	/// Description: Machine/Engine pricing API
	/// Version Release: 14.x
	///</summary>
	public partial class CSS006MIResource : M3BaseResourceEndpoint
	{
		public CSS006MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CSS006MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddN
		/// Description Add Machine and Enging Pricing N-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDL1">Dealer code (Required)</param>
		/// <param name="m3_APRM">Price model (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_SECO">Section code (Required)</param>
		/// <param name="m3_SEQ3">Sequence number (Required)</param>
		/// <param name="m3_SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3_TPCD">Item category (Required)</param>
		/// <param name="m3_SEQ5">Reference sequence number (Required)</param>
		/// <param name="m3_AVCD">Activity code</param>
		/// <param name="m3_MSDS">Sequence number</param>
		/// <param name="m3_ANSQ">Attribute sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddN(
			string m3_IDL1, 
			string m3_APRM, 
			DateTime m3_FDAT, 
			string m3_SECO, 
			int m3_SEQ3, 
			int m3_SEQ2, 
			int m3_TPCD, 
			int m3_SEQ5, 
			string m3_AVCD = null, 
			int? m3_MSDS = null, 
			int? m3_ANSQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddN",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDL1))
				throw new ArgumentNullException("m3_IDL1");
			if (string.IsNullOrWhiteSpace(m3_APRM))
				throw new ArgumentNullException("m3_APRM");
			if (string.IsNullOrWhiteSpace(m3_SECO))
				throw new ArgumentNullException("m3_SECO");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3_IDL1.Trim())
				.WithQueryParameter("APRM", m3_APRM.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("SECO", m3_SECO.Trim())
				.WithQueryParameter("SEQ3", m3_SEQ3.ToString())
				.WithQueryParameter("SEQ2", m3_SEQ2.ToString())
				.WithQueryParameter("TPCD", m3_TPCD.ToString())
				.WithQueryParameter("SEQ5", m3_SEQ5.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_AVCD))
				request.WithQueryParameter("AVCD", m3_AVCD.Trim());
			if (m3_MSDS.HasValue)
				request.WithQueryParameter("MSDS", m3_MSDS.Value.ToString());
			if (m3_ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3_ANSQ.Value.ToString());

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
		/// Name AddP
		/// Description Add equipment Interface Parameters
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_STCO">Constant value (Required)</param>
		/// <param name="m3_TX20">Text</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX70">Text</param>
		/// <param name="m3_PARM">Parameter value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddP(
			string m3_STCO, 
			string m3_TX20 = null, 
			string m3_TX40 = null, 
			string m3_TX70 = null, 
			string m3_PARM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STCO))
				throw new ArgumentNullException("m3_STCO");

			// Set mandatory parameters
			request
				.WithQueryParameter("STCO", m3_STCO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TX20))
				request.WithQueryParameter("TX20", m3_TX20.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX70))
				request.WithQueryParameter("TX70", m3_TX70.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PARM))
				request.WithQueryParameter("PARM", m3_PARM.Trim());

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
		/// Name AddR
		/// Description Add Machine and Enging Pricing R-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDL1">Dealer code (Required)</param>
		/// <param name="m3_APRM">Price model (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_SECO">Section code (Required)</param>
		/// <param name="m3_SEQ3">Sequence number (Required)</param>
		/// <param name="m3_SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3_TPCD">Item category (Required)</param>
		/// <param name="m3_SEQ5">Reference sequence number (Required)</param>
		/// <param name="m3_CHDA">Change date (Required)</param>
		/// <param name="m3_AVCD">Activity code</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BIRS">Date introduced into Movex</param>
		/// <param name="m3_REPI">Replaced item number</param>
		/// <param name="m3_USCO">Use code</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_NEWE">Net weight</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_SAP1">Sales price</param>
		/// <param name="m3_NTCD">Net price used</param>
		/// <param name="m3_DIP1">Discount 1</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_ATCI">Attachment indicator</param>
		/// <param name="m3_IN60">Indicator</param>
		/// <param name="m3_ORPT">Order product type</param>
		/// <param name="m3_IN71">Indicator</param>
		/// <param name="m3_ASLM">Sales model</param>
		/// <param name="m3_MSDS">Sequence number</param>
		/// <param name="m3_ANSQ">Attribute sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddR(
			string m3_IDL1, 
			string m3_APRM, 
			DateTime m3_FDAT, 
			string m3_SECO, 
			int m3_SEQ3, 
			int m3_SEQ2, 
			int m3_TPCD, 
			int m3_SEQ5, 
			DateTime m3_CHDA, 
			string m3_AVCD = null, 
			string m3_ITNO = null, 
			DateTime? m3_BIRS = null, 
			string m3_REPI = null, 
			string m3_USCO = null, 
			decimal? m3_GRWE = null, 
			decimal? m3_NEWE = null, 
			decimal? m3_SAPR = null, 
			decimal? m3_SAP1 = null, 
			int? m3_NTCD = null, 
			int? m3_DIP1 = null, 
			string m3_ITDS = null, 
			string m3_ATCI = null, 
			string m3_IN60 = null, 
			string m3_ORPT = null, 
			string m3_IN71 = null, 
			string m3_ASLM = null, 
			int? m3_MSDS = null, 
			int? m3_ANSQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddR",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDL1))
				throw new ArgumentNullException("m3_IDL1");
			if (string.IsNullOrWhiteSpace(m3_APRM))
				throw new ArgumentNullException("m3_APRM");
			if (string.IsNullOrWhiteSpace(m3_SECO))
				throw new ArgumentNullException("m3_SECO");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3_IDL1.Trim())
				.WithQueryParameter("APRM", m3_APRM.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("SECO", m3_SECO.Trim())
				.WithQueryParameter("SEQ3", m3_SEQ3.ToString())
				.WithQueryParameter("SEQ2", m3_SEQ2.ToString())
				.WithQueryParameter("TPCD", m3_TPCD.ToString())
				.WithQueryParameter("SEQ5", m3_SEQ5.ToString())
				.WithQueryParameter("CHDA", m3_CHDA.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_AVCD))
				request.WithQueryParameter("AVCD", m3_AVCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_BIRS.HasValue)
				request.WithQueryParameter("BIRS", m3_BIRS.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_REPI))
				request.WithQueryParameter("REPI", m3_REPI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USCO))
				request.WithQueryParameter("USCO", m3_USCO.Trim());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3_NEWE.Value.ToString());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_SAP1.HasValue)
				request.WithQueryParameter("SAP1", m3_SAP1.Value.ToString());
			if (m3_NTCD.HasValue)
				request.WithQueryParameter("NTCD", m3_NTCD.Value.ToString());
			if (m3_DIP1.HasValue)
				request.WithQueryParameter("DIP1", m3_DIP1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATCI))
				request.WithQueryParameter("ATCI", m3_ATCI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IN60))
				request.WithQueryParameter("IN60", m3_IN60.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORPT))
				request.WithQueryParameter("ORPT", m3_ORPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IN71))
				request.WithQueryParameter("IN71", m3_IN71.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ASLM))
				request.WithQueryParameter("ASLM", m3_ASLM.Trim());
			if (m3_MSDS.HasValue)
				request.WithQueryParameter("MSDS", m3_MSDS.Value.ToString());
			if (m3_ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3_ANSQ.Value.ToString());

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
		/// Name AddS
		/// Description Add Machine and Enging Pricing S-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDL1">Dealer code (Required)</param>
		/// <param name="m3_APRM">Price model (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_MSDS">Sequence number</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_ITCL">Product group</param>
		/// <param name="m3_SUDT">Supesede date</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_ARAT">Exchange rate</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddS(
			string m3_IDL1, 
			string m3_APRM, 
			DateTime m3_FDAT, 
			int? m3_MSDS = null, 
			string m3_FACI = null, 
			string m3_ITCL = null, 
			DateTime? m3_SUDT = null, 
			string m3_CUCD = null, 
			decimal? m3_ARAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddS",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDL1))
				throw new ArgumentNullException("m3_IDL1");
			if (string.IsNullOrWhiteSpace(m3_APRM))
				throw new ArgumentNullException("m3_APRM");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3_IDL1.Trim())
				.WithQueryParameter("APRM", m3_APRM.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_MSDS.HasValue)
				request.WithQueryParameter("MSDS", m3_MSDS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCL))
				request.WithQueryParameter("ITCL", m3_ITCL.Trim());
			if (m3_SUDT.HasValue)
				request.WithQueryParameter("SUDT", m3_SUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3_ARAT.Value.ToString());

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
		/// Name AddT
		/// Description Add Machine and Enging Pricing N-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDL1">Dealer code (Required)</param>
		/// <param name="m3_APRM">Price model (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_SECO">Section code (Required)</param>
		/// <param name="m3_SEQ3">Sequence number (Required)</param>
		/// <param name="m3_SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3_TPCD">Item category (Required)</param>
		/// <param name="m3_SEQ5">Reference sequence number (Required)</param>
		/// <param name="m3_TXKY">Text sequence number (Required)</param>
		/// <param name="m3_TXCC">Text control code (Required)</param>
		/// <param name="m3_AVCD">Activity code</param>
		/// <param name="m3_TX70">Text</param>
		/// <param name="m3_MSDS">Sequence number</param>
		/// <param name="m3_ANSQ">Attribute sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddT(
			string m3_IDL1, 
			string m3_APRM, 
			DateTime m3_FDAT, 
			string m3_SECO, 
			int m3_SEQ3, 
			int m3_SEQ2, 
			int m3_TPCD, 
			int m3_SEQ5, 
			int m3_TXKY, 
			string m3_TXCC, 
			string m3_AVCD = null, 
			string m3_TX70 = null, 
			int? m3_MSDS = null, 
			int? m3_ANSQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDL1))
				throw new ArgumentNullException("m3_IDL1");
			if (string.IsNullOrWhiteSpace(m3_APRM))
				throw new ArgumentNullException("m3_APRM");
			if (string.IsNullOrWhiteSpace(m3_SECO))
				throw new ArgumentNullException("m3_SECO");
			if (string.IsNullOrWhiteSpace(m3_TXCC))
				throw new ArgumentNullException("m3_TXCC");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3_IDL1.Trim())
				.WithQueryParameter("APRM", m3_APRM.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("SECO", m3_SECO.Trim())
				.WithQueryParameter("SEQ3", m3_SEQ3.ToString())
				.WithQueryParameter("SEQ2", m3_SEQ2.ToString())
				.WithQueryParameter("TPCD", m3_TPCD.ToString())
				.WithQueryParameter("SEQ5", m3_SEQ5.ToString())
				.WithQueryParameter("TXKY", m3_TXKY.ToString())
				.WithQueryParameter("TXCC", m3_TXCC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_AVCD))
				request.WithQueryParameter("AVCD", m3_AVCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX70))
				request.WithQueryParameter("TX70", m3_TX70.Trim());
			if (m3_MSDS.HasValue)
				request.WithQueryParameter("MSDS", m3_MSDS.Value.ToString());
			if (m3_ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3_ANSQ.Value.ToString());

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
		/// Name AddU
		/// Description Add Machine and Enging Pricing U-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDL1">Dealer code (Required)</param>
		/// <param name="m3_APRM">Price model (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_SECO">Section code (Required)</param>
		/// <param name="m3_SEQ3">Sequence number (Required)</param>
		/// <param name="m3_SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3_TPCD">Item category (Required)</param>
		/// <param name="m3_AVCD">Activity code</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX70">Text</param>
		/// <param name="m3_MSDS">Sequence number</param>
		/// <param name="m3_ANSQ">Attribute sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddU(
			string m3_IDL1, 
			string m3_APRM, 
			DateTime m3_FDAT, 
			string m3_SECO, 
			int m3_SEQ3, 
			int m3_SEQ2, 
			int m3_TPCD, 
			string m3_AVCD = null, 
			string m3_TX40 = null, 
			string m3_TX70 = null, 
			int? m3_MSDS = null, 
			int? m3_ANSQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddU",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDL1))
				throw new ArgumentNullException("m3_IDL1");
			if (string.IsNullOrWhiteSpace(m3_APRM))
				throw new ArgumentNullException("m3_APRM");
			if (string.IsNullOrWhiteSpace(m3_SECO))
				throw new ArgumentNullException("m3_SECO");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3_IDL1.Trim())
				.WithQueryParameter("APRM", m3_APRM.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("SECO", m3_SECO.Trim())
				.WithQueryParameter("SEQ3", m3_SEQ3.ToString())
				.WithQueryParameter("SEQ2", m3_SEQ2.ToString())
				.WithQueryParameter("TPCD", m3_TPCD.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_AVCD))
				request.WithQueryParameter("AVCD", m3_AVCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX70))
				request.WithQueryParameter("TX70", m3_TX70.Trim());
			if (m3_MSDS.HasValue)
				request.WithQueryParameter("MSDS", m3_MSDS.Value.ToString());
			if (m3_ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3_ANSQ.Value.ToString());

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
		/// Name DelP
		/// Description Delete equipment Interface Parameters
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_STCO">Constant value (Required)</param>
		/// <param name="m3_TX20">Text (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_TX70">Text (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelP(
			string m3_STCO, 
			string m3_TX20, 
			string m3_TX40, 
			string m3_TX70, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STCO))
				throw new ArgumentNullException("m3_STCO");
			if (string.IsNullOrWhiteSpace(m3_TX20))
				throw new ArgumentNullException("m3_TX20");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");
			if (string.IsNullOrWhiteSpace(m3_TX70))
				throw new ArgumentNullException("m3_TX70");

			// Set mandatory parameters
			request
				.WithQueryParameter("STCO", m3_STCO.Trim())
				.WithQueryParameter("TX20", m3_TX20.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim())
				.WithQueryParameter("TX70", m3_TX70.Trim());

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
		/// Name DltS
		/// Description Delete Machine and Enging Pricing S-record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDL1">Dealer code (Required)</param>
		/// <param name="m3_APRM">Price model (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltS(
			string m3_IDL1, 
			string m3_APRM, 
			DateTime m3_FDAT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltS",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDL1))
				throw new ArgumentNullException("m3_IDL1");
			if (string.IsNullOrWhiteSpace(m3_APRM))
				throw new ArgumentNullException("m3_APRM");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3_IDL1.Trim())
				.WithQueryParameter("APRM", m3_APRM.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String());

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
		/// Name DltT
		/// Description Delete Machine and Enging Pricing T-record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDL1">Dealer code (Required)</param>
		/// <param name="m3_APRM">Price model (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_SECO">Section code (Required)</param>
		/// <param name="m3_SEQ3">Sequence number (Required)</param>
		/// <param name="m3_SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3_TPCD">Item category (Required)</param>
		/// <param name="m3_SEQ5">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltT(
			string m3_IDL1, 
			string m3_APRM, 
			DateTime m3_FDAT, 
			string m3_SECO, 
			int m3_SEQ3, 
			int m3_SEQ2, 
			int m3_TPCD, 
			int? m3_SEQ5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDL1))
				throw new ArgumentNullException("m3_IDL1");
			if (string.IsNullOrWhiteSpace(m3_APRM))
				throw new ArgumentNullException("m3_APRM");
			if (string.IsNullOrWhiteSpace(m3_SECO))
				throw new ArgumentNullException("m3_SECO");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3_IDL1.Trim())
				.WithQueryParameter("APRM", m3_APRM.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("SECO", m3_SECO.Trim())
				.WithQueryParameter("SEQ3", m3_SEQ3.ToString())
				.WithQueryParameter("SEQ2", m3_SEQ2.ToString())
				.WithQueryParameter("TPCD", m3_TPCD.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_SEQ5.HasValue)
				request.WithQueryParameter("SEQ5", m3_SEQ5.Value.ToString());

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
		/// Name DltU
		/// Description Delete Machine and Enging Pricing U-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDL1">Dealer code (Required)</param>
		/// <param name="m3_APRM">Price model (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_SECO">Section code (Required)</param>
		/// <param name="m3_SEQ3">Sequence number (Required)</param>
		/// <param name="m3_SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3_TPCD">Item category (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltU(
			string m3_IDL1, 
			string m3_APRM, 
			DateTime m3_FDAT, 
			string m3_SECO, 
			int m3_SEQ3, 
			int m3_SEQ2, 
			int m3_TPCD, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltU",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDL1))
				throw new ArgumentNullException("m3_IDL1");
			if (string.IsNullOrWhiteSpace(m3_APRM))
				throw new ArgumentNullException("m3_APRM");
			if (string.IsNullOrWhiteSpace(m3_SECO))
				throw new ArgumentNullException("m3_SECO");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3_IDL1.Trim())
				.WithQueryParameter("APRM", m3_APRM.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("SECO", m3_SECO.Trim())
				.WithQueryParameter("SEQ3", m3_SEQ3.ToString())
				.WithQueryParameter("SEQ2", m3_SEQ2.ToString())
				.WithQueryParameter("TPCD", m3_TPCD.ToString());

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
		/// Name GetN
		/// Description Get Machine and Enging Pricing N-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDL1">Dealer code (Required)</param>
		/// <param name="m3_APRM">Price model (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_SECO">Section code (Required)</param>
		/// <param name="m3_SEQ3">Sequence number (Required)</param>
		/// <param name="m3_SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3_TPCD">Item category (Required)</param>
		/// <param name="m3_SEQ5">Reference sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetNResponse></returns>
		/// <exception cref="M3Exception<GetNResponse>"></exception>
		public async Task<M3Response<GetNResponse>> GetN(
			string m3_IDL1, 
			string m3_APRM, 
			DateTime m3_FDAT, 
			string m3_SECO, 
			int m3_SEQ3, 
			int m3_SEQ2, 
			int m3_TPCD, 
			int m3_SEQ5, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetN",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDL1))
				throw new ArgumentNullException("m3_IDL1");
			if (string.IsNullOrWhiteSpace(m3_APRM))
				throw new ArgumentNullException("m3_APRM");
			if (string.IsNullOrWhiteSpace(m3_SECO))
				throw new ArgumentNullException("m3_SECO");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3_IDL1.Trim())
				.WithQueryParameter("APRM", m3_APRM.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("SECO", m3_SECO.Trim())
				.WithQueryParameter("SEQ3", m3_SEQ3.ToString())
				.WithQueryParameter("SEQ2", m3_SEQ2.ToString())
				.WithQueryParameter("TPCD", m3_TPCD.ToString())
				.WithQueryParameter("SEQ5", m3_SEQ5.ToString());

			// Execute the request
			var result = await Execute<GetNResponse>(
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
		/// Name GetP
		/// Description Get equipment Interface Parameters
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_STCO">Constant value (Required)</param>
		/// <param name="m3_TX20">Text (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_TX70">Text (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPResponse></returns>
		/// <exception cref="M3Exception<GetPResponse>"></exception>
		public async Task<M3Response<GetPResponse>> GetP(
			string m3_STCO, 
			string m3_TX20, 
			string m3_TX40, 
			string m3_TX70, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STCO))
				throw new ArgumentNullException("m3_STCO");
			if (string.IsNullOrWhiteSpace(m3_TX20))
				throw new ArgumentNullException("m3_TX20");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");
			if (string.IsNullOrWhiteSpace(m3_TX70))
				throw new ArgumentNullException("m3_TX70");

			// Set mandatory parameters
			request
				.WithQueryParameter("STCO", m3_STCO.Trim())
				.WithQueryParameter("TX20", m3_TX20.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim())
				.WithQueryParameter("TX70", m3_TX70.Trim());

			// Execute the request
			var result = await Execute<GetPResponse>(
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
		/// Name GetR
		/// Description Get Machine and Enging Pricing R-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDL1">Dealer code (Required)</param>
		/// <param name="m3_APRM">Price model (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_SECO">Section code (Required)</param>
		/// <param name="m3_SEQ3">Sequence number (Required)</param>
		/// <param name="m3_SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3_TPCD">Item category (Required)</param>
		/// <param name="m3_SEQ5">Reference sequence number (Required)</param>
		/// <param name="m3_CHDA">Change date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetRResponse></returns>
		/// <exception cref="M3Exception<GetRResponse>"></exception>
		public async Task<M3Response<GetRResponse>> GetR(
			string m3_IDL1, 
			string m3_APRM, 
			DateTime m3_FDAT, 
			string m3_SECO, 
			int m3_SEQ3, 
			int m3_SEQ2, 
			int m3_TPCD, 
			int m3_SEQ5, 
			DateTime m3_CHDA, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetR",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDL1))
				throw new ArgumentNullException("m3_IDL1");
			if (string.IsNullOrWhiteSpace(m3_APRM))
				throw new ArgumentNullException("m3_APRM");
			if (string.IsNullOrWhiteSpace(m3_SECO))
				throw new ArgumentNullException("m3_SECO");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3_IDL1.Trim())
				.WithQueryParameter("APRM", m3_APRM.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("SECO", m3_SECO.Trim())
				.WithQueryParameter("SEQ3", m3_SEQ3.ToString())
				.WithQueryParameter("SEQ2", m3_SEQ2.ToString())
				.WithQueryParameter("TPCD", m3_TPCD.ToString())
				.WithQueryParameter("SEQ5", m3_SEQ5.ToString())
				.WithQueryParameter("CHDA", m3_CHDA.ToM3String());

			// Execute the request
			var result = await Execute<GetRResponse>(
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
		/// Name GetS
		/// Description Get Machine and Enging Pricing S-record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDL1">Dealer code (Required)</param>
		/// <param name="m3_APRM">Price model (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSResponse></returns>
		/// <exception cref="M3Exception<GetSResponse>"></exception>
		public async Task<M3Response<GetSResponse>> GetS(
			string m3_IDL1, 
			string m3_APRM, 
			DateTime m3_FDAT, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetS",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDL1))
				throw new ArgumentNullException("m3_IDL1");
			if (string.IsNullOrWhiteSpace(m3_APRM))
				throw new ArgumentNullException("m3_APRM");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3_IDL1.Trim())
				.WithQueryParameter("APRM", m3_APRM.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String());

			// Execute the request
			var result = await Execute<GetSResponse>(
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
		/// Name GetT
		/// Description Get Machine and Enging Pricing N-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDL1">Dealer code (Required)</param>
		/// <param name="m3_APRM">Price model (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_SECO">Section code (Required)</param>
		/// <param name="m3_SEQ3">Sequence number (Required)</param>
		/// <param name="m3_SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3_TPCD">Item category (Required)</param>
		/// <param name="m3_SEQ5">Reference sequence number (Required)</param>
		/// <param name="m3_TXKY">Text sequence number (Required)</param>
		/// <param name="m3_TXCC">Text control code (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTResponse></returns>
		/// <exception cref="M3Exception<GetTResponse>"></exception>
		public async Task<M3Response<GetTResponse>> GetT(
			string m3_IDL1, 
			string m3_APRM, 
			DateTime m3_FDAT, 
			string m3_SECO, 
			int m3_SEQ3, 
			int m3_SEQ2, 
			int m3_TPCD, 
			int m3_SEQ5, 
			int m3_TXKY, 
			string m3_TXCC, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDL1))
				throw new ArgumentNullException("m3_IDL1");
			if (string.IsNullOrWhiteSpace(m3_APRM))
				throw new ArgumentNullException("m3_APRM");
			if (string.IsNullOrWhiteSpace(m3_SECO))
				throw new ArgumentNullException("m3_SECO");
			if (string.IsNullOrWhiteSpace(m3_TXCC))
				throw new ArgumentNullException("m3_TXCC");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3_IDL1.Trim())
				.WithQueryParameter("APRM", m3_APRM.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("SECO", m3_SECO.Trim())
				.WithQueryParameter("SEQ3", m3_SEQ3.ToString())
				.WithQueryParameter("SEQ2", m3_SEQ2.ToString())
				.WithQueryParameter("TPCD", m3_TPCD.ToString())
				.WithQueryParameter("SEQ5", m3_SEQ5.ToString())
				.WithQueryParameter("TXKY", m3_TXKY.ToString())
				.WithQueryParameter("TXCC", m3_TXCC.Trim());

			// Execute the request
			var result = await Execute<GetTResponse>(
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
		/// Name GetU
		/// Description Get Machine and Enging Pricing U-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDL1">Dealer code (Required)</param>
		/// <param name="m3_APRM">Price model (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_SECO">Section code (Required)</param>
		/// <param name="m3_SEQ3">Sequence number (Required)</param>
		/// <param name="m3_SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3_TPCD">Item category (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetUResponse></returns>
		/// <exception cref="M3Exception<GetUResponse>"></exception>
		public async Task<M3Response<GetUResponse>> GetU(
			string m3_IDL1, 
			string m3_APRM, 
			DateTime m3_FDAT, 
			string m3_SECO, 
			int m3_SEQ3, 
			int m3_SEQ2, 
			int m3_TPCD, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetU",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDL1))
				throw new ArgumentNullException("m3_IDL1");
			if (string.IsNullOrWhiteSpace(m3_APRM))
				throw new ArgumentNullException("m3_APRM");
			if (string.IsNullOrWhiteSpace(m3_SECO))
				throw new ArgumentNullException("m3_SECO");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3_IDL1.Trim())
				.WithQueryParameter("APRM", m3_APRM.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("SECO", m3_SECO.Trim())
				.WithQueryParameter("SEQ3", m3_SEQ3.ToString())
				.WithQueryParameter("SEQ2", m3_SEQ2.ToString())
				.WithQueryParameter("TPCD", m3_TPCD.ToString());

			// Execute the request
			var result = await Execute<GetUResponse>(
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
		/// Name LstN
		/// Description List Machine and Enging Pricing N-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDL1">Dealer code (Required)</param>
		/// <param name="m3_APRM">Price model (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_SECO">Section code</param>
		/// <param name="m3_SEQ3">Sequence number</param>
		/// <param name="m3_SEQ2">Sub sequence number</param>
		/// <param name="m3_TPCD">Item category</param>
		/// <param name="m3_SEQ5">Reference sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstNResponse></returns>
		/// <exception cref="M3Exception<LstNResponse>"></exception>
		public async Task<M3Response<LstNResponse>> LstN(
			string m3_IDL1, 
			string m3_APRM, 
			DateTime m3_FDAT, 
			string m3_SECO = null, 
			int? m3_SEQ3 = null, 
			int? m3_SEQ2 = null, 
			int? m3_TPCD = null, 
			int? m3_SEQ5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstN",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDL1))
				throw new ArgumentNullException("m3_IDL1");
			if (string.IsNullOrWhiteSpace(m3_APRM))
				throw new ArgumentNullException("m3_APRM");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3_IDL1.Trim())
				.WithQueryParameter("APRM", m3_APRM.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SECO))
				request.WithQueryParameter("SECO", m3_SECO.Trim());
			if (m3_SEQ3.HasValue)
				request.WithQueryParameter("SEQ3", m3_SEQ3.Value.ToString());
			if (m3_SEQ2.HasValue)
				request.WithQueryParameter("SEQ2", m3_SEQ2.Value.ToString());
			if (m3_TPCD.HasValue)
				request.WithQueryParameter("TPCD", m3_TPCD.Value.ToString());
			if (m3_SEQ5.HasValue)
				request.WithQueryParameter("SEQ5", m3_SEQ5.Value.ToString());

			// Execute the request
			var result = await Execute<LstNResponse>(
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
		/// Name LstP
		/// Description List Equipment Interface Parameters
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_STCO">Constant value (Required)</param>
		/// <param name="m3_PARM">Parameter value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPResponse></returns>
		/// <exception cref="M3Exception<LstPResponse>"></exception>
		public async Task<M3Response<LstPResponse>> LstP(
			string m3_STCO, 
			string m3_PARM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STCO))
				throw new ArgumentNullException("m3_STCO");

			// Set mandatory parameters
			request
				.WithQueryParameter("STCO", m3_STCO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PARM))
				request.WithQueryParameter("PARM", m3_PARM.Trim());

			// Execute the request
			var result = await Execute<LstPResponse>(
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
		/// Name LstR
		/// Description List Machine and Enging Pricing R-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDL1">Dealer code (Required)</param>
		/// <param name="m3_APRM">Price model (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_SECO">Section code</param>
		/// <param name="m3_SEQ3">Sequence number</param>
		/// <param name="m3_SEQ2">Sub sequence number</param>
		/// <param name="m3_TPCD">Item category</param>
		/// <param name="m3_SEQ5">Reference sequence number</param>
		/// <param name="m3_CHDA">Change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRResponse></returns>
		/// <exception cref="M3Exception<LstRResponse>"></exception>
		public async Task<M3Response<LstRResponse>> LstR(
			string m3_IDL1, 
			string m3_APRM, 
			DateTime m3_FDAT, 
			string m3_SECO = null, 
			int? m3_SEQ3 = null, 
			int? m3_SEQ2 = null, 
			int? m3_TPCD = null, 
			int? m3_SEQ5 = null, 
			DateTime? m3_CHDA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstR",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDL1))
				throw new ArgumentNullException("m3_IDL1");
			if (string.IsNullOrWhiteSpace(m3_APRM))
				throw new ArgumentNullException("m3_APRM");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3_IDL1.Trim())
				.WithQueryParameter("APRM", m3_APRM.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SECO))
				request.WithQueryParameter("SECO", m3_SECO.Trim());
			if (m3_SEQ3.HasValue)
				request.WithQueryParameter("SEQ3", m3_SEQ3.Value.ToString());
			if (m3_SEQ2.HasValue)
				request.WithQueryParameter("SEQ2", m3_SEQ2.Value.ToString());
			if (m3_TPCD.HasValue)
				request.WithQueryParameter("TPCD", m3_TPCD.Value.ToString());
			if (m3_SEQ5.HasValue)
				request.WithQueryParameter("SEQ5", m3_SEQ5.Value.ToString());
			if (m3_CHDA.HasValue)
				request.WithQueryParameter("CHDA", m3_CHDA.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstRResponse>(
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
		/// Name LstS
		/// Description List Machine and Enging Pricing S-record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDL1">Dealer code (Required)</param>
		/// <param name="m3_APRM">Price model</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSResponse></returns>
		/// <exception cref="M3Exception<LstSResponse>"></exception>
		public async Task<M3Response<LstSResponse>> LstS(
			string m3_IDL1, 
			string m3_APRM = null, 
			DateTime? m3_FDAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstS",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDL1))
				throw new ArgumentNullException("m3_IDL1");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3_IDL1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_APRM))
				request.WithQueryParameter("APRM", m3_APRM.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstSResponse>(
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
		/// Name LstSByMSDS
		/// Description List Machine and Enging by Sales Model Seq No
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDL1">Dealer code (Required)</param>
		/// <param name="m3_MSDS">Sequence number</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_APRM">Price model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSByMSDSResponse></returns>
		/// <exception cref="M3Exception<LstSByMSDSResponse>"></exception>
		public async Task<M3Response<LstSByMSDSResponse>> LstSByMSDS(
			string m3_IDL1, 
			int? m3_MSDS = null, 
			DateTime? m3_FDAT = null, 
			string m3_APRM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSByMSDS",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDL1))
				throw new ArgumentNullException("m3_IDL1");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3_IDL1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_MSDS.HasValue)
				request.WithQueryParameter("MSDS", m3_MSDS.Value.ToString());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_APRM))
				request.WithQueryParameter("APRM", m3_APRM.Trim());

			// Execute the request
			var result = await Execute<LstSByMSDSResponse>(
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
		/// Name LstT
		/// Description List Machine and Enging Pricing N-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDL1">Dealer code (Required)</param>
		/// <param name="m3_APRM">Price model (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_SECO">Section code</param>
		/// <param name="m3_SEQ3">Sequence number</param>
		/// <param name="m3_SEQ2">Sub sequence number</param>
		/// <param name="m3_TPCD">Item category</param>
		/// <param name="m3_SEQ5">Reference sequence number</param>
		/// <param name="m3_TXKY">Text sequence number</param>
		/// <param name="m3_TXCC">Text control code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTResponse></returns>
		/// <exception cref="M3Exception<LstTResponse>"></exception>
		public async Task<M3Response<LstTResponse>> LstT(
			string m3_IDL1, 
			string m3_APRM, 
			DateTime m3_FDAT, 
			string m3_SECO = null, 
			int? m3_SEQ3 = null, 
			int? m3_SEQ2 = null, 
			int? m3_TPCD = null, 
			int? m3_SEQ5 = null, 
			int? m3_TXKY = null, 
			string m3_TXCC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDL1))
				throw new ArgumentNullException("m3_IDL1");
			if (string.IsNullOrWhiteSpace(m3_APRM))
				throw new ArgumentNullException("m3_APRM");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3_IDL1.Trim())
				.WithQueryParameter("APRM", m3_APRM.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SECO))
				request.WithQueryParameter("SECO", m3_SECO.Trim());
			if (m3_SEQ3.HasValue)
				request.WithQueryParameter("SEQ3", m3_SEQ3.Value.ToString());
			if (m3_SEQ2.HasValue)
				request.WithQueryParameter("SEQ2", m3_SEQ2.Value.ToString());
			if (m3_TPCD.HasValue)
				request.WithQueryParameter("TPCD", m3_TPCD.Value.ToString());
			if (m3_SEQ5.HasValue)
				request.WithQueryParameter("SEQ5", m3_SEQ5.Value.ToString());
			if (m3_TXKY.HasValue)
				request.WithQueryParameter("TXKY", m3_TXKY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TXCC))
				request.WithQueryParameter("TXCC", m3_TXCC.Trim());

			// Execute the request
			var result = await Execute<LstTResponse>(
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
		/// Name LstU
		/// Description List Machine and Enging Pricing U-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDL1">Dealer code (Required)</param>
		/// <param name="m3_APRM">Price model (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_SECO">Section code</param>
		/// <param name="m3_SEQ3">Sequence number</param>
		/// <param name="m3_SEQ2">Sub sequence number</param>
		/// <param name="m3_TPCD">Item category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstUResponse></returns>
		/// <exception cref="M3Exception<LstUResponse>"></exception>
		public async Task<M3Response<LstUResponse>> LstU(
			string m3_IDL1, 
			string m3_APRM, 
			DateTime m3_FDAT, 
			string m3_SECO = null, 
			int? m3_SEQ3 = null, 
			int? m3_SEQ2 = null, 
			int? m3_TPCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstU",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDL1))
				throw new ArgumentNullException("m3_IDL1");
			if (string.IsNullOrWhiteSpace(m3_APRM))
				throw new ArgumentNullException("m3_APRM");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3_IDL1.Trim())
				.WithQueryParameter("APRM", m3_APRM.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SECO))
				request.WithQueryParameter("SECO", m3_SECO.Trim());
			if (m3_SEQ3.HasValue)
				request.WithQueryParameter("SEQ3", m3_SEQ3.Value.ToString());
			if (m3_SEQ2.HasValue)
				request.WithQueryParameter("SEQ2", m3_SEQ2.Value.ToString());
			if (m3_TPCD.HasValue)
				request.WithQueryParameter("TPCD", m3_TPCD.Value.ToString());

			// Execute the request
			var result = await Execute<LstUResponse>(
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
		/// Name Resequence
		/// Description Resequence Machine and Enging Pricing records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDL1">Dealer code (Required)</param>
		/// <param name="m3_APRM">Price model (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_SECO">Section code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Resequence(
			string m3_IDL1, 
			string m3_APRM, 
			DateTime m3_FDAT, 
			string m3_SECO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Resequence",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDL1))
				throw new ArgumentNullException("m3_IDL1");
			if (string.IsNullOrWhiteSpace(m3_APRM))
				throw new ArgumentNullException("m3_APRM");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3_IDL1.Trim())
				.WithQueryParameter("APRM", m3_APRM.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SECO))
				request.WithQueryParameter("SECO", m3_SECO.Trim());

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
		/// Name UpdateN
		/// Description Update Machine and Enging Pricing N-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDL1">Dealer code (Required)</param>
		/// <param name="m3_APRM">Price model (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_SECO">Section code (Required)</param>
		/// <param name="m3_SEQ3">Sequence number (Required)</param>
		/// <param name="m3_SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3_TPCD">Item category (Required)</param>
		/// <param name="m3_SEQ5">Reference sequence number (Required)</param>
		/// <param name="m3_AVCD">Activity code</param>
		/// <param name="m3_MSDS">Sequence number</param>
		/// <param name="m3_ANSQ">Attribute sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdateN(
			string m3_IDL1, 
			string m3_APRM, 
			DateTime m3_FDAT, 
			string m3_SECO, 
			int m3_SEQ3, 
			int m3_SEQ2, 
			int m3_TPCD, 
			int m3_SEQ5, 
			string m3_AVCD = null, 
			int? m3_MSDS = null, 
			int? m3_ANSQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdateN",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDL1))
				throw new ArgumentNullException("m3_IDL1");
			if (string.IsNullOrWhiteSpace(m3_APRM))
				throw new ArgumentNullException("m3_APRM");
			if (string.IsNullOrWhiteSpace(m3_SECO))
				throw new ArgumentNullException("m3_SECO");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3_IDL1.Trim())
				.WithQueryParameter("APRM", m3_APRM.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("SECO", m3_SECO.Trim())
				.WithQueryParameter("SEQ3", m3_SEQ3.ToString())
				.WithQueryParameter("SEQ2", m3_SEQ2.ToString())
				.WithQueryParameter("TPCD", m3_TPCD.ToString())
				.WithQueryParameter("SEQ5", m3_SEQ5.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_AVCD))
				request.WithQueryParameter("AVCD", m3_AVCD.Trim());
			if (m3_MSDS.HasValue)
				request.WithQueryParameter("MSDS", m3_MSDS.Value.ToString());
			if (m3_ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3_ANSQ.Value.ToString());

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
		/// Name UpdateP
		/// Description Update equipment Interface Parameters
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_STCO">Constant value (Required)</param>
		/// <param name="m3_TX20">Text (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_TX70">Text (Required)</param>
		/// <param name="m3_PARM">Parameter value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdateP(
			string m3_STCO, 
			string m3_TX20, 
			string m3_TX40, 
			string m3_TX70, 
			string m3_PARM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdateP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_STCO))
				throw new ArgumentNullException("m3_STCO");
			if (string.IsNullOrWhiteSpace(m3_TX20))
				throw new ArgumentNullException("m3_TX20");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");
			if (string.IsNullOrWhiteSpace(m3_TX70))
				throw new ArgumentNullException("m3_TX70");

			// Set mandatory parameters
			request
				.WithQueryParameter("STCO", m3_STCO.Trim())
				.WithQueryParameter("TX20", m3_TX20.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim())
				.WithQueryParameter("TX70", m3_TX70.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PARM))
				request.WithQueryParameter("PARM", m3_PARM.Trim());

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
		/// Name UpdateR
		/// Description Update Machine and Enging Pricing R-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDL1">Dealer code (Required)</param>
		/// <param name="m3_APRM">Price model (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_SECO">Section code (Required)</param>
		/// <param name="m3_SEQ3">Sequence number (Required)</param>
		/// <param name="m3_SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3_TPCD">Item category (Required)</param>
		/// <param name="m3_SEQ5">Reference sequence number (Required)</param>
		/// <param name="m3_CHDA">Change date (Required)</param>
		/// <param name="m3_AVCD">Activity code</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BIRS">Date introduced into Movex</param>
		/// <param name="m3_REPI">Replaced item number</param>
		/// <param name="m3_USCO">Use code</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_NEWE">Net weight</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_SAP1">Sales price</param>
		/// <param name="m3_NTCD">Net price used</param>
		/// <param name="m3_DIP1">Discount 1</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_ATCI">Attachment indicator</param>
		/// <param name="m3_IN60">Indicator</param>
		/// <param name="m3_ORPT">Order product type</param>
		/// <param name="m3_IN71">Indicator</param>
		/// <param name="m3_ASLM">Sales model</param>
		/// <param name="m3_MSDS">Sequence number</param>
		/// <param name="m3_ANSQ">Attribute sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdateR(
			string m3_IDL1, 
			string m3_APRM, 
			DateTime m3_FDAT, 
			string m3_SECO, 
			int m3_SEQ3, 
			int m3_SEQ2, 
			int m3_TPCD, 
			int m3_SEQ5, 
			DateTime m3_CHDA, 
			string m3_AVCD = null, 
			string m3_ITNO = null, 
			DateTime? m3_BIRS = null, 
			string m3_REPI = null, 
			string m3_USCO = null, 
			decimal? m3_GRWE = null, 
			decimal? m3_NEWE = null, 
			decimal? m3_SAPR = null, 
			decimal? m3_SAP1 = null, 
			int? m3_NTCD = null, 
			int? m3_DIP1 = null, 
			string m3_ITDS = null, 
			string m3_ATCI = null, 
			string m3_IN60 = null, 
			string m3_ORPT = null, 
			string m3_IN71 = null, 
			string m3_ASLM = null, 
			int? m3_MSDS = null, 
			int? m3_ANSQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdateR",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDL1))
				throw new ArgumentNullException("m3_IDL1");
			if (string.IsNullOrWhiteSpace(m3_APRM))
				throw new ArgumentNullException("m3_APRM");
			if (string.IsNullOrWhiteSpace(m3_SECO))
				throw new ArgumentNullException("m3_SECO");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3_IDL1.Trim())
				.WithQueryParameter("APRM", m3_APRM.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("SECO", m3_SECO.Trim())
				.WithQueryParameter("SEQ3", m3_SEQ3.ToString())
				.WithQueryParameter("SEQ2", m3_SEQ2.ToString())
				.WithQueryParameter("TPCD", m3_TPCD.ToString())
				.WithQueryParameter("SEQ5", m3_SEQ5.ToString())
				.WithQueryParameter("CHDA", m3_CHDA.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_AVCD))
				request.WithQueryParameter("AVCD", m3_AVCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_BIRS.HasValue)
				request.WithQueryParameter("BIRS", m3_BIRS.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_REPI))
				request.WithQueryParameter("REPI", m3_REPI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USCO))
				request.WithQueryParameter("USCO", m3_USCO.Trim());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3_NEWE.Value.ToString());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_SAP1.HasValue)
				request.WithQueryParameter("SAP1", m3_SAP1.Value.ToString());
			if (m3_NTCD.HasValue)
				request.WithQueryParameter("NTCD", m3_NTCD.Value.ToString());
			if (m3_DIP1.HasValue)
				request.WithQueryParameter("DIP1", m3_DIP1.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ATCI))
				request.WithQueryParameter("ATCI", m3_ATCI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IN60))
				request.WithQueryParameter("IN60", m3_IN60.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORPT))
				request.WithQueryParameter("ORPT", m3_ORPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IN71))
				request.WithQueryParameter("IN71", m3_IN71.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ASLM))
				request.WithQueryParameter("ASLM", m3_ASLM.Trim());
			if (m3_MSDS.HasValue)
				request.WithQueryParameter("MSDS", m3_MSDS.Value.ToString());
			if (m3_ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3_ANSQ.Value.ToString());

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
		/// Name UpdateS
		/// Description Update Machine and Enging Pricing S-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDL1">Dealer code (Required)</param>
		/// <param name="m3_APRM">Price model (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_MSDS">Sequence number</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_ITCL">Product group</param>
		/// <param name="m3_SUDT">Supesede date</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_ARAT">Exchange rate</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdateS(
			string m3_IDL1, 
			string m3_APRM, 
			DateTime m3_FDAT, 
			int? m3_MSDS = null, 
			string m3_FACI = null, 
			string m3_ITCL = null, 
			DateTime? m3_SUDT = null, 
			string m3_CUCD = null, 
			decimal? m3_ARAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdateS",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDL1))
				throw new ArgumentNullException("m3_IDL1");
			if (string.IsNullOrWhiteSpace(m3_APRM))
				throw new ArgumentNullException("m3_APRM");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3_IDL1.Trim())
				.WithQueryParameter("APRM", m3_APRM.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_MSDS.HasValue)
				request.WithQueryParameter("MSDS", m3_MSDS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITCL))
				request.WithQueryParameter("ITCL", m3_ITCL.Trim());
			if (m3_SUDT.HasValue)
				request.WithQueryParameter("SUDT", m3_SUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (m3_ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3_ARAT.Value.ToString());

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
		/// Name UpdateT
		/// Description Update Machine and Enging Pricing N-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDL1">Dealer code (Required)</param>
		/// <param name="m3_APRM">Price model (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_SECO">Section code (Required)</param>
		/// <param name="m3_SEQ3">Sequence number (Required)</param>
		/// <param name="m3_SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3_TPCD">Item category (Required)</param>
		/// <param name="m3_SEQ5">Reference sequence number (Required)</param>
		/// <param name="m3_TXKY">Text sequence number (Required)</param>
		/// <param name="m3_TXCC">Text control code (Required)</param>
		/// <param name="m3_AVCD">Activity code</param>
		/// <param name="m3_TX70">Text</param>
		/// <param name="m3_MSDS">Sequence number</param>
		/// <param name="m3_ANSQ">Attribute sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdateT(
			string m3_IDL1, 
			string m3_APRM, 
			DateTime m3_FDAT, 
			string m3_SECO, 
			int m3_SEQ3, 
			int m3_SEQ2, 
			int m3_TPCD, 
			int m3_SEQ5, 
			int m3_TXKY, 
			string m3_TXCC, 
			string m3_AVCD = null, 
			string m3_TX70 = null, 
			int? m3_MSDS = null, 
			int? m3_ANSQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdateT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDL1))
				throw new ArgumentNullException("m3_IDL1");
			if (string.IsNullOrWhiteSpace(m3_APRM))
				throw new ArgumentNullException("m3_APRM");
			if (string.IsNullOrWhiteSpace(m3_SECO))
				throw new ArgumentNullException("m3_SECO");
			if (string.IsNullOrWhiteSpace(m3_TXCC))
				throw new ArgumentNullException("m3_TXCC");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3_IDL1.Trim())
				.WithQueryParameter("APRM", m3_APRM.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("SECO", m3_SECO.Trim())
				.WithQueryParameter("SEQ3", m3_SEQ3.ToString())
				.WithQueryParameter("SEQ2", m3_SEQ2.ToString())
				.WithQueryParameter("TPCD", m3_TPCD.ToString())
				.WithQueryParameter("SEQ5", m3_SEQ5.ToString())
				.WithQueryParameter("TXKY", m3_TXKY.ToString())
				.WithQueryParameter("TXCC", m3_TXCC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_AVCD))
				request.WithQueryParameter("AVCD", m3_AVCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX70))
				request.WithQueryParameter("TX70", m3_TX70.Trim());
			if (m3_MSDS.HasValue)
				request.WithQueryParameter("MSDS", m3_MSDS.Value.ToString());
			if (m3_ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3_ANSQ.Value.ToString());

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
		/// Name UpdateU
		/// Description Update Machine and Enging Pricing U-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_IDL1">Dealer code (Required)</param>
		/// <param name="m3_APRM">Price model (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_SECO">Section code (Required)</param>
		/// <param name="m3_SEQ3">Sequence number (Required)</param>
		/// <param name="m3_SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3_TPCD">Item category (Required)</param>
		/// <param name="m3_AVCD">Activity code</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX70">Text</param>
		/// <param name="m3_MSDS">Sequence number</param>
		/// <param name="m3_ANSQ">Attribute sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdateU(
			string m3_IDL1, 
			string m3_APRM, 
			DateTime m3_FDAT, 
			string m3_SECO, 
			int m3_SEQ3, 
			int m3_SEQ2, 
			int m3_TPCD, 
			string m3_AVCD = null, 
			string m3_TX40 = null, 
			string m3_TX70 = null, 
			int? m3_MSDS = null, 
			int? m3_ANSQ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdateU",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IDL1))
				throw new ArgumentNullException("m3_IDL1");
			if (string.IsNullOrWhiteSpace(m3_APRM))
				throw new ArgumentNullException("m3_APRM");
			if (string.IsNullOrWhiteSpace(m3_SECO))
				throw new ArgumentNullException("m3_SECO");

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3_IDL1.Trim())
				.WithQueryParameter("APRM", m3_APRM.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String())
				.WithQueryParameter("SECO", m3_SECO.Trim())
				.WithQueryParameter("SEQ3", m3_SEQ3.ToString())
				.WithQueryParameter("SEQ2", m3_SEQ2.ToString())
				.WithQueryParameter("TPCD", m3_TPCD.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_AVCD))
				request.WithQueryParameter("AVCD", m3_AVCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX70))
				request.WithQueryParameter("TX70", m3_TX70.Trim());
			if (m3_MSDS.HasValue)
				request.WithQueryParameter("MSDS", m3_MSDS.Value.ToString());
			if (m3_ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3_ANSQ.Value.ToString());

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
