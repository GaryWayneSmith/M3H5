/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.PPS386MI;
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
	/// Name: PPS386MI
	/// Component Name: SettlementPrintingModel
	/// Description: Settlement Printing Model. Connect test and attribute lines
	/// Version Release: 5e90
	///</summary>
	public partial class PPS386MIResource : M3BaseResourceEndpoint
	{
		public PPS386MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPS386MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddModelElement
		/// Description AddModelElement
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3WSCA">Costing model</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3ANSQ">Attribute sequence number</param>
		/// <param name="m3SCET">Element type - sales price costing</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3POSE">Print on settlement</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddModelElement(
			string m3WSCA = null, 
			int? m3FDAT = null, 
			int? m3ANSQ = null, 
			int? m3SCET = null, 
			string m3OBV1 = null, 
			int? m3POSE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddModelElement",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WSCA))
				request.WithQueryParameter("WSCA", m3WSCA.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3ANSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCET.HasValue)
				request.WithQueryParameter("SCET", m3SCET.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (m3POSE.HasValue)
				request.WithQueryParameter("POSE", m3POSE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltModelElement
		/// Description DltModelElement
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3WSCA">Costing model</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3ANSQ">Attribute sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltModelElement(
			string m3WSCA = null, 
			DateTime? m3FDAT = null, 
			int? m3ANSQ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltModelElement",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WSCA))
				request.WithQueryParameter("WSCA", m3WSCA.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3ANSQ.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetModelElement
		/// Description GetModelElement
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3WSCA">Costing model</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3ANSQ">Attribute sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetModelElementResponse></returns>
		/// <exception cref="M3Exception<GetModelElementResponse>"></exception>
		public async Task<M3Response<GetModelElementResponse>> GetModelElement(
			string m3WSCA = null, 
			DateTime? m3FDAT = null, 
			int? m3ANSQ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetModelElement",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WSCA))
				request.WithQueryParameter("WSCA", m3WSCA.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3ANSQ.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetModelElementResponse>(
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
		/// Name LstModelElement
		/// Description LstModelElement
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3WSCA">Costing model</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3ANSQ">Attribute sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstModelElementResponse></returns>
		/// <exception cref="M3Exception<LstModelElementResponse>"></exception>
		public async Task<M3Response<LstModelElementResponse>> LstModelElement(
			string m3WSCA = null, 
			DateTime? m3FDAT = null, 
			int? m3ANSQ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstModelElement",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WSCA))
				request.WithQueryParameter("WSCA", m3WSCA.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3ANSQ.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstModelElementResponse>(
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
		/// Name UpdModelElement
		/// Description UpdModelElement
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3WSCA">Costing model</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3ANSQ">Attribute sequence number</param>
		/// <param name="m3SCET">Element type - sales price costing</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3POSE">Print on settlement</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdModelElement(
			string m3WSCA = null, 
			DateTime? m3FDAT = null, 
			int? m3ANSQ = null, 
			int? m3SCET = null, 
			string m3OBV1 = null, 
			int? m3POSE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdModelElement",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WSCA))
				request.WithQueryParameter("WSCA", m3WSCA.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3ANSQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCET.HasValue)
				request.WithQueryParameter("SCET", m3SCET.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (m3POSE.HasValue)
				request.WithQueryParameter("POSE", m3POSE.Value.ToString(CultureInfo.CurrentCulture));

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
