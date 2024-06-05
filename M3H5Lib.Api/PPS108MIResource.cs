/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PPS108MI;
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
	/// Name: PPS108MI
	/// Component Name: ConnectBaseOrigin
	/// Description: Agreement. Connect base origin
	/// Version Release: 5e90
	///</summary>
	public partial class PPS108MIResource : M3BaseResourceEndpoint
	{
		public PPS108MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPS108MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddBaseOrigin
		/// Description Add to Base Origin table
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_RIDI">Delivery number (Required)</param>
		/// <param name="m3_BANO">Lot number (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_CRQT">Carryover quantity</param>
		/// <param name="m3_CRQA">Carryover quantity approved</param>
		/// <param name="m3_DSP1">Flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBaseOrigin(
			string m3_SUNO, 
			string m3_AGNB, 
			int m3_SEQN, 
			string m3_RIDN, 
			int m3_RIDL, 
			decimal m3_RIDI, 
			string m3_BANO, 
			string m3_ITNO, 
			int? m3_RIDX = null, 
			decimal? m3_TRQT = null, 
			DateTime? m3_TRDT = null, 
			decimal? m3_CRQT = null, 
			int? m3_CRQA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBaseOrigin",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString())
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString())
				.WithQueryParameter("RIDI", m3_RIDI.ToString())
				.WithQueryParameter("BANO", m3_BANO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (m3_TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3_TRQT.Value.ToString());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_CRQT.HasValue)
				request.WithQueryParameter("CRQT", m3_CRQT.Value.ToString());
			if (m3_CRQA.HasValue)
				request.WithQueryParameter("CRQA", m3_CRQA.Value.ToString());
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
		/// Name DltBaseOrigin
		/// Description Delete in Base Origin table
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_RIDI">Delivery number (Required)</param>
		/// <param name="m3_BANO">Lot number (Required)</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltBaseOrigin(
			string m3_SUNO, 
			string m3_AGNB, 
			int m3_SEQN, 
			string m3_RIDN, 
			int m3_RIDL, 
			decimal m3_RIDI, 
			string m3_BANO, 
			int? m3_RIDX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltBaseOrigin",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString())
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString())
				.WithQueryParameter("RIDI", m3_RIDI.ToString())
				.WithQueryParameter("BANO", m3_BANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());

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
		/// Name GetBaseOrigin
		/// Description Retrieve record from Base Origin table
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_RIDI">Delivery number (Required)</param>
		/// <param name="m3_BANO">Lot number (Required)</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBaseOriginResponse></returns>
		/// <exception cref="M3Exception<GetBaseOriginResponse>"></exception>
		public async Task<M3Response<GetBaseOriginResponse>> GetBaseOrigin(
			string m3_SUNO, 
			string m3_AGNB, 
			int m3_SEQN, 
			string m3_RIDN, 
			int m3_RIDL, 
			decimal m3_RIDI, 
			string m3_BANO, 
			int? m3_RIDX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBaseOrigin",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString())
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString())
				.WithQueryParameter("RIDI", m3_RIDI.ToString())
				.WithQueryParameter("BANO", m3_BANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());

			// Execute the request
			var result = await Execute<GetBaseOriginResponse>(
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
		/// Name LstBaseOrigin
		/// Description List data from Base Origin table
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBaseOriginResponse></returns>
		/// <exception cref="M3Exception<LstBaseOriginResponse>"></exception>
		public async Task<M3Response<LstBaseOriginResponse>> LstBaseOrigin(
			string m3_SUNO, 
			string m3_AGNB, 
			int m3_SEQN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBaseOrigin",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString());

			// Execute the request
			var result = await Execute<LstBaseOriginResponse>(
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
		/// Name UpdBaseOrigin
		/// Description Update in Base Origin table
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_SUNO">Supplier (Required)</param>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_SEQN">Sequence number (Required)</param>
		/// <param name="m3_RIDN">Order number (Required)</param>
		/// <param name="m3_RIDL">Order line (Required)</param>
		/// <param name="m3_RIDI">Delivery number (Required)</param>
		/// <param name="m3_BANO">Lot number (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_RIDX">Line suffix</param>
		/// <param name="m3_TRQT">Transaction quantity - basic U/M</param>
		/// <param name="m3_TRDT">Transaction date</param>
		/// <param name="m3_CRQT">Carryover quantity</param>
		/// <param name="m3_CRQA">Carryover quantity approved</param>
		/// <param name="m3_DSP1">Flag</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdBaseOrigin(
			string m3_SUNO, 
			string m3_AGNB, 
			int m3_SEQN, 
			string m3_RIDN, 
			int m3_RIDL, 
			decimal m3_RIDI, 
			string m3_BANO, 
			string m3_ITNO, 
			int? m3_RIDX = null, 
			decimal? m3_TRQT = null, 
			DateTime? m3_TRDT = null, 
			decimal? m3_CRQT = null, 
			int? m3_CRQA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdBaseOrigin",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");
			if (string.IsNullOrWhiteSpace(m3_RIDN))
				throw new ArgumentNullException("m3_RIDN");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("SEQN", m3_SEQN.ToString())
				.WithQueryParameter("RIDN", m3_RIDN.Trim())
				.WithQueryParameter("RIDL", m3_RIDL.ToString())
				.WithQueryParameter("RIDI", m3_RIDI.ToString())
				.WithQueryParameter("BANO", m3_BANO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3_RIDX.Value.ToString());
			if (m3_TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3_TRQT.Value.ToString());
			if (m3_TRDT.HasValue)
				request.WithQueryParameter("TRDT", m3_TRDT.Value.ToM3String());
			if (m3_CRQT.HasValue)
				request.WithQueryParameter("CRQT", m3_CRQT.Value.ToString());
			if (m3_CRQA.HasValue)
				request.WithQueryParameter("CRQA", m3_CRQA.Value.ToString());
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
	}
}
// EOF
