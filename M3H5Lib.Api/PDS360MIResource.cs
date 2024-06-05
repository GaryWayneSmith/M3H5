/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.PDS360MI;
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
	/// Name: PDS360MI
	/// Component Name: Substitution Table
	/// Description: Substitution Table Interface
	/// Version Release: 5ea0
	///</summary>
	public partial class PDS360MIResource : M3BaseResourceEndpoint
	{
		public PDS360MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PDS360MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddSubstitFeat
		/// Description Add feature substitution
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3STRT">Product structure type (Required)</param>
		/// <param name="m3MSEQ">Sequence number (Required)</param>
		/// <param name="m3PFTI">Product Feature (Required)</param>
		/// <param name="m3MFTI">Component Feature (Required)</param>
		/// <param name="m3XSBT">Substitution type (Required)</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSubstitFeat(
			string m3FACI, 
			string m3PRNO, 
			string m3STRT, 
			int m3MSEQ, 
			string m3PFTI, 
			string m3MFTI, 
			int m3XSBT, 
			DateTime? m3FDAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddSubstitFeat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3STRT))
				throw new ArgumentNullException(nameof(m3STRT));
			if (string.IsNullOrWhiteSpace(m3PFTI))
				throw new ArgumentNullException(nameof(m3PFTI));
			if (string.IsNullOrWhiteSpace(m3MFTI))
				throw new ArgumentNullException(nameof(m3MFTI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("STRT", m3STRT.Trim())
				.WithQueryParameter("MSEQ", m3MSEQ.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PFTI", m3PFTI.Trim())
				.WithQueryParameter("MFTI", m3MFTI.Trim())
				.WithQueryParameter("XSBT", m3XSBT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());

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
		/// Name AddSubstitOpt
		/// Description Add option substitution
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3STRT">Product structure type (Required)</param>
		/// <param name="m3MSEQ">Sequence number (Required)</param>
		/// <param name="m3PFTI">Product Feature (Required)</param>
		/// <param name="m3MFTI">Component Feature (Required)</param>
		/// <param name="m3POPT">Product Option (Required)</param>
		/// <param name="m3MOPT">Component Option (Required)</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSubstitOpt(
			string m3FACI, 
			string m3PRNO, 
			string m3STRT, 
			int m3MSEQ, 
			string m3PFTI, 
			string m3MFTI, 
			string m3POPT, 
			string m3MOPT, 
			DateTime? m3FDAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddSubstitOpt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3STRT))
				throw new ArgumentNullException(nameof(m3STRT));
			if (string.IsNullOrWhiteSpace(m3PFTI))
				throw new ArgumentNullException(nameof(m3PFTI));
			if (string.IsNullOrWhiteSpace(m3MFTI))
				throw new ArgumentNullException(nameof(m3MFTI));
			if (string.IsNullOrWhiteSpace(m3POPT))
				throw new ArgumentNullException(nameof(m3POPT));
			if (string.IsNullOrWhiteSpace(m3MOPT))
				throw new ArgumentNullException(nameof(m3MOPT));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("STRT", m3STRT.Trim())
				.WithQueryParameter("MSEQ", m3MSEQ.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PFTI", m3PFTI.Trim())
				.WithQueryParameter("MFTI", m3MFTI.Trim())
				.WithQueryParameter("POPT", m3POPT.Trim())
				.WithQueryParameter("MOPT", m3MOPT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());

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
		/// Name DltSubstitFeat
		/// Description Delete feature substitution
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3STRT">Product structure type (Required)</param>
		/// <param name="m3MSEQ">Sequence number (Required)</param>
		/// <param name="m3PFTI">Product Feature (Required)</param>
		/// <param name="m3MFTI">Component Feature (Required)</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltSubstitFeat(
			string m3FACI, 
			string m3PRNO, 
			string m3STRT, 
			int m3MSEQ, 
			string m3PFTI, 
			string m3MFTI, 
			DateTime? m3FDAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltSubstitFeat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3STRT))
				throw new ArgumentNullException(nameof(m3STRT));
			if (string.IsNullOrWhiteSpace(m3PFTI))
				throw new ArgumentNullException(nameof(m3PFTI));
			if (string.IsNullOrWhiteSpace(m3MFTI))
				throw new ArgumentNullException(nameof(m3MFTI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("STRT", m3STRT.Trim())
				.WithQueryParameter("MSEQ", m3MSEQ.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PFTI", m3PFTI.Trim())
				.WithQueryParameter("MFTI", m3MFTI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());

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
		/// Name DltSubstitOpt
		/// Description Delete option substitution
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3STRT">Product structure type (Required)</param>
		/// <param name="m3MSEQ">Sequence number (Required)</param>
		/// <param name="m3PFTI">Product Feature (Required)</param>
		/// <param name="m3MFTI">Component Feature (Required)</param>
		/// <param name="m3POPT">Product Option (Required)</param>
		/// <param name="m3MOPT">Component Option (Required)</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltSubstitOpt(
			string m3FACI, 
			string m3PRNO, 
			string m3STRT, 
			int m3MSEQ, 
			string m3PFTI, 
			string m3MFTI, 
			string m3POPT, 
			string m3MOPT, 
			DateTime? m3FDAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltSubstitOpt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3STRT))
				throw new ArgumentNullException(nameof(m3STRT));
			if (string.IsNullOrWhiteSpace(m3PFTI))
				throw new ArgumentNullException(nameof(m3PFTI));
			if (string.IsNullOrWhiteSpace(m3MFTI))
				throw new ArgumentNullException(nameof(m3MFTI));
			if (string.IsNullOrWhiteSpace(m3POPT))
				throw new ArgumentNullException(nameof(m3POPT));
			if (string.IsNullOrWhiteSpace(m3MOPT))
				throw new ArgumentNullException(nameof(m3MOPT));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("STRT", m3STRT.Trim())
				.WithQueryParameter("MSEQ", m3MSEQ.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PFTI", m3PFTI.Trim())
				.WithQueryParameter("MFTI", m3MFTI.Trim())
				.WithQueryParameter("POPT", m3POPT.Trim())
				.WithQueryParameter("MOPT", m3MOPT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());

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
		/// Name LstSubstitFeat
		/// Description List feature substitutions
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3STRT">Product structure type (Required)</param>
		/// <param name="m3MSEQ">Sequence number (Required)</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSubstitFeatResponse></returns>
		/// <exception cref="M3Exception<LstSubstitFeatResponse>"></exception>
		public async Task<M3Response<LstSubstitFeatResponse>> LstSubstitFeat(
			string m3FACI, 
			string m3PRNO, 
			string m3STRT, 
			int m3MSEQ, 
			DateTime? m3FDAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSubstitFeat",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3STRT))
				throw new ArgumentNullException(nameof(m3STRT));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("STRT", m3STRT.Trim())
				.WithQueryParameter("MSEQ", m3MSEQ.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstSubstitFeatResponse>(
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
		/// Name LstSubstitOpt
		/// Description List option substitutions
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3STRT">Product structure type (Required)</param>
		/// <param name="m3MSEQ">Sequence number (Required)</param>
		/// <param name="m3PFTI">Product Feature (Required)</param>
		/// <param name="m3MFTI">Component Feature (Required)</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSubstitOptResponse></returns>
		/// <exception cref="M3Exception<LstSubstitOptResponse>"></exception>
		public async Task<M3Response<LstSubstitOptResponse>> LstSubstitOpt(
			string m3FACI, 
			string m3PRNO, 
			string m3STRT, 
			int m3MSEQ, 
			string m3PFTI, 
			string m3MFTI, 
			DateTime? m3FDAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSubstitOpt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3STRT))
				throw new ArgumentNullException(nameof(m3STRT));
			if (string.IsNullOrWhiteSpace(m3PFTI))
				throw new ArgumentNullException(nameof(m3PFTI));
			if (string.IsNullOrWhiteSpace(m3MFTI))
				throw new ArgumentNullException(nameof(m3MFTI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("STRT", m3STRT.Trim())
				.WithQueryParameter("MSEQ", m3MSEQ.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PFTI", m3PFTI.Trim())
				.WithQueryParameter("MFTI", m3MFTI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstSubstitOptResponse>(
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
