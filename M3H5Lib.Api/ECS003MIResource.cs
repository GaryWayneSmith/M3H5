/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.ECS003MI;
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
	/// Name: ECS003MI
	/// Component Name: Service Revision
	/// Description: Material/Op. Connect Feature/Options
	/// Version Release: 5ea0
	///</summary>
	public partial class ECS003MIResource : M3BaseResourceEndpoint
	{
		public ECS003MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "ECS003MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add Option Feature
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3ECVE">Revision number (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3OTYP">Selection type</param>
		/// <param name="m3FTID">Selection identity</param>
		/// <param name="m3OPTN">Option</param>
		/// <param name="m3INCE">Include/exclude product strukture line</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3FACI, 
			string m3SUFI, 
			string m3ECVE, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3MSEQ = null, 
			int? m3OPNO = null, 
			string m3OTYP = null, 
			string m3FTID = null, 
			string m3OPTN = null, 
			string m3INCE = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));
			if (string.IsNullOrWhiteSpace(m3ECVE))
				throw new ArgumentNullException(nameof(m3ECVE));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("ECVE", m3ECVE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OTYP))
				request.WithQueryParameter("OTYP", m3OTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FTID))
				request.WithQueryParameter("FTID", m3FTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTN))
				request.WithQueryParameter("OPTN", m3OPTN.Trim());
			if (!string.IsNullOrWhiteSpace(m3INCE))
				request.WithQueryParameter("INCE", m3INCE.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Description Delete Option Feature
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3ECVE">Revision number (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3OTYP">Selection type</param>
		/// <param name="m3FTID">Selection identity</param>
		/// <param name="m3OPTN">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			string m3FACI, 
			string m3SUFI, 
			string m3ECVE, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3MSEQ = null, 
			int? m3OPNO = null, 
			string m3OTYP = null, 
			string m3FTID = null, 
			string m3OPTN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Del",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));
			if (string.IsNullOrWhiteSpace(m3ECVE))
				throw new ArgumentNullException(nameof(m3ECVE));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("ECVE", m3ECVE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OTYP))
				request.WithQueryParameter("OTYP", m3OTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FTID))
				request.WithQueryParameter("FTID", m3FTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTN))
				request.WithQueryParameter("OPTN", m3OPTN.Trim());

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
		/// Name Get
		/// Description Get Option Feature
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3ECVE">Revision number (Required)</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3OTYP">Selection type</param>
		/// <param name="m3FTID">Selection identity</param>
		/// <param name="m3OPTN">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3SUFI, 
			string m3ECVE, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3MSEQ = null, 
			int? m3OPNO = null, 
			string m3OTYP = null, 
			string m3FTID = null, 
			string m3OPTN = null, 
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

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));
			if (string.IsNullOrWhiteSpace(m3ECVE))
				throw new ArgumentNullException(nameof(m3ECVE));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("ECVE", m3ECVE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OTYP))
				request.WithQueryParameter("OTYP", m3OTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FTID))
				request.WithQueryParameter("FTID", m3FTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTN))
				request.WithQueryParameter("OPTN", m3OPTN.Trim());

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
		/// Name LstService
		/// Description List Option Feature for Service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3OTYP">Selection type</param>
		/// <param name="m3FTID">Selection identity</param>
		/// <param name="m3OPTN">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstServiceResponse></returns>
		/// <exception cref="M3Exception<LstServiceResponse>"></exception>
		public async Task<M3Response<LstServiceResponse>> LstService(
			string m3FACI, 
			string m3SUFI, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3ECVE = null, 
			int? m3MSEQ = null, 
			int? m3OPNO = null, 
			string m3OTYP = null, 
			string m3FTID = null, 
			string m3OPTN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstService",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("SUFI", m3SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OTYP))
				request.WithQueryParameter("OTYP", m3OTYP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FTID))
				request.WithQueryParameter("FTID", m3FTID.Trim());
			if (!string.IsNullOrWhiteSpace(m3OPTN))
				request.WithQueryParameter("OPTN", m3OPTN.Trim());

			// Execute the request
			var result = await Execute<LstServiceResponse>(
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
