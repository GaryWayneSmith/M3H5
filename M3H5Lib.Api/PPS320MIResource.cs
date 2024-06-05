/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.PPS320MI;
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
	/// Name: PPS320MI
	/// Component Name: Put Away PO
	/// Description: Api: Put-Away PO
	/// Version Release: 5ea1
	///</summary>
	public partial class PPS320MIResource : M3BaseResourceEndpoint
	{
		public PPS320MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPS320MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name ClosePADelNote
		/// Description Close put-away delivery note
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3SUDO">Delivery note number (Required)</param>
		/// <param name="m3DNDT">Delivery note date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ClosePADelNote(
			string m3WHLO, 
			string m3SUNO, 
			string m3SUDO, 
			DateTime m3DNDT, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ClosePADelNote",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));
			if (string.IsNullOrWhiteSpace(m3SUDO))
				throw new ArgumentNullException(nameof(m3SUDO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("SUDO", m3SUDO.Trim())
				.WithQueryParameter("DNDT", m3DNDT.ToM3String());

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
		/// Name GetPADataPO
		/// Description Get put-away data for purchase order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3REPN">Receiving number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPADataPOResponse></returns>
		/// <exception cref="M3Exception<GetPADataPOResponse>"></exception>
		public async Task<M3Response<GetPADataPOResponse>> GetPADataPO(
			long m3REPN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetPADataPO",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("REPN", m3REPN.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetPADataPOResponse>(
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
		/// Name LstBalIDPA
		/// Description List Balance ID
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3REPN">Receiving number</param>
		/// <param name="m3WHLT">Location type</param>
		/// <param name="m3ALOC">Allocatable</param>
		/// <param name="m3FSLT">From stock zone</param>
		/// <param name="m3TSLT">To stock zone</param>
		/// <param name="m3ISLT">Include stock zone</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBalIDPAResponse></returns>
		/// <exception cref="M3Exception<LstBalIDPAResponse>"></exception>
		public async Task<M3Response<LstBalIDPAResponse>> LstBalIDPA(
			string m3WHLO = null, 
			string m3ITNO = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			long? m3REPN = null, 
			string m3WHLT = null, 
			int? m3ALOC = null, 
			string m3FSLT = null, 
			string m3TSLT = null, 
			string m3ISLT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstBalIDPA",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3REPN.HasValue)
				request.WithQueryParameter("REPN", m3REPN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHLT))
				request.WithQueryParameter("WHLT", m3WHLT.Trim());
			if (m3ALOC.HasValue)
				request.WithQueryParameter("ALOC", m3ALOC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FSLT))
				request.WithQueryParameter("FSLT", m3FSLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSLT))
				request.WithQueryParameter("TSLT", m3TSLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ISLT))
				request.WithQueryParameter("ISLT", m3ISLT.Trim());

			// Execute the request
			var result = await Execute<LstBalIDPAResponse>(
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
		/// Name LstPADataPO
		/// Description List put-away data PO
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3REPN">Receiving number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPADataPOResponse></returns>
		/// <exception cref="M3Exception<LstPADataPOResponse>"></exception>
		public async Task<M3Response<LstPADataPOResponse>> LstPADataPO(
			long m3REPN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPADataPO",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("REPN", m3REPN.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPADataPOResponse>(
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
		/// Name LstPADataPack
		/// Description List put-away data for package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPADataPackResponse></returns>
		/// <exception cref="M3Exception<LstPADataPackResponse>"></exception>
		public async Task<M3Response<LstPADataPackResponse>> LstPADataPack(
			string m3PACN = null, 
			string m3WHLO = null, 
			string m3SUNO = null, 
			string m3SUDO = null, 
			DateTime? m3DNDT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPADataPack",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstPADataPackResponse>(
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
		/// Name LstPADataSSCC
		/// Description List put-away data for SSCC number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SSCC">SSCC number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPADataSSCCResponse></returns>
		/// <exception cref="M3Exception<LstPADataSSCCResponse>"></exception>
		public async Task<M3Response<LstPADataSSCCResponse>> LstPADataSSCC(
			string m3SSCC, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPADataSSCC",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SSCC))
				throw new ArgumentNullException(nameof(m3SSCC));

			// Set mandatory parameters
			request
				.WithQueryParameter("SSCC", m3SSCC.Trim());

			// Execute the request
			var result = await Execute<LstPADataSSCCResponse>(
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
		/// Name LstReceivedPO
		/// Description List Received Purchase Order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstReceivedPOResponse></returns>
		/// <exception cref="M3Exception<LstReceivedPOResponse>"></exception>
		public async Task<M3Response<LstReceivedPOResponse>> LstReceivedPO(
			string m3PUNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstReceivedPO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim());

			// Execute the request
			var result = await Execute<LstReceivedPOResponse>(
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
		/// Name PutawayPO
		/// Description Put-away Purchase Order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3REPN">Receiving number (Required)</param>
		/// <param name="m3RESP">Responsible (Required)</param>
		/// <param name="m3RPQA">Reported quantity in alternative unit (Required)</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3TRTM">Transaction time</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3OEND">Flagged as completed</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3PRDT">Priority date</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3NOPK">Number of packages</param>
		/// <param name="m3DSP1">Warning indicator 1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PutawayPO(
			long m3REPN, 
			string m3RESP, 
			decimal m3RPQA, 
			DateTime? m3TRDT = null, 
			int? m3TRTM = null, 
			string m3WHSL = null, 
			int? m3OEND = null, 
			string m3BANO = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			string m3CAMU = null, 
			decimal? m3CAWE = null, 
			DateTime? m3PRDT = null, 
			string m3BREM = null, 
			int? m3NOPK = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/PutawayPO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RESP))
				throw new ArgumentNullException(nameof(m3RESP));

			// Set mandatory parameters
			request
				.WithQueryParameter("REPN", m3REPN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RESP", m3RESP.Trim())
				.WithQueryParameter("RPQA", m3RPQA.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (m3NOPK.HasValue)
				request.WithQueryParameter("NOPK", m3NOPK.Value.ToString(CultureInfo.CurrentCulture));
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
		/// Name PutawayPack
		/// Description Put-away package level
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RESP">Responsible (Required)</param>
		/// <param name="m3PACN">Package number</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3TRTM">Transaction time</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PutawayPack(
			string m3RESP, 
			string m3PACN = null, 
			string m3WHLO = null, 
			string m3SUNO = null, 
			string m3SUDO = null, 
			DateTime? m3DNDT = null, 
			DateTime? m3TRDT = null, 
			int? m3TRTM = null, 
			string m3WHSL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/PutawayPack",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RESP))
				throw new ArgumentNullException(nameof(m3RESP));

			// Set mandatory parameters
			request
				.WithQueryParameter("RESP", m3RESP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());

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
		/// Name PutawayPackBld
		/// Description Put-away package level and include in
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PACN">Package number (Required)</param>
		/// <param name="m3RESP">Responsible (Required)</param>
		/// <param name="m3PACC">Included in package number (Required)</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3TRTM">Transaction time</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PutawayPackBld(
			string m3PACN, 
			string m3RESP, 
			string m3PACC, 
			DateTime? m3TRDT = null, 
			int? m3TRTM = null, 
			string m3WHSL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/PutawayPackBld",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PACN))
				throw new ArgumentNullException(nameof(m3PACN));
			if (string.IsNullOrWhiteSpace(m3RESP))
				throw new ArgumentNullException(nameof(m3RESP));
			if (string.IsNullOrWhiteSpace(m3PACC))
				throw new ArgumentNullException(nameof(m3PACC));

			// Set mandatory parameters
			request
				.WithQueryParameter("PACN", m3PACN.Trim())
				.WithQueryParameter("RESP", m3RESP.Trim())
				.WithQueryParameter("PACC", m3PACC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());

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
		/// Name PutawaySSCC
		/// Description Put-away on SSCC number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SSCC">SSCC number (Required)</param>
		/// <param name="m3RESP">Responsible (Required)</param>
		/// <param name="m3TRDT">Transaction date</param>
		/// <param name="m3TRTM">Transaction time</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PutawaySSCC(
			string m3SSCC, 
			string m3RESP, 
			DateTime? m3TRDT = null, 
			int? m3TRTM = null, 
			string m3WHSL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/PutawaySSCC",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SSCC))
				throw new ArgumentNullException(nameof(m3SSCC));
			if (string.IsNullOrWhiteSpace(m3RESP))
				throw new ArgumentNullException(nameof(m3RESP));

			// Set mandatory parameters
			request
				.WithQueryParameter("SSCC", m3SSCC.Trim())
				.WithQueryParameter("RESP", m3RESP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3TRDT.Value.ToM3String());
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());

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
