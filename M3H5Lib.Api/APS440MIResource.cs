/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddStmntHead
		/// Description Add Statement Head
		/// Version Release: 
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3SSRO">Supplier statement Round (Required)</param>
		/// <param name="m3SSTY">Supplier statement Type (Required)</param>
		/// <param name="m3SSTD">Supplier statement Date</param>
		/// <param name="m3SSTO">Supplier statement Total</param>
		/// <param name="m3STTD">Supplier statement to due date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddStmntHeadResponse></returns>
		/// <exception cref="M3Exception<AddStmntHeadResponse>"></exception>
		public async Task<M3Response<AddStmntHeadResponse>> AddStmntHead(
			string m3DIVI, 
			string m3SSRO, 
			int m3SSTY, 
			int? m3SSTD = null, 
			string m3SSTO = null, 
			DateTime? m3STTD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddStmntHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3SSRO))
				throw new ArgumentNullException(nameof(m3SSRO));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("SSRO", m3SSRO.Trim())
				.WithQueryParameter("SSTY", m3SSTY.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3SSTD.HasValue)
				request.WithQueryParameter("SSTD", m3SSTD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SSTO))
				request.WithQueryParameter("SSTO", m3SSTO.Trim());
			if (m3STTD.HasValue)
				request.WithQueryParameter("STTD", m3STTD.Value.ToM3String());

			// Execute the request
			var result = await Execute<AddStmntHeadResponse>(
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
		/// Name AddStmntLine
		/// Description Add Statement Line
		/// Version Release: 
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BJNO">Job number (Required)</param>
		/// <param name="m3SSLI">Supplier statement Line (Required)</param>
		/// <param name="m3SSPA">Supplier statement Payee (Required)</param>
		/// <param name="m3SSIY">Supplier statement Invoice year (Required)</param>
		/// <param name="m3SSIN">Supplier statement Invoice number (Required)</param>
		/// <param name="m3SSIC">Supplier statement Invoice currency (Required)</param>
		/// <param name="m3SSIV">Supplier statement Invoice amount (Required)</param>
		/// <param name="m3SSID">Supplier statement Invoice date (Required)</param>
		/// <param name="m3SSIB">Supplier statement due date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddStmntLineResponse></returns>
		/// <exception cref="M3Exception<AddStmntLineResponse>"></exception>
		public async Task<M3Response<AddStmntLineResponse>> AddStmntLine(
			string m3DIVI, 
			string m3BJNO, 
			int m3SSLI, 
			string m3SSPA, 
			int m3SSIY, 
			string m3SSIN, 
			string m3SSIC, 
			decimal m3SSIV, 
			int m3SSID, 
			DateTime? m3SSIB = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddStmntLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BJNO))
				throw new ArgumentNullException(nameof(m3BJNO));
			if (string.IsNullOrWhiteSpace(m3SSPA))
				throw new ArgumentNullException(nameof(m3SSPA));
			if (string.IsNullOrWhiteSpace(m3SSIN))
				throw new ArgumentNullException(nameof(m3SSIN));
			if (string.IsNullOrWhiteSpace(m3SSIC))
				throw new ArgumentNullException(nameof(m3SSIC));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BJNO", m3BJNO.Trim())
				.WithQueryParameter("SSLI", m3SSLI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SSPA", m3SSPA.Trim())
				.WithQueryParameter("SSIY", m3SSIY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SSIN", m3SSIN.Trim())
				.WithQueryParameter("SSIC", m3SSIC.Trim())
				.WithQueryParameter("SSIV", m3SSIV.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SSID", m3SSID.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3SSIB.HasValue)
				request.WithQueryParameter("SSIB", m3SSIB.Value.ToM3String());

			// Execute the request
			var result = await Execute<AddStmntLineResponse>(
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
		/// Name AddStmntPayee
		/// Description Add Statement Payee
		/// Version Release: 
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3BJNO">Job number (Required)</param>
		/// <param name="m3SSPA">Supplier statement Payee (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddStmntPayee(
			string m3DIVI, 
			string m3BJNO, 
			string m3SSPA, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddStmntPayee",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3BJNO))
				throw new ArgumentNullException(nameof(m3BJNO));
			if (string.IsNullOrWhiteSpace(m3SSPA))
				throw new ArgumentNullException(nameof(m3SSPA));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("BJNO", m3BJNO.Trim())
				.WithQueryParameter("SSPA", m3SSPA.Trim());

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
