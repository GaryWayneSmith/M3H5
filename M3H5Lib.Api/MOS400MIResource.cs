/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddModel
		/// Description Add Model
		/// Version Release: 
		/// </summary>
		/// <param name="m3_MOTP">Model/site (Required)</param>
		/// <param name="m3_STNC">Standard numbering system (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_DISD">Display date</param>
		/// <param name="m3_AUPL">Used as site</param>
		/// <param name="m3_MNUS">MEL numbering system</param>
		/// <param name="m3_AATP">Alias type - Equipment no</param>
		/// <param name="m3_AAT1">Alias Type - Position</param>
		/// <param name="m3_ADPD">Depreciation periods</param>
		/// <param name="m3_ARPT">Revaluation percent</param>
		/// <param name="m3_ARVP">Remaining value in percent</param>
		/// <param name="m3_AOAC">Active operational unit</param>
		/// <param name="m3_ALDD">Last depreciation date</param>
		/// <param name="m3_ADLH">Depreciation length</param>
		/// <param name="m3_MAIS">Maintenance sequence number</param>
		/// <param name="m3_ACSE">Serial number administration</param>
		/// <param name="m3_EFMA">Configuration management</param>
		/// <param name="m3_OPRU">Operational unit</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddModel(
			string m3_MOTP, 
			string m3_STNC, 
			int? m3_CONO = null, 
			string m3_STAT = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			int? m3_DISD = null, 
			int? m3_AUPL = null, 
			string m3_MNUS = null, 
			int? m3_AATP = null, 
			int? m3_AAT1 = null, 
			int? m3_ADPD = null, 
			int? m3_ARPT = null, 
			int? m3_ARVP = null, 
			int? m3_AOAC = null, 
			DateTime? m3_ALDD = null, 
			int? m3_ADLH = null, 
			int? m3_MAIS = null, 
			int? m3_ACSE = null, 
			int? m3_EFMA = null, 
			int? m3_OPRU = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddModel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MOTP))
				throw new ArgumentNullException("m3_MOTP");
			if (string.IsNullOrWhiteSpace(m3_STNC))
				throw new ArgumentNullException("m3_STNC");

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3_MOTP.Trim())
				.WithQueryParameter("STNC", m3_STNC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_DISD.HasValue)
				request.WithQueryParameter("DISD", m3_DISD.Value.ToString());
			if (m3_AUPL.HasValue)
				request.WithQueryParameter("AUPL", m3_AUPL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MNUS))
				request.WithQueryParameter("MNUS", m3_MNUS.Trim());
			if (m3_AATP.HasValue)
				request.WithQueryParameter("AATP", m3_AATP.Value.ToString());
			if (m3_AAT1.HasValue)
				request.WithQueryParameter("AAT1", m3_AAT1.Value.ToString());
			if (m3_ADPD.HasValue)
				request.WithQueryParameter("ADPD", m3_ADPD.Value.ToString());
			if (m3_ARPT.HasValue)
				request.WithQueryParameter("ARPT", m3_ARPT.Value.ToString());
			if (m3_ARVP.HasValue)
				request.WithQueryParameter("ARVP", m3_ARVP.Value.ToString());
			if (m3_AOAC.HasValue)
				request.WithQueryParameter("AOAC", m3_AOAC.Value.ToString());
			if (m3_ALDD.HasValue)
				request.WithQueryParameter("ALDD", m3_ALDD.Value.ToM3String());
			if (m3_ADLH.HasValue)
				request.WithQueryParameter("ADLH", m3_ADLH.Value.ToString());
			if (m3_MAIS.HasValue)
				request.WithQueryParameter("MAIS", m3_MAIS.Value.ToString());
			if (m3_ACSE.HasValue)
				request.WithQueryParameter("ACSE", m3_ACSE.Value.ToString());
			if (m3_EFMA.HasValue)
				request.WithQueryParameter("EFMA", m3_EFMA.Value.ToString());
			if (m3_OPRU.HasValue)
				request.WithQueryParameter("OPRU", m3_OPRU.Value.ToString());

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
		/// Name DltModel
		/// Description Delete Model
		/// Version Release: 
		/// </summary>
		/// <param name="m3_MOTP">Model/site (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_COPY">Delete Config</param>
		/// <param name="m3_DSP1">Warning Indicator</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltModel(
			string m3_MOTP, 
			int? m3_CONO = null, 
			string m3_COPY = null, 
			int? m3_DSP1 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltModel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MOTP))
				throw new ArgumentNullException("m3_MOTP");

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3_MOTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_COPY))
				request.WithQueryParameter("COPY", m3_COPY.Trim());
			if (m3_DSP1.HasValue)
				request.WithQueryParameter("DSP1", m3_DSP1.Value.ToString());

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
		/// Name GetModel
		/// Description Get Model
		/// Version Release: 
		/// </summary>
		/// <param name="m3_MOTP">Model/site (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetModelResponse></returns>
		/// <exception cref="M3Exception<GetModelResponse>"></exception>
		public async Task<M3Response<GetModelResponse>> GetModel(
			string m3_MOTP, 
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetModel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MOTP))
				throw new ArgumentNullException("m3_MOTP");

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3_MOTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetModelResponse>(
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
		/// Name LstModel
		/// Description List Model
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstModelResponse></returns>
		/// <exception cref="M3Exception<LstModelResponse>"></exception>
		public async Task<M3Response<LstModelResponse>> LstModel(
			int? m3_CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstModel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstModelResponse>(
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
		/// Name UpdModel
		/// Description Update Model
		/// Version Release: 
		/// </summary>
		/// <param name="m3_MOTP">Model/site (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_STNC">Standard numbering system</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_DISD">Display date</param>
		/// <param name="m3_AUPL">Used as site</param>
		/// <param name="m3_MNUS">MEL numbering system</param>
		/// <param name="m3_AATP">Alias type - Equipment no</param>
		/// <param name="m3_AAT1">Alias Type - Position</param>
		/// <param name="m3_ADPD">Depreciation periods</param>
		/// <param name="m3_ARPT">Revaluation percent</param>
		/// <param name="m3_ARVP">Remaining value in percent</param>
		/// <param name="m3_AOAC">Active operational unit</param>
		/// <param name="m3_ALDD">Last depreciation date</param>
		/// <param name="m3_ADLH">Depreciation length</param>
		/// <param name="m3_MAIS">Maintenance sequence number</param>
		/// <param name="m3_ACSE">Serial number administration</param>
		/// <param name="m3_EFMA">Configuration management</param>
		/// <param name="m3_OPRU">Operational unit</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdModel(
			string m3_MOTP, 
			int? m3_CONO = null, 
			string m3_STNC = null, 
			string m3_STAT = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			int? m3_DISD = null, 
			int? m3_AUPL = null, 
			string m3_MNUS = null, 
			int? m3_AATP = null, 
			int? m3_AAT1 = null, 
			int? m3_ADPD = null, 
			int? m3_ARPT = null, 
			int? m3_ARVP = null, 
			int? m3_AOAC = null, 
			DateTime? m3_ALDD = null, 
			int? m3_ADLH = null, 
			int? m3_MAIS = null, 
			int? m3_ACSE = null, 
			int? m3_EFMA = null, 
			int? m3_OPRU = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdModel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MOTP))
				throw new ArgumentNullException("m3_MOTP");

			// Set mandatory parameters
			request
				.WithQueryParameter("MOTP", m3_MOTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STNC))
				request.WithQueryParameter("STNC", m3_STNC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_DISD.HasValue)
				request.WithQueryParameter("DISD", m3_DISD.Value.ToString());
			if (m3_AUPL.HasValue)
				request.WithQueryParameter("AUPL", m3_AUPL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MNUS))
				request.WithQueryParameter("MNUS", m3_MNUS.Trim());
			if (m3_AATP.HasValue)
				request.WithQueryParameter("AATP", m3_AATP.Value.ToString());
			if (m3_AAT1.HasValue)
				request.WithQueryParameter("AAT1", m3_AAT1.Value.ToString());
			if (m3_ADPD.HasValue)
				request.WithQueryParameter("ADPD", m3_ADPD.Value.ToString());
			if (m3_ARPT.HasValue)
				request.WithQueryParameter("ARPT", m3_ARPT.Value.ToString());
			if (m3_ARVP.HasValue)
				request.WithQueryParameter("ARVP", m3_ARVP.Value.ToString());
			if (m3_AOAC.HasValue)
				request.WithQueryParameter("AOAC", m3_AOAC.Value.ToString());
			if (m3_ALDD.HasValue)
				request.WithQueryParameter("ALDD", m3_ALDD.Value.ToM3String());
			if (m3_ADLH.HasValue)
				request.WithQueryParameter("ADLH", m3_ADLH.Value.ToString());
			if (m3_MAIS.HasValue)
				request.WithQueryParameter("MAIS", m3_MAIS.Value.ToString());
			if (m3_ACSE.HasValue)
				request.WithQueryParameter("ACSE", m3_ACSE.Value.ToString());
			if (m3_EFMA.HasValue)
				request.WithQueryParameter("EFMA", m3_EFMA.Value.ToString());
			if (m3_OPRU.HasValue)
				request.WithQueryParameter("OPRU", m3_OPRU.Value.ToString());

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
