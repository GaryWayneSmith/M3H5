/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.CMS035MI;
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
	/// Name: CMS035MI
	/// Component Name: LES
	/// Description: Api: Search Tags
	/// Version Release: 14.1
	///</summary>
	public partial class CMS035MIResource : M3BaseResourceEndpoint
	{
		public CMS035MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS035MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
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
		/// <param name="m3SQNR">Sequence number</param>
		/// <param name="m3PARM">Parameter value</param>
		/// <param name="m3SETG">Search tag</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3FILE, 
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
			int? m3SQNR = null, 
			string m3PARM = null, 
			int? m3SETG = null, 
			string m3RESP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim());

			// Set optional parameters, checking for null/blank data for each element
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
			if (m3SQNR.HasValue)
				request.WithQueryParameter("SQNR", m3SQNR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PARM))
				request.WithQueryParameter("PARM", m3PARM.Trim());
			if (m3SETG.HasValue)
				request.WithQueryParameter("SETG", m3SETG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());

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
		/// Name Chg
		/// Description Chg
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
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
		/// <param name="m3SQNR">Sequence number</param>
		/// <param name="m3PARM">Parameter value</param>
		/// <param name="m3SETG">Search tag</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Chg(
			string m3FILE, 
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
			int? m3SQNR = null, 
			string m3PARM = null, 
			int? m3SETG = null, 
			string m3RESP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Chg",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim());

			// Set optional parameters, checking for null/blank data for each element
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
			if (m3SQNR.HasValue)
				request.WithQueryParameter("SQNR", m3SQNR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PARM))
				request.WithQueryParameter("PARM", m3PARM.Trim());
			if (m3SETG.HasValue)
				request.WithQueryParameter("SETG", m3SETG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());

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
		/// Name Del
		/// Description Del
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
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
		/// <param name="m3SQNR">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			string m3FILE, 
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
			int? m3SQNR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Del",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim());

			// Set optional parameters, checking for null/blank data for each element
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
			if (m3SQNR.HasValue)
				request.WithQueryParameter("SQNR", m3SQNR.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name List
		/// Description List
		/// Version Release: 14.1
		/// </summary>
		/// <param name="m3FILE">Table (Required)</param>
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
		/// <param name="m3SQNR">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3FILE, 
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
			int? m3SQNR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/List",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));

			// Set mandatory parameters
			request
				.WithQueryParameter("FILE", m3FILE.Trim());

			// Set optional parameters, checking for null/blank data for each element
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
			if (m3SQNR.HasValue)
				request.WithQueryParameter("SQNR", m3SQNR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ListResponse>(
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
