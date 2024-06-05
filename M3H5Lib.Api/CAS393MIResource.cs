/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAccBalance
		/// Description Add Analytic Accounting Balance record
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3MOID">Model ID (Required)</param>
		/// <param name="m3MOLN">Model Line (Required)</param>
		/// <param name="m3COV1">Column value 1 (Required)</param>
		/// <param name="m3COV2">Column value 2 (Required)</param>
		/// <param name="m3COV3">Column value 3 (Required)</param>
		/// <param name="m3COV4">Column value 4 (Required)</param>
		/// <param name="m3COV5">Column value 5 (Required)</param>
		/// <param name="m3COV6">Column value 6 (Required)</param>
		/// <param name="m3COV7">Column value 7 (Required)</param>
		/// <param name="m3COV8">Column value 8 (Required)</param>
		/// <param name="m3COV9">Column value 9 (Required)</param>
		/// <param name="m3CO10">Column value 10 (Required)</param>
		/// <param name="m3ACYP">Accounting period (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ACAM">Recorded amount</param>
		/// <param name="m3BUAM">Budget amount</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3CURC">Actual amt</param>
		/// <param name="m3BURC">Budget amt reporting currency</param>
		/// <param name="m3ACQT">Accounted quantity</param>
		/// <param name="m3BUQT">Budget quantity</param>
		/// <param name="m3CONR">Connection no</param>
		/// <param name="m3EVEN">Accounting event</param>
		/// <param name="m3NHBI">Next origin ID</param>
		/// <param name="m3ADSR">Additional record</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAccBalance(
			string m3DIVI, 
			string m3MOID, 
			int m3MOLN, 
			string m3COV1, 
			string m3COV2, 
			string m3COV3, 
			string m3COV4, 
			string m3COV5, 
			string m3COV6, 
			string m3COV7, 
			string m3COV8, 
			string m3COV9, 
			string m3CO10, 
			int m3ACYP, 
			int? m3CONO = null, 
			decimal? m3ACAM = null, 
			decimal? m3BUAM = null, 
			decimal? m3TXID = null, 
			decimal? m3CURC = null, 
			decimal? m3BURC = null, 
			decimal? m3ACQT = null, 
			decimal? m3BUQT = null, 
			int? m3CONR = null, 
			string m3EVEN = null, 
			long? m3NHBI = null, 
			int? m3ADSR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddAccBalance",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3MOID))
				throw new ArgumentNullException(nameof(m3MOID));
			if (string.IsNullOrWhiteSpace(m3COV1))
				throw new ArgumentNullException(nameof(m3COV1));
			if (string.IsNullOrWhiteSpace(m3COV2))
				throw new ArgumentNullException(nameof(m3COV2));
			if (string.IsNullOrWhiteSpace(m3COV3))
				throw new ArgumentNullException(nameof(m3COV3));
			if (string.IsNullOrWhiteSpace(m3COV4))
				throw new ArgumentNullException(nameof(m3COV4));
			if (string.IsNullOrWhiteSpace(m3COV5))
				throw new ArgumentNullException(nameof(m3COV5));
			if (string.IsNullOrWhiteSpace(m3COV6))
				throw new ArgumentNullException(nameof(m3COV6));
			if (string.IsNullOrWhiteSpace(m3COV7))
				throw new ArgumentNullException(nameof(m3COV7));
			if (string.IsNullOrWhiteSpace(m3COV8))
				throw new ArgumentNullException(nameof(m3COV8));
			if (string.IsNullOrWhiteSpace(m3COV9))
				throw new ArgumentNullException(nameof(m3COV9));
			if (string.IsNullOrWhiteSpace(m3CO10))
				throw new ArgumentNullException(nameof(m3CO10));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("MOID", m3MOID.Trim())
				.WithQueryParameter("MOLN", m3MOLN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("COV1", m3COV1.Trim())
				.WithQueryParameter("COV2", m3COV2.Trim())
				.WithQueryParameter("COV3", m3COV3.Trim())
				.WithQueryParameter("COV4", m3COV4.Trim())
				.WithQueryParameter("COV5", m3COV5.Trim())
				.WithQueryParameter("COV6", m3COV6.Trim())
				.WithQueryParameter("COV7", m3COV7.Trim())
				.WithQueryParameter("COV8", m3COV8.Trim())
				.WithQueryParameter("COV9", m3COV9.Trim())
				.WithQueryParameter("CO10", m3CO10.Trim())
				.WithQueryParameter("ACYP", m3ACYP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACAM.HasValue)
				request.WithQueryParameter("ACAM", m3ACAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUAM.HasValue)
				request.WithQueryParameter("BUAM", m3BUAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CURC.HasValue)
				request.WithQueryParameter("CURC", m3CURC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BURC.HasValue)
				request.WithQueryParameter("BURC", m3BURC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACQT.HasValue)
				request.WithQueryParameter("ACQT", m3ACQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUQT.HasValue)
				request.WithQueryParameter("BUQT", m3BUQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CONR.HasValue)
				request.WithQueryParameter("CONR", m3CONR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EVEN))
				request.WithQueryParameter("EVEN", m3EVEN.Trim());
			if (m3NHBI.HasValue)
				request.WithQueryParameter("NHBI", m3NHBI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADSR.HasValue)
				request.WithQueryParameter("ADSR", m3ADSR.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelActValues
		/// Description Delete Actual Values
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3MOID">Model ID (Required)</param>
		/// <param name="m3MOLN">Model Line (Required)</param>
		/// <param name="m3COV1">Column value 1 (Required)</param>
		/// <param name="m3COV2">Column value 2 (Required)</param>
		/// <param name="m3COV3">Column value 3 (Required)</param>
		/// <param name="m3COV4">Column value 4 (Required)</param>
		/// <param name="m3COV5">Column value 5 (Required)</param>
		/// <param name="m3COV6">Column value 6 (Required)</param>
		/// <param name="m3COV7">Column value 7 (Required)</param>
		/// <param name="m3COV8">Column value 8 (Required)</param>
		/// <param name="m3COV9">Column value 9 (Required)</param>
		/// <param name="m3CO10">Column value 10 (Required)</param>
		/// <param name="m3ACYP">Accounting period (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ACAM">Recorded amount</param>
		/// <param name="m3BUAM">Budget amount</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3CURC">Actual amt</param>
		/// <param name="m3CO11">Column value 11</param>
		/// <param name="m3CO12">Column value 12</param>
		/// <param name="m3CO13">Column value 13</param>
		/// <param name="m3CO14">Column value 14</param>
		/// <param name="m3CO15">Column value 15</param>
		/// <param name="m3BURC">Budget amt reporting currency</param>
		/// <param name="m3ACQT">Accounted quantity</param>
		/// <param name="m3BUQT">Budget quantity</param>
		/// <param name="m3CONR">Connection no</param>
		/// <param name="m3EVEN">Accounting event</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelActValues(
			string m3DIVI, 
			string m3MOID, 
			int m3MOLN, 
			string m3COV1, 
			string m3COV2, 
			string m3COV3, 
			string m3COV4, 
			string m3COV5, 
			string m3COV6, 
			string m3COV7, 
			string m3COV8, 
			string m3COV9, 
			string m3CO10, 
			int m3ACYP, 
			int? m3CONO = null, 
			decimal? m3ACAM = null, 
			decimal? m3BUAM = null, 
			decimal? m3TXID = null, 
			decimal? m3CURC = null, 
			string m3CO11 = null, 
			string m3CO12 = null, 
			string m3CO13 = null, 
			string m3CO14 = null, 
			string m3CO15 = null, 
			decimal? m3BURC = null, 
			decimal? m3ACQT = null, 
			decimal? m3BUQT = null, 
			int? m3CONR = null, 
			string m3EVEN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelActValues",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3MOID))
				throw new ArgumentNullException(nameof(m3MOID));
			if (string.IsNullOrWhiteSpace(m3COV1))
				throw new ArgumentNullException(nameof(m3COV1));
			if (string.IsNullOrWhiteSpace(m3COV2))
				throw new ArgumentNullException(nameof(m3COV2));
			if (string.IsNullOrWhiteSpace(m3COV3))
				throw new ArgumentNullException(nameof(m3COV3));
			if (string.IsNullOrWhiteSpace(m3COV4))
				throw new ArgumentNullException(nameof(m3COV4));
			if (string.IsNullOrWhiteSpace(m3COV5))
				throw new ArgumentNullException(nameof(m3COV5));
			if (string.IsNullOrWhiteSpace(m3COV6))
				throw new ArgumentNullException(nameof(m3COV6));
			if (string.IsNullOrWhiteSpace(m3COV7))
				throw new ArgumentNullException(nameof(m3COV7));
			if (string.IsNullOrWhiteSpace(m3COV8))
				throw new ArgumentNullException(nameof(m3COV8));
			if (string.IsNullOrWhiteSpace(m3COV9))
				throw new ArgumentNullException(nameof(m3COV9));
			if (string.IsNullOrWhiteSpace(m3CO10))
				throw new ArgumentNullException(nameof(m3CO10));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("MOID", m3MOID.Trim())
				.WithQueryParameter("MOLN", m3MOLN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("COV1", m3COV1.Trim())
				.WithQueryParameter("COV2", m3COV2.Trim())
				.WithQueryParameter("COV3", m3COV3.Trim())
				.WithQueryParameter("COV4", m3COV4.Trim())
				.WithQueryParameter("COV5", m3COV5.Trim())
				.WithQueryParameter("COV6", m3COV6.Trim())
				.WithQueryParameter("COV7", m3COV7.Trim())
				.WithQueryParameter("COV8", m3COV8.Trim())
				.WithQueryParameter("COV9", m3COV9.Trim())
				.WithQueryParameter("CO10", m3CO10.Trim())
				.WithQueryParameter("ACYP", m3ACYP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACAM.HasValue)
				request.WithQueryParameter("ACAM", m3ACAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUAM.HasValue)
				request.WithQueryParameter("BUAM", m3BUAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CURC.HasValue)
				request.WithQueryParameter("CURC", m3CURC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CO11))
				request.WithQueryParameter("CO11", m3CO11.Trim());
			if (!string.IsNullOrWhiteSpace(m3CO12))
				request.WithQueryParameter("CO12", m3CO12.Trim());
			if (!string.IsNullOrWhiteSpace(m3CO13))
				request.WithQueryParameter("CO13", m3CO13.Trim());
			if (!string.IsNullOrWhiteSpace(m3CO14))
				request.WithQueryParameter("CO14", m3CO14.Trim());
			if (!string.IsNullOrWhiteSpace(m3CO15))
				request.WithQueryParameter("CO15", m3CO15.Trim());
			if (m3BURC.HasValue)
				request.WithQueryParameter("BURC", m3BURC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACQT.HasValue)
				request.WithQueryParameter("ACQT", m3ACQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUQT.HasValue)
				request.WithQueryParameter("BUQT", m3BUQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CONR.HasValue)
				request.WithQueryParameter("CONR", m3CONR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EVEN))
				request.WithQueryParameter("EVEN", m3EVEN.Trim());

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
		/// Name DelBudgValues
		/// Description Delete Analytic Accounting Balance Values
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3MOID">Model ID (Required)</param>
		/// <param name="m3MOLN">Model Line (Required)</param>
		/// <param name="m3COV1">Column value 1 (Required)</param>
		/// <param name="m3COV2">Column value 2 (Required)</param>
		/// <param name="m3COV3">Column value 3 (Required)</param>
		/// <param name="m3COV4">Column value 4 (Required)</param>
		/// <param name="m3COV5">Column value 5 (Required)</param>
		/// <param name="m3COV6">Column value 6 (Required)</param>
		/// <param name="m3COV7">Column value 7 (Required)</param>
		/// <param name="m3COV8">Column value 8 (Required)</param>
		/// <param name="m3COV9">Column value 9 (Required)</param>
		/// <param name="m3CO10">Column value 10 (Required)</param>
		/// <param name="m3ACYP">Accounting period (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ACAM">Recorded amount</param>
		/// <param name="m3BUAM">Budget amount</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3CURC">Actual amt</param>
		/// <param name="m3CO11">Column value 11</param>
		/// <param name="m3CO12">Column value 12</param>
		/// <param name="m3CO13">Column value 13</param>
		/// <param name="m3CO14">Column value 14</param>
		/// <param name="m3CO15">Column value 15</param>
		/// <param name="m3BURC">Budget amt reporting currency</param>
		/// <param name="m3ACQT">Accounted quantity</param>
		/// <param name="m3BUQT">Budget quantity</param>
		/// <param name="m3CONR">Connection no</param>
		/// <param name="m3EVEN">Accounting event</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelBudgValues(
			string m3DIVI, 
			string m3MOID, 
			int m3MOLN, 
			string m3COV1, 
			string m3COV2, 
			string m3COV3, 
			string m3COV4, 
			string m3COV5, 
			string m3COV6, 
			string m3COV7, 
			string m3COV8, 
			string m3COV9, 
			string m3CO10, 
			int m3ACYP, 
			int? m3CONO = null, 
			decimal? m3ACAM = null, 
			decimal? m3BUAM = null, 
			decimal? m3TXID = null, 
			decimal? m3CURC = null, 
			string m3CO11 = null, 
			string m3CO12 = null, 
			string m3CO13 = null, 
			string m3CO14 = null, 
			string m3CO15 = null, 
			decimal? m3BURC = null, 
			decimal? m3ACQT = null, 
			decimal? m3BUQT = null, 
			int? m3CONR = null, 
			string m3EVEN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelBudgValues",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3MOID))
				throw new ArgumentNullException(nameof(m3MOID));
			if (string.IsNullOrWhiteSpace(m3COV1))
				throw new ArgumentNullException(nameof(m3COV1));
			if (string.IsNullOrWhiteSpace(m3COV2))
				throw new ArgumentNullException(nameof(m3COV2));
			if (string.IsNullOrWhiteSpace(m3COV3))
				throw new ArgumentNullException(nameof(m3COV3));
			if (string.IsNullOrWhiteSpace(m3COV4))
				throw new ArgumentNullException(nameof(m3COV4));
			if (string.IsNullOrWhiteSpace(m3COV5))
				throw new ArgumentNullException(nameof(m3COV5));
			if (string.IsNullOrWhiteSpace(m3COV6))
				throw new ArgumentNullException(nameof(m3COV6));
			if (string.IsNullOrWhiteSpace(m3COV7))
				throw new ArgumentNullException(nameof(m3COV7));
			if (string.IsNullOrWhiteSpace(m3COV8))
				throw new ArgumentNullException(nameof(m3COV8));
			if (string.IsNullOrWhiteSpace(m3COV9))
				throw new ArgumentNullException(nameof(m3COV9));
			if (string.IsNullOrWhiteSpace(m3CO10))
				throw new ArgumentNullException(nameof(m3CO10));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("MOID", m3MOID.Trim())
				.WithQueryParameter("MOLN", m3MOLN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("COV1", m3COV1.Trim())
				.WithQueryParameter("COV2", m3COV2.Trim())
				.WithQueryParameter("COV3", m3COV3.Trim())
				.WithQueryParameter("COV4", m3COV4.Trim())
				.WithQueryParameter("COV5", m3COV5.Trim())
				.WithQueryParameter("COV6", m3COV6.Trim())
				.WithQueryParameter("COV7", m3COV7.Trim())
				.WithQueryParameter("COV8", m3COV8.Trim())
				.WithQueryParameter("COV9", m3COV9.Trim())
				.WithQueryParameter("CO10", m3CO10.Trim())
				.WithQueryParameter("ACYP", m3ACYP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACAM.HasValue)
				request.WithQueryParameter("ACAM", m3ACAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUAM.HasValue)
				request.WithQueryParameter("BUAM", m3BUAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CURC.HasValue)
				request.WithQueryParameter("CURC", m3CURC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CO11))
				request.WithQueryParameter("CO11", m3CO11.Trim());
			if (!string.IsNullOrWhiteSpace(m3CO12))
				request.WithQueryParameter("CO12", m3CO12.Trim());
			if (!string.IsNullOrWhiteSpace(m3CO13))
				request.WithQueryParameter("CO13", m3CO13.Trim());
			if (!string.IsNullOrWhiteSpace(m3CO14))
				request.WithQueryParameter("CO14", m3CO14.Trim());
			if (!string.IsNullOrWhiteSpace(m3CO15))
				request.WithQueryParameter("CO15", m3CO15.Trim());
			if (m3BURC.HasValue)
				request.WithQueryParameter("BURC", m3BURC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACQT.HasValue)
				request.WithQueryParameter("ACQT", m3ACQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUQT.HasValue)
				request.WithQueryParameter("BUQT", m3BUQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CONR.HasValue)
				request.WithQueryParameter("CONR", m3CONR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EVEN))
				request.WithQueryParameter("EVEN", m3EVEN.Trim());

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
