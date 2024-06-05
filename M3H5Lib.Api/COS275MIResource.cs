/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3AAGN">Agreement number</param>
		/// <param name="m3AOTY">Order type</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3RLDT">Requested delivery date</param>
		/// <param name="m3DWHM">Requested delivery time</param>
		/// <param name="m3AAP1">Planned receipt date</param>
		/// <param name="m3APTI">Planned receipt time</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3TAIL">Registration number/site</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddBatchHeadResponse></returns>
		/// <exception cref="M3Exception<AddBatchHeadResponse>"></exception>
		public async Task<M3Response<AddBatchHeadResponse>> AddBatchHead(
			string m3CUNO, 
			int? m3CONO = null, 
			string m3PRNO = null, 
			string m3BANO = null, 
			string m3AAGN = null, 
			string m3AOTY = null, 
			string m3FACI = null, 
			DateTime? m3RLDT = null, 
			int? m3DWHM = null, 
			DateTime? m3AAP1 = null, 
			int? m3APTI = null, 
			string m3CUOR = null, 
			string m3YREF = null, 
			string m3TAIL = null, 
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
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AAGN))
				request.WithQueryParameter("AAGN", m3AAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3AOTY))
				request.WithQueryParameter("AOTY", m3AOTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (m3RLDT.HasValue)
				request.WithQueryParameter("RLDT", m3RLDT.Value.ToM3String());
			if (m3DWHM.HasValue)
				request.WithQueryParameter("DWHM", m3DWHM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AAP1.HasValue)
				request.WithQueryParameter("AAP1", m3AAP1.Value.ToM3String());
			if (m3APTI.HasValue)
				request.WithQueryParameter("APTI", m3APTI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAIL))
				request.WithQueryParameter("TAIL", m3TAIL.Trim());

			// Execute the request
			var result = await Execute<AddBatchHeadResponse>(
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
		/// Name AddBatchLine
		/// Description Add Batch Order Line
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3AOQT">Original quantity (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3AEXT">MCO line type</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3AAP1">Planned receipt date</param>
		/// <param name="m3APTI">Planned receipt time</param>
		/// <param name="m3RLDT">Requested delivery date</param>
		/// <param name="m3DWHM">Requested delivery time</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddBatchLineResponse></returns>
		/// <exception cref="M3Exception<AddBatchLineResponse>"></exception>
		public async Task<M3Response<AddBatchLineResponse>> AddBatchLine(
			string m3ORNO, 
			string m3PRNO, 
			decimal m3AOQT, 
			int? m3CONO = null, 
			int? m3AEXT = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3BANO = null, 
			DateTime? m3AAP1 = null, 
			int? m3APTI = null, 
			DateTime? m3RLDT = null, 
			int? m3DWHM = null, 
			string m3WHLO = null, 
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
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("AOQT", m3AOQT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AEXT.HasValue)
				request.WithQueryParameter("AEXT", m3AEXT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3AAP1.HasValue)
				request.WithQueryParameter("AAP1", m3AAP1.Value.ToM3String());
			if (m3APTI.HasValue)
				request.WithQueryParameter("APTI", m3APTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RLDT.HasValue)
				request.WithQueryParameter("RLDT", m3RLDT.Value.ToM3String());
			if (m3DWHM.HasValue)
				request.WithQueryParameter("DWHM", m3DWHM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Execute the request
			var result = await Execute<AddBatchLineResponse>(
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
		/// Name AddText
		/// Description Add Text for Order Head/Line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3TYPE">Order Head or Line 1=Head, 2=Line (Required)</param>
		/// <param name="m3TYTR">Type of text, 1=Pre, 2=Post, 3=F6 (Required)</param>
		/// <param name="m3PARM">Text (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PONR">Line number</param>
		/// <param name="m3TXHE">Document Class</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TXEI">External/internal text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddText(
			string m3ORNO, 
			string m3TYPE, 
			int m3TYTR, 
			string m3PARM, 
			int? m3CONO = null, 
			int? m3PONR = null, 
			string m3TXHE = null, 
			string m3LNCD = null, 
			string m3TX40 = null, 
			int? m3TXEI = null, 
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
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3TYPE))
				throw new ArgumentNullException(nameof(m3TYPE));
			if (string.IsNullOrWhiteSpace(m3PARM))
				throw new ArgumentNullException(nameof(m3PARM));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("TYPE", m3TYPE.Trim())
				.WithQueryParameter("TYTR", m3TYTR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PARM", m3PARM.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TXHE))
				request.WithQueryParameter("TXHE", m3TXHE.Trim());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (m3TXEI.HasValue)
				request.WithQueryParameter("TXEI", m3TXEI.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Confirm
		/// Description Confirm Order (Release Batch)
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3CTYP">Closing type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ConfirmResponse></returns>
		/// <exception cref="M3Exception<ConfirmResponse>"></exception>
		public async Task<M3Response<ConfirmResponse>> Confirm(
			int? m3CONO = null, 
			string m3ORNO = null, 
			string m3CTYP = null, 
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
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTYP))
				request.WithQueryParameter("CTYP", m3CTYP.Trim());

			// Execute the request
			var result = await Execute<ConfirmResponse>(
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
		/// Name SndBatchLine
		/// Description Snd Batch Order Line
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3AOQT">Original quantity (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3AEXT">MCO line type</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3AAP1">Planned receipt date</param>
		/// <param name="m3APTI">Planned receipt time</param>
		/// <param name="m3RLDT">Requested delivery date</param>
		/// <param name="m3DWHM">Requested delivery time</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndBatchLine(
			string m3ORNO, 
			string m3PRNO, 
			decimal m3AOQT, 
			int? m3CONO = null, 
			int? m3AEXT = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3BANO = null, 
			DateTime? m3AAP1 = null, 
			int? m3APTI = null, 
			DateTime? m3RLDT = null, 
			int? m3DWHM = null, 
			string m3WHLO = null, 
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
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("AOQT", m3AOQT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AEXT.HasValue)
				request.WithQueryParameter("AEXT", m3AEXT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3AAP1.HasValue)
				request.WithQueryParameter("AAP1", m3AAP1.Value.ToM3String());
			if (m3APTI.HasValue)
				request.WithQueryParameter("APTI", m3APTI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RLDT.HasValue)
				request.WithQueryParameter("RLDT", m3RLDT.Value.ToM3String());
			if (m3DWHM.HasValue)
				request.WithQueryParameter("DWHM", m3DWHM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());

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
