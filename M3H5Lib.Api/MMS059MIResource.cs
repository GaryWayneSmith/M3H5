/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3SPLM">Supply model (Required)</param>
		/// <param name="m3PREX">Priority (Required)</param>
		/// <param name="m3SPLA">Alternative (Required)</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3QQTY">Quantity</param>
		/// <param name="m3SRCC">Supply source</param>
		/// <param name="m3FWHL">From warehouse</param>
		/// <param name="m3TWHL">To warehouse</param>
		/// <param name="m3TRTP">Order type</param>
		/// <param name="m3DSCH">Distribution chain</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3AFL6">Replace item</param>
		/// <param name="m3LTYP">Line type</param>
		/// <param name="m3AOPT">Automatic option</param>
		/// <param name="m3BCKO">Backorder</param>
		/// <param name="m3PADL">Partial delivery</param>
		/// <param name="m3SPLP">Split on alternative</param>
		/// <param name="m3PALT">Selected alternative</param>
		/// <param name="m3CTPC">Capacity-to-promise check</param>
		/// <param name="m3MTPC">Material-to-promise check</param>
		/// <param name="m3TTPC">Transportation-to-promise check</param>
		/// <param name="m3ATLE">ATP level</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3SPLM, 
			string m3PREX, 
			int m3SPLA, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			DateTime? m3FDAT = null, 
			DateTime? m3TDAT = null, 
			decimal? m3QQTY = null, 
			int? m3SRCC = null, 
			string m3FWHL = null, 
			string m3TWHL = null, 
			string m3TRTP = null, 
			string m3DSCH = null, 
			string m3ORTY = null, 
			string m3SUNO = null, 
			string m3ITNO = null, 
			int? m3AFL6 = null, 
			string m3LTYP = null, 
			int? m3AOPT = null, 
			int? m3BCKO = null, 
			int? m3PADL = null, 
			int? m3SPLP = null, 
			int? m3PALT = null, 
			int? m3CTPC = null, 
			int? m3MTPC = null, 
			int? m3TTPC = null, 
			string m3ATLE = null, 
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
			if (string.IsNullOrWhiteSpace(m3SPLM))
				throw new ArgumentNullException(nameof(m3SPLM));
			if (string.IsNullOrWhiteSpace(m3PREX))
				throw new ArgumentNullException(nameof(m3PREX));

			// Set mandatory parameters
			request
				.WithQueryParameter("SPLM", m3SPLM.Trim())
				.WithQueryParameter("PREX", m3PREX.Trim())
				.WithQueryParameter("SPLA", m3SPLA.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());
			if (m3QQTY.HasValue)
				request.WithQueryParameter("QQTY", m3QQTY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SRCC.HasValue)
				request.WithQueryParameter("SRCC", m3SRCC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FWHL))
				request.WithQueryParameter("FWHL", m3FWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWHL))
				request.WithQueryParameter("TWHL", m3TWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRTP))
				request.WithQueryParameter("TRTP", m3TRTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSCH))
				request.WithQueryParameter("DSCH", m3DSCH.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3AFL6.HasValue)
				request.WithQueryParameter("AFL6", m3AFL6.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LTYP))
				request.WithQueryParameter("LTYP", m3LTYP.Trim());
			if (m3AOPT.HasValue)
				request.WithQueryParameter("AOPT", m3AOPT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCKO.HasValue)
				request.WithQueryParameter("BCKO", m3BCKO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PADL.HasValue)
				request.WithQueryParameter("PADL", m3PADL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPLP.HasValue)
				request.WithQueryParameter("SPLP", m3SPLP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PALT.HasValue)
				request.WithQueryParameter("PALT", m3PALT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CTPC.HasValue)
				request.WithQueryParameter("CTPC", m3CTPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MTPC.HasValue)
				request.WithQueryParameter("MTPC", m3MTPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TTPC.HasValue)
				request.WithQueryParameter("TTPC", m3TTPC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ATLE))
				request.WithQueryParameter("ATLE", m3ATLE.Trim());

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
		/// Name Delete
		/// Description Delete a record
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3SPLM">Supply model (Required)</param>
		/// <param name="m3PREX">Priority (Required)</param>
		/// <param name="m3SPLA">Alternative (Required)</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3QQTY">Quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Delete(
			string m3SPLM, 
			string m3PREX, 
			int m3SPLA, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			DateTime? m3FDAT = null, 
			decimal? m3QQTY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Delete",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SPLM))
				throw new ArgumentNullException(nameof(m3SPLM));
			if (string.IsNullOrWhiteSpace(m3PREX))
				throw new ArgumentNullException(nameof(m3PREX));

			// Set mandatory parameters
			request
				.WithQueryParameter("SPLM", m3SPLM.Trim())
				.WithQueryParameter("PREX", m3PREX.Trim())
				.WithQueryParameter("SPLA", m3SPLA.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3QQTY.HasValue)
				request.WithQueryParameter("QQTY", m3QQTY.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Description Get Equipment group
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3SPLM">Supply model (Required)</param>
		/// <param name="m3PREX">Priority (Required)</param>
		/// <param name="m3SPLA">Alternative (Required)</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3QQTY">Quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3SPLM, 
			string m3PREX, 
			int m3SPLA, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			DateTime? m3FDAT = null, 
			decimal? m3QQTY = null, 
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
			if (string.IsNullOrWhiteSpace(m3SPLM))
				throw new ArgumentNullException(nameof(m3SPLM));
			if (string.IsNullOrWhiteSpace(m3PREX))
				throw new ArgumentNullException(nameof(m3PREX));

			// Set mandatory parameters
			request
				.WithQueryParameter("SPLM", m3SPLM.Trim())
				.WithQueryParameter("PREX", m3PREX.Trim())
				.WithQueryParameter("SPLA", m3SPLA.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3QQTY.HasValue)
				request.WithQueryParameter("QQTY", m3QQTY.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name List
		/// Description List records
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3SPLM">Supply model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListResponse></returns>
		/// <exception cref="M3Exception<ListResponse>"></exception>
		public async Task<M3Response<ListResponse>> List(
			string m3SPLM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/List",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SPLM))
				request.WithQueryParameter("SPLM", m3SPLM.Trim());

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

		/// <summary>
		/// Name Update
		/// Description Update a record
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3SPLM">Supply model (Required)</param>
		/// <param name="m3PREX">Priority (Required)</param>
		/// <param name="m3SPLA">Alternative (Required)</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="m3OBV4">Start value 4</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3QQTY">Quantity</param>
		/// <param name="m3SRCC">Supply source</param>
		/// <param name="m3FWHL">From warehouse</param>
		/// <param name="m3TWHL">To warehouse</param>
		/// <param name="m3TRTP">Order type</param>
		/// <param name="m3DSCH">Distribution chain</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3SUNO">Supplier</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3AFL6">Replace item</param>
		/// <param name="m3LTYP">Line type</param>
		/// <param name="m3AOPT">Automatic option</param>
		/// <param name="m3BCKO">Backorder</param>
		/// <param name="m3PADL">Partial delivery</param>
		/// <param name="m3SPLP">Split on alternative</param>
		/// <param name="m3PALT">Selected alternative</param>
		/// <param name="m3CTPC">Capacity-to-promise check</param>
		/// <param name="m3MTPC">Material-to-promise check</param>
		/// <param name="m3TTPC">Transportation-to-promise check</param>
		/// <param name="m3ATLE">ATP level</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Update(
			string m3SPLM, 
			string m3PREX, 
			int m3SPLA, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3OBV4 = null, 
			DateTime? m3FDAT = null, 
			DateTime? m3TDAT = null, 
			decimal? m3QQTY = null, 
			int? m3SRCC = null, 
			string m3FWHL = null, 
			string m3TWHL = null, 
			string m3TRTP = null, 
			string m3DSCH = null, 
			string m3ORTY = null, 
			string m3SUNO = null, 
			string m3ITNO = null, 
			int? m3AFL6 = null, 
			string m3LTYP = null, 
			int? m3AOPT = null, 
			int? m3BCKO = null, 
			int? m3PADL = null, 
			int? m3SPLP = null, 
			int? m3PALT = null, 
			int? m3CTPC = null, 
			int? m3MTPC = null, 
			int? m3TTPC = null, 
			string m3ATLE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Update",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SPLM))
				throw new ArgumentNullException(nameof(m3SPLM));
			if (string.IsNullOrWhiteSpace(m3PREX))
				throw new ArgumentNullException(nameof(m3PREX));

			// Set mandatory parameters
			request
				.WithQueryParameter("SPLM", m3SPLM.Trim())
				.WithQueryParameter("PREX", m3PREX.Trim())
				.WithQueryParameter("SPLA", m3SPLA.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV4))
				request.WithQueryParameter("OBV4", m3OBV4.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());
			if (m3QQTY.HasValue)
				request.WithQueryParameter("QQTY", m3QQTY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SRCC.HasValue)
				request.WithQueryParameter("SRCC", m3SRCC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FWHL))
				request.WithQueryParameter("FWHL", m3FWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWHL))
				request.WithQueryParameter("TWHL", m3TWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRTP))
				request.WithQueryParameter("TRTP", m3TRTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3DSCH))
				request.WithQueryParameter("DSCH", m3DSCH.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3AFL6.HasValue)
				request.WithQueryParameter("AFL6", m3AFL6.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LTYP))
				request.WithQueryParameter("LTYP", m3LTYP.Trim());
			if (m3AOPT.HasValue)
				request.WithQueryParameter("AOPT", m3AOPT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BCKO.HasValue)
				request.WithQueryParameter("BCKO", m3BCKO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PADL.HasValue)
				request.WithQueryParameter("PADL", m3PADL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPLP.HasValue)
				request.WithQueryParameter("SPLP", m3SPLP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PALT.HasValue)
				request.WithQueryParameter("PALT", m3PALT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CTPC.HasValue)
				request.WithQueryParameter("CTPC", m3CTPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MTPC.HasValue)
				request.WithQueryParameter("MTPC", m3MTPC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TTPC.HasValue)
				request.WithQueryParameter("TTPC", m3TTPC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ATLE))
				request.WithQueryParameter("ATLE", m3ATLE.Trim());

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
