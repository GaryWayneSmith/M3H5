/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PPS001MI;
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
	/// Name: PPS001MI
	/// Component Name: PurchaseOrder
	/// Description: Purchase order interface
	/// Version Release: 5ea3
	///</summary>
	public partial class PPS001MIResource : M3BaseResourceEndpoint
	{
		public PPS001MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPS001MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AdviseAll
		/// Description Advise all lines in a purchase order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SMDT">Planned pickup date</param>
		/// <param name="m3_FWRF">Forwarding agent reference</param>
		/// <param name="m3_BOLN">Bill of lading</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_CARN">Carrier name</param>
		/// <param name="m3_PACN">Package</param>
		/// <param name="m3_PACC">Included in package</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="m3_SDDT">Suppliers departure date</param>
		/// <param name="m3_STWH">Ship-to warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AdviseAll(
			string m3_PUNO, 
			int? m3_CONO = null, 
			string m3_LNCD = null, 
			string m3_SUNO = null, 
			DateTime? m3_SMDT = null, 
			string m3_FWRF = null, 
			string m3_BOLN = null, 
			string m3_SUDO = null, 
			string m3_CARN = null, 
			string m3_PACN = null, 
			string m3_PACC = null, 
			string m3_PACT = null, 
			string m3_SSCC = null, 
			DateTime? m3_SDDT = null, 
			string m3_STWH = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AdviseAll",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_SMDT.HasValue)
				request.WithQueryParameter("SMDT", m3_SMDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_FWRF))
				request.WithQueryParameter("FWRF", m3_FWRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BOLN))
				request.WithQueryParameter("BOLN", m3_BOLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CARN))
				request.WithQueryParameter("CARN", m3_CARN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACC))
				request.WithQueryParameter("PACC", m3_PACC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());
			if (m3_SDDT.HasValue)
				request.WithQueryParameter("SDDT", m3_SDDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_STWH))
				request.WithQueryParameter("STWH", m3_STWH.Trim());

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
		/// Name AdviseLine
		/// Description Advise one line in a purchase order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="m3_PNLI">Purchase order line (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PNLS">Purchase order line subnumber</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SMDT">Planned pickup date</param>
		/// <param name="m3_ADQA">Advised quantity alternate U/M</param>
		/// <param name="m3_FWRF">Forwarding agent reference</param>
		/// <param name="m3_BOLN">Bill of lading</param>
		/// <param name="m3_SUDO">Delivery not number</param>
		/// <param name="m3_CARN">Carrier name</param>
		/// <param name="m3_COLI">*** Not in use *** Continue line</param>
		/// <param name="m3_OEND">Flagged as complete</param>
		/// <param name="m3_PACN">Package</param>
		/// <param name="m3_PACC">Included in package</param>
		/// <param name="m3_TIHM">Time hours & minutes</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_SSCC">SSCC number</param>
		/// <param name="m3_SDDT">Suppliers departure date</param>
		/// <param name="m3_STWH">Ship-to warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AdviseLine(
			string m3_PUNO, 
			int m3_PNLI, 
			int? m3_CONO = null, 
			int? m3_PNLS = null, 
			string m3_LNCD = null, 
			string m3_SUNO = null, 
			DateTime? m3_SMDT = null, 
			decimal? m3_ADQA = null, 
			string m3_FWRF = null, 
			string m3_BOLN = null, 
			string m3_SUDO = null, 
			string m3_CARN = null, 
			int? m3_COLI = null, 
			int? m3_OEND = null, 
			string m3_PACN = null, 
			string m3_PACC = null, 
			int? m3_TIHM = null, 
			string m3_PACT = null, 
			string m3_SSCC = null, 
			DateTime? m3_SDDT = null, 
			string m3_STWH = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AdviseLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim())
				.WithQueryParameter("PNLI", m3_PNLI.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3_PNLS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_SMDT.HasValue)
				request.WithQueryParameter("SMDT", m3_SMDT.Value.ToM3String());
			if (m3_ADQA.HasValue)
				request.WithQueryParameter("ADQA", m3_ADQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FWRF))
				request.WithQueryParameter("FWRF", m3_FWRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BOLN))
				request.WithQueryParameter("BOLN", m3_BOLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CARN))
				request.WithQueryParameter("CARN", m3_CARN.Trim());
			if (m3_COLI.HasValue)
				request.WithQueryParameter("COLI", m3_COLI.Value.ToString());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACN))
				request.WithQueryParameter("PACN", m3_PACN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACC))
				request.WithQueryParameter("PACC", m3_PACC.Trim());
			if (m3_TIHM.HasValue)
				request.WithQueryParameter("TIHM", m3_TIHM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SSCC))
				request.WithQueryParameter("SSCC", m3_SSCC.Trim());
			if (m3_SDDT.HasValue)
				request.WithQueryParameter("SDDT", m3_SDDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_STWH))
				request.WithQueryParameter("STWH", m3_STWH.Trim());

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
		/// Name CalculateLine
		/// Description Calculate one  line in a purchase order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PUNO">Purchase order nubmber(PO number) (Required)</param>
		/// <param name="m3_PNLI">Purchase order line number (Required)</param>
		/// <param name="m3_PNLS">Purchase order line sub number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CalculateLine(
			string m3_PUNO, 
			int m3_PNLI, 
			int m3_PNLS, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CalculateLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim())
				.WithQueryParameter("PNLI", m3_PNLI.ToString())
				.WithQueryParameter("PNLS", m3_PNLS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

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
		/// Name ConfirmAll
		/// Description Confirm all lines for a purchase order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_CODT">Confirmed delivery date</param>
		/// <param name="m3_SORN">Supplier order number</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_HAFE">Harbor or airport</param>
		/// <param name="m3_RASN">Rail station</param>
		/// <param name="m3_CIAD">Confirmed pickup address</param>
		/// <param name="m3_SADR">Supplier´s address reference</param>
		/// <param name="m3_STWH">Ship-to warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ConfirmAll(
			string m3_PUNO, 
			int? m3_CONO = null, 
			DateTime? m3_CODT = null, 
			string m3_SORN = null, 
			string m3_TEDL = null, 
			string m3_MODL = null, 
			string m3_HAFE = null, 
			string m3_RASN = null, 
			string m3_CIAD = null, 
			string m3_SADR = null, 
			string m3_STWH = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ConfirmAll",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_CODT.HasValue)
				request.WithQueryParameter("CODT", m3_CODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SORN))
				request.WithQueryParameter("SORN", m3_SORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HAFE))
				request.WithQueryParameter("HAFE", m3_HAFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RASN))
				request.WithQueryParameter("RASN", m3_RASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CIAD))
				request.WithQueryParameter("CIAD", m3_CIAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SADR))
				request.WithQueryParameter("SADR", m3_SADR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STWH))
				request.WithQueryParameter("STWH", m3_STWH.Trim());

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
		/// Name ConfirmLine
		/// Description Confirms one line in a purchase order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PUNO">Purchase order nubmber(PO number) (Required)</param>
		/// <param name="m3_PNLI">Purchase order line number (Required)</param>
		/// <param name="m3_PNLS">Purchase order line sub number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LNCD">Language code</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_YRE1">Your reference</param>
		/// <param name="m3_SORN">Supplier order number</param>
		/// <param name="m3_CODT">Confirmed delivery date</param>
		/// <param name="m3_CFQA">Confirmed quantity</param>
		/// <param name="m3_CPPR">Confirmed purchase price</param>
		/// <param name="m3_CPUC">Confirmed price quantity</param>
		/// <param name="m3_CFD1">Confirmed discount 1</param>
		/// <param name="m3_CFD2">Confirmed discount 2</param>
		/// <param name="m3_CFD3">Confirmed discount 3</param>
		/// <param name="m3_ZDI1">*** Not in use *** - Clear discount 1</param>
		/// <param name="m3_ZDI2">*** Not in use *** - Clear discount 2</param>
		/// <param name="m3_ZDI3">*** Not in use *** - Clear discount 3</param>
		/// <param name="m3_PDDT">Deviating confirmed delivery date</param>
		/// <param name="m3_PUSL">Lowest status</param>
		/// <param name="m3_COLI">*** Not in use *** - Continue line</param>
		/// <param name="m3_OEND">Flagged as completed</param>
		/// <param name="m3_TIHM">Time hours & minutes</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_HAFE">Harbor or airport</param>
		/// <param name="m3_RASN">Rail station</param>
		/// <param name="m3_CIAD">Confirmed pickup address</param>
		/// <param name="m3_SADR">Supplier´s address reference</param>
		/// <param name="m3_STWH">Ship-to warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ConfirmLine(
			string m3_PUNO, 
			int m3_PNLI, 
			int m3_PNLS, 
			int? m3_CONO = null, 
			string m3_LNCD = null, 
			string m3_SUNO = null, 
			string m3_YRE1 = null, 
			string m3_SORN = null, 
			DateTime? m3_CODT = null, 
			decimal? m3_CFQA = null, 
			decimal? m3_CPPR = null, 
			int? m3_CPUC = null, 
			int? m3_CFD1 = null, 
			int? m3_CFD2 = null, 
			int? m3_CFD3 = null, 
			int? m3_ZDI1 = null, 
			int? m3_ZDI2 = null, 
			int? m3_ZDI3 = null, 
			DateTime? m3_PDDT = null, 
			string m3_PUSL = null, 
			int? m3_COLI = null, 
			int? m3_OEND = null, 
			int? m3_TIHM = null, 
			string m3_TEDL = null, 
			string m3_MODL = null, 
			string m3_HAFE = null, 
			string m3_RASN = null, 
			string m3_CIAD = null, 
			string m3_SADR = null, 
			string m3_STWH = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ConfirmLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim())
				.WithQueryParameter("PNLI", m3_PNLI.ToString())
				.WithQueryParameter("PNLS", m3_PNLS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YRE1))
				request.WithQueryParameter("YRE1", m3_YRE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SORN))
				request.WithQueryParameter("SORN", m3_SORN.Trim());
			if (m3_CODT.HasValue)
				request.WithQueryParameter("CODT", m3_CODT.Value.ToM3String());
			if (m3_CFQA.HasValue)
				request.WithQueryParameter("CFQA", m3_CFQA.Value.ToString());
			if (m3_CPPR.HasValue)
				request.WithQueryParameter("CPPR", m3_CPPR.Value.ToString());
			if (m3_CPUC.HasValue)
				request.WithQueryParameter("CPUC", m3_CPUC.Value.ToString());
			if (m3_CFD1.HasValue)
				request.WithQueryParameter("CFD1", m3_CFD1.Value.ToString());
			if (m3_CFD2.HasValue)
				request.WithQueryParameter("CFD2", m3_CFD2.Value.ToString());
			if (m3_CFD3.HasValue)
				request.WithQueryParameter("CFD3", m3_CFD3.Value.ToString());
			if (m3_ZDI1.HasValue)
				request.WithQueryParameter("ZDI1", m3_ZDI1.Value.ToString());
			if (m3_ZDI2.HasValue)
				request.WithQueryParameter("ZDI2", m3_ZDI2.Value.ToString());
			if (m3_ZDI3.HasValue)
				request.WithQueryParameter("ZDI3", m3_ZDI3.Value.ToString());
			if (m3_PDDT.HasValue)
				request.WithQueryParameter("PDDT", m3_PDDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PUSL))
				request.WithQueryParameter("PUSL", m3_PUSL.Trim());
			if (m3_COLI.HasValue)
				request.WithQueryParameter("COLI", m3_COLI.Value.ToString());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (m3_TIHM.HasValue)
				request.WithQueryParameter("TIHM", m3_TIHM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HAFE))
				request.WithQueryParameter("HAFE", m3_HAFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RASN))
				request.WithQueryParameter("RASN", m3_RASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CIAD))
				request.WithQueryParameter("CIAD", m3_CIAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SADR))
				request.WithQueryParameter("SADR", m3_SADR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STWH))
				request.WithQueryParameter("STWH", m3_STWH.Trim());

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
		/// Name FinishMark
		/// Description Marks an order or an order line finished
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="m3_CONO">Company number</param>
		/// <param name="m3_PNLI">Purchase order line</param>
		/// <param name="m3_PNLS">Purchase order subline</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> FinishMark(
			string m3_PUNO, 
			int? m3_CONO = null, 
			int? m3_PNLI = null, 
			int? m3_PNLS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/FinishMark",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3_PNLI.Value.ToString());
			if (m3_PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3_PNLS.Value.ToString());

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
		/// Name GetBasicData
		/// Description Get Basic Data from Purchase Order Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PUNO">Purchase Order Number (Required)</param>
		/// <param name="m3_CONO">Company number</param>
		/// <param name="m3_PNLI">Purchase Order Line Number</param>
		/// <param name="m3_PNLS">Purchase Order Line Number Suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicDataResponse></returns>
		/// <exception cref="M3Exception<GetBasicDataResponse>"></exception>
		public async Task<M3Response<GetBasicDataResponse>> GetBasicData(
			string m3_PUNO, 
			int? m3_CONO = null, 
			int? m3_PNLI = null, 
			int? m3_PNLS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3_PNLI.Value.ToString());
			if (m3_PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3_PNLS.Value.ToString());

			// Execute the request
			var result = await Execute<GetBasicDataResponse>(
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
		/// Name GetBasicData2
		/// Description Get Basic Data from Purchase Order Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PUNO">Purchase Order Number (Required)</param>
		/// <param name="m3_PNLI">Purchase Order Line Number (Required)</param>
		/// <param name="m3_PNLS">Purchase Order Line Number Suffix (Required)</param>
		/// <param name="m3_CONO">Company number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicData2Response></returns>
		/// <exception cref="M3Exception<GetBasicData2Response>"></exception>
		public async Task<M3Response<GetBasicData2Response>> GetBasicData2(
			string m3_PUNO, 
			int m3_PNLI, 
			int m3_PNLS, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBasicData2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim())
				.WithQueryParameter("PNLI", m3_PNLI.ToString())
				.WithQueryParameter("PNLS", m3_PNLS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetBasicData2Response>(
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
		/// Name GetHeadBasic
		/// Description Retrieve Purchase order header basic information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadBasicResponse></returns>
		/// <exception cref="M3Exception<GetHeadBasicResponse>"></exception>
		public async Task<M3Response<GetHeadBasicResponse>> GetHeadBasic(
			string m3_PUNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHeadBasic",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<GetHeadBasicResponse>(
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
		/// Description Retrieve Purchase order line information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="m3_PNLI">Purchase order line (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PNLS">Purchase order line subnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLineResponse></returns>
		/// <exception cref="M3Exception<GetLineResponse>"></exception>
		public async Task<M3Response<GetLineResponse>> GetLine(
			string m3_PUNO, 
			int m3_PNLI, 
			int? m3_CONO = null, 
			int? m3_PNLS = null, 
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
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim())
				.WithQueryParameter("PNLI", m3_PNLI.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3_PNLS.Value.ToString());

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
		/// Name ListHeadBasic
		/// Description List Purchase order header basic information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PURC">Requisition by (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListHeadBasicResponse></returns>
		/// <exception cref="M3Exception<ListHeadBasicResponse>"></exception>
		public async Task<M3Response<ListHeadBasicResponse>> ListHeadBasic(
			string m3_PURC, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ListHeadBasic",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PURC))
				throw new ArgumentNullException("m3_PURC");

			// Set mandatory parameters
			request
				.WithQueryParameter("PURC", m3_PURC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<ListHeadBasicResponse>(
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
		/// Name LstBasicData
		/// Description List purchase order line basic data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PUNO">Purchase Order Number (Required)</param>
		/// <param name="m3_CONO">Company number</param>
		/// <param name="m3_PNLI">Purchase Order Line Number</param>
		/// <param name="m3_PNLS">Purchase Order Line Number Suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBasicDataResponse></returns>
		/// <exception cref="M3Exception<LstBasicDataResponse>"></exception>
		public async Task<M3Response<LstBasicDataResponse>> LstBasicData(
			string m3_PUNO, 
			int? m3_CONO = null, 
			int? m3_PNLI = null, 
			int? m3_PNLS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3_PNLI.Value.ToString());
			if (m3_PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3_PNLS.Value.ToString());

			// Execute the request
			var result = await Execute<LstBasicDataResponse>(
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
		/// Name LstLine
		/// Description List Purchase order line information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_PURC">Requisition by (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PLPN">Order proposal number</param>
		/// <param name="m3_PLPS">Sub number - order proposal</param>
		/// <param name="m3_PUSL">Lowest status - purchase order</param>
		/// <param name="m3_SOPT">Sorting option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineResponse></returns>
		/// <exception cref="M3Exception<LstLineResponse>"></exception>
		public async Task<M3Response<LstLineResponse>> LstLine(
			string m3_WHLO, 
			string m3_PURC, 
			int? m3_CONO = null, 
			int? m3_PLPN = null, 
			string m3_PLPS = null, 
			string m3_PUSL = null, 
			string m3_SOPT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_PURC))
				throw new ArgumentNullException("m3_PURC");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("PURC", m3_PURC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_PLPN.HasValue)
				request.WithQueryParameter("PLPN", m3_PLPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLPS))
				request.WithQueryParameter("PLPS", m3_PLPS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PUSL))
				request.WithQueryParameter("PUSL", m3_PUSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SOPT))
				request.WithQueryParameter("SOPT", m3_SOPT.Trim());

			// Execute the request
			var result = await Execute<LstLineResponse>(
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
		/// Name NotifyAll
		/// Description Notify all lines in a purchase order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SMDT">Carrier departure date</param>
		/// <param name="m3_FWRF">Forwarding agent reference</param>
		/// <param name="m3_BOLN">Bill of lading</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_CARN">Carrier name</param>
		/// <param name="m3_ARDT">Arrival date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> NotifyAll(
			string m3_PUNO, 
			int? m3_CONO = null, 
			string m3_LNCD = null, 
			string m3_SUNO = null, 
			DateTime? m3_SMDT = null, 
			string m3_FWRF = null, 
			string m3_BOLN = null, 
			string m3_SUDO = null, 
			string m3_CARN = null, 
			DateTime? m3_ARDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/NotifyAll",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_SMDT.HasValue)
				request.WithQueryParameter("SMDT", m3_SMDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_FWRF))
				request.WithQueryParameter("FWRF", m3_FWRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BOLN))
				request.WithQueryParameter("BOLN", m3_BOLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CARN))
				request.WithQueryParameter("CARN", m3_CARN.Trim());
			if (m3_ARDT.HasValue)
				request.WithQueryParameter("ARDT", m3_ARDT.Value.ToM3String());

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
		/// Name NotifyDelNot
		/// Description Notify all lines by a delivery note number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUDO">Delivery note number (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_SMDT">Carrier departure date</param>
		/// <param name="m3_FWRF">Forwarding agent reference</param>
		/// <param name="m3_BOLN">Bill of lading</param>
		/// <param name="m3_CARN">Carrier name</param>
		/// <param name="m3_ARDT">Arrival date</param>
		/// <param name="m3_TIHM">Time hours & minutes</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> NotifyDelNot(
			string m3_SUDO, 
			string m3_SUNO, 
			int? m3_CONO = null, 
			string m3_LNCD = null, 
			DateTime? m3_SMDT = null, 
			string m3_FWRF = null, 
			string m3_BOLN = null, 
			string m3_CARN = null, 
			DateTime? m3_ARDT = null, 
			int? m3_TIHM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/NotifyDelNot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUDO))
				throw new ArgumentNullException("m3_SUDO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUDO", m3_SUDO.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (m3_SMDT.HasValue)
				request.WithQueryParameter("SMDT", m3_SMDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_FWRF))
				request.WithQueryParameter("FWRF", m3_FWRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BOLN))
				request.WithQueryParameter("BOLN", m3_BOLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CARN))
				request.WithQueryParameter("CARN", m3_CARN.Trim());
			if (m3_ARDT.HasValue)
				request.WithQueryParameter("ARDT", m3_ARDT.Value.ToM3String());
			if (m3_TIHM.HasValue)
				request.WithQueryParameter("TIHM", m3_TIHM.Value.ToString());

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
		/// Name NotifyLine
		/// Description Notify one line in a purchase order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PUNO">Purchase order number (Required)</param>
		/// <param name="m3_PNLI">Purchase order line (Required)</param>
		/// <param name="m3_PNLS">Purchase order line subnumber (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_SMDT">Carrier departure date</param>
		/// <param name="m3_TNQA">Transport notified quantity</param>
		/// <param name="m3_FWRF">Forwarding agent reference</param>
		/// <param name="m3_BOLN">Bill of lading</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_CARN">Carrier name</param>
		/// <param name="m3_ARDT">Arrival date</param>
		/// <param name="m3_OEND">Flagged as complete</param>
		/// <param name="m3_TIHM">Time hours & minutes</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> NotifyLine(
			string m3_PUNO, 
			int m3_PNLI, 
			int m3_PNLS, 
			int? m3_CONO = null, 
			string m3_LNCD = null, 
			string m3_SUNO = null, 
			DateTime? m3_SMDT = null, 
			decimal? m3_TNQA = null, 
			string m3_FWRF = null, 
			string m3_BOLN = null, 
			string m3_SUDO = null, 
			string m3_CARN = null, 
			DateTime? m3_ARDT = null, 
			int? m3_OEND = null, 
			int? m3_TIHM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/NotifyLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3_PUNO.Trim())
				.WithQueryParameter("PNLI", m3_PNLI.ToString())
				.WithQueryParameter("PNLS", m3_PNLS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_SMDT.HasValue)
				request.WithQueryParameter("SMDT", m3_SMDT.Value.ToM3String());
			if (m3_TNQA.HasValue)
				request.WithQueryParameter("TNQA", m3_TNQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FWRF))
				request.WithQueryParameter("FWRF", m3_FWRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BOLN))
				request.WithQueryParameter("BOLN", m3_BOLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CARN))
				request.WithQueryParameter("CARN", m3_CARN.Trim());
			if (m3_ARDT.HasValue)
				request.WithQueryParameter("ARDT", m3_ARDT.Value.ToM3String());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (m3_TIHM.HasValue)
				request.WithQueryParameter("TIHM", m3_TIHM.Value.ToString());

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
		/// Name Receipt
		/// Description Goods Receipt
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_TRDT">Transaction Date (Required)</param>
		/// <param name="m3_RESP">Responsible (Required)</param>
		/// <param name="m3_PUNO">Purchase Order Number (Required)</param>
		/// <param name="m3_PNLI">Purchase Order Number Line (Required)</param>
		/// <param name="m3_PNLS">Purchase Order Number Subline (Required)</param>
		/// <param name="m3_RVQA">Received quantity (Required)</param>
		/// <param name="m3_CONO">Company No</param>
		/// <param name="m3_OEND">Finish Mark</param>
		/// <param name="m3_WHSL">Location</param>
		/// <param name="m3_BANO">Lot Number</param>
		/// <param name="m3_CAMU">Container</param>
		/// <param name="m3_WHLO">Ware House Stock Location</param>
		/// <param name="m3_SUDO">Delivery note number</param>
		/// <param name="m3_BREF">Lot reference 1</param>
		/// <param name="m3_BRE2">Lot reference 2</param>
		/// <param name="m3_NOPK">Number of package</param>
		/// <param name="m3_CAWE">Catch weight</param>
		/// <param name="m3_PRDT">Manufacturing date</param>
		/// <param name="m3_BREM">Remark</param>
		/// <param name="m3_AT01">Attribute identity 1</param>
		/// <param name="m3_AV01">Attribute value 1</param>
		/// <param name="m3_AT02">Attribute identity 2</param>
		/// <param name="m3_AV02">Attribute value 2</param>
		/// <param name="m3_AT03">Attribute identity 3</param>
		/// <param name="m3_AV03">Attribute value 3</param>
		/// <param name="m3_AT04">Attribute identity 4</param>
		/// <param name="m3_AV04">Attribute value 4</param>
		/// <param name="m3_AT05">Attribute identity 5</param>
		/// <param name="m3_AV05">Attribute value 5</param>
		/// <param name="m3_AT06">Attribute identity 6</param>
		/// <param name="m3_AV06">Attribute value 6</param>
		/// <param name="m3_AT07">Attribute identity 7</param>
		/// <param name="m3_AV07">Attribute value 7</param>
		/// <param name="m3_AT08">Attribute identity 8</param>
		/// <param name="m3_AV08">Attribute value 8</param>
		/// <param name="m3_AT09">Attribute identity 9</param>
		/// <param name="m3_AV09">Attribute value 9</param>
		/// <param name="m3_AT10">Attribute identity 10</param>
		/// <param name="m3_AV10">Attribute value 10</param>
		/// <param name="m3_POCY">Normal potency</param>
		/// <param name="m3_TRTM">Transaction time</param>
		/// <param name="m3_UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Receipt(
			DateTime m3_TRDT, 
			string m3_RESP, 
			string m3_PUNO, 
			int m3_PNLI, 
			int m3_PNLS, 
			decimal m3_RVQA, 
			int? m3_CONO = null, 
			int? m3_OEND = null, 
			string m3_WHSL = null, 
			string m3_BANO = null, 
			string m3_CAMU = null, 
			string m3_WHLO = null, 
			string m3_SUDO = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			int? m3_NOPK = null, 
			decimal? m3_CAWE = null, 
			DateTime? m3_PRDT = null, 
			string m3_BREM = null, 
			string m3_AT01 = null, 
			string m3_AV01 = null, 
			string m3_AT02 = null, 
			string m3_AV02 = null, 
			string m3_AT03 = null, 
			string m3_AV03 = null, 
			string m3_AT04 = null, 
			string m3_AV04 = null, 
			string m3_AT05 = null, 
			string m3_AV05 = null, 
			string m3_AT06 = null, 
			string m3_AV06 = null, 
			string m3_AT07 = null, 
			string m3_AV07 = null, 
			string m3_AT08 = null, 
			string m3_AV08 = null, 
			string m3_AT09 = null, 
			string m3_AV09 = null, 
			string m3_AT10 = null, 
			string m3_AV10 = null, 
			int? m3_POCY = null, 
			int? m3_TRTM = null, 
			int? m3_UTCM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Receipt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RESP))
				throw new ArgumentNullException("m3_RESP");
			if (string.IsNullOrWhiteSpace(m3_PUNO))
				throw new ArgumentNullException("m3_PUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("TRDT", m3_TRDT.ToM3String())
				.WithQueryParameter("RESP", m3_RESP.Trim())
				.WithQueryParameter("PUNO", m3_PUNO.Trim())
				.WithQueryParameter("PNLI", m3_PNLI.ToString())
				.WithQueryParameter("PNLS", m3_PNLS.ToString())
				.WithQueryParameter("RVQA", m3_RVQA.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_OEND.HasValue)
				request.WithQueryParameter("OEND", m3_OEND.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WHSL))
				request.WithQueryParameter("WHSL", m3_WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CAMU))
				request.WithQueryParameter("CAMU", m3_CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUDO))
				request.WithQueryParameter("SUDO", m3_SUDO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (m3_NOPK.HasValue)
				request.WithQueryParameter("NOPK", m3_NOPK.Value.ToString());
			if (m3_CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3_CAWE.Value.ToString());
			if (m3_PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3_PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_BREM))
				request.WithQueryParameter("BREM", m3_BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AT01))
				request.WithQueryParameter("AT01", m3_AT01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AV01))
				request.WithQueryParameter("AV01", m3_AV01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AT02))
				request.WithQueryParameter("AT02", m3_AT02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AV02))
				request.WithQueryParameter("AV02", m3_AV02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AT03))
				request.WithQueryParameter("AT03", m3_AT03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AV03))
				request.WithQueryParameter("AV03", m3_AV03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AT04))
				request.WithQueryParameter("AT04", m3_AT04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AV04))
				request.WithQueryParameter("AV04", m3_AV04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AT05))
				request.WithQueryParameter("AT05", m3_AT05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AV05))
				request.WithQueryParameter("AV05", m3_AV05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AT06))
				request.WithQueryParameter("AT06", m3_AT06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AV06))
				request.WithQueryParameter("AV06", m3_AV06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AT07))
				request.WithQueryParameter("AT07", m3_AT07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AV07))
				request.WithQueryParameter("AV07", m3_AV07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AT08))
				request.WithQueryParameter("AT08", m3_AT08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AV08))
				request.WithQueryParameter("AV08", m3_AV08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AT09))
				request.WithQueryParameter("AT09", m3_AT09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AV09))
				request.WithQueryParameter("AV09", m3_AV09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AT10))
				request.WithQueryParameter("AT10", m3_AT10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AV10))
				request.WithQueryParameter("AV10", m3_AV10.Trim());
			if (m3_POCY.HasValue)
				request.WithQueryParameter("POCY", m3_POCY.Value.ToString());
			if (m3_TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3_TRTM.Value.ToString());
			if (m3_UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3_UTCM.Value.ToString());

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
