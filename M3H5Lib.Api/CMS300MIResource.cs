/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.CMS300MI;
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
	/// Name: CMS300MI
	/// Component Name: Equipment
	/// Description: Event log
	/// Version Release: 14.x
	///</summary>
	public partial class CMS300MIResource : M3BaseResourceEndpoint
	{
		public CMS300MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS300MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Get
		/// Description Get reord from CSYLOG
		/// Version Release: 15
		/// </summary>
		/// <param name="m3EVNM">Event name</param>
		/// <param name="m3EVNR">Event sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3EVNM = null, 
			decimal? m3EVNR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Get",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EVNM))
				request.WithQueryParameter("EVNM", m3EVNM.Trim());
			if (m3EVNR.HasValue)
				request.WithQueryParameter("EVNR", m3EVNR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name Lst
		/// Description List records from CSYLOG
		/// Version Release: 15
		/// </summary>
		/// <param name="m3EVNM">Event name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3EVNM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Lst",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EVNM))
				request.WithQueryParameter("EVNM", m3EVNM.Trim());

			// Execute the request
			var result = await Execute<LstResponse>(
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
		/// Name LstField
		/// Description List records from CSYLOG
		/// Version Release: 15
		/// </summary>
		/// <param name="m3EVNM">Event name</param>
		/// <param name="m3FLDI">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFieldResponse></returns>
		/// <exception cref="M3Exception<LstFieldResponse>"></exception>
		public async Task<M3Response<LstFieldResponse>> LstField(
			string m3EVNM = null, 
			string m3FLDI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstField",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EVNM))
				request.WithQueryParameter("EVNM", m3EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());

			// Execute the request
			var result = await Execute<LstFieldResponse>(
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
		/// Name LstKey
		/// Description List records from CSYLOG
		/// Version Release: 15
		/// </summary>
		/// <param name="m3EVNM">Event name</param>
		/// <param name="m3FLDI">Field</param>
		/// <param name="m3PK01">Primary key 1</param>
		/// <param name="m3PK02">Primary key 2</param>
		/// <param name="m3PK03">Primary key 3</param>
		/// <param name="m3PK04">Primary key 4</param>
		/// <param name="m3PK05">Primary key 5</param>
		/// <param name="m3PK06">Primary key 6</param>
		/// <param name="m3PK07">Primary key 7</param>
		/// <param name="m3PK08">Primary key 8</param>
		/// <param name="m3PK09">Primary key 9</param>
		/// <param name="m3PK10">Primary key 10</param>
		/// <param name="m3PK11">Primary key 11</param>
		/// <param name="m3PK12">Primary key 12</param>
		/// <param name="m3PK13">Primary key 13</param>
		/// <param name="m3PK14">Primary key 14</param>
		/// <param name="m3PK15">Primary key 15</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstKeyResponse></returns>
		/// <exception cref="M3Exception<LstKeyResponse>"></exception>
		public async Task<M3Response<LstKeyResponse>> LstKey(
			string m3EVNM = null, 
			string m3FLDI = null, 
			string m3PK01 = null, 
			string m3PK02 = null, 
			string m3PK03 = null, 
			string m3PK04 = null, 
			string m3PK05 = null, 
			string m3PK06 = null, 
			string m3PK07 = null, 
			string m3PK08 = null, 
			string m3PK09 = null, 
			string m3PK10 = null, 
			string m3PK11 = null, 
			string m3PK12 = null, 
			string m3PK13 = null, 
			string m3PK14 = null, 
			string m3PK15 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstKey",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EVNM))
				request.WithQueryParameter("EVNM", m3EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3FLDI))
				request.WithQueryParameter("FLDI", m3FLDI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK01))
				request.WithQueryParameter("PK01", m3PK01.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK02))
				request.WithQueryParameter("PK02", m3PK02.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK03))
				request.WithQueryParameter("PK03", m3PK03.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK04))
				request.WithQueryParameter("PK04", m3PK04.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK05))
				request.WithQueryParameter("PK05", m3PK05.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK06))
				request.WithQueryParameter("PK06", m3PK06.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK07))
				request.WithQueryParameter("PK07", m3PK07.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK08))
				request.WithQueryParameter("PK08", m3PK08.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK09))
				request.WithQueryParameter("PK09", m3PK09.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK10))
				request.WithQueryParameter("PK10", m3PK10.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK11))
				request.WithQueryParameter("PK11", m3PK11.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK12))
				request.WithQueryParameter("PK12", m3PK12.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK13))
				request.WithQueryParameter("PK13", m3PK13.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK14))
				request.WithQueryParameter("PK14", m3PK14.Trim());
			if (!string.IsNullOrWhiteSpace(m3PK15))
				request.WithQueryParameter("PK15", m3PK15.Trim());

			// Execute the request
			var result = await Execute<LstKeyResponse>(
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
		/// Name Upd
		/// Description Update dates in  CSYLOG
		/// Version Release: 15
		/// </summary>
		/// <param name="m3EVNM">Event name</param>
		/// <param name="m3EVNO">Event name operation</param>
		/// <param name="m3EVPB">Event publisher</param>
		/// <param name="m3EVNR">Event sequence number</param>
		/// <param name="m3UPDT">Updating date</param>
		/// <param name="m3DTPR">Date printed</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdResponse></returns>
		/// <exception cref="M3Exception<UpdResponse>"></exception>
		public async Task<M3Response<UpdResponse>> Upd(
			string m3EVNM = null, 
			string m3EVNO = null, 
			string m3EVPB = null, 
			decimal? m3EVNR = null, 
			DateTime? m3UPDT = null, 
			DateTime? m3DTPR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Upd",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EVNM))
				request.WithQueryParameter("EVNM", m3EVNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVNO))
				request.WithQueryParameter("EVNO", m3EVNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EVPB))
				request.WithQueryParameter("EVPB", m3EVPB.Trim());
			if (m3EVNR.HasValue)
				request.WithQueryParameter("EVNR", m3EVNR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UPDT.HasValue)
				request.WithQueryParameter("UPDT", m3UPDT.Value.ToM3String());
			if (m3DTPR.HasValue)
				request.WithQueryParameter("DTPR", m3DTPR.Value.ToM3String());

			// Execute the request
			var result = await Execute<UpdResponse>(
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
