/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AdviseAll
		/// Description Advise all lines in a purchase order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SMDT">Planned pickup date</param>
		/// <param name="m3FWRF">Forwarding agent reference</param>
		/// <param name="m3BOLN">Bill of lading</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3CARN">Carrier name</param>
		/// <param name="m3PACN">Package</param>
		/// <param name="m3PACC">Included in package</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="m3SDDT">Suppliers departure date</param>
		/// <param name="m3STWH">Ship-to warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AdviseAll(
			string m3PUNO, 
			int? m3CONO = null, 
			string m3LNCD = null, 
			string m3SUNO = null, 
			DateTime? m3SMDT = null, 
			string m3FWRF = null, 
			string m3BOLN = null, 
			string m3SUDO = null, 
			string m3CARN = null, 
			string m3PACN = null, 
			string m3PACC = null, 
			string m3PACT = null, 
			string m3SSCC = null, 
			DateTime? m3SDDT = null, 
			string m3STWH = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AdviseAll",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3SMDT.HasValue)
				request.WithQueryParameter("SMDT", m3SMDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3FWRF))
				request.WithQueryParameter("FWRF", m3FWRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BOLN))
				request.WithQueryParameter("BOLN", m3BOLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CARN))
				request.WithQueryParameter("CARN", m3CARN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACC))
				request.WithQueryParameter("PACC", m3PACC.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());
			if (m3SDDT.HasValue)
				request.WithQueryParameter("SDDT", m3SDDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3STWH))
				request.WithQueryParameter("STWH", m3STWH.Trim());

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
		/// Name AdviseLine
		/// Description Advise one line in a purchase order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="m3PNLI">Purchase order line (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PNLS">Purchase order line subnumber</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SMDT">Planned pickup date</param>
		/// <param name="m3ADQA">Advised quantity alternate U/M</param>
		/// <param name="m3FWRF">Forwarding agent reference</param>
		/// <param name="m3BOLN">Bill of lading</param>
		/// <param name="m3SUDO">Delivery not number</param>
		/// <param name="m3CARN">Carrier name</param>
		/// <param name="m3COLI">*** Not in use *** Continue line</param>
		/// <param name="m3OEND">Flagged as complete</param>
		/// <param name="m3PACN">Package</param>
		/// <param name="m3PACC">Included in package</param>
		/// <param name="m3TIHM">Time hours & minutes</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="m3SDDT">Suppliers departure date</param>
		/// <param name="m3STWH">Ship-to warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AdviseLine(
			string m3PUNO, 
			int m3PNLI, 
			int? m3CONO = null, 
			int? m3PNLS = null, 
			string m3LNCD = null, 
			string m3SUNO = null, 
			DateTime? m3SMDT = null, 
			decimal? m3ADQA = null, 
			string m3FWRF = null, 
			string m3BOLN = null, 
			string m3SUDO = null, 
			string m3CARN = null, 
			int? m3COLI = null, 
			int? m3OEND = null, 
			string m3PACN = null, 
			string m3PACC = null, 
			int? m3TIHM = null, 
			string m3PACT = null, 
			string m3SSCC = null, 
			DateTime? m3SDDT = null, 
			string m3STWH = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AdviseLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim())
				.WithQueryParameter("PNLI", m3PNLI.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3PNLS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3SMDT.HasValue)
				request.WithQueryParameter("SMDT", m3SMDT.Value.ToM3String());
			if (m3ADQA.HasValue)
				request.WithQueryParameter("ADQA", m3ADQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FWRF))
				request.WithQueryParameter("FWRF", m3FWRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BOLN))
				request.WithQueryParameter("BOLN", m3BOLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CARN))
				request.WithQueryParameter("CARN", m3CARN.Trim());
			if (m3COLI.HasValue)
				request.WithQueryParameter("COLI", m3COLI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACN))
				request.WithQueryParameter("PACN", m3PACN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACC))
				request.WithQueryParameter("PACC", m3PACC.Trim());
			if (m3TIHM.HasValue)
				request.WithQueryParameter("TIHM", m3TIHM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());
			if (m3SDDT.HasValue)
				request.WithQueryParameter("SDDT", m3SDDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3STWH))
				request.WithQueryParameter("STWH", m3STWH.Trim());

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
		/// Name CalculateLine
		/// Description Calculate one  line in a purchase order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PUNO">Purchase order nubmber(PO number) (Required)</param>
		/// <param name="m3PNLI">Purchase order line number (Required)</param>
		/// <param name="m3PNLS">Purchase order line sub number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CalculateLine(
			string m3PUNO, 
			int m3PNLI, 
			int m3PNLS, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CalculateLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim())
				.WithQueryParameter("PNLI", m3PNLI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PNLS", m3PNLS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ConfirmAll
		/// Description Confirm all lines for a purchase order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3CODT">Confirmed delivery date</param>
		/// <param name="m3SORN">Supplier order number</param>
		/// <param name="m3TEDL">Delivery terms</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3HAFE">Harbor or airport</param>
		/// <param name="m3RASN">Rail station</param>
		/// <param name="m3CIAD">Confirmed pickup address</param>
		/// <param name="m3SADR">Supplier´s address reference</param>
		/// <param name="m3STWH">Ship-to warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ConfirmAll(
			string m3PUNO, 
			int? m3CONO = null, 
			DateTime? m3CODT = null, 
			string m3SORN = null, 
			string m3TEDL = null, 
			string m3MODL = null, 
			string m3HAFE = null, 
			string m3RASN = null, 
			string m3CIAD = null, 
			string m3SADR = null, 
			string m3STWH = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ConfirmAll",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CODT.HasValue)
				request.WithQueryParameter("CODT", m3CODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SORN))
				request.WithQueryParameter("SORN", m3SORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3HAFE))
				request.WithQueryParameter("HAFE", m3HAFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3RASN))
				request.WithQueryParameter("RASN", m3RASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CIAD))
				request.WithQueryParameter("CIAD", m3CIAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SADR))
				request.WithQueryParameter("SADR", m3SADR.Trim());
			if (!string.IsNullOrWhiteSpace(m3STWH))
				request.WithQueryParameter("STWH", m3STWH.Trim());

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
		/// Name ConfirmLine
		/// Description Confirms one line in a purchase order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PUNO">Purchase order nubmber(PO number) (Required)</param>
		/// <param name="m3PNLI">Purchase order line number (Required)</param>
		/// <param name="m3PNLS">Purchase order line sub number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LNCD">Language code</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3YRE1">Your reference</param>
		/// <param name="m3SORN">Supplier order number</param>
		/// <param name="m3CODT">Confirmed delivery date</param>
		/// <param name="m3CFQA">Confirmed quantity</param>
		/// <param name="m3CPPR">Confirmed purchase price</param>
		/// <param name="m3CPUC">Confirmed price quantity</param>
		/// <param name="m3CFD1">Confirmed discount 1</param>
		/// <param name="m3CFD2">Confirmed discount 2</param>
		/// <param name="m3CFD3">Confirmed discount 3</param>
		/// <param name="m3ZDI1">*** Not in use *** - Clear discount 1</param>
		/// <param name="m3ZDI2">*** Not in use *** - Clear discount 2</param>
		/// <param name="m3ZDI3">*** Not in use *** - Clear discount 3</param>
		/// <param name="m3PDDT">Deviating confirmed delivery date</param>
		/// <param name="m3PUSL">Lowest status</param>
		/// <param name="m3COLI">*** Not in use *** - Continue line</param>
		/// <param name="m3OEND">Flagged as completed</param>
		/// <param name="m3TIHM">Time hours & minutes</param>
		/// <param name="m3TEDL">Delivery terms</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3HAFE">Harbor or airport</param>
		/// <param name="m3RASN">Rail station</param>
		/// <param name="m3CIAD">Confirmed pickup address</param>
		/// <param name="m3SADR">Supplier´s address reference</param>
		/// <param name="m3STWH">Ship-to warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ConfirmLine(
			string m3PUNO, 
			int m3PNLI, 
			int m3PNLS, 
			int? m3CONO = null, 
			string m3LNCD = null, 
			string m3SUNO = null, 
			string m3YRE1 = null, 
			string m3SORN = null, 
			DateTime? m3CODT = null, 
			decimal? m3CFQA = null, 
			decimal? m3CPPR = null, 
			int? m3CPUC = null, 
			int? m3CFD1 = null, 
			int? m3CFD2 = null, 
			int? m3CFD3 = null, 
			int? m3ZDI1 = null, 
			int? m3ZDI2 = null, 
			int? m3ZDI3 = null, 
			DateTime? m3PDDT = null, 
			string m3PUSL = null, 
			int? m3COLI = null, 
			int? m3OEND = null, 
			int? m3TIHM = null, 
			string m3TEDL = null, 
			string m3MODL = null, 
			string m3HAFE = null, 
			string m3RASN = null, 
			string m3CIAD = null, 
			string m3SADR = null, 
			string m3STWH = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ConfirmLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim())
				.WithQueryParameter("PNLI", m3PNLI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PNLS", m3PNLS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3YRE1))
				request.WithQueryParameter("YRE1", m3YRE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SORN))
				request.WithQueryParameter("SORN", m3SORN.Trim());
			if (m3CODT.HasValue)
				request.WithQueryParameter("CODT", m3CODT.Value.ToM3String());
			if (m3CFQA.HasValue)
				request.WithQueryParameter("CFQA", m3CFQA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPPR.HasValue)
				request.WithQueryParameter("CPPR", m3CPPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPUC.HasValue)
				request.WithQueryParameter("CPUC", m3CPUC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFD1.HasValue)
				request.WithQueryParameter("CFD1", m3CFD1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFD2.HasValue)
				request.WithQueryParameter("CFD2", m3CFD2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFD3.HasValue)
				request.WithQueryParameter("CFD3", m3CFD3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ZDI1.HasValue)
				request.WithQueryParameter("ZDI1", m3ZDI1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ZDI2.HasValue)
				request.WithQueryParameter("ZDI2", m3ZDI2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ZDI3.HasValue)
				request.WithQueryParameter("ZDI3", m3ZDI3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PDDT.HasValue)
				request.WithQueryParameter("PDDT", m3PDDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PUSL))
				request.WithQueryParameter("PUSL", m3PUSL.Trim());
			if (m3COLI.HasValue)
				request.WithQueryParameter("COLI", m3COLI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TIHM.HasValue)
				request.WithQueryParameter("TIHM", m3TIHM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3HAFE))
				request.WithQueryParameter("HAFE", m3HAFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3RASN))
				request.WithQueryParameter("RASN", m3RASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CIAD))
				request.WithQueryParameter("CIAD", m3CIAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SADR))
				request.WithQueryParameter("SADR", m3SADR.Trim());
			if (!string.IsNullOrWhiteSpace(m3STWH))
				request.WithQueryParameter("STWH", m3STWH.Trim());

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
		/// Name FinishMark
		/// Description Marks an order or an order line finished
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="m3CONO">Company number</param>
		/// <param name="m3PNLI">Purchase order line</param>
		/// <param name="m3PNLS">Purchase order subline</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> FinishMark(
			string m3PUNO, 
			int? m3CONO = null, 
			int? m3PNLI = null, 
			int? m3PNLS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/FinishMark",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3PNLI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3PNLS.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetBasicData
		/// Description Get Basic Data from Purchase Order Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PUNO">Purchase Order Number (Required)</param>
		/// <param name="m3CONO">Company number</param>
		/// <param name="m3PNLI">Purchase Order Line Number</param>
		/// <param name="m3PNLS">Purchase Order Line Number Suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicDataResponse></returns>
		/// <exception cref="M3Exception<GetBasicDataResponse>"></exception>
		public async Task<M3Response<GetBasicDataResponse>> GetBasicData(
			string m3PUNO, 
			int? m3CONO = null, 
			int? m3PNLI = null, 
			int? m3PNLS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3PNLI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3PNLS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetBasicDataResponse>(
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
		/// Name GetBasicData2
		/// Description Get Basic Data from Purchase Order Line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PUNO">Purchase Order Number (Required)</param>
		/// <param name="m3PNLI">Purchase Order Line Number (Required)</param>
		/// <param name="m3PNLS">Purchase Order Line Number Suffix (Required)</param>
		/// <param name="m3CONO">Company number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicData2Response></returns>
		/// <exception cref="M3Exception<GetBasicData2Response>"></exception>
		public async Task<M3Response<GetBasicData2Response>> GetBasicData2(
			string m3PUNO, 
			int m3PNLI, 
			int m3PNLS, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBasicData2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim())
				.WithQueryParameter("PNLI", m3PNLI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PNLS", m3PNLS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetBasicData2Response>(
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
		/// Name GetHeadBasic
		/// Description Retrieve Purchase order header basic information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeadBasicResponse></returns>
		/// <exception cref="M3Exception<GetHeadBasicResponse>"></exception>
		public async Task<M3Response<GetHeadBasicResponse>> GetHeadBasic(
			string m3PUNO, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetHeadBasic",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetHeadBasicResponse>(
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
		/// Name GetLine
		/// Description Retrieve Purchase order line information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="m3PNLI">Purchase order line (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PNLS">Purchase order line subnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLineResponse></returns>
		/// <exception cref="M3Exception<GetLineResponse>"></exception>
		public async Task<M3Response<GetLineResponse>> GetLine(
			string m3PUNO, 
			int m3PNLI, 
			int? m3CONO = null, 
			int? m3PNLS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim())
				.WithQueryParameter("PNLI", m3PNLI.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3PNLS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetLineResponse>(
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
		/// Name ListHeadBasic
		/// Description List Purchase order header basic information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PURC">Requisition by (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListHeadBasicResponse></returns>
		/// <exception cref="M3Exception<ListHeadBasicResponse>"></exception>
		public async Task<M3Response<ListHeadBasicResponse>> ListHeadBasic(
			string m3PURC, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ListHeadBasic",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PURC))
				throw new ArgumentNullException(nameof(m3PURC));

			// Set mandatory parameters
			request
				.WithQueryParameter("PURC", m3PURC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ListHeadBasicResponse>(
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
		/// Name LstBasicData
		/// Description List purchase order line basic data
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PUNO">Purchase Order Number (Required)</param>
		/// <param name="m3CONO">Company number</param>
		/// <param name="m3PNLI">Purchase Order Line Number</param>
		/// <param name="m3PNLS">Purchase Order Line Number Suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBasicDataResponse></returns>
		/// <exception cref="M3Exception<LstBasicDataResponse>"></exception>
		public async Task<M3Response<LstBasicDataResponse>> LstBasicData(
			string m3PUNO, 
			int? m3CONO = null, 
			int? m3PNLI = null, 
			int? m3PNLS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstBasicData",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3PNLI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PNLS.HasValue)
				request.WithQueryParameter("PNLS", m3PNLS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstBasicDataResponse>(
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
		/// Name LstLine
		/// Description List Purchase order line information
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3PURC">Requisition by (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PLPN">Order proposal number</param>
		/// <param name="m3PLPS">Sub number - order proposal</param>
		/// <param name="m3PUSL">Lowest status - purchase order</param>
		/// <param name="m3SOPT">Sorting option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLineResponse></returns>
		/// <exception cref="M3Exception<LstLineResponse>"></exception>
		public async Task<M3Response<LstLineResponse>> LstLine(
			string m3WHLO, 
			string m3PURC, 
			int? m3CONO = null, 
			int? m3PLPN = null, 
			string m3PLPS = null, 
			string m3PUSL = null, 
			string m3SOPT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3PURC))
				throw new ArgumentNullException(nameof(m3PURC));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("PURC", m3PURC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLPN.HasValue)
				request.WithQueryParameter("PLPN", m3PLPN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLPS))
				request.WithQueryParameter("PLPS", m3PLPS.Trim());
			if (!string.IsNullOrWhiteSpace(m3PUSL))
				request.WithQueryParameter("PUSL", m3PUSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SOPT))
				request.WithQueryParameter("SOPT", m3SOPT.Trim());

			// Execute the request
			var result = await Execute<LstLineResponse>(
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
		/// Name NotifyAll
		/// Description Notify all lines in a purchase order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SMDT">Carrier departure date</param>
		/// <param name="m3FWRF">Forwarding agent reference</param>
		/// <param name="m3BOLN">Bill of lading</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3CARN">Carrier name</param>
		/// <param name="m3ARDT">Arrival date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> NotifyAll(
			string m3PUNO, 
			int? m3CONO = null, 
			string m3LNCD = null, 
			string m3SUNO = null, 
			DateTime? m3SMDT = null, 
			string m3FWRF = null, 
			string m3BOLN = null, 
			string m3SUDO = null, 
			string m3CARN = null, 
			DateTime? m3ARDT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/NotifyAll",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3SMDT.HasValue)
				request.WithQueryParameter("SMDT", m3SMDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3FWRF))
				request.WithQueryParameter("FWRF", m3FWRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BOLN))
				request.WithQueryParameter("BOLN", m3BOLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CARN))
				request.WithQueryParameter("CARN", m3CARN.Trim());
			if (m3ARDT.HasValue)
				request.WithQueryParameter("ARDT", m3ARDT.Value.ToM3String());

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
		/// Name NotifyDelNot
		/// Description Notify all lines by a delivery note number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUDO">Delivery note number (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3SMDT">Carrier departure date</param>
		/// <param name="m3FWRF">Forwarding agent reference</param>
		/// <param name="m3BOLN">Bill of lading</param>
		/// <param name="m3CARN">Carrier name</param>
		/// <param name="m3ARDT">Arrival date</param>
		/// <param name="m3TIHM">Time hours & minutes</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> NotifyDelNot(
			string m3SUDO, 
			string m3SUNO, 
			int? m3CONO = null, 
			string m3LNCD = null, 
			DateTime? m3SMDT = null, 
			string m3FWRF = null, 
			string m3BOLN = null, 
			string m3CARN = null, 
			DateTime? m3ARDT = null, 
			int? m3TIHM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/NotifyDelNot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUDO))
				throw new ArgumentNullException(nameof(m3SUDO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUDO", m3SUDO.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (m3SMDT.HasValue)
				request.WithQueryParameter("SMDT", m3SMDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3FWRF))
				request.WithQueryParameter("FWRF", m3FWRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BOLN))
				request.WithQueryParameter("BOLN", m3BOLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CARN))
				request.WithQueryParameter("CARN", m3CARN.Trim());
			if (m3ARDT.HasValue)
				request.WithQueryParameter("ARDT", m3ARDT.Value.ToM3String());
			if (m3TIHM.HasValue)
				request.WithQueryParameter("TIHM", m3TIHM.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name NotifyLine
		/// Description Notify one line in a purchase order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PUNO">Purchase order number (Required)</param>
		/// <param name="m3PNLI">Purchase order line (Required)</param>
		/// <param name="m3PNLS">Purchase order line subnumber (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3SMDT">Carrier departure date</param>
		/// <param name="m3TNQA">Transport notified quantity</param>
		/// <param name="m3FWRF">Forwarding agent reference</param>
		/// <param name="m3BOLN">Bill of lading</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3CARN">Carrier name</param>
		/// <param name="m3ARDT">Arrival date</param>
		/// <param name="m3OEND">Flagged as complete</param>
		/// <param name="m3TIHM">Time hours & minutes</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> NotifyLine(
			string m3PUNO, 
			int m3PNLI, 
			int m3PNLS, 
			int? m3CONO = null, 
			string m3LNCD = null, 
			string m3SUNO = null, 
			DateTime? m3SMDT = null, 
			decimal? m3TNQA = null, 
			string m3FWRF = null, 
			string m3BOLN = null, 
			string m3SUDO = null, 
			string m3CARN = null, 
			DateTime? m3ARDT = null, 
			int? m3OEND = null, 
			int? m3TIHM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/NotifyLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PUNO", m3PUNO.Trim())
				.WithQueryParameter("PNLI", m3PNLI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PNLS", m3PNLS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3SMDT.HasValue)
				request.WithQueryParameter("SMDT", m3SMDT.Value.ToM3String());
			if (m3TNQA.HasValue)
				request.WithQueryParameter("TNQA", m3TNQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FWRF))
				request.WithQueryParameter("FWRF", m3FWRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BOLN))
				request.WithQueryParameter("BOLN", m3BOLN.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CARN))
				request.WithQueryParameter("CARN", m3CARN.Trim());
			if (m3ARDT.HasValue)
				request.WithQueryParameter("ARDT", m3ARDT.Value.ToM3String());
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TIHM.HasValue)
				request.WithQueryParameter("TIHM", m3TIHM.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Receipt
		/// Description Goods Receipt
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3TRDT">Transaction Date (Required)</param>
		/// <param name="m3RESP">Responsible (Required)</param>
		/// <param name="m3PUNO">Purchase Order Number (Required)</param>
		/// <param name="m3PNLI">Purchase Order Number Line (Required)</param>
		/// <param name="m3PNLS">Purchase Order Number Subline (Required)</param>
		/// <param name="m3RVQA">Received quantity (Required)</param>
		/// <param name="m3CONO">Company No</param>
		/// <param name="m3OEND">Finish Mark</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3BANO">Lot Number</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3WHLO">Ware House Stock Location</param>
		/// <param name="m3SUDO">Delivery note number</param>
		/// <param name="m3BREF">Lot reference 1</param>
		/// <param name="m3BRE2">Lot reference 2</param>
		/// <param name="m3NOPK">Number of package</param>
		/// <param name="m3CAWE">Catch weight</param>
		/// <param name="m3PRDT">Manufacturing date</param>
		/// <param name="m3BREM">Remark</param>
		/// <param name="m3AT01">Attribute identity 1</param>
		/// <param name="m3AV01">Attribute value 1</param>
		/// <param name="m3AT02">Attribute identity 2</param>
		/// <param name="m3AV02">Attribute value 2</param>
		/// <param name="m3AT03">Attribute identity 3</param>
		/// <param name="m3AV03">Attribute value 3</param>
		/// <param name="m3AT04">Attribute identity 4</param>
		/// <param name="m3AV04">Attribute value 4</param>
		/// <param name="m3AT05">Attribute identity 5</param>
		/// <param name="m3AV05">Attribute value 5</param>
		/// <param name="m3AT06">Attribute identity 6</param>
		/// <param name="m3AV06">Attribute value 6</param>
		/// <param name="m3AT07">Attribute identity 7</param>
		/// <param name="m3AV07">Attribute value 7</param>
		/// <param name="m3AT08">Attribute identity 8</param>
		/// <param name="m3AV08">Attribute value 8</param>
		/// <param name="m3AT09">Attribute identity 9</param>
		/// <param name="m3AV09">Attribute value 9</param>
		/// <param name="m3AT10">Attribute identity 10</param>
		/// <param name="m3AV10">Attribute value 10</param>
		/// <param name="m3POCY">Normal potency</param>
		/// <param name="m3TRTM">Transaction time</param>
		/// <param name="m3UTCM">UTC mode</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Receipt(
			DateTime m3TRDT, 
			string m3RESP, 
			string m3PUNO, 
			int m3PNLI, 
			int m3PNLS, 
			decimal m3RVQA, 
			int? m3CONO = null, 
			int? m3OEND = null, 
			string m3WHSL = null, 
			string m3BANO = null, 
			string m3CAMU = null, 
			string m3WHLO = null, 
			string m3SUDO = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			int? m3NOPK = null, 
			decimal? m3CAWE = null, 
			DateTime? m3PRDT = null, 
			string m3BREM = null, 
			string m3AT01 = null, 
			string m3AV01 = null, 
			string m3AT02 = null, 
			string m3AV02 = null, 
			string m3AT03 = null, 
			string m3AV03 = null, 
			string m3AT04 = null, 
			string m3AV04 = null, 
			string m3AT05 = null, 
			string m3AV05 = null, 
			string m3AT06 = null, 
			string m3AV06 = null, 
			string m3AT07 = null, 
			string m3AV07 = null, 
			string m3AT08 = null, 
			string m3AV08 = null, 
			string m3AT09 = null, 
			string m3AV09 = null, 
			string m3AT10 = null, 
			string m3AV10 = null, 
			int? m3POCY = null, 
			int? m3TRTM = null, 
			int? m3UTCM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Receipt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RESP))
				throw new ArgumentNullException(nameof(m3RESP));
			if (string.IsNullOrWhiteSpace(m3PUNO))
				throw new ArgumentNullException(nameof(m3PUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("TRDT", m3TRDT.ToM3String())
				.WithQueryParameter("RESP", m3RESP.Trim())
				.WithQueryParameter("PUNO", m3PUNO.Trim())
				.WithQueryParameter("PNLI", m3PNLI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PNLS", m3PNLS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RVQA", m3RVQA.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OEND.HasValue)
				request.WithQueryParameter("OEND", m3OEND.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUDO))
				request.WithQueryParameter("SUDO", m3SUDO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (m3NOPK.HasValue)
				request.WithQueryParameter("NOPK", m3NOPK.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CAWE.HasValue)
				request.WithQueryParameter("CAWE", m3CAWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3BREM))
				request.WithQueryParameter("BREM", m3BREM.Trim());
			if (!string.IsNullOrWhiteSpace(m3AT01))
				request.WithQueryParameter("AT01", m3AT01.Trim());
			if (!string.IsNullOrWhiteSpace(m3AV01))
				request.WithQueryParameter("AV01", m3AV01.Trim());
			if (!string.IsNullOrWhiteSpace(m3AT02))
				request.WithQueryParameter("AT02", m3AT02.Trim());
			if (!string.IsNullOrWhiteSpace(m3AV02))
				request.WithQueryParameter("AV02", m3AV02.Trim());
			if (!string.IsNullOrWhiteSpace(m3AT03))
				request.WithQueryParameter("AT03", m3AT03.Trim());
			if (!string.IsNullOrWhiteSpace(m3AV03))
				request.WithQueryParameter("AV03", m3AV03.Trim());
			if (!string.IsNullOrWhiteSpace(m3AT04))
				request.WithQueryParameter("AT04", m3AT04.Trim());
			if (!string.IsNullOrWhiteSpace(m3AV04))
				request.WithQueryParameter("AV04", m3AV04.Trim());
			if (!string.IsNullOrWhiteSpace(m3AT05))
				request.WithQueryParameter("AT05", m3AT05.Trim());
			if (!string.IsNullOrWhiteSpace(m3AV05))
				request.WithQueryParameter("AV05", m3AV05.Trim());
			if (!string.IsNullOrWhiteSpace(m3AT06))
				request.WithQueryParameter("AT06", m3AT06.Trim());
			if (!string.IsNullOrWhiteSpace(m3AV06))
				request.WithQueryParameter("AV06", m3AV06.Trim());
			if (!string.IsNullOrWhiteSpace(m3AT07))
				request.WithQueryParameter("AT07", m3AT07.Trim());
			if (!string.IsNullOrWhiteSpace(m3AV07))
				request.WithQueryParameter("AV07", m3AV07.Trim());
			if (!string.IsNullOrWhiteSpace(m3AT08))
				request.WithQueryParameter("AT08", m3AT08.Trim());
			if (!string.IsNullOrWhiteSpace(m3AV08))
				request.WithQueryParameter("AV08", m3AV08.Trim());
			if (!string.IsNullOrWhiteSpace(m3AT09))
				request.WithQueryParameter("AT09", m3AT09.Trim());
			if (!string.IsNullOrWhiteSpace(m3AV09))
				request.WithQueryParameter("AV09", m3AV09.Trim());
			if (!string.IsNullOrWhiteSpace(m3AT10))
				request.WithQueryParameter("AT10", m3AT10.Trim());
			if (!string.IsNullOrWhiteSpace(m3AV10))
				request.WithQueryParameter("AV10", m3AV10.Trim());
			if (m3POCY.HasValue)
				request.WithQueryParameter("POCY", m3POCY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRTM.HasValue)
				request.WithQueryParameter("TRTM", m3TRTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UTCM.HasValue)
				request.WithQueryParameter("UTCM", m3UTCM.Value.ToString(CultureInfo.CurrentCulture));

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
