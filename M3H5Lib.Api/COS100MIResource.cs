/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_AAGN">Agreement number (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_AOTY">Order type</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_AORQ">Order quantity</param>
		/// <param name="m3_UNIT">Unit of measure</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_AOST">Highest status</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_CUPO">Line number</param>
		/// <param name="m3_CUSX">Line suffix</param>
		/// <param name="m3_ANQU">New quotation</param>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_PITI">Run time</param>
		/// <param name="m3_ADRT">MCO Address type</param>
		/// <param name="m3_ADID">MCO Address  number</param>
		/// <param name="m3_ADRR">Mtrl Address file</param>
		/// <param name="m3_ADR2">Mtrl Address type</param>
		/// <param name="m3_ADI2">Mtrl Address number</param>
		/// <param name="m3_OIVR">Original invoice reference</param>
		/// <param name="m3_OYEA">Original year</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddResponse></returns>
		/// <exception cref="M3Exception<AddResponse>"></exception>
		public async Task<M3Response<AddResponse>> Add(
			string m3_CUNO, 
			string m3_PRNO, 
			string m3_AAGN, 
			string m3_FACI, 
			int? m3_CONO = null, 
			string m3_BANO = null, 
			string m3_AOTY = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			decimal? m3_AORQ = null, 
			string m3_UNIT = null, 
			string m3_WHLO = null, 
			string m3_AOST = null, 
			string m3_RESP = null, 
			string m3_CUOR = null, 
			int? m3_CUPO = null, 
			int? m3_CUSX = null, 
			int? m3_ANQU = null, 
			string m3_EMNO = null, 
			string m3_PLGR = null, 
			int? m3_PITI = null, 
			int? m3_ADRT = null, 
			string m3_ADID = null, 
			int? m3_ADRR = null, 
			int? m3_ADR2 = null, 
			string m3_ADI2 = null, 
			string m3_OIVR = null, 
			int? m3_OYEA = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("AAGN", m3_AAGN.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AOTY))
				request.WithQueryParameter("AOTY", m3_AOTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_AORQ.HasValue)
				request.WithQueryParameter("AORQ", m3_AORQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNIT))
				request.WithQueryParameter("UNIT", m3_UNIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AOST))
				request.WithQueryParameter("AOST", m3_AOST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (m3_CUPO.HasValue)
				request.WithQueryParameter("CUPO", m3_CUPO.Value.ToString());
			if (m3_CUSX.HasValue)
				request.WithQueryParameter("CUSX", m3_CUSX.Value.ToString());
			if (m3_ANQU.HasValue)
				request.WithQueryParameter("ANQU", m3_ANQU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (m3_PITI.HasValue)
				request.WithQueryParameter("PITI", m3_PITI.Value.ToString());
			if (m3_ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3_ADRT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (m3_ADRR.HasValue)
				request.WithQueryParameter("ADRR", m3_ADRR.Value.ToString());
			if (m3_ADR2.HasValue)
				request.WithQueryParameter("ADR2", m3_ADR2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ADI2))
				request.WithQueryParameter("ADI2", m3_ADI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OIVR))
				request.WithQueryParameter("OIVR", m3_OIVR.Trim());
			if (m3_OYEA.HasValue)
				request.WithQueryParameter("OYEA", m3_OYEA.Value.ToString());

			// Execute the request
			var result = await Execute<AddResponse>(
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
		/// Name AddClaimMCO
		/// Description Add Claim Customer order head (and lines)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CLNO">Claim (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CUNO">Customer number</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_AAGN">Agreement number</param>
		/// <param name="m3_AOTY">Order type</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_AORQ">Order quantity</param>
		/// <param name="m3_UNIT">Unit of measure</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_AOST">Highest status</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddClaimMCOResponse></returns>
		/// <exception cref="M3Exception<AddClaimMCOResponse>"></exception>
		public async Task<M3Response<AddClaimMCOResponse>> AddClaimMCO(
			string m3_CLNO, 
			int? m3_CONO = null, 
			string m3_CUNO = null, 
			string m3_PRNO = null, 
			string m3_BANO = null, 
			string m3_AAGN = null, 
			string m3_AOTY = null, 
			string m3_FACI = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			decimal? m3_AORQ = null, 
			string m3_UNIT = null, 
			string m3_WHLO = null, 
			string m3_AOST = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CLNO))
				throw new ArgumentNullException("m3_CLNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CLNO", m3_CLNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_AORQ.HasValue)
				request.WithQueryParameter("AORQ", m3_AORQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNIT))
				request.WithQueryParameter("UNIT", m3_UNIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AOST))
				request.WithQueryParameter("AOST", m3_AOST.Trim());

			// Execute the request
			var result = await Execute<AddClaimMCOResponse>(
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
		/// Name AddLine
		/// Description Add Customer order lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_AORQ">Order quantity</param>
		/// <param name="m3_UNIT">Unit of measure</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_AOST">Highest status</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_CUPO">Line number</param>
		/// <param name="m3_CUSX">Line suffix</param>
		/// <param name="m3_ANQU">New quotation</param>
		/// <param name="m3_EMNO">Employee number</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_PITI">Run time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLineResponse></returns>
		/// <exception cref="M3Exception<AddLineResponse>"></exception>
		public async Task<M3Response<AddLineResponse>> AddLine(
			string m3_PRNO, 
			int? m3_CONO = null, 
			string m3_ORNO = null, 
			string m3_BANO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			decimal? m3_AORQ = null, 
			string m3_UNIT = null, 
			string m3_WHLO = null, 
			string m3_AOST = null, 
			string m3_CUOR = null, 
			int? m3_CUPO = null, 
			int? m3_CUSX = null, 
			int? m3_ANQU = null, 
			string m3_EMNO = null, 
			string m3_PLGR = null, 
			int? m3_PITI = null, 
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
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3_PRNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_AORQ.HasValue)
				request.WithQueryParameter("AORQ", m3_AORQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNIT))
				request.WithQueryParameter("UNIT", m3_UNIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AOST))
				request.WithQueryParameter("AOST", m3_AOST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (m3_CUPO.HasValue)
				request.WithQueryParameter("CUPO", m3_CUPO.Value.ToString());
			if (m3_CUSX.HasValue)
				request.WithQueryParameter("CUSX", m3_CUSX.Value.ToString());
			if (m3_ANQU.HasValue)
				request.WithQueryParameter("ANQU", m3_ANQU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EMNO))
				request.WithQueryParameter("EMNO", m3_EMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (m3_PITI.HasValue)
				request.WithQueryParameter("PITI", m3_PITI.Value.ToString());

			// Execute the request
			var result = await Execute<AddLineResponse>(
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
		/// Name ApproveMCOLine
		/// Description ApproveMCOLine
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Order line number (Required)</param>
		/// <param name="m3_ACWA">Check warranty Yes/no(1/0) (Required)</param>
		/// <param name="m3_CLIM">Create claim  Yes/no (1/0) (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ApproveMCOLine(
			string m3_ORNO, 
			int m3_PONR, 
			int m3_ACWA, 
			int m3_CLIM, 
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
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("ACWA", m3_ACWA.ToString())
				.WithQueryParameter("CLIM", m3_CLIM.ToString());

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
		/// Name ChgQuot
		/// Description Change quotation information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Line number (Required)</param>
		/// <param name="m3_AQUO">Quotation (Required)</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_ORCD">Quotation reason</param>
		/// <param name="m3_GIDT">Valid to</param>
		/// <param name="m3_BVD1">Follow-up date 1</param>
		/// <param name="m3_BVD2">Follow-up date 2</param>
		/// <param name="m3_BVC1">Follow-up activity 1</param>
		/// <param name="m3_BVC2">Follow-up activity 2</param>
		/// <param name="m3_DLDA">Delivery time in days</param>
		/// <param name="m3_REFO">Reference object</param>
		/// <param name="m3_FFI1">User-defined field 1</param>
		/// <param name="m3_FFI2">User-defined field 2</param>
		/// <param name="m3_FFI3">User-defined field 3</param>
		/// <param name="m3_FFI4">User-defined field 4</param>
		/// <param name="m3_FFI5">User-defined field 5</param>
		/// <param name="m3_FFI6">User-defined field 6</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgQuot(
			string m3_ORNO, 
			int m3_PONR, 
			int m3_AQUO, 
			string m3_STAT = null, 
			string m3_ORCD = null, 
			DateTime? m3_GIDT = null, 
			DateTime? m3_BVD1 = null, 
			DateTime? m3_BVD2 = null, 
			string m3_BVC1 = null, 
			string m3_BVC2 = null, 
			int? m3_DLDA = null, 
			string m3_REFO = null, 
			string m3_FFI1 = null, 
			string m3_FFI2 = null, 
			string m3_FFI3 = null, 
			string m3_FFI4 = null, 
			string m3_FFI5 = null, 
			string m3_FFI6 = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString())
				.WithQueryParameter("AQUO", m3_AQUO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORCD))
				request.WithQueryParameter("ORCD", m3_ORCD.Trim());
			if (m3_GIDT.HasValue)
				request.WithQueryParameter("GIDT", m3_GIDT.Value.ToM3String());
			if (m3_BVD1.HasValue)
				request.WithQueryParameter("BVD1", m3_BVD1.Value.ToM3String());
			if (m3_BVD2.HasValue)
				request.WithQueryParameter("BVD2", m3_BVD2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_BVC1))
				request.WithQueryParameter("BVC1", m3_BVC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BVC2))
				request.WithQueryParameter("BVC2", m3_BVC2.Trim());
			if (m3_DLDA.HasValue)
				request.WithQueryParameter("DLDA", m3_DLDA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REFO))
				request.WithQueryParameter("REFO", m3_REFO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFI1))
				request.WithQueryParameter("FFI1", m3_FFI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFI2))
				request.WithQueryParameter("FFI2", m3_FFI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFI3))
				request.WithQueryParameter("FFI3", m3_FFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFI4))
				request.WithQueryParameter("FFI4", m3_FFI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFI5))
				request.WithQueryParameter("FFI5", m3_FFI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FFI6))
				request.WithQueryParameter("FFI6", m3_FFI6.Trim());

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
		/// Name GetAddress
		/// Description GetAddress
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_ADRT">Address type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAddressResponse></returns>
		/// <exception cref="M3Exception<GetAddressResponse>"></exception>
		public async Task<M3Response<GetAddressResponse>> GetAddress(
			int? m3_CONO = null, 
			string m3_ORNO = null, 
			int? m3_ADRT = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (m3_ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3_ADRT.Value.ToString());

			// Execute the request
			var result = await Execute<GetAddressResponse>(
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
		/// Name GetCreditCheck
		/// Description Get Credit Check Information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_AAGN">Agreement number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCreditCheckResponse></returns>
		/// <exception cref="M3Exception<GetCreditCheckResponse>"></exception>
		public async Task<M3Response<GetCreditCheckResponse>> GetCreditCheck(
			string m3_CUNO, 
			string m3_AAGN, 
			int? m3_CONO = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");
			if (string.IsNullOrWhiteSpace(m3_AAGN))
				throw new ArgumentNullException("m3_AAGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim())
				.WithQueryParameter("AAGN", m3_AAGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetCreditCheckResponse>(
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
		/// Name GetMCOHead
		/// Description Get MCO Header Information
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMCOHeadResponse></returns>
		/// <exception cref="M3Exception<GetMCOHeadResponse>"></exception>
		public async Task<M3Response<GetMCOHeadResponse>> GetMCOHead(
			int? m3_CONO = null, 
			string m3_ORNO = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Execute the request
			var result = await Execute<GetMCOHeadResponse>(
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
		/// Name LstByProject
		/// Description List Maintenance Customer Order by Project number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_APRS">Project</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByProjectResponse></returns>
		/// <exception cref="M3Exception<LstByProjectResponse>"></exception>
		public async Task<M3Response<LstByProjectResponse>> LstByProject(
			string m3_APRS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByProject",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_APRS))
				request.WithQueryParameter("APRS", m3_APRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());

			// Execute the request
			var result = await Execute<LstByProjectResponse>(
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
		/// Name LstHead
		/// Description Retrieve customer order head information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUNO">Customer number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_AOSL">Order status from</param>
		/// <param name="m3_AOST">Order status to</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeadResponse></returns>
		/// <exception cref="M3Exception<LstHeadResponse>"></exception>
		public async Task<M3Response<LstHeadResponse>> LstHead(
			string m3_CUNO, 
			int? m3_CONO = null, 
			string m3_AOSL = null, 
			string m3_AOST = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AOSL))
				request.WithQueryParameter("AOSL", m3_AOSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AOST))
				request.WithQueryParameter("AOST", m3_AOST.Trim());

			// Execute the request
			var result = await Execute<LstHeadResponse>(
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
		/// Name LstHeaderCharge
		/// Description LstHeaderCharge
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_CRID">Charge</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstHeaderChargeResponse></returns>
		/// <exception cref="M3Exception<LstHeaderChargeResponse>"></exception>
		public async Task<M3Response<LstHeaderChargeResponse>> LstHeaderCharge(
			string m3_ORNO, 
			string m3_CRID = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CRID))
				request.WithQueryParameter("CRID", m3_CRID.Trim());

			// Execute the request
			var result = await Execute<LstHeaderChargeResponse>(
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
		/// Name LstLineCharge
		/// Description LstLineCharge
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Order line number</param>
		/// <param name="m3_CRID">Charge</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineChargeResponse></returns>
		/// <exception cref="M3Exception<LstLineChargeResponse>"></exception>
		public async Task<M3Response<LstLineChargeResponse>> LstLineCharge(
			string m3_ORNO, 
			int? m3_PONR = null, 
			string m3_CRID = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CRID))
				request.WithQueryParameter("CRID", m3_CRID.Trim());

			// Execute the request
			var result = await Execute<LstLineChargeResponse>(
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
		/// Name LstMCOLines
		/// Description List MCO Line Information
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMCOLinesResponse></returns>
		/// <exception cref="M3Exception<LstMCOLinesResponse>"></exception>
		public async Task<M3Response<LstMCOLinesResponse>> LstMCOLines(
			int? m3_CONO = null, 
			string m3_ORNO = null, 
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
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Execute the request
			var result = await Execute<LstMCOLinesResponse>(
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
		/// Name PrintInvProp
		/// Description Print Invoice Propoposal
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Order line number</param>
		/// <param name="m3_ACDT">Accounting date</param>
		/// <param name="m3_IVDT">Invoice date</param>
		/// <param name="m3_PICD">Advance invoicing code</param>
		/// <param name="m3_PAIC">Summary invoicing code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrintInvProp(
			int m3_CONO, 
			string m3_ORNO, 
			int? m3_PONR = null, 
			DateTime? m3_ACDT = null, 
			DateTime? m3_IVDT = null, 
			int? m3_PICD = null, 
			int? m3_PAIC = null, 
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
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("ORNO", m3_ORNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_PONR.HasValue)
				request.WithQueryParameter("PONR", m3_PONR.Value.ToString());
			if (m3_ACDT.HasValue)
				request.WithQueryParameter("ACDT", m3_ACDT.Value.ToM3String());
			if (m3_IVDT.HasValue)
				request.WithQueryParameter("IVDT", m3_IVDT.Value.ToM3String());
			if (m3_PICD.HasValue)
				request.WithQueryParameter("PICD", m3_PICD.Value.ToString());
			if (m3_PAIC.HasValue)
				request.WithQueryParameter("PAIC", m3_PAIC.Value.ToString());

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
		/// Name UpdLine
		/// Description Update Customer order lines
		/// Version Release: 5ea5
		/// </summary>
		/// <param name="m3_ORNO">Customer order number (Required)</param>
		/// <param name="m3_PONR">Order line number (Required)</param>
		/// <param name="m3_SRVP">Service price method</param>
		/// <param name="m3_APA1">Price in agreement currency</param>
		/// <param name="m3_APM1">Price in material currency</param>
		/// <param name="m3_ADF1">Price in labor currency</param>
		/// <param name="m3_ADF2">Price in material currency</param>
		/// <param name="m3_ADF3">Price in subcontracting currency</param>
		/// <param name="m3_ADF4">Price in miscellaneous currency</param>
		/// <param name="m3_WATP">Warranty type</param>
		/// <param name="m3_INAP">Industry application</param>
		/// <param name="m3_ACWA">Claim warranty</param>
		/// <param name="m3_APD1">Planned delivery date</param>
		/// <param name="m3_APTA">Planned delivery time</param>
		/// <param name="m3_TECN">Tax exemption contract number</param>
		/// <param name="m3_CAAY">Credit check amount agreement cur</param>
		/// <param name="m3_AUSR">Auto create claim</param>
		/// <param name="m3_AUAP">Auto approval</param>
		/// <param name="m3_AUAL">Approval limit</param>
		/// <param name="m3_WAAP">Warranty indicator auto reset</param>
		/// <param name="m3_WAAL">Warranty auto reset limit</param>
		/// <param name="m3_AOST">Highest status</param>
		/// <param name="m3_RLDT">Requested delivery date</param>
		/// <param name="m3_AADT">Actual receipt date</param>
		/// <param name="m3_PROJ">Project Number</param>
		/// <param name="m3_ELNO">Project Element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<UpdLineResponse></returns>
		/// <exception cref="M3Exception<UpdLineResponse>"></exception>
		public async Task<M3Response<UpdLineResponse>> UpdLine(
			string m3_ORNO, 
			int m3_PONR, 
			int? m3_SRVP = null, 
			decimal? m3_APA1 = null, 
			decimal? m3_APM1 = null, 
			decimal? m3_ADF1 = null, 
			decimal? m3_ADF2 = null, 
			decimal? m3_ADF3 = null, 
			decimal? m3_ADF4 = null, 
			string m3_WATP = null, 
			string m3_INAP = null, 
			int? m3_ACWA = null, 
			DateTime? m3_APD1 = null, 
			int? m3_APTA = null, 
			string m3_TECN = null, 
			decimal? m3_CAAY = null, 
			string m3_AUSR = null, 
			string m3_AUAP = null, 
			decimal? m3_AUAL = null, 
			string m3_WAAP = null, 
			decimal? m3_WAAL = null, 
			string m3_AOST = null, 
			DateTime? m3_RLDT = null, 
			DateTime? m3_AADT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ORNO))
				throw new ArgumentNullException("m3_ORNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3_ORNO.Trim())
				.WithQueryParameter("PONR", m3_PONR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_SRVP.HasValue)
				request.WithQueryParameter("SRVP", m3_SRVP.Value.ToString());
			if (m3_APA1.HasValue)
				request.WithQueryParameter("APA1", m3_APA1.Value.ToString());
			if (m3_APM1.HasValue)
				request.WithQueryParameter("APM1", m3_APM1.Value.ToString());
			if (m3_ADF1.HasValue)
				request.WithQueryParameter("ADF1", m3_ADF1.Value.ToString());
			if (m3_ADF2.HasValue)
				request.WithQueryParameter("ADF2", m3_ADF2.Value.ToString());
			if (m3_ADF3.HasValue)
				request.WithQueryParameter("ADF3", m3_ADF3.Value.ToString());
			if (m3_ADF4.HasValue)
				request.WithQueryParameter("ADF4", m3_ADF4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WATP))
				request.WithQueryParameter("WATP", m3_WATP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INAP))
				request.WithQueryParameter("INAP", m3_INAP.Trim());
			if (m3_ACWA.HasValue)
				request.WithQueryParameter("ACWA", m3_ACWA.Value.ToString());
			if (m3_APD1.HasValue)
				request.WithQueryParameter("APD1", m3_APD1.Value.ToM3String());
			if (m3_APTA.HasValue)
				request.WithQueryParameter("APTA", m3_APTA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TECN))
				request.WithQueryParameter("TECN", m3_TECN.Trim());
			if (m3_CAAY.HasValue)
				request.WithQueryParameter("CAAY", m3_CAAY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AUSR))
				request.WithQueryParameter("AUSR", m3_AUSR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AUAP))
				request.WithQueryParameter("AUAP", m3_AUAP.Trim());
			if (m3_AUAL.HasValue)
				request.WithQueryParameter("AUAL", m3_AUAL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WAAP))
				request.WithQueryParameter("WAAP", m3_WAAP.Trim());
			if (m3_WAAL.HasValue)
				request.WithQueryParameter("WAAL", m3_WAAL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AOST))
				request.WithQueryParameter("AOST", m3_AOST.Trim());
			if (m3_RLDT.HasValue)
				request.WithQueryParameter("RLDT", m3_RLDT.Value.ToM3String());
			if (m3_AADT.HasValue)
				request.WithQueryParameter("AADT", m3_AADT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());

			// Execute the request
			var result = await Execute<UpdLineResponse>(
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
