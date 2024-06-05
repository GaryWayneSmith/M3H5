/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.MOS400MI;
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
	/// Name: MOS400MI
	/// Component Name: Models
	/// Description: Api: Models
	/// Version Release: 
	///</summary>
	public partial class MOS400MIResource : M3BaseResourceEndpoint
	{
		public MOS400MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS400MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddModel
		/// Description Add Model
		/// Version Release: 
		/// </summary>
		/// <param name="m3MOTP">Model/site (Required)</param>
		/// <param name="m3STNC">Standard numbering system (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3DISD">Display date</param>
		/// <param name="m3AUPL">Used as site</param>
		/// <param name="m3MNUS">MEL numbering system</param>
		/// <param name="m3AATP">Alias type - Equipment no</param>
		/// <param name="m3AAT1">Alias Type - Position</param>
		/// <param name="m3ADPD">Depreciation periods</param>
		/// <param name="m3ARPT">Revaluation percent</param>
		/// <param name="m3ARVP">Remaining value in percent</param>
		/// <param name="m3AOAC">Active operational unit</param>
		/// <param name="m3ALDD">Last depreciation date</param>
		/// <param name="m3ADLH">Depreciation length</param>
		/// <param name="m3MAIS">Maintenance sequence number</param>
		/// <param name="m3ACSE">Serial number administration</param>
		/// <param name="m3EFMA">Configuration management</param>
		/// <param name="m3OPRU">Operational unit</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddModel(
			string m3MOTP, 
			string m3STNC, 
			int? m3CONO = null, 
			string m3STAT = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			int? m3DISD = null, 
			int? m3AUPL = null, 
			string m3MNUS = null, 
			int? m3AATP = null, 
			int? m3AAT1 = null, 
			int? m3ADPD = null, 
			int? m3ARPT = null, 
			int? m3ARVP = null, 
			int? m3AOAC = null, 
			DateTime? m3ALDD = null, 
			int? m3ADLH = null, 
			int? m3MAIS = null, 
			int? m3ACSE = null, 
			int? m3EFMA = null, 
			int? m3OPRU = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddModel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MOTP))
				throw new ArgumentNullException(nameof(m3MOTP));
			if (string.IsNullOrWhiteSpace(m3STNC))
				throw new ArgumentNullException(nameof(m3STNC));

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3MOTP.Trim())
				.WithQueryParameter("STNC", m3STNC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3DISD.HasValue)
				request.WithQueryParameter("DISD", m3DISD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUPL.HasValue)
				request.WithQueryParameter("AUPL", m3AUPL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MNUS))
				request.WithQueryParameter("MNUS", m3MNUS.Trim());
			if (m3AATP.HasValue)
				request.WithQueryParameter("AATP", m3AATP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AAT1.HasValue)
				request.WithQueryParameter("AAT1", m3AAT1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADPD.HasValue)
				request.WithQueryParameter("ADPD", m3ADPD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ARPT.HasValue)
				request.WithQueryParameter("ARPT", m3ARPT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ARVP.HasValue)
				request.WithQueryParameter("ARVP", m3ARVP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AOAC.HasValue)
				request.WithQueryParameter("AOAC", m3AOAC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALDD.HasValue)
				request.WithQueryParameter("ALDD", m3ALDD.Value.ToM3String());
			if (m3ADLH.HasValue)
				request.WithQueryParameter("ADLH", m3ADLH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MAIS.HasValue)
				request.WithQueryParameter("MAIS", m3MAIS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACSE.HasValue)
				request.WithQueryParameter("ACSE", m3ACSE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EFMA.HasValue)
				request.WithQueryParameter("EFMA", m3EFMA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPRU.HasValue)
				request.WithQueryParameter("OPRU", m3OPRU.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltModel
		/// Description Delete Model
		/// Version Release: 
		/// </summary>
		/// <param name="m3MOTP">Model/site (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3COPY">Delete Config</param>
		/// <param name="m3DSP1">Warning Indicator</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltModel(
			string m3MOTP, 
			int? m3CONO = null, 
			string m3COPY = null, 
			int? m3DSP1 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltModel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MOTP))
				throw new ArgumentNullException(nameof(m3MOTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3MOTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3COPY))
				request.WithQueryParameter("COPY", m3COPY.Trim());
			if (m3DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3DSP1.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetModel
		/// Description Get Model
		/// Version Release: 
		/// </summary>
		/// <param name="m3MOTP">Model/site (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetModelResponse></returns>
		/// <exception cref="M3Exception<GetModelResponse>"></exception>
		public async Task<M3Response<GetModelResponse>> GetModel(
			string m3MOTP, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetModel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MOTP))
				throw new ArgumentNullException(nameof(m3MOTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3MOTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetModelResponse>(
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
		/// Name LstModel
		/// Description List Model
		/// Version Release: 
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstModelResponse></returns>
		/// <exception cref="M3Exception<LstModelResponse>"></exception>
		public async Task<M3Response<LstModelResponse>> LstModel(
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstModel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstModelResponse>(
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
		/// Name UpdModel
		/// Description Update Model
		/// Version Release: 
		/// </summary>
		/// <param name="m3MOTP">Model/site (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STNC">Standard numbering system</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3DISD">Display date</param>
		/// <param name="m3AUPL">Used as site</param>
		/// <param name="m3MNUS">MEL numbering system</param>
		/// <param name="m3AATP">Alias type - Equipment no</param>
		/// <param name="m3AAT1">Alias Type - Position</param>
		/// <param name="m3ADPD">Depreciation periods</param>
		/// <param name="m3ARPT">Revaluation percent</param>
		/// <param name="m3ARVP">Remaining value in percent</param>
		/// <param name="m3AOAC">Active operational unit</param>
		/// <param name="m3ALDD">Last depreciation date</param>
		/// <param name="m3ADLH">Depreciation length</param>
		/// <param name="m3MAIS">Maintenance sequence number</param>
		/// <param name="m3ACSE">Serial number administration</param>
		/// <param name="m3EFMA">Configuration management</param>
		/// <param name="m3OPRU">Operational unit</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdModel(
			string m3MOTP, 
			int? m3CONO = null, 
			string m3STNC = null, 
			string m3STAT = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			int? m3DISD = null, 
			int? m3AUPL = null, 
			string m3MNUS = null, 
			int? m3AATP = null, 
			int? m3AAT1 = null, 
			int? m3ADPD = null, 
			int? m3ARPT = null, 
			int? m3ARVP = null, 
			int? m3AOAC = null, 
			DateTime? m3ALDD = null, 
			int? m3ADLH = null, 
			int? m3MAIS = null, 
			int? m3ACSE = null, 
			int? m3EFMA = null, 
			int? m3OPRU = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdModel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MOTP))
				throw new ArgumentNullException(nameof(m3MOTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3MOTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STNC))
				request.WithQueryParameter("STNC", m3STNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3DISD.HasValue)
				request.WithQueryParameter("DISD", m3DISD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUPL.HasValue)
				request.WithQueryParameter("AUPL", m3AUPL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MNUS))
				request.WithQueryParameter("MNUS", m3MNUS.Trim());
			if (m3AATP.HasValue)
				request.WithQueryParameter("AATP", m3AATP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AAT1.HasValue)
				request.WithQueryParameter("AAT1", m3AAT1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADPD.HasValue)
				request.WithQueryParameter("ADPD", m3ADPD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ARPT.HasValue)
				request.WithQueryParameter("ARPT", m3ARPT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ARVP.HasValue)
				request.WithQueryParameter("ARVP", m3ARVP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AOAC.HasValue)
				request.WithQueryParameter("AOAC", m3AOAC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ALDD.HasValue)
				request.WithQueryParameter("ALDD", m3ALDD.Value.ToM3String());
			if (m3ADLH.HasValue)
				request.WithQueryParameter("ADLH", m3ADLH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MAIS.HasValue)
				request.WithQueryParameter("MAIS", m3MAIS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACSE.HasValue)
				request.WithQueryParameter("ACSE", m3ACSE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EFMA.HasValue)
				request.WithQueryParameter("EFMA", m3EFMA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPRU.HasValue)
				request.WithQueryParameter("OPRU", m3OPRU.Value.ToString(CultureInfo.CurrentCulture));

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
