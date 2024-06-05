/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.COS275MI;
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
	/// Name: COS275MI
	/// Component Name: COS275MI
	/// Description: Batch Order. Maintenance Customer Order
	/// Version Release: 5ea0
	///</summary>
	public partial class COS275MIResource : M3BaseResourceEndpoint
	{
		public COS275MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "COS275MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddBatchHead
		/// Description Add Batch Order Header
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_AAGN">Agreement number</param>
		/// <param name="m3_AOTY">Order type</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_RLDT">Requested delivery date</param>
		/// <param name="m3_DWHM">Requested delivery time</param>
		/// <param name="m3_AAP1">Planned receipt date</param>
		/// <param name="m3_APTI">Planned receipt time</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_TAIL">Registration number/site</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddBatchHeadResponse></returns>
		/// <exception cref="M3Exception<AddBatchHeadResponse>"></exception>
		public async Task<M3Response<AddBatchHeadResponse>> AddBatchHead(
			string m3_CUNO, 
			int? m3_CONO = null, 
			string m3_PRNO = null, 
			string m3_BANO = null, 
			string m3_AAGN = null, 
			string m3_AOTY = null, 
			string m3_FACI = null, 
			DateTime? m3_RLDT = null, 
			int? m3_DWHM = null, 
			DateTime? m3_AAP1 = null, 
			int? m3_APTI = null, 
			string m3_CUOR = null, 
			string m3_YREF = null, 
			string m3_TAIL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBatchHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AAGN))
				request.WithQueryParameter("AAGN", m3_AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AOTY))
				request.WithQueryParameter("AOTY", m3_AOTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (m3_RLDT.HasValue)
				request.WithQueryParameter("RLDT", m3_RLDT.Value.ToM3String());
			if (m3_DWHM.HasValue)
				request.WithQueryParameter("DWHM", m3_DWHM.Value.ToString());
			if (m3_AAP1.HasValue)
				request.WithQueryParameter("AAP1", m3_AAP1.Value.ToM3String());
			if (m3_APTI.HasValue)
				request.WithQueryParameter("APTI", m3_APTI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAIL))
				request.WithQueryParameter("TAIL", m3_TAIL.Trim());

			// Execute the request
			var result = await Execute<AddBatchHeadResponse>(
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
		/// Name AddBatchLine
		/// Description Add Batch Order Line
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_AOQT">Original quantity (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_AEXT">MCO line type</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_AAP1">Planned receipt date</param>
		/// <param name="m3_APTI">Planned receipt time</param>
		/// <param name="m3_RLDT">Requested delivery date</param>
		/// <param name="m3_DWHM">Requested delivery time</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddBatchLineResponse></returns>
		/// <exception cref="M3Exception<AddBatchLineResponse>"></exception>
		public async Task<M3Response<AddBatchLineResponse>> AddBatchLine(
			string m3_ORNO, 
			string m3_PRNO, 
			decimal m3_AOQT, 
			int? m3_CONO = null, 
			int? m3_AEXT = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_BANO = null, 
			DateTime? m3_AAP1 = null, 
			int? m3_APTI = null, 
			DateTime? m3_RLDT = null, 
			int? m3_DWHM = null, 
			string m3_WHLO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBatchLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("AOQT", m3_AOQT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_AEXT.HasValue)
				request.WithQueryParameter("AEXT", m3_AEXT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_AAP1.HasValue)
				request.WithQueryParameter("AAP1", m3_AAP1.Value.ToM3String());
			if (m3_APTI.HasValue)
				request.WithQueryParameter("APTI", m3_APTI.Value.ToString());
			if (m3_RLDT.HasValue)
				request.WithQueryParameter("RLDT", m3_RLDT.Value.ToM3String());
			if (m3_DWHM.HasValue)
				request.WithQueryParameter("DWHM", m3_DWHM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());

			// Execute the request
			var result = await Execute<AddBatchLineResponse>(
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
		/// Name AddText
		/// Description Add Text for Order Head/Line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_TYPE">Order Head or Line 1=Head, 2=Line (Required)</param>
		/// <param name="m3_TYTR">Type of text, 1=Pre, 2=Post, 3=F6 (Required)</param>
		/// <param name="m3_PARM">Text (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PONR">Line number</param>
		/// <param name="m3_TXHE">Document Class</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TXEI">External/internal text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddText(
			string m3_ORNO, 
			string m3_TYPE, 
			int m3_TYTR, 
			string m3_PARM, 
			int? m3_CONO = null, 
			int? m3_PONR = null, 
			string m3_TXHE = null, 
			string m3_LNCD = null, 
			string m3_TX40 = null, 
			int? m3_TXEI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_TYPE))
				throw new ArgumentNullException("m3_TYPE");
			if (string.IsNullOrWhiteSpace(m3_PARM))
				throw new ArgumentNullException("m3_PARM");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("TYPE", m3_TYPE.Trim())
				.WithQueryParameter("TYTR", m3_TYTR.ToString())
				.WithQueryParameter("PARM", m3_PARM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TXHE))
				request.WithQueryParameter("TXHE", m3_TXHE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (m3_TXEI.HasValue)
				request.WithQueryParameter("TXEI", m3_TXEI.Value.ToString());

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
		/// Name Confirm
		/// Description Confirm Order (Release Batch)
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_CTYP">Closing type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ConfirmResponse></returns>
		/// <exception cref="M3Exception<ConfirmResponse>"></exception>
		public async Task<M3Response<ConfirmResponse>> Confirm(
			int? m3_CONO = null, 
			string m3_ORNO = null, 
			string m3_CTYP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Confirm",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTYP))
				request.WithQueryParameter("CTYP", m3_CTYP.Trim());

			// Execute the request
			var result = await Execute<ConfirmResponse>(
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
		/// Name SndBatchLine
		/// Description Snd Batch Order Line
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_AOQT">Original quantity (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_AEXT">MCO line type</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_AAP1">Planned receipt date</param>
		/// <param name="m3_APTI">Planned receipt time</param>
		/// <param name="m3_RLDT">Requested delivery date</param>
		/// <param name="m3_DWHM">Requested delivery time</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndBatchLine(
			string m3_ORNO, 
			string m3_PRNO, 
			decimal m3_AOQT, 
			int? m3_CONO = null, 
			int? m3_AEXT = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_BANO = null, 
			DateTime? m3_AAP1 = null, 
			int? m3_APTI = null, 
			DateTime? m3_RLDT = null, 
			int? m3_DWHM = null, 
			string m3_WHLO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndBatchLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("AOQT", m3_AOQT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_AEXT.HasValue)
				request.WithQueryParameter("AEXT", m3_AEXT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_AAP1.HasValue)
				request.WithQueryParameter("AAP1", m3_AAP1.Value.ToM3String());
			if (m3_APTI.HasValue)
				request.WithQueryParameter("APTI", m3_APTI.Value.ToString());
			if (m3_RLDT.HasValue)
				request.WithQueryParameter("RLDT", m3_RLDT.Value.ToM3String());
			if (m3_DWHM.HasValue)
				request.WithQueryParameter("DWHM", m3_DWHM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());

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
