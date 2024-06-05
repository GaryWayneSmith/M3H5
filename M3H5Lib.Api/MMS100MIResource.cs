/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MMS100MI;
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
	/// Name: MMS100MI
	/// Component Name: Requisition/DistributionOrder
	/// Description: Requisition/distribution orders interface
	/// Version Release: 5ea1
	///</summary>
	public partial class MMS100MIResource : M3BaseResourceEndpoint
	{
		public MMS100MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS100MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddDOLine
		/// Description Adds a new line to an existing Distribution order
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_TRNR">Order number (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_TRQT">Transaction quantity - basic U/M (Required)</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TIHM">Time hours & minutes</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_TWSL">To location</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_REFE">Reference</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddDOLineResponse></returns>
		/// <exception cref="M3Exception<AddDOLineResponse>"></exception>
		public async Task<M3Response<AddDOLineResponse>> AddDOLine(
			string m3_TRNR, 
			string m3_ITNO, 
			decimal m3_TRQT, 
			string m3_WHLO = null, 
			string m3_ALUN = null, 
			DateTime? m3_TRDT = null, 
			int? m3_TIHM = null, 
			string m3_WHSL = null, 
			string m3_TWSL = null, 
			string m3_RSCD = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			decimal? m3_CAWE = null, 
			string m3_BREM = null, 
			string m3_REFE = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDOLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TRNR))
				throw new ArgumentNullException("m3_TRNR");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("TRNR", m3_TRNR.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("TRQT", m3_TRQT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TIHM.HasValue)
				request.WithQueryParameter("TIHM", m3_TIHM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWSL))
				request.WithQueryParameter("TWSL", m3_TWSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REFE))
				request.WithQueryParameter("REFE", m3_REFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());

			// Execute the request
			var result = await Execute<AddDOLineResponse>(
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
		/// Name DltDOLine
		/// Description Deletes a line from a disribution order
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_TRNR">Order number (Required)</param>
		/// <param name="m3_PONR">Order line number (Required)</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltDOLine(
			string m3_TRNR, 
			int m3_PONR, 
			int? m3_POSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltDOLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TRNR))
				throw new ArgumentNullException("m3_TRNR");

			// Set mandatory parameters
			request
				.WithQueryParameter("TRNR", m3_TRNR.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());

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
		/// Name GetHead
		/// Description Get all information about the Req/Distr Order Head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_TRNR">Order number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadResponse></returns>
		/// <exception cref="M3Exception<GetHeadResponse>"></exception>
		public async Task<M3Response<GetHeadResponse>> GetHead(
			string m3_TRNR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TRNR))
				throw new ArgumentNullException("m3_TRNR");

			// Set mandatory parameters
			request
				.WithQueryParameter("TRNR", m3_TRNR.Trim());

			// Execute the request
			var result = await Execute<GetHeadResponse>(
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
		/// Name GetLine
		/// Description Get all the information about the Req/Distr Order Line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_TRNR">Order number (Required)</param>
		/// <param name="m3_PONR">Order line number (Required)</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLineResponse></returns>
		/// <exception cref="M3Exception<GetLineResponse>"></exception>
		public async Task<M3Response<GetLineResponse>> GetLine(
			string m3_TRNR, 
			string m3_PONR, 
			string m3_POSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TRNR))
				throw new ArgumentNullException("m3_TRNR");
			if (string.IsNullOrWhiteSpace(m3_PONR))
				throw new ArgumentNullException("m3_PONR");

			// Set mandatory parameters
			request
				.WithQueryParameter("TRNR", m3_TRNR.Trim())
				.WithQueryParameter("PONR", m3_PONR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_POSX))
				request.WithQueryParameter("POSX", m3_POSX.Trim());

			// Execute the request
			var result = await Execute<GetLineResponse>(
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
		/// Name LstLines
		/// Description List all the information about the Req/Distr Order Line
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_TRNR">Order number (Required)</param>
		/// <param name="m3_PONR">Order line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLinesResponse></returns>
		/// <exception cref="M3Exception<LstLinesResponse>"></exception>
		public async Task<M3Response<LstLinesResponse>> LstLines(
			string m3_TRNR, 
			string m3_PONR = null, 
			string m3_POSX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_TRNR))
				throw new ArgumentNullException("m3_TRNR");

			// Set mandatory parameters
			request
				.WithQueryParameter("TRNR", m3_TRNR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PONR))
				request.WithQueryParameter("PONR", m3_PONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POSX))
				request.WithQueryParameter("POSX", m3_POSX.Trim());

			// Execute the request
			var result = await Execute<LstLinesResponse>(
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
		/// Name SearchHead
		/// Description Search head
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchHeadResponse></returns>
		/// <exception cref="M3Exception<SearchHeadResponse>"></exception>
		public async Task<M3Response<SearchHeadResponse>> SearchHead(
			string m3_SQRY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SQRY))
				throw new ArgumentNullException("m3_SQRY");

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchHeadResponse>(
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
		/// Name SearchLine
		/// Description Search line
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchLineResponse></returns>
		/// <exception cref="M3Exception<SearchLineResponse>"></exception>
		public async Task<M3Response<SearchLineResponse>> SearchLine(
			string m3_SQRY, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SQRY))
				throw new ArgumentNullException("m3_SQRY");

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchLineResponse>(
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
		/// Name SelLines
		/// Description Select Requisition/Distribution Order Lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHGR">Warehouse group (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FTTP">From Transaction Type</param>
		/// <param name="m3_TTTP">To Transaction Type</param>
		/// <param name="m3_FTRS">From (line) status</param>
		/// <param name="m3_TTRS">To (line) status</param>
		/// <param name="m3_DEDR">De-select external distribution records</param>
		/// <param name="m3_SCHH">Scheduling horizon</param>
		/// <param name="m3_APIP">APS-policy</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelLinesResponse></returns>
		/// <exception cref="M3Exception<SelLinesResponse>"></exception>
		public async Task<M3Response<SelLinesResponse>> SelLines(
			string m3_WHGR, 
			int? m3_CONO = null, 
			int? m3_FTTP = null, 
			int? m3_TTTP = null, 
			string m3_FTRS = null, 
			string m3_TTRS = null, 
			int? m3_DEDR = null, 
			int? m3_SCHH = null, 
			string m3_APIP = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SelLines",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHGR))
				throw new ArgumentNullException("m3_WHGR");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHGR", m3_WHGR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_FTTP.HasValue)
				request.WithQueryParameter("FTTP", m3_FTTP.Value.ToString());
			if (m3_TTTP.HasValue)
				request.WithQueryParameter("TTTP", m3_TTTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FTRS))
				request.WithQueryParameter("FTRS", m3_FTRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TTRS))
				request.WithQueryParameter("TTRS", m3_TTRS.Trim());
			if (m3_DEDR.HasValue)
				request.WithQueryParameter("DEDR", m3_DEDR.Value.ToString());
			if (m3_SCHH.HasValue)
				request.WithQueryParameter("SCHH", m3_SCHH.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_APIP))
				request.WithQueryParameter("APIP", m3_APIP.Trim());

			// Execute the request
			var result = await Execute<SelLinesResponse>(
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
		/// Name UpdDateQtyRelDO
		/// Description UpdDateQtyRelDO
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_TRNR">Order number</param>
		/// <param name="m3_PONR">Order line number</param>
		/// <param name="m3_POSX">Line suffix</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_TIHM">Time hours & minutes</param>
		/// <param name="m3_TRQT">Transaction quantity - basic U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdDateQtyRelDO(
			string m3_TRNR = null, 
			int? m3_PONR = null, 
			int? m3_POSX = null, 
			DateTime? m3_TRDT = null, 
			int? m3_TIHM = null, 
			decimal? m3_TRQT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdDateQtyRelDO",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_TRNR))
				request.WithQueryParameter("TRNR", m3_TRNR.Trim());
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_POSX.HasValue)
				request.WithQueryParameter("POSX", m3_POSX.Value.ToString());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_TIHM.HasValue)
				request.WithQueryParameter("TIHM", m3_TIHM.Value.ToString());
			if (m3_TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3_TRQT.Value.ToString());

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
