/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MMS059MI;
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
	/// Name: MMS059MI
	/// Component Name: SupplyModelOpenLines
	/// Description: Supply model. Open lines
	/// Version Release: 5e90
	///</summary>
	public partial class MMS059MIResource : M3BaseResourceEndpoint
	{
		public MMS059MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS059MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_SPLM">Supply model (Required)</param>
		/// <param name="m3_PREX">Priority (Required)</param>
		/// <param name="m3_SPLA">Alternative (Required)</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_QQTY">Quantity</param>
		/// <param name="m3_SRCC">Supply source</param>
		/// <param name="m3_FWHL">From warehouse</param>
		/// <param name="m3_TWHL">To warehouse</param>
		/// <param name="m3_TRTP">Order type</param>
		/// <param name="m3_DSCH">Distribution chain</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_AFL6">Replace item</param>
		/// <param name="m3_LTYP">Line type</param>
		/// <param name="m3_AOPT">Automatic option</param>
		/// <param name="m3_BCKO">Backorder</param>
		/// <param name="m3_PADL">Partial delivery</param>
		/// <param name="m3_SPLP">Split on alternative</param>
		/// <param name="m3_PALT">Selected alternative</param>
		/// <param name="m3_CTPC">Capacity-to-promise check</param>
		/// <param name="m3_MTPC">Material-to-promise check</param>
		/// <param name="m3_TTPC">Transportation-to-promise check</param>
		/// <param name="m3_ATLE">ATP level</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_SPLM, 
			string m3_PREX, 
			int m3_SPLA, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			DateTime? m3_FDAT = null, 
			DateTime? m3_TDAT = null, 
			decimal? m3_QQTY = null, 
			int? m3_SRCC = null, 
			string m3_FWHL = null, 
			string m3_TWHL = null, 
			string m3_TRTP = null, 
			string m3_DSCH = null, 
			string m3_ORTY = null, 
			string m3_SUNO = null, 
			string m3_ITNO = null, 
			int? m3_AFL6 = null, 
			string m3_LTYP = null, 
			int? m3_AOPT = null, 
			int? m3_BCKO = null, 
			int? m3_PADL = null, 
			int? m3_SPLP = null, 
			int? m3_PALT = null, 
			int? m3_CTPC = null, 
			int? m3_MTPC = null, 
			int? m3_TTPC = null, 
			string m3_ATLE = null, 
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
			if (string.IsNullOrWhiteSpace(m3_SPLM))
				throw new ArgumentNullException("m3_SPLM");
			if (string.IsNullOrWhiteSpace(m3_PREX))
				throw new ArgumentNullException("m3_PREX");

			// Set mandatory parameters
			request
				.WithQueryParameter("SPLM", m3_SPLM.Trim())
				.WithQueryParameter("PREX", m3_PREX.Trim())
				.WithQueryParameter("SPLA", m3_SPLA.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());
			if (m3_QQTY.HasValue)
				request.WithQueryParameter("QQTY", m3_QQTY.Value.ToString());
			if (m3_SRCC.HasValue)
				request.WithQueryParameter("SRCC", m3_SRCC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FWHL))
				request.WithQueryParameter("FWHL", m3_FWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWHL))
				request.WithQueryParameter("TWHL", m3_TWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRTP))
				request.WithQueryParameter("TRTP", m3_TRTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSCH))
				request.WithQueryParameter("DSCH", m3_DSCH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_AFL6.HasValue)
				request.WithQueryParameter("AFL6", m3_AFL6.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LTYP))
				request.WithQueryParameter("LTYP", m3_LTYP.Trim());
			if (m3_AOPT.HasValue)
				request.WithQueryParameter("AOPT", m3_AOPT.Value.ToString());
			if (m3_BCKO.HasValue)
				request.WithQueryParameter("BCKO", m3_BCKO.Value.ToString());
			if (m3_PADL.HasValue)
				request.WithQueryParameter("PADL", m3_PADL.Value.ToString());
			if (m3_SPLP.HasValue)
				request.WithQueryParameter("SPLP", m3_SPLP.Value.ToString());
			if (m3_PALT.HasValue)
				request.WithQueryParameter("PALT", m3_PALT.Value.ToString());
			if (m3_CTPC.HasValue)
				request.WithQueryParameter("CTPC", m3_CTPC.Value.ToString());
			if (m3_MTPC.HasValue)
				request.WithQueryParameter("MTPC", m3_MTPC.Value.ToString());
			if (m3_TTPC.HasValue)
				request.WithQueryParameter("TTPC", m3_TTPC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ATLE))
				request.WithQueryParameter("ATLE", m3_ATLE.Trim());

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
		/// Name Delete
		/// Description Delete a record
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_SPLM">Supply model (Required)</param>
		/// <param name="m3_PREX">Priority (Required)</param>
		/// <param name="m3_SPLA">Alternative (Required)</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_QQTY">Quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3_SPLM, 
			string m3_PREX, 
			int m3_SPLA, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			DateTime? m3_FDAT = null, 
			decimal? m3_QQTY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Delete",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SPLM))
				throw new ArgumentNullException("m3_SPLM");
			if (string.IsNullOrWhiteSpace(m3_PREX))
				throw new ArgumentNullException("m3_PREX");

			// Set mandatory parameters
			request
				.WithQueryParameter("SPLM", m3_SPLM.Trim())
				.WithQueryParameter("PREX", m3_PREX.Trim())
				.WithQueryParameter("SPLA", m3_SPLA.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_QQTY.HasValue)
				request.WithQueryParameter("QQTY", m3_QQTY.Value.ToString());

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
		/// Name Get
		/// Description Get Equipment group
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_SPLM">Supply model (Required)</param>
		/// <param name="m3_PREX">Priority (Required)</param>
		/// <param name="m3_SPLA">Alternative (Required)</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_QQTY">Quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_SPLM, 
			string m3_PREX, 
			int m3_SPLA, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			DateTime? m3_FDAT = null, 
			decimal? m3_QQTY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SPLM))
				throw new ArgumentNullException("m3_SPLM");
			if (string.IsNullOrWhiteSpace(m3_PREX))
				throw new ArgumentNullException("m3_PREX");

			// Set mandatory parameters
			request
				.WithQueryParameter("SPLM", m3_SPLM.Trim())
				.WithQueryParameter("PREX", m3_PREX.Trim())
				.WithQueryParameter("SPLA", m3_SPLA.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_QQTY.HasValue)
				request.WithQueryParameter("QQTY", m3_QQTY.Value.ToString());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Name List
		/// Description List records
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_SPLM">Supply model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3_SPLM = null, 
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

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SPLM))
				request.WithQueryParameter("SPLM", m3_SPLM.Trim());

			// Execute the request
			var result = await Execute<ListResponse>(
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
		/// Name Update
		/// Description Update a record
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_SPLM">Supply model (Required)</param>
		/// <param name="m3_PREX">Priority (Required)</param>
		/// <param name="m3_SPLA">Alternative (Required)</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="m3_OBV4">Start value 4</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_QQTY">Quantity</param>
		/// <param name="m3_SRCC">Supply source</param>
		/// <param name="m3_FWHL">From warehouse</param>
		/// <param name="m3_TWHL">To warehouse</param>
		/// <param name="m3_TRTP">Order type</param>
		/// <param name="m3_DSCH">Distribution chain</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_SUNO">Supplier</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_AFL6">Replace item</param>
		/// <param name="m3_LTYP">Line type</param>
		/// <param name="m3_AOPT">Automatic option</param>
		/// <param name="m3_BCKO">Backorder</param>
		/// <param name="m3_PADL">Partial delivery</param>
		/// <param name="m3_SPLP">Split on alternative</param>
		/// <param name="m3_PALT">Selected alternative</param>
		/// <param name="m3_CTPC">Capacity-to-promise check</param>
		/// <param name="m3_MTPC">Material-to-promise check</param>
		/// <param name="m3_TTPC">Transportation-to-promise check</param>
		/// <param name="m3_ATLE">ATP level</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Update(
			string m3_SPLM, 
			string m3_PREX, 
			int m3_SPLA, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_OBV4 = null, 
			DateTime? m3_FDAT = null, 
			DateTime? m3_TDAT = null, 
			decimal? m3_QQTY = null, 
			int? m3_SRCC = null, 
			string m3_FWHL = null, 
			string m3_TWHL = null, 
			string m3_TRTP = null, 
			string m3_DSCH = null, 
			string m3_ORTY = null, 
			string m3_SUNO = null, 
			string m3_ITNO = null, 
			int? m3_AFL6 = null, 
			string m3_LTYP = null, 
			int? m3_AOPT = null, 
			int? m3_BCKO = null, 
			int? m3_PADL = null, 
			int? m3_SPLP = null, 
			int? m3_PALT = null, 
			int? m3_CTPC = null, 
			int? m3_MTPC = null, 
			int? m3_TTPC = null, 
			string m3_ATLE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Update",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SPLM))
				throw new ArgumentNullException("m3_SPLM");
			if (string.IsNullOrWhiteSpace(m3_PREX))
				throw new ArgumentNullException("m3_PREX");

			// Set mandatory parameters
			request
				.WithQueryParameter("SPLM", m3_SPLM.Trim())
				.WithQueryParameter("PREX", m3_PREX.Trim())
				.WithQueryParameter("SPLA", m3_SPLA.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV4))
				request.WithQueryParameter("OBV4", m3_OBV4.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());
			if (m3_QQTY.HasValue)
				request.WithQueryParameter("QQTY", m3_QQTY.Value.ToString());
			if (m3_SRCC.HasValue)
				request.WithQueryParameter("SRCC", m3_SRCC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FWHL))
				request.WithQueryParameter("FWHL", m3_FWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWHL))
				request.WithQueryParameter("TWHL", m3_TWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRTP))
				request.WithQueryParameter("TRTP", m3_TRTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DSCH))
				request.WithQueryParameter("DSCH", m3_DSCH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_AFL6.HasValue)
				request.WithQueryParameter("AFL6", m3_AFL6.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LTYP))
				request.WithQueryParameter("LTYP", m3_LTYP.Trim());
			if (m3_AOPT.HasValue)
				request.WithQueryParameter("AOPT", m3_AOPT.Value.ToString());
			if (m3_BCKO.HasValue)
				request.WithQueryParameter("BCKO", m3_BCKO.Value.ToString());
			if (m3_PADL.HasValue)
				request.WithQueryParameter("PADL", m3_PADL.Value.ToString());
			if (m3_SPLP.HasValue)
				request.WithQueryParameter("SPLP", m3_SPLP.Value.ToString());
			if (m3_PALT.HasValue)
				request.WithQueryParameter("PALT", m3_PALT.Value.ToString());
			if (m3_CTPC.HasValue)
				request.WithQueryParameter("CTPC", m3_CTPC.Value.ToString());
			if (m3_MTPC.HasValue)
				request.WithQueryParameter("MTPC", m3_MTPC.Value.ToString());
			if (m3_TTPC.HasValue)
				request.WithQueryParameter("TTPC", m3_TTPC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ATLE))
				request.WithQueryParameter("ATLE", m3_ATLE.Trim());

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
