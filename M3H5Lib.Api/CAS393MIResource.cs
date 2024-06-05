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
	/// Name: CAS393MI
	/// Component Name: Analytic accounting Balance
	/// Description: Api: Analytic accounting Balance
	/// Version Release: 13.1
	///</summary>
	public partial class CAS393MIResource : M3BaseResourceEndpoint
	{
		public CAS393MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CAS393MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAccBalance
		/// Description Add Analytic Accounting Balance record
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_MOID">Model ID (Required)</param>
		/// <param name="m3_MOLN">Model Line (Required)</param>
		/// <param name="m3_COV1">Column value 1 (Required)</param>
		/// <param name="m3_COV2">Column value 2 (Required)</param>
		/// <param name="m3_COV3">Column value 3 (Required)</param>
		/// <param name="m3_COV4">Column value 4 (Required)</param>
		/// <param name="m3_COV5">Column value 5 (Required)</param>
		/// <param name="m3_COV6">Column value 6 (Required)</param>
		/// <param name="m3_COV7">Column value 7 (Required)</param>
		/// <param name="m3_COV8">Column value 8 (Required)</param>
		/// <param name="m3_COV9">Column value 9 (Required)</param>
		/// <param name="m3_CO10">Column value 10 (Required)</param>
		/// <param name="m3_ACYP">Accounting period (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ACAM">Recorded amount</param>
		/// <param name="m3_BUAM">Budget amount</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_CURC">Actual amt</param>
		/// <param name="m3_BURC">Budget amt reporting currency</param>
		/// <param name="m3_ACQT">Accounted quantity</param>
		/// <param name="m3_BUQT">Budget quantity</param>
		/// <param name="m3_CONR">Connection no</param>
		/// <param name="m3_EVEN">Accounting event</param>
		/// <param name="m3_NHBI">Next origin ID</param>
		/// <param name="m3_ADSR">Additional record</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAccBalance(
			string m3_DIVI, 
			string m3_MOID, 
			int m3_MOLN, 
			string m3_COV1, 
			string m3_COV2, 
			string m3_COV3, 
			string m3_COV4, 
			string m3_COV5, 
			string m3_COV6, 
			string m3_COV7, 
			string m3_COV8, 
			string m3_COV9, 
			string m3_CO10, 
			int m3_ACYP, 
			int? m3_CONO = null, 
			decimal? m3_ACAM = null, 
			decimal? m3_BUAM = null, 
			decimal? m3_TXID = null, 
			decimal? m3_CURC = null, 
			decimal? m3_BURC = null, 
			decimal? m3_ACQT = null, 
			decimal? m3_BUQT = null, 
			int? m3_CONR = null, 
			string m3_EVEN = null, 
			long? m3_NHBI = null, 
			int? m3_ADSR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAccBalance",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_MOID))
				throw new ArgumentNullException("m3_MOID");
			if (string.IsNullOrWhiteSpace(m3_COV1))
				throw new ArgumentNullException("m3_COV1");
			if (string.IsNullOrWhiteSpace(m3_COV2))
				throw new ArgumentNullException("m3_COV2");
			if (string.IsNullOrWhiteSpace(m3_COV3))
				throw new ArgumentNullException("m3_COV3");
			if (string.IsNullOrWhiteSpace(m3_COV4))
				throw new ArgumentNullException("m3_COV4");
			if (string.IsNullOrWhiteSpace(m3_COV5))
				throw new ArgumentNullException("m3_COV5");
			if (string.IsNullOrWhiteSpace(m3_COV6))
				throw new ArgumentNullException("m3_COV6");
			if (string.IsNullOrWhiteSpace(m3_COV7))
				throw new ArgumentNullException("m3_COV7");
			if (string.IsNullOrWhiteSpace(m3_COV8))
				throw new ArgumentNullException("m3_COV8");
			if (string.IsNullOrWhiteSpace(m3_COV9))
				throw new ArgumentNullException("m3_COV9");
			if (string.IsNullOrWhiteSpace(m3_CO10))
				throw new ArgumentNullException("m3_CO10");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("MOID", m3_MOID.Trim())
				.WithQueryParameter("MOLN", m3_MOLN.ToString())
				.WithQueryParameter("COV1", m3_COV1.Trim())
				.WithQueryParameter("COV2", m3_COV2.Trim())
				.WithQueryParameter("COV3", m3_COV3.Trim())
				.WithQueryParameter("COV4", m3_COV4.Trim())
				.WithQueryParameter("COV5", m3_COV5.Trim())
				.WithQueryParameter("COV6", m3_COV6.Trim())
				.WithQueryParameter("COV7", m3_COV7.Trim())
				.WithQueryParameter("COV8", m3_COV8.Trim())
				.WithQueryParameter("COV9", m3_COV9.Trim())
				.WithQueryParameter("CO10", m3_CO10.Trim())
				.WithQueryParameter("ACYP", m3_ACYP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_ACAM.HasValue)
				request.WithQueryParameter("ACAM", m3_ACAM.Value.ToString());
			if (m3_BUAM.HasValue)
				request.WithQueryParameter("BUAM", m3_BUAM.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_CURC.HasValue)
				request.WithQueryParameter("CURC", m3_CURC.Value.ToString());
			if (m3_BURC.HasValue)
				request.WithQueryParameter("BURC", m3_BURC.Value.ToString());
			if (m3_ACQT.HasValue)
				request.WithQueryParameter("ACQT", m3_ACQT.Value.ToString());
			if (m3_BUQT.HasValue)
				request.WithQueryParameter("BUQT", m3_BUQT.Value.ToString());
			if (m3_CONR.HasValue)
				request.WithQueryParameter("CONR", m3_CONR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EVEN))
				request.WithQueryParameter("EVEN", m3_EVEN.Trim());
			if (m3_NHBI.HasValue)
				request.WithQueryParameter("NHBI", m3_NHBI.Value.ToString());
			if (m3_ADSR.HasValue)
				request.WithQueryParameter("ADSR", m3_ADSR.Value.ToString());

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
		/// Name DelActValues
		/// Description Delete Actual Values
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_MOID">Model ID (Required)</param>
		/// <param name="m3_MOLN">Model Line (Required)</param>
		/// <param name="m3_COV1">Column value 1 (Required)</param>
		/// <param name="m3_COV2">Column value 2 (Required)</param>
		/// <param name="m3_COV3">Column value 3 (Required)</param>
		/// <param name="m3_COV4">Column value 4 (Required)</param>
		/// <param name="m3_COV5">Column value 5 (Required)</param>
		/// <param name="m3_COV6">Column value 6 (Required)</param>
		/// <param name="m3_COV7">Column value 7 (Required)</param>
		/// <param name="m3_COV8">Column value 8 (Required)</param>
		/// <param name="m3_COV9">Column value 9 (Required)</param>
		/// <param name="m3_CO10">Column value 10 (Required)</param>
		/// <param name="m3_ACYP">Accounting period (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ACAM">Recorded amount</param>
		/// <param name="m3_BUAM">Budget amount</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_CURC">Actual amt</param>
		/// <param name="m3_CO11">Column value 11</param>
		/// <param name="m3_CO12">Column value 12</param>
		/// <param name="m3_CO13">Column value 13</param>
		/// <param name="m3_CO14">Column value 14</param>
		/// <param name="m3_CO15">Column value 15</param>
		/// <param name="m3_BURC">Budget amt reporting currency</param>
		/// <param name="m3_ACQT">Accounted quantity</param>
		/// <param name="m3_BUQT">Budget quantity</param>
		/// <param name="m3_CONR">Connection no</param>
		/// <param name="m3_EVEN">Accounting event</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelActValues(
			string m3_DIVI, 
			string m3_MOID, 
			int m3_MOLN, 
			string m3_COV1, 
			string m3_COV2, 
			string m3_COV3, 
			string m3_COV4, 
			string m3_COV5, 
			string m3_COV6, 
			string m3_COV7, 
			string m3_COV8, 
			string m3_COV9, 
			string m3_CO10, 
			int m3_ACYP, 
			int? m3_CONO = null, 
			decimal? m3_ACAM = null, 
			decimal? m3_BUAM = null, 
			decimal? m3_TXID = null, 
			decimal? m3_CURC = null, 
			string m3_CO11 = null, 
			string m3_CO12 = null, 
			string m3_CO13 = null, 
			string m3_CO14 = null, 
			string m3_CO15 = null, 
			decimal? m3_BURC = null, 
			decimal? m3_ACQT = null, 
			decimal? m3_BUQT = null, 
			int? m3_CONR = null, 
			string m3_EVEN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelActValues",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_MOID))
				throw new ArgumentNullException("m3_MOID");
			if (string.IsNullOrWhiteSpace(m3_COV1))
				throw new ArgumentNullException("m3_COV1");
			if (string.IsNullOrWhiteSpace(m3_COV2))
				throw new ArgumentNullException("m3_COV2");
			if (string.IsNullOrWhiteSpace(m3_COV3))
				throw new ArgumentNullException("m3_COV3");
			if (string.IsNullOrWhiteSpace(m3_COV4))
				throw new ArgumentNullException("m3_COV4");
			if (string.IsNullOrWhiteSpace(m3_COV5))
				throw new ArgumentNullException("m3_COV5");
			if (string.IsNullOrWhiteSpace(m3_COV6))
				throw new ArgumentNullException("m3_COV6");
			if (string.IsNullOrWhiteSpace(m3_COV7))
				throw new ArgumentNullException("m3_COV7");
			if (string.IsNullOrWhiteSpace(m3_COV8))
				throw new ArgumentNullException("m3_COV8");
			if (string.IsNullOrWhiteSpace(m3_COV9))
				throw new ArgumentNullException("m3_COV9");
			if (string.IsNullOrWhiteSpace(m3_CO10))
				throw new ArgumentNullException("m3_CO10");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("MOID", m3_MOID.Trim())
				.WithQueryParameter("MOLN", m3_MOLN.ToString())
				.WithQueryParameter("COV1", m3_COV1.Trim())
				.WithQueryParameter("COV2", m3_COV2.Trim())
				.WithQueryParameter("COV3", m3_COV3.Trim())
				.WithQueryParameter("COV4", m3_COV4.Trim())
				.WithQueryParameter("COV5", m3_COV5.Trim())
				.WithQueryParameter("COV6", m3_COV6.Trim())
				.WithQueryParameter("COV7", m3_COV7.Trim())
				.WithQueryParameter("COV8", m3_COV8.Trim())
				.WithQueryParameter("COV9", m3_COV9.Trim())
				.WithQueryParameter("CO10", m3_CO10.Trim())
				.WithQueryParameter("ACYP", m3_ACYP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_ACAM.HasValue)
				request.WithQueryParameter("ACAM", m3_ACAM.Value.ToString());
			if (m3_BUAM.HasValue)
				request.WithQueryParameter("BUAM", m3_BUAM.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_CURC.HasValue)
				request.WithQueryParameter("CURC", m3_CURC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CO11))
				request.WithQueryParameter("CO11", m3_CO11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CO12))
				request.WithQueryParameter("CO12", m3_CO12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CO13))
				request.WithQueryParameter("CO13", m3_CO13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CO14))
				request.WithQueryParameter("CO14", m3_CO14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CO15))
				request.WithQueryParameter("CO15", m3_CO15.Trim());
			if (m3_BURC.HasValue)
				request.WithQueryParameter("BURC", m3_BURC.Value.ToString());
			if (m3_ACQT.HasValue)
				request.WithQueryParameter("ACQT", m3_ACQT.Value.ToString());
			if (m3_BUQT.HasValue)
				request.WithQueryParameter("BUQT", m3_BUQT.Value.ToString());
			if (m3_CONR.HasValue)
				request.WithQueryParameter("CONR", m3_CONR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EVEN))
				request.WithQueryParameter("EVEN", m3_EVEN.Trim());

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
		/// Name DelBudgValues
		/// Description Delete Analytic Accounting Balance Values
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_DIVI">Division (Required)</param>
		/// <param name="m3_MOID">Model ID (Required)</param>
		/// <param name="m3_MOLN">Model Line (Required)</param>
		/// <param name="m3_COV1">Column value 1 (Required)</param>
		/// <param name="m3_COV2">Column value 2 (Required)</param>
		/// <param name="m3_COV3">Column value 3 (Required)</param>
		/// <param name="m3_COV4">Column value 4 (Required)</param>
		/// <param name="m3_COV5">Column value 5 (Required)</param>
		/// <param name="m3_COV6">Column value 6 (Required)</param>
		/// <param name="m3_COV7">Column value 7 (Required)</param>
		/// <param name="m3_COV8">Column value 8 (Required)</param>
		/// <param name="m3_COV9">Column value 9 (Required)</param>
		/// <param name="m3_CO10">Column value 10 (Required)</param>
		/// <param name="m3_ACYP">Accounting period (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ACAM">Recorded amount</param>
		/// <param name="m3_BUAM">Budget amount</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_CURC">Actual amt</param>
		/// <param name="m3_CO11">Column value 11</param>
		/// <param name="m3_CO12">Column value 12</param>
		/// <param name="m3_CO13">Column value 13</param>
		/// <param name="m3_CO14">Column value 14</param>
		/// <param name="m3_CO15">Column value 15</param>
		/// <param name="m3_BURC">Budget amt reporting currency</param>
		/// <param name="m3_ACQT">Accounted quantity</param>
		/// <param name="m3_BUQT">Budget quantity</param>
		/// <param name="m3_CONR">Connection no</param>
		/// <param name="m3_EVEN">Accounting event</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelBudgValues(
			string m3_DIVI, 
			string m3_MOID, 
			int m3_MOLN, 
			string m3_COV1, 
			string m3_COV2, 
			string m3_COV3, 
			string m3_COV4, 
			string m3_COV5, 
			string m3_COV6, 
			string m3_COV7, 
			string m3_COV8, 
			string m3_COV9, 
			string m3_CO10, 
			int m3_ACYP, 
			int? m3_CONO = null, 
			decimal? m3_ACAM = null, 
			decimal? m3_BUAM = null, 
			decimal? m3_TXID = null, 
			decimal? m3_CURC = null, 
			string m3_CO11 = null, 
			string m3_CO12 = null, 
			string m3_CO13 = null, 
			string m3_CO14 = null, 
			string m3_CO15 = null, 
			decimal? m3_BURC = null, 
			decimal? m3_ACQT = null, 
			decimal? m3_BUQT = null, 
			int? m3_CONR = null, 
			string m3_EVEN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelBudgValues",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_DIVI))
				throw new ArgumentNullException("m3_DIVI");
			if (string.IsNullOrWhiteSpace(m3_MOID))
				throw new ArgumentNullException("m3_MOID");
			if (string.IsNullOrWhiteSpace(m3_COV1))
				throw new ArgumentNullException("m3_COV1");
			if (string.IsNullOrWhiteSpace(m3_COV2))
				throw new ArgumentNullException("m3_COV2");
			if (string.IsNullOrWhiteSpace(m3_COV3))
				throw new ArgumentNullException("m3_COV3");
			if (string.IsNullOrWhiteSpace(m3_COV4))
				throw new ArgumentNullException("m3_COV4");
			if (string.IsNullOrWhiteSpace(m3_COV5))
				throw new ArgumentNullException("m3_COV5");
			if (string.IsNullOrWhiteSpace(m3_COV6))
				throw new ArgumentNullException("m3_COV6");
			if (string.IsNullOrWhiteSpace(m3_COV7))
				throw new ArgumentNullException("m3_COV7");
			if (string.IsNullOrWhiteSpace(m3_COV8))
				throw new ArgumentNullException("m3_COV8");
			if (string.IsNullOrWhiteSpace(m3_COV9))
				throw new ArgumentNullException("m3_COV9");
			if (string.IsNullOrWhiteSpace(m3_CO10))
				throw new ArgumentNullException("m3_CO10");

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3_DIVI.Trim())
				.WithQueryParameter("MOID", m3_MOID.Trim())
				.WithQueryParameter("MOLN", m3_MOLN.ToString())
				.WithQueryParameter("COV1", m3_COV1.Trim())
				.WithQueryParameter("COV2", m3_COV2.Trim())
				.WithQueryParameter("COV3", m3_COV3.Trim())
				.WithQueryParameter("COV4", m3_COV4.Trim())
				.WithQueryParameter("COV5", m3_COV5.Trim())
				.WithQueryParameter("COV6", m3_COV6.Trim())
				.WithQueryParameter("COV7", m3_COV7.Trim())
				.WithQueryParameter("COV8", m3_COV8.Trim())
				.WithQueryParameter("COV9", m3_COV9.Trim())
				.WithQueryParameter("CO10", m3_CO10.Trim())
				.WithQueryParameter("ACYP", m3_ACYP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_ACAM.HasValue)
				request.WithQueryParameter("ACAM", m3_ACAM.Value.ToString());
			if (m3_BUAM.HasValue)
				request.WithQueryParameter("BUAM", m3_BUAM.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_CURC.HasValue)
				request.WithQueryParameter("CURC", m3_CURC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CO11))
				request.WithQueryParameter("CO11", m3_CO11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CO12))
				request.WithQueryParameter("CO12", m3_CO12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CO13))
				request.WithQueryParameter("CO13", m3_CO13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CO14))
				request.WithQueryParameter("CO14", m3_CO14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CO15))
				request.WithQueryParameter("CO15", m3_CO15.Trim());
			if (m3_BURC.HasValue)
				request.WithQueryParameter("BURC", m3_BURC.Value.ToString());
			if (m3_ACQT.HasValue)
				request.WithQueryParameter("ACQT", m3_ACQT.Value.ToString());
			if (m3_BUQT.HasValue)
				request.WithQueryParameter("BUQT", m3_BUQT.Value.ToString());
			if (m3_CONR.HasValue)
				request.WithQueryParameter("CONR", m3_CONR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EVEN))
				request.WithQueryParameter("EVEN", m3_EVEN.Trim());

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
