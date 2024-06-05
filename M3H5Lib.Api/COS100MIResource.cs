/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.COS100MI;
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
	/// Name: COS100MI
	/// Component Name: MaintenanceCustomerOrder
	/// Description: Maintenance customer order interface
	/// Version Release: 5ea5
	///</summary>
	public partial class COS100MIResource : M3BaseResourceEndpoint
	{
		public COS100MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "COS100MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add Customer order head (and lines)
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3AAGN">Agreement number (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3AOTY">Order type</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3AORQ">Order quantity</param>
		/// <param name="m3UNIT">Unit of measure</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3AOST">Highest status</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3CUPO">Line number</param>
		/// <param name="m3CUSX">Line suffix</param>
		/// <param name="m3ANQU">New quotation</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3PITI">Run time</param>
		/// <param name="m3ADRT">MCO Address type</param>
		/// <param name="m3ADID">MCO Address  number</param>
		/// <param name="m3ADRR">Mtrl Address file</param>
		/// <param name="m3ADR2">Mtrl Address type</param>
		/// <param name="m3ADI2">Mtrl Address number</param>
		/// <param name="m3OIVR">Original invoice reference</param>
		/// <param name="m3OYEA">Original year</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddResponse></returns>
		/// <exception cref="M3Exception<AddResponse>"></exception>
		public async Task<M3Response<AddResponse>> Add(
			string m3CUNO, 
			string m3PRNO, 
			string m3AAGN, 
			string m3FACI, 
			int? m3CONO = null, 
			string m3BANO = null, 
			string m3AOTY = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			decimal? m3AORQ = null, 
			string m3UNIT = null, 
			string m3WHLO = null, 
			string m3AOST = null, 
			string m3RESP = null, 
			string m3CUOR = null, 
			int? m3CUPO = null, 
			int? m3CUSX = null, 
			int? m3ANQU = null, 
			string m3EMNO = null, 
			string m3PLGR = null, 
			int? m3PITI = null, 
			int? m3ADRT = null, 
			string m3ADID = null, 
			int? m3ADRR = null, 
			int? m3ADR2 = null, 
			string m3ADI2 = null, 
			string m3OIVR = null, 
			int? m3OYEA = null, 
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
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("AAGN", m3AAGN.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AOTY))
				request.WithQueryParameter("AOTY", m3AOTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (m3AORQ.HasValue)
				request.WithQueryParameter("AORQ", m3AORQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNIT))
				request.WithQueryParameter("UNIT", m3UNIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AOST))
				request.WithQueryParameter("AOST", m3AOST.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (m3CUPO.HasValue)
				request.WithQueryParameter("CUPO", m3CUPO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CUSX.HasValue)
				request.WithQueryParameter("CUSX", m3CUSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ANQU.HasValue)
				request.WithQueryParameter("ANQU", m3ANQU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (m3PITI.HasValue)
				request.WithQueryParameter("PITI", m3PITI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3ADRT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (m3ADRR.HasValue)
				request.WithQueryParameter("ADRR", m3ADRR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADR2.HasValue)
				request.WithQueryParameter("ADR2", m3ADR2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ADI2))
				request.WithQueryParameter("ADI2", m3ADI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OIVR))
				request.WithQueryParameter("OIVR", m3OIVR.Trim());
			if (m3OYEA.HasValue)
				request.WithQueryParameter("OYEA", m3OYEA.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddResponse>(
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
		/// Name AddClaimMCO
		/// Description Add Claim Customer order head (and lines)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CLNO">Claim (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CUNO">Customer number</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3AAGN">Agreement number</param>
		/// <param name="m3AOTY">Order type</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3AORQ">Order quantity</param>
		/// <param name="m3UNIT">Unit of measure</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3AOST">Highest status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddClaimMCOResponse></returns>
		/// <exception cref="M3Exception<AddClaimMCOResponse>"></exception>
		public async Task<M3Response<AddClaimMCOResponse>> AddClaimMCO(
			string m3CLNO, 
			int? m3CONO = null, 
			string m3CUNO = null, 
			string m3PRNO = null, 
			string m3BANO = null, 
			string m3AAGN = null, 
			string m3AOTY = null, 
			string m3FACI = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			decimal? m3AORQ = null, 
			string m3UNIT = null, 
			string m3WHLO = null, 
			string m3AOST = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddClaimMCO",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CLNO))
				throw new ArgumentNullException(nameof(m3CLNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3CLNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (m3AORQ.HasValue)
				request.WithQueryParameter("AORQ", m3AORQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNIT))
				request.WithQueryParameter("UNIT", m3UNIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AOST))
				request.WithQueryParameter("AOST", m3AOST.Trim());

			// Execute the request
			var result = await Execute<AddClaimMCOResponse>(
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
		/// Name AddLine
		/// Description Add Customer order lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3AORQ">Order quantity</param>
		/// <param name="m3UNIT">Unit of measure</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3AOST">Highest status</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3CUPO">Line number</param>
		/// <param name="m3CUSX">Line suffix</param>
		/// <param name="m3ANQU">New quotation</param>
		/// <param name="m3EMNO">Employee number</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3PITI">Run time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLineResponse></returns>
		/// <exception cref="M3Exception<AddLineResponse>"></exception>
		public async Task<M3Response<AddLineResponse>> AddLine(
			string m3PRNO, 
			int? m3CONO = null, 
			string m3ORNO = null, 
			string m3BANO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			decimal? m3AORQ = null, 
			string m3UNIT = null, 
			string m3WHLO = null, 
			string m3AOST = null, 
			string m3CUOR = null, 
			int? m3CUPO = null, 
			int? m3CUSX = null, 
			int? m3ANQU = null, 
			string m3EMNO = null, 
			string m3PLGR = null, 
			int? m3PITI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3PRNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (m3AORQ.HasValue)
				request.WithQueryParameter("AORQ", m3AORQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3UNIT))
				request.WithQueryParameter("UNIT", m3UNIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AOST))
				request.WithQueryParameter("AOST", m3AOST.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (m3CUPO.HasValue)
				request.WithQueryParameter("CUPO", m3CUPO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CUSX.HasValue)
				request.WithQueryParameter("CUSX", m3CUSX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ANQU.HasValue)
				request.WithQueryParameter("ANQU", m3ANQU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EMNO))
				request.WithQueryParameter("EMNO", m3EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (m3PITI.HasValue)
				request.WithQueryParameter("PITI", m3PITI.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddLineResponse>(
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
		/// Name ApproveMCOLine
		/// Description ApproveMCOLine
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Order line number (Required)</param>
		/// <param name="m3ACWA">Check warranty Yes/no(1/0) (Required)</param>
		/// <param name="m3CLIM">Create claim  Yes/no (1/0) (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ApproveMCOLine(
			string m3ORNO, 
			int m3PONR, 
			int m3ACWA, 
			int m3CLIM, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ApproveMCOLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACWA", m3ACWA.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CLIM", m3CLIM.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgQuot
		/// Description Change quotation information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Line number (Required)</param>
		/// <param name="m3AQUO">Quotation (Required)</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3ORCD">Quotation reason</param>
		/// <param name="m3GIDT">Valid to</param>
		/// <param name="m3BVD1">Follow-up date 1</param>
		/// <param name="m3BVD2">Follow-up date 2</param>
		/// <param name="m3BVC1">Follow-up activity 1</param>
		/// <param name="m3BVC2">Follow-up activity 2</param>
		/// <param name="m3DLDA">Delivery time in days</param>
		/// <param name="m3REFO">Reference object</param>
		/// <param name="m3FFI1">User-defined field 1</param>
		/// <param name="m3FFI2">User-defined field 2</param>
		/// <param name="m3FFI3">User-defined field 3</param>
		/// <param name="m3FFI4">User-defined field 4</param>
		/// <param name="m3FFI5">User-defined field 5</param>
		/// <param name="m3FFI6">User-defined field 6</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgQuot(
			string m3ORNO, 
			int m3PONR, 
			int m3AQUO, 
			string m3STAT = null, 
			string m3ORCD = null, 
			DateTime? m3GIDT = null, 
			DateTime? m3BVD1 = null, 
			DateTime? m3BVD2 = null, 
			string m3BVC1 = null, 
			string m3BVC2 = null, 
			int? m3DLDA = null, 
			string m3REFO = null, 
			string m3FFI1 = null, 
			string m3FFI2 = null, 
			string m3FFI3 = null, 
			string m3FFI4 = null, 
			string m3FFI5 = null, 
			string m3FFI6 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgQuot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("AQUO", m3AQUO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORCD))
				request.WithQueryParameter("ORCD", m3ORCD.Trim());
			if (m3GIDT.HasValue)
				request.WithQueryParameter("GIDT", m3GIDT.Value.ToM3String());
			if (m3BVD1.HasValue)
				request.WithQueryParameter("BVD1", m3BVD1.Value.ToM3String());
			if (m3BVD2.HasValue)
				request.WithQueryParameter("BVD2", m3BVD2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3BVC1))
				request.WithQueryParameter("BVC1", m3BVC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3BVC2))
				request.WithQueryParameter("BVC2", m3BVC2.Trim());
			if (m3DLDA.HasValue)
				request.WithQueryParameter("DLDA", m3DLDA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3REFO))
				request.WithQueryParameter("REFO", m3REFO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFI1))
				request.WithQueryParameter("FFI1", m3FFI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFI2))
				request.WithQueryParameter("FFI2", m3FFI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFI3))
				request.WithQueryParameter("FFI3", m3FFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFI4))
				request.WithQueryParameter("FFI4", m3FFI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFI5))
				request.WithQueryParameter("FFI5", m3FFI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3FFI6))
				request.WithQueryParameter("FFI6", m3FFI6.Trim());

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
		/// Name GetAddress
		/// Description GetAddress
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3ADRT">Address type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAddressResponse></returns>
		/// <exception cref="M3Exception<GetAddressResponse>"></exception>
		public async Task<M3Response<GetAddressResponse>> GetAddress(
			int? m3CONO = null, 
			string m3ORNO = null, 
			int? m3ADRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAddress",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (m3ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3ADRT.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetAddressResponse>(
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
		/// Name GetCreditCheck
		/// Description Get Credit Check Information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3AAGN">Agreement number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCreditCheckResponse></returns>
		/// <exception cref="M3Exception<GetCreditCheckResponse>"></exception>
		public async Task<M3Response<GetCreditCheckResponse>> GetCreditCheck(
			string m3CUNO, 
			string m3AAGN, 
			int? m3CONO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetCreditCheck",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3AAGN))
				throw new ArgumentNullException(nameof(m3AAGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("AAGN", m3AAGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetCreditCheckResponse>(
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
		/// Name GetMCOHead
		/// Description Get MCO Header Information
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMCOHeadResponse></returns>
		/// <exception cref="M3Exception<GetMCOHeadResponse>"></exception>
		public async Task<M3Response<GetMCOHeadResponse>> GetMCOHead(
			int? m3CONO = null, 
			string m3ORNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMCOHead",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Execute the request
			var result = await Execute<GetMCOHeadResponse>(
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
		/// Name LstByProject
		/// Description List Maintenance Customer Order by Project number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3APRS">Project</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByProjectResponse></returns>
		/// <exception cref="M3Exception<LstByProjectResponse>"></exception>
		public async Task<M3Response<LstByProjectResponse>> LstByProject(
			string m3APRS = null, 
			string m3ELNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByProject",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3APRS))
				request.WithQueryParameter("APRS", m3APRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());

			// Execute the request
			var result = await Execute<LstByProjectResponse>(
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
		/// Name LstHead
		/// Description Retrieve customer order head information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUNO">Customer number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3AOSL">Order status from</param>
		/// <param name="m3AOST">Order status to</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadResponse></returns>
		/// <exception cref="M3Exception<LstHeadResponse>"></exception>
		public async Task<M3Response<LstHeadResponse>> LstHead(
			string m3CUNO, 
			int? m3CONO = null, 
			string m3AOSL = null, 
			string m3AOST = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstHead",
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
			if (!string.IsNullOrWhiteSpace(m3AOSL))
				request.WithQueryParameter("AOSL", m3AOSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3AOST))
				request.WithQueryParameter("AOST", m3AOST.Trim());

			// Execute the request
			var result = await Execute<LstHeadResponse>(
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
		/// Name LstHeaderCharge
		/// Description LstHeaderCharge
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3CRID">Charge</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeaderChargeResponse></returns>
		/// <exception cref="M3Exception<LstHeaderChargeResponse>"></exception>
		public async Task<M3Response<LstHeaderChargeResponse>> LstHeaderCharge(
			string m3ORNO, 
			string m3CRID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstHeaderCharge",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CRID))
				request.WithQueryParameter("CRID", m3CRID.Trim());

			// Execute the request
			var result = await Execute<LstHeaderChargeResponse>(
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
		/// Name LstLineCharge
		/// Description LstLineCharge
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Order line number</param>
		/// <param name="m3CRID">Charge</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineChargeResponse></returns>
		/// <exception cref="M3Exception<LstLineChargeResponse>"></exception>
		public async Task<M3Response<LstLineChargeResponse>> LstLineCharge(
			string m3ORNO, 
			int? m3PONR = null, 
			string m3CRID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLineCharge",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CRID))
				request.WithQueryParameter("CRID", m3CRID.Trim());

			// Execute the request
			var result = await Execute<LstLineChargeResponse>(
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
		/// Name LstMCOLines
		/// Description List MCO Line Information
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMCOLinesResponse></returns>
		/// <exception cref="M3Exception<LstMCOLinesResponse>"></exception>
		public async Task<M3Response<LstMCOLinesResponse>> LstMCOLines(
			int? m3CONO = null, 
			string m3ORNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMCOLines",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Execute the request
			var result = await Execute<LstMCOLinesResponse>(
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
		/// Name PrintInvProp
		/// Description Print Invoice Propoposal
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Order line number</param>
		/// <param name="m3ACDT">Accounting date</param>
		/// <param name="m3IVDT">Invoice date</param>
		/// <param name="m3PICD">Advance invoicing code</param>
		/// <param name="m3PAIC">Summary invoicing code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrintInvProp(
			int m3CONO, 
			string m3ORNO, 
			int? m3PONR = null, 
			DateTime? m3ACDT = null, 
			DateTime? m3IVDT = null, 
			int? m3PICD = null, 
			int? m3PAIC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrintInvProp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3PONR.HasValue)
				request.WithQueryParameter("PONR", m3PONR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACDT.HasValue)
				request.WithQueryParameter("ACDT", m3ACDT.Value.ToM3String());
			if (m3IVDT.HasValue)
				request.WithQueryParameter("IVDT", m3IVDT.Value.ToM3String());
			if (m3PICD.HasValue)
				request.WithQueryParameter("PICD", m3PICD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PAIC.HasValue)
				request.WithQueryParameter("PAIC", m3PAIC.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name SearchHead
		/// Description Search head
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchHeadResponse></returns>
		/// <exception cref="M3Exception<SearchHeadResponse>"></exception>
		public async Task<M3Response<SearchHeadResponse>> SearchHead(
			string m3SQRY, 
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
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchHeadResponse>(
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
		/// Name SearchLine
		/// Description Search line
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchLineResponse></returns>
		/// <exception cref="M3Exception<SearchLineResponse>"></exception>
		public async Task<M3Response<SearchLineResponse>> SearchLine(
			string m3SQRY, 
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
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchLineResponse>(
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
		/// Name UpdLine
		/// Description Update Customer order lines
		/// Version Release: 5ea5
		/// </summary>
		/// <param name="m3ORNO">Customer order number (Required)</param>
		/// <param name="m3PONR">Order line number (Required)</param>
		/// <param name="m3SRVP">Service price method</param>
		/// <param name="m3APA1">Price in agreement currency</param>
		/// <param name="m3APM1">Price in material currency</param>
		/// <param name="m3ADF1">Price in labor currency</param>
		/// <param name="m3ADF2">Price in material currency</param>
		/// <param name="m3ADF3">Price in subcontracting currency</param>
		/// <param name="m3ADF4">Price in miscellaneous currency</param>
		/// <param name="m3WATP">Warranty type</param>
		/// <param name="m3INAP">Industry application</param>
		/// <param name="m3ACWA">Claim warranty</param>
		/// <param name="m3APD1">Planned delivery date</param>
		/// <param name="m3APTA">Planned delivery time</param>
		/// <param name="m3TECN">Tax exemption contract number</param>
		/// <param name="m3CAAY">Credit check amount agreement cur</param>
		/// <param name="m3AUSR">Auto create claim</param>
		/// <param name="m3AUAP">Auto approval</param>
		/// <param name="m3AUAL">Approval limit</param>
		/// <param name="m3WAAP">Warranty indicator auto reset</param>
		/// <param name="m3WAAL">Warranty auto reset limit</param>
		/// <param name="m3AOST">Highest status</param>
		/// <param name="m3RLDT">Requested delivery date</param>
		/// <param name="m3AADT">Actual receipt date</param>
		/// <param name="m3PROJ">Project Number</param>
		/// <param name="m3ELNO">Project Element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdLineResponse></returns>
		/// <exception cref="M3Exception<UpdLineResponse>"></exception>
		public async Task<M3Response<UpdLineResponse>> UpdLine(
			string m3ORNO, 
			int m3PONR, 
			int? m3SRVP = null, 
			decimal? m3APA1 = null, 
			decimal? m3APM1 = null, 
			decimal? m3ADF1 = null, 
			decimal? m3ADF2 = null, 
			decimal? m3ADF3 = null, 
			decimal? m3ADF4 = null, 
			string m3WATP = null, 
			string m3INAP = null, 
			int? m3ACWA = null, 
			DateTime? m3APD1 = null, 
			int? m3APTA = null, 
			string m3TECN = null, 
			decimal? m3CAAY = null, 
			string m3AUSR = null, 
			string m3AUAP = null, 
			decimal? m3AUAL = null, 
			string m3WAAP = null, 
			decimal? m3WAAL = null, 
			string m3AOST = null, 
			DateTime? m3RLDT = null, 
			DateTime? m3AADT = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("PONR", m3PONR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3SRVP.HasValue)
				request.WithQueryParameter("SRVP", m3SRVP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3APA1.HasValue)
				request.WithQueryParameter("APA1", m3APA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3APM1.HasValue)
				request.WithQueryParameter("APM1", m3APM1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADF1.HasValue)
				request.WithQueryParameter("ADF1", m3ADF1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADF2.HasValue)
				request.WithQueryParameter("ADF2", m3ADF2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADF3.HasValue)
				request.WithQueryParameter("ADF3", m3ADF3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADF4.HasValue)
				request.WithQueryParameter("ADF4", m3ADF4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WATP))
				request.WithQueryParameter("WATP", m3WATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3INAP))
				request.WithQueryParameter("INAP", m3INAP.Trim());
			if (m3ACWA.HasValue)
				request.WithQueryParameter("ACWA", m3ACWA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3APD1.HasValue)
				request.WithQueryParameter("APD1", m3APD1.Value.ToM3String());
			if (m3APTA.HasValue)
				request.WithQueryParameter("APTA", m3APTA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TECN))
				request.WithQueryParameter("TECN", m3TECN.Trim());
			if (m3CAAY.HasValue)
				request.WithQueryParameter("CAAY", m3CAAY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AUSR))
				request.WithQueryParameter("AUSR", m3AUSR.Trim());
			if (!string.IsNullOrWhiteSpace(m3AUAP))
				request.WithQueryParameter("AUAP", m3AUAP.Trim());
			if (m3AUAL.HasValue)
				request.WithQueryParameter("AUAL", m3AUAL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WAAP))
				request.WithQueryParameter("WAAP", m3WAAP.Trim());
			if (m3WAAL.HasValue)
				request.WithQueryParameter("WAAL", m3WAAL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AOST))
				request.WithQueryParameter("AOST", m3AOST.Trim());
			if (m3RLDT.HasValue)
				request.WithQueryParameter("RLDT", m3RLDT.Value.ToM3String());
			if (m3AADT.HasValue)
				request.WithQueryParameter("AADT", m3AADT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());

			// Execute the request
			var result = await Execute<UpdLineResponse>(
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
