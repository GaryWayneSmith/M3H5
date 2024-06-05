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
	/// Name: ECS001MI
	/// Component Name: Cad integration - Head
	/// Description: CAD integration - Head
	/// Version Release: 11.3
	///</summary>
	public partial class ECS001MIResource : M3BaseResourceEndpoint
	{
		public ECS001MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "ECS001MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddHead
		/// Description CAD Integration - head
		/// Version Release: 11,3
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddHead(
			string m3FACI, 
			string m3PRNO, 
			int? m3CONO = null, 
			string m3STRT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());

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
		/// Name AddLines
		/// Description CAD Integration - head
		/// Version Release: 11,3
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3MSEQ">Sequence number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3MTNO">Component number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3DWPO">Drawing position</param>
		/// <param name="m3FMT1">Text1</param>
		/// <param name="m3FMT2">Text2</param>
		/// <param name="m3CNQT">Quantity</param>
		/// <param name="m3DCCD">Number of decimal plac</param>
		/// <param name="m3CCQT">Quantity on drawing</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLines(
			string m3FACI, 
			string m3PRNO, 
			int m3MSEQ, 
			int? m3CONO = null, 
			string m3MTNO = null, 
			string m3STRT = null, 
			int? m3OPNO = null, 
			string m3DWPO = null, 
			string m3FMT1 = null, 
			string m3FMT2 = null, 
			decimal? m3CNQT = null, 
			int? m3DCCD = null, 
			decimal? m3CCQT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("MSEQ", m3MSEQ.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MTNO))
				request.WithQueryParameter("MTNO", m3MTNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DWPO))
				request.WithQueryParameter("DWPO", m3DWPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMT1))
				request.WithQueryParameter("FMT1", m3FMT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMT2))
				request.WithQueryParameter("FMT2", m3FMT2.Trim());
			if (m3CNQT.HasValue)
				request.WithQueryParameter("CNQT", m3CNQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DCCD.HasValue)
				request.WithQueryParameter("DCCD", m3DCCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CCQT.HasValue)
				request.WithQueryParameter("CCQT", m3CCQT.Value.ToString(CultureInfo.CurrentCulture));

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
