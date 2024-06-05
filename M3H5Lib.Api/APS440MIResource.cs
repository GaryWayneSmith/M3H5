/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.APS440MI;
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
	/// Name: APS440MI
	/// Component Name: SupplierStatement
	/// Description: Supplier Statement
	/// Version Release: 14.x
	///</summary>
	public partial class APS440MIResource : M3BaseResourceEndpoint
	{
		public APS440MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "APS440MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddStmntHead
		/// Description Add Statement Head
		/// Version Release: 
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_SSRO">Supplier statement Round (Required)</param>
		/// <param name="m3_SSTY">Supplier statement Type (Required)</param>
		/// <param name="m3_SSTD">Supplier statement Date</param>
		/// <param name="m3_SSTO">Supplier statement Total</param>
		/// <param name="m3_STTD">Supplier statement to due date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddStmntHeadResponse></returns>
		/// <exception cref="M3Exception<AddStmntHeadResponse>"></exception>
		public async Task<M3Response<AddStmntHeadResponse>> AddStmntHead(
			string m3_DIVI, 
			string m3_SSRO, 
			int m3_SSTY, 
			int? m3_SSTD = null, 
			string m3_SSTO = null, 
			DateTime? m3_STTD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddStmntHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_SSRO))
				throw new ArgumentNullException("m3_SSRO");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("SSRO", m3_SSRO.Trim())
				.WithQueryParameter("SSTY", m3_SSTY.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_SSTD.HasValue)
				request.WithQueryParameter("SSTD", m3_SSTD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SSTO))
				request.WithQueryParameter("SSTO", m3_SSTO.Trim());
			if (m3_STTD.HasValue)
				request.WithQueryParameter("STTD", m3_STTD.Value.ToM3String());

			// Execute the request
			var result = await Execute<AddStmntHeadResponse>(
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
		/// Name AddStmntLine
		/// Description Add Statement Line
		/// Version Release: 
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BJNO">Job number (Required)</param>
		/// <param name="m3_SSLI">Supplier statement Line (Required)</param>
		/// <param name="m3_SSPA">Supplier statement Payee (Required)</param>
		/// <param name="m3_SSIY">Supplier statement Invoice year (Required)</param>
		/// <param name="m3_SSIN">Supplier statement Invoice number (Required)</param>
		/// <param name="m3_SSIC">Supplier statement Invoice currency (Required)</param>
		/// <param name="m3_SSIV">Supplier statement Invoice amount (Required)</param>
		/// <param name="m3_SSID">Supplier statement Invoice date (Required)</param>
		/// <param name="m3_SSIB">Supplier statement due date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddStmntLineResponse></returns>
		/// <exception cref="M3Exception<AddStmntLineResponse>"></exception>
		public async Task<M3Response<AddStmntLineResponse>> AddStmntLine(
			string m3_DIVI, 
			string m3_BJNO, 
			int m3_SSLI, 
			string m3_SSPA, 
			int m3_SSIY, 
			string m3_SSIN, 
			string m3_SSIC, 
			decimal m3_SSIV, 
			int m3_SSID, 
			DateTime? m3_SSIB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddStmntLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BJNO))
				throw new ArgumentNullException("m3_BJNO");
			if (string.IsNullOrWhiteSpace(m3_SSPA))
				throw new ArgumentNullException("m3_SSPA");
			if (string.IsNullOrWhiteSpace(m3_SSIN))
				throw new ArgumentNullException("m3_SSIN");
			if (string.IsNullOrWhiteSpace(m3_SSIC))
				throw new ArgumentNullException("m3_SSIC");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BJNO", m3_BJNO.Trim())
				.WithQueryParameter("SSLI", m3_SSLI.ToString())
				.WithQueryParameter("SSPA", m3_SSPA.Trim())
				.WithQueryParameter("SSIY", m3_SSIY.ToString())
				.WithQueryParameter("SSIN", m3_SSIN.Trim())
				.WithQueryParameter("SSIC", m3_SSIC.Trim())
				.WithQueryParameter("SSIV", m3_SSIV.ToString())
				.WithQueryParameter("SSID", m3_SSID.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_SSIB.HasValue)
				request.WithQueryParameter("SSIB", m3_SSIB.Value.ToM3String());

			// Execute the request
			var result = await Execute<AddStmntLineResponse>(
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
		/// Name AddStmntPayee
		/// Description Add Statement Payee
		/// Version Release: 
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_BJNO">Job number (Required)</param>
		/// <param name="m3_SSPA">Supplier statement Payee (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddStmntPayee(
			string m3_DIVI, 
			string m3_BJNO, 
			string m3_SSPA, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddStmntPayee",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_BJNO))
				throw new ArgumentNullException("m3_BJNO");
			if (string.IsNullOrWhiteSpace(m3_SSPA))
				throw new ArgumentNullException("m3_SSPA");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("BJNO", m3_BJNO.Trim())
				.WithQueryParameter("SSPA", m3_SSPA.Trim());

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
