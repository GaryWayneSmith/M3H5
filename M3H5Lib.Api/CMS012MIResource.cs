/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
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
	/// Name: CMS012MI
	/// Component Name: InfoBrowser
	/// Description: Api: Information browser cat - virtual fields
	/// Version Release: 5ea1
	///</summary>
	public partial class CMS012MIResource : M3BaseResourceEndpoint
	{
		public CMS012MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS012MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddCalcVal
		/// Description Add value calculated by formula
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3IBCA">Information browser category (Required)</param>
		/// <param name="m3VIFL">Virtual field (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="m3CASQ">Calculation sequence</param>
		/// <param name="m3FLDT">Field type</param>
		/// <param name="m3FLDB">Field length</param>
		/// <param name="m3FLDP">Number of decimal places</param>
		/// <param name="m3FDCA">Field information code</param>
		/// <param name="m3OP01">Operand</param>
		/// <param name="m3OP02">Operand</param>
		/// <param name="m3OP03">Operand</param>
		/// <param name="m3OP04">Operand</param>
		/// <param name="m3OP05">Operand</param>
		/// <param name="m3OP06">Operand</param>
		/// <param name="m3OP07">Operand</param>
		/// <param name="m3OP08">Operand</param>
		/// <param name="m3OP09">Operand</param>
		/// <param name="m3OP10">Operand</param>
		/// <param name="m3OB01">Field</param>
		/// <param name="m3OB02">Field</param>
		/// <param name="m3OB03">Field</param>
		/// <param name="m3OB04">Field</param>
		/// <param name="m3OB05">Field</param>
		/// <param name="m3OB06">Field</param>
		/// <param name="m3OB07">Field</param>
		/// <param name="m3OB08">Field</param>
		/// <param name="m3OB09">Field</param>
		/// <param name="m3OB10">Field</param>
		/// <param name="m3FA01">Factor</param>
		/// <param name="m3FA02">Factor</param>
		/// <param name="m3FA03">Factor</param>
		/// <param name="m3FA04">Factor</param>
		/// <param name="m3FA05">Factor</param>
		/// <param name="m3FA06">Factor</param>
		/// <param name="m3FA07">Factor</param>
		/// <param name="m3FA08">Factor</param>
		/// <param name="m3FA09">Factor</param>
		/// <param name="m3FA10">Factor</param>
		/// <param name="m3RPBK">XML section</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCalcVal(
			string m3IBCA, 
			string m3VIFL, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3MSID = null, 
			int? m3CASQ = null, 
			string m3FLDT = null, 
			int? m3FLDB = null, 
			int? m3FLDP = null, 
			string m3FDCA = null, 
			string m3OP01 = null, 
			string m3OP02 = null, 
			string m3OP03 = null, 
			string m3OP04 = null, 
			string m3OP05 = null, 
			string m3OP06 = null, 
			string m3OP07 = null, 
			string m3OP08 = null, 
			string m3OP09 = null, 
			string m3OP10 = null, 
			string m3OB01 = null, 
			string m3OB02 = null, 
			string m3OB03 = null, 
			string m3OB04 = null, 
			string m3OB05 = null, 
			string m3OB06 = null, 
			string m3OB07 = null, 
			string m3OB08 = null, 
			string m3OB09 = null, 
			string m3OB10 = null, 
			decimal? m3FA01 = null, 
			decimal? m3FA02 = null, 
			decimal? m3FA03 = null, 
			decimal? m3FA04 = null, 
			decimal? m3FA05 = null, 
			decimal? m3FA06 = null, 
			decimal? m3FA07 = null, 
			decimal? m3FA08 = null, 
			decimal? m3FA09 = null, 
			decimal? m3FA10 = null, 
			int? m3RPBK = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddCalcVal",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IBCA))
				throw new ArgumentNullException(nameof(m3IBCA));
			if (string.IsNullOrWhiteSpace(m3VIFL))
				throw new ArgumentNullException(nameof(m3VIFL));

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3IBCA.Trim())
				.WithQueryParameter("VIFL", m3VIFL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());
			if (m3CASQ.HasValue)
				request.WithQueryParameter("CASQ", m3CASQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FLDT))
				request.WithQueryParameter("FLDT", m3FLDT.Trim());
			if (m3FLDB.HasValue)
				request.WithQueryParameter("FLDB", m3FLDB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLDP.HasValue)
				request.WithQueryParameter("FLDP", m3FLDP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FDCA))
				request.WithQueryParameter("FDCA", m3FDCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3OP01))
				request.WithQueryParameter("OP01", m3OP01.Trim());
			if (!string.IsNullOrWhiteSpace(m3OP02))
				request.WithQueryParameter("OP02", m3OP02.Trim());
			if (!string.IsNullOrWhiteSpace(m3OP03))
				request.WithQueryParameter("OP03", m3OP03.Trim());
			if (!string.IsNullOrWhiteSpace(m3OP04))
				request.WithQueryParameter("OP04", m3OP04.Trim());
			if (!string.IsNullOrWhiteSpace(m3OP05))
				request.WithQueryParameter("OP05", m3OP05.Trim());
			if (!string.IsNullOrWhiteSpace(m3OP06))
				request.WithQueryParameter("OP06", m3OP06.Trim());
			if (!string.IsNullOrWhiteSpace(m3OP07))
				request.WithQueryParameter("OP07", m3OP07.Trim());
			if (!string.IsNullOrWhiteSpace(m3OP08))
				request.WithQueryParameter("OP08", m3OP08.Trim());
			if (!string.IsNullOrWhiteSpace(m3OP09))
				request.WithQueryParameter("OP09", m3OP09.Trim());
			if (!string.IsNullOrWhiteSpace(m3OP10))
				request.WithQueryParameter("OP10", m3OP10.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB01))
				request.WithQueryParameter("OB01", m3OB01.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB02))
				request.WithQueryParameter("OB02", m3OB02.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB03))
				request.WithQueryParameter("OB03", m3OB03.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB04))
				request.WithQueryParameter("OB04", m3OB04.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB05))
				request.WithQueryParameter("OB05", m3OB05.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB06))
				request.WithQueryParameter("OB06", m3OB06.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB07))
				request.WithQueryParameter("OB07", m3OB07.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB08))
				request.WithQueryParameter("OB08", m3OB08.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB09))
				request.WithQueryParameter("OB09", m3OB09.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB10))
				request.WithQueryParameter("OB10", m3OB10.Trim());
			if (m3FA01.HasValue)
				request.WithQueryParameter("FA01", m3FA01.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FA02.HasValue)
				request.WithQueryParameter("FA02", m3FA02.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FA03.HasValue)
				request.WithQueryParameter("FA03", m3FA03.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FA04.HasValue)
				request.WithQueryParameter("FA04", m3FA04.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FA05.HasValue)
				request.WithQueryParameter("FA05", m3FA05.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FA06.HasValue)
				request.WithQueryParameter("FA06", m3FA06.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FA07.HasValue)
				request.WithQueryParameter("FA07", m3FA07.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FA08.HasValue)
				request.WithQueryParameter("FA08", m3FA08.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FA09.HasValue)
				request.WithQueryParameter("FA09", m3FA09.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FA10.HasValue)
				request.WithQueryParameter("FA10", m3FA10.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3RPBK.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddCurrConv
		/// Description Add value from a currency conversion
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3IBCA">Information browser category (Required)</param>
		/// <param name="m3VIFL">Virtual field (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="m3CASQ">Calculation sequence</param>
		/// <param name="m3FLDT">Field type</param>
		/// <param name="m3FLDB">Field length</param>
		/// <param name="m3FLDP">Number of decimal places</param>
		/// <param name="m3FDCA">Field information code</param>
		/// <param name="m3RO01">Read option</param>
		/// <param name="m3RO02">Read option</param>
		/// <param name="m3RO03">Read option</param>
		/// <param name="m3RO04">Read option</param>
		/// <param name="m3RO05">Read option</param>
		/// <param name="m3OB01">Field</param>
		/// <param name="m3OB02">Field</param>
		/// <param name="m3OB03">Field</param>
		/// <param name="m3OB04">Field</param>
		/// <param name="m3OB05">Field</param>
		/// <param name="m3OB06">Field</param>
		/// <param name="m3VAL1">Value field</param>
		/// <param name="m3VAL2">Value field</param>
		/// <param name="m3VAL3">Value field</param>
		/// <param name="m3VAL4">Value field</param>
		/// <param name="m3VAL5">Value field</param>
		/// <param name="m3BADT">Base date</param>
		/// <param name="m3CALD">Calculation date</param>
		/// <param name="m3RPBK">XML section</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCurrConv(
			string m3IBCA, 
			string m3VIFL, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3MSID = null, 
			int? m3CASQ = null, 
			string m3FLDT = null, 
			int? m3FLDB = null, 
			int? m3FLDP = null, 
			string m3FDCA = null, 
			int? m3RO01 = null, 
			int? m3RO02 = null, 
			int? m3RO03 = null, 
			int? m3RO04 = null, 
			int? m3RO05 = null, 
			string m3OB01 = null, 
			string m3OB02 = null, 
			string m3OB03 = null, 
			string m3OB04 = null, 
			string m3OB05 = null, 
			string m3OB06 = null, 
			string m3VAL1 = null, 
			string m3VAL2 = null, 
			string m3VAL3 = null, 
			string m3VAL4 = null, 
			string m3VAL5 = null, 
			DateTime? m3BADT = null, 
			DateTime? m3CALD = null, 
			int? m3RPBK = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddCurrConv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IBCA))
				throw new ArgumentNullException(nameof(m3IBCA));
			if (string.IsNullOrWhiteSpace(m3VIFL))
				throw new ArgumentNullException(nameof(m3VIFL));

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3IBCA.Trim())
				.WithQueryParameter("VIFL", m3VIFL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());
			if (m3CASQ.HasValue)
				request.WithQueryParameter("CASQ", m3CASQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FLDT))
				request.WithQueryParameter("FLDT", m3FLDT.Trim());
			if (m3FLDB.HasValue)
				request.WithQueryParameter("FLDB", m3FLDB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLDP.HasValue)
				request.WithQueryParameter("FLDP", m3FLDP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FDCA))
				request.WithQueryParameter("FDCA", m3FDCA.Trim());
			if (m3RO01.HasValue)
				request.WithQueryParameter("RO01", m3RO01.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO02.HasValue)
				request.WithQueryParameter("RO02", m3RO02.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO03.HasValue)
				request.WithQueryParameter("RO03", m3RO03.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO04.HasValue)
				request.WithQueryParameter("RO04", m3RO04.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO05.HasValue)
				request.WithQueryParameter("RO05", m3RO05.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OB01))
				request.WithQueryParameter("OB01", m3OB01.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB02))
				request.WithQueryParameter("OB02", m3OB02.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB03))
				request.WithQueryParameter("OB03", m3OB03.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB04))
				request.WithQueryParameter("OB04", m3OB04.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB05))
				request.WithQueryParameter("OB05", m3OB05.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB06))
				request.WithQueryParameter("OB06", m3OB06.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL1))
				request.WithQueryParameter("VAL1", m3VAL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL2))
				request.WithQueryParameter("VAL2", m3VAL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL3))
				request.WithQueryParameter("VAL3", m3VAL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL4))
				request.WithQueryParameter("VAL4", m3VAL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL5))
				request.WithQueryParameter("VAL5", m3VAL5.Trim());
			if (m3BADT.HasValue)
				request.WithQueryParameter("BADT", m3BADT.Value.ToM3String());
			if (m3CALD.HasValue)
				request.WithQueryParameter("CALD", m3CALD.Value.ToM3String());
			if (m3RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3RPBK.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddDate
		/// Description Add date field
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3IBCA">Information browser category (Required)</param>
		/// <param name="m3VIFL">Virtual field (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="m3CASQ">Calculation sequence</param>
		/// <param name="m3FLDT">Field type</param>
		/// <param name="m3FLDB">Field length</param>
		/// <param name="m3FLDP">Number of decimal places</param>
		/// <param name="m3BADT">Base date</param>
		/// <param name="m3DAYA">Day adjustment</param>
		/// <param name="m3DTOU">Date output</param>
		/// <param name="m3OB01">Field</param>
		/// <param name="m3CALD">Calculation date</param>
		/// <param name="m3RPBK">XML section</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDate(
			string m3IBCA, 
			string m3VIFL, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3MSID = null, 
			int? m3CASQ = null, 
			string m3FLDT = null, 
			int? m3FLDB = null, 
			int? m3FLDP = null, 
			DateTime? m3BADT = null, 
			int? m3DAYA = null, 
			int? m3DTOU = null, 
			string m3OB01 = null, 
			DateTime? m3CALD = null, 
			int? m3RPBK = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddDate",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IBCA))
				throw new ArgumentNullException(nameof(m3IBCA));
			if (string.IsNullOrWhiteSpace(m3VIFL))
				throw new ArgumentNullException(nameof(m3VIFL));

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3IBCA.Trim())
				.WithQueryParameter("VIFL", m3VIFL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());
			if (m3CASQ.HasValue)
				request.WithQueryParameter("CASQ", m3CASQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FLDT))
				request.WithQueryParameter("FLDT", m3FLDT.Trim());
			if (m3FLDB.HasValue)
				request.WithQueryParameter("FLDB", m3FLDB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLDP.HasValue)
				request.WithQueryParameter("FLDP", m3FLDP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BADT.HasValue)
				request.WithQueryParameter("BADT", m3BADT.Value.ToM3String());
			if (m3DAYA.HasValue)
				request.WithQueryParameter("DAYA", m3DAYA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTOU.HasValue)
				request.WithQueryParameter("DTOU", m3DTOU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OB01))
				request.WithQueryParameter("OB01", m3OB01.Trim());
			if (m3CALD.HasValue)
				request.WithQueryParameter("CALD", m3CALD.Value.ToM3String());
			if (m3RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3RPBK.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddLogicFormula
		/// Description Add value from a logic formula
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3IBCA">Information browser category (Required)</param>
		/// <param name="m3VIFL">Virtual field (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="m3CASQ">Calculation sequence</param>
		/// <param name="m3FLDT">Field type</param>
		/// <param name="m3FLDB">Field length</param>
		/// <param name="m3LOT1">Logical type</param>
		/// <param name="m3LOT2">Logical type</param>
		/// <param name="m3LOT3">Logical type</param>
		/// <param name="m3ADO1">And/or</param>
		/// <param name="m3ADO2">And/or</param>
		/// <param name="m3OB01">Field</param>
		/// <param name="m3OB02">Field</param>
		/// <param name="m3OB03">Field</param>
		/// <param name="m3OB04">Field</param>
		/// <param name="m3OB05">Field</param>
		/// <param name="m3OB06">Field</param>
		/// <param name="m3OB07">Field</param>
		/// <param name="m3OB08">Field</param>
		/// <param name="m3COD1">Condition</param>
		/// <param name="m3COD2">Condition</param>
		/// <param name="m3COD3">Condition</param>
		/// <param name="m3OPR1">Operand</param>
		/// <param name="m3OPR2">Operand</param>
		/// <param name="m3OPR3">Operand</param>
		/// <param name="m3VAL1">Value field</param>
		/// <param name="m3VAL2">Value field</param>
		/// <param name="m3VAL3">Value field</param>
		/// <param name="m3VAL4">Value field</param>
		/// <param name="m3VAL5">Value field</param>
		/// <param name="m3VTRU">Value if true</param>
		/// <param name="m3VFAL">Value if false</param>
		/// <param name="m3RPBK">XML section</param>
		/// <param name="m3FLDP">Number of decimal places</param>
		/// <param name="m3FDCA">Field information code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLogicFormula(
			string m3IBCA, 
			string m3VIFL, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3MSID = null, 
			int? m3CASQ = null, 
			string m3FLDT = null, 
			int? m3FLDB = null, 
			string m3LOT1 = null, 
			string m3LOT2 = null, 
			string m3LOT3 = null, 
			int? m3ADO1 = null, 
			int? m3ADO2 = null, 
			string m3OB01 = null, 
			string m3OB02 = null, 
			string m3OB03 = null, 
			string m3OB04 = null, 
			string m3OB05 = null, 
			string m3OB06 = null, 
			string m3OB07 = null, 
			string m3OB08 = null, 
			int? m3COD1 = null, 
			int? m3COD2 = null, 
			int? m3COD3 = null, 
			int? m3OPR1 = null, 
			int? m3OPR2 = null, 
			int? m3OPR3 = null, 
			string m3VAL1 = null, 
			string m3VAL2 = null, 
			string m3VAL3 = null, 
			string m3VAL4 = null, 
			string m3VAL5 = null, 
			int? m3VTRU = null, 
			int? m3VFAL = null, 
			int? m3RPBK = null, 
			int? m3FLDP = null, 
			string m3FDCA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddLogicFormula",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IBCA))
				throw new ArgumentNullException(nameof(m3IBCA));
			if (string.IsNullOrWhiteSpace(m3VIFL))
				throw new ArgumentNullException(nameof(m3VIFL));

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3IBCA.Trim())
				.WithQueryParameter("VIFL", m3VIFL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());
			if (m3CASQ.HasValue)
				request.WithQueryParameter("CASQ", m3CASQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FLDT))
				request.WithQueryParameter("FLDT", m3FLDT.Trim());
			if (m3FLDB.HasValue)
				request.WithQueryParameter("FLDB", m3FLDB.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LOT1))
				request.WithQueryParameter("LOT1", m3LOT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3LOT2))
				request.WithQueryParameter("LOT2", m3LOT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3LOT3))
				request.WithQueryParameter("LOT3", m3LOT3.Trim());
			if (m3ADO1.HasValue)
				request.WithQueryParameter("ADO1", m3ADO1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADO2.HasValue)
				request.WithQueryParameter("ADO2", m3ADO2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OB01))
				request.WithQueryParameter("OB01", m3OB01.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB02))
				request.WithQueryParameter("OB02", m3OB02.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB03))
				request.WithQueryParameter("OB03", m3OB03.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB04))
				request.WithQueryParameter("OB04", m3OB04.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB05))
				request.WithQueryParameter("OB05", m3OB05.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB06))
				request.WithQueryParameter("OB06", m3OB06.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB07))
				request.WithQueryParameter("OB07", m3OB07.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB08))
				request.WithQueryParameter("OB08", m3OB08.Trim());
			if (m3COD1.HasValue)
				request.WithQueryParameter("COD1", m3COD1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COD2.HasValue)
				request.WithQueryParameter("COD2", m3COD2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3COD3.HasValue)
				request.WithQueryParameter("COD3", m3COD3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPR1.HasValue)
				request.WithQueryParameter("OPR1", m3OPR1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPR2.HasValue)
				request.WithQueryParameter("OPR2", m3OPR2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPR3.HasValue)
				request.WithQueryParameter("OPR3", m3OPR3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3VAL1))
				request.WithQueryParameter("VAL1", m3VAL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL2))
				request.WithQueryParameter("VAL2", m3VAL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL3))
				request.WithQueryParameter("VAL3", m3VAL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL4))
				request.WithQueryParameter("VAL4", m3VAL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL5))
				request.WithQueryParameter("VAL5", m3VAL5.Trim());
			if (m3VTRU.HasValue)
				request.WithQueryParameter("VTRU", m3VTRU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VFAL.HasValue)
				request.WithQueryParameter("VFAL", m3VFAL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3RPBK.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLDP.HasValue)
				request.WithQueryParameter("FLDP", m3FLDP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FDCA))
				request.WithQueryParameter("FDCA", m3FDCA.Trim());

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
		/// Name AddPreDefined
		/// Description Add value retrieved by a function program
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3IBCA">Information browser category (Required)</param>
		/// <param name="m3VIFL">Virtual field (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="m3CASQ">Calculation sequence</param>
		/// <param name="m3FLDT">Field type</param>
		/// <param name="m3FLDB">Field length</param>
		/// <param name="m3VIPD">Pre-defined value</param>
		/// <param name="m3RPBK">XML section</param>
		/// <param name="m3FLDP">Number of decimal places</param>
		/// <param name="m3FDCA">Field information code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPreDefined(
			string m3IBCA, 
			string m3VIFL, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3MSID = null, 
			int? m3CASQ = null, 
			string m3FLDT = null, 
			int? m3FLDB = null, 
			int? m3VIPD = null, 
			int? m3RPBK = null, 
			int? m3FLDP = null, 
			string m3FDCA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPreDefined",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IBCA))
				throw new ArgumentNullException(nameof(m3IBCA));
			if (string.IsNullOrWhiteSpace(m3VIFL))
				throw new ArgumentNullException(nameof(m3VIFL));

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3IBCA.Trim())
				.WithQueryParameter("VIFL", m3VIFL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());
			if (m3CASQ.HasValue)
				request.WithQueryParameter("CASQ", m3CASQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FLDT))
				request.WithQueryParameter("FLDT", m3FLDT.Trim());
			if (m3FLDB.HasValue)
				request.WithQueryParameter("FLDB", m3FLDB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VIPD.HasValue)
				request.WithQueryParameter("VIPD", m3VIPD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3RPBK.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLDP.HasValue)
				request.WithQueryParameter("FLDP", m3FLDP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FDCA))
				request.WithQueryParameter("FDCA", m3FDCA.Trim());

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
		/// Name AddTX15FrCSYTAB
		/// Description Add value from name field in CSYTAB
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3IBCA">Information browser category (Required)</param>
		/// <param name="m3VIFL">Virtual field (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="m3CASQ">Calculation sequence</param>
		/// <param name="m3KEY1">Key field</param>
		/// <param name="m3KEY2">Key field</param>
		/// <param name="m3KEY3">Key field</param>
		/// <param name="m3KEY4">Key field</param>
		/// <param name="m3KEY5">Key field</param>
		/// <param name="m3RO01">Read option</param>
		/// <param name="m3RO02">Read option</param>
		/// <param name="m3RO03">Read option</param>
		/// <param name="m3RO04">Read option</param>
		/// <param name="m3RO05">Read option</param>
		/// <param name="m3OB01">Field</param>
		/// <param name="m3OB02">Field</param>
		/// <param name="m3OB03">Field</param>
		/// <param name="m3OB04">Field</param>
		/// <param name="m3OB05">Field</param>
		/// <param name="m3VAL1">Value field</param>
		/// <param name="m3VAL2">Value field</param>
		/// <param name="m3VAL3">Value field</param>
		/// <param name="m3VAL4">Value field</param>
		/// <param name="m3VAL5">Value field</param>
		/// <param name="m3RPBK">XML section</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTX15FrCSYTAB(
			string m3IBCA, 
			string m3VIFL, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3MSID = null, 
			int? m3CASQ = null, 
			string m3KEY1 = null, 
			string m3KEY2 = null, 
			string m3KEY3 = null, 
			string m3KEY4 = null, 
			string m3KEY5 = null, 
			int? m3RO01 = null, 
			int? m3RO02 = null, 
			int? m3RO03 = null, 
			int? m3RO04 = null, 
			int? m3RO05 = null, 
			string m3OB01 = null, 
			string m3OB02 = null, 
			string m3OB03 = null, 
			string m3OB04 = null, 
			string m3OB05 = null, 
			string m3VAL1 = null, 
			string m3VAL2 = null, 
			string m3VAL3 = null, 
			string m3VAL4 = null, 
			string m3VAL5 = null, 
			int? m3RPBK = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddTX15FrCSYTAB",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IBCA))
				throw new ArgumentNullException(nameof(m3IBCA));
			if (string.IsNullOrWhiteSpace(m3VIFL))
				throw new ArgumentNullException(nameof(m3VIFL));

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3IBCA.Trim())
				.WithQueryParameter("VIFL", m3VIFL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());
			if (m3CASQ.HasValue)
				request.WithQueryParameter("CASQ", m3CASQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3KEY1))
				request.WithQueryParameter("KEY1", m3KEY1.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY2))
				request.WithQueryParameter("KEY2", m3KEY2.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY3))
				request.WithQueryParameter("KEY3", m3KEY3.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY4))
				request.WithQueryParameter("KEY4", m3KEY4.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY5))
				request.WithQueryParameter("KEY5", m3KEY5.Trim());
			if (m3RO01.HasValue)
				request.WithQueryParameter("RO01", m3RO01.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO02.HasValue)
				request.WithQueryParameter("RO02", m3RO02.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO03.HasValue)
				request.WithQueryParameter("RO03", m3RO03.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO04.HasValue)
				request.WithQueryParameter("RO04", m3RO04.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO05.HasValue)
				request.WithQueryParameter("RO05", m3RO05.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OB01))
				request.WithQueryParameter("OB01", m3OB01.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB02))
				request.WithQueryParameter("OB02", m3OB02.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB03))
				request.WithQueryParameter("OB03", m3OB03.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB04))
				request.WithQueryParameter("OB04", m3OB04.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB05))
				request.WithQueryParameter("OB05", m3OB05.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL1))
				request.WithQueryParameter("VAL1", m3VAL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL2))
				request.WithQueryParameter("VAL2", m3VAL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL3))
				request.WithQueryParameter("VAL3", m3VAL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL4))
				request.WithQueryParameter("VAL4", m3VAL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL5))
				request.WithQueryParameter("VAL5", m3VAL5.Trim());
			if (m3RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3RPBK.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddTX40FrCSYTAB
		/// Description Add value from description field in CSYTAB
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3IBCA">Information browser category (Required)</param>
		/// <param name="m3VIFL">Virtual field (Required)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="m3CASQ">Calculation sequence</param>
		/// <param name="m3KEY1">Key field</param>
		/// <param name="m3KEY2">Key field</param>
		/// <param name="m3KEY3">Key field</param>
		/// <param name="m3KEY4">Key field</param>
		/// <param name="m3KEY5">Key field</param>
		/// <param name="m3RO01">Read option</param>
		/// <param name="m3RO02">Read option</param>
		/// <param name="m3RO03">Read option</param>
		/// <param name="m3RO04">Read option</param>
		/// <param name="m3RO05">Read option</param>
		/// <param name="m3OB01">Field</param>
		/// <param name="m3OB02">Field</param>
		/// <param name="m3OB03">Field</param>
		/// <param name="m3OB04">Field</param>
		/// <param name="m3OB05">Field</param>
		/// <param name="m3VAL1">Value field</param>
		/// <param name="m3VAL2">Value field</param>
		/// <param name="m3VAL3">Value field</param>
		/// <param name="m3VAL4">Value field</param>
		/// <param name="m3VAL5">Value field</param>
		/// <param name="m3RPBK">XML section</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddTX40FrCSYTAB(
			string m3IBCA, 
			string m3VIFL, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3MSID = null, 
			int? m3CASQ = null, 
			string m3KEY1 = null, 
			string m3KEY2 = null, 
			string m3KEY3 = null, 
			string m3KEY4 = null, 
			string m3KEY5 = null, 
			int? m3RO01 = null, 
			int? m3RO02 = null, 
			int? m3RO03 = null, 
			int? m3RO04 = null, 
			int? m3RO05 = null, 
			string m3OB01 = null, 
			string m3OB02 = null, 
			string m3OB03 = null, 
			string m3OB04 = null, 
			string m3OB05 = null, 
			string m3VAL1 = null, 
			string m3VAL2 = null, 
			string m3VAL3 = null, 
			string m3VAL4 = null, 
			string m3VAL5 = null, 
			int? m3RPBK = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddTX40FrCSYTAB",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IBCA))
				throw new ArgumentNullException(nameof(m3IBCA));
			if (string.IsNullOrWhiteSpace(m3VIFL))
				throw new ArgumentNullException(nameof(m3VIFL));

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3IBCA.Trim())
				.WithQueryParameter("VIFL", m3VIFL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());
			if (m3CASQ.HasValue)
				request.WithQueryParameter("CASQ", m3CASQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3KEY1))
				request.WithQueryParameter("KEY1", m3KEY1.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY2))
				request.WithQueryParameter("KEY2", m3KEY2.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY3))
				request.WithQueryParameter("KEY3", m3KEY3.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY4))
				request.WithQueryParameter("KEY4", m3KEY4.Trim());
			if (!string.IsNullOrWhiteSpace(m3KEY5))
				request.WithQueryParameter("KEY5", m3KEY5.Trim());
			if (m3RO01.HasValue)
				request.WithQueryParameter("RO01", m3RO01.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO02.HasValue)
				request.WithQueryParameter("RO02", m3RO02.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO03.HasValue)
				request.WithQueryParameter("RO03", m3RO03.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO04.HasValue)
				request.WithQueryParameter("RO04", m3RO04.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO05.HasValue)
				request.WithQueryParameter("RO05", m3RO05.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OB01))
				request.WithQueryParameter("OB01", m3OB01.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB02))
				request.WithQueryParameter("OB02", m3OB02.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB03))
				request.WithQueryParameter("OB03", m3OB03.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB04))
				request.WithQueryParameter("OB04", m3OB04.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB05))
				request.WithQueryParameter("OB05", m3OB05.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL1))
				request.WithQueryParameter("VAL1", m3VAL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL2))
				request.WithQueryParameter("VAL2", m3VAL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL3))
				request.WithQueryParameter("VAL3", m3VAL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL4))
				request.WithQueryParameter("VAL4", m3VAL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL5))
				request.WithQueryParameter("VAL5", m3VAL5.Trim());
			if (m3RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3RPBK.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelVirtualField
		/// Description Delete virtual field
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3IBCA">Information browser category (Required)</param>
		/// <param name="m3VIFL">Virtual field (Required)</param>
		/// <param name="m3RPBK">XML section</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelVirtualField(
			string m3IBCA, 
			string m3VIFL, 
			int? m3RPBK = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelVirtualField",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IBCA))
				throw new ArgumentNullException(nameof(m3IBCA));
			if (string.IsNullOrWhiteSpace(m3VIFL))
				throw new ArgumentNullException(nameof(m3VIFL));

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3IBCA.Trim())
				.WithQueryParameter("VIFL", m3VIFL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3RPBK.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name MergeData
		/// Description Add  Merge Data information
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3IBCA">Information browser category</param>
		/// <param name="m3VIFL">Virtual field</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3MSID">Message ID</param>
		/// <param name="m3CASQ">Calculation sequence</param>
		/// <param name="m3FLDT">Field type</param>
		/// <param name="m3FLDB">Field length</param>
		/// <param name="m3FLDP">Number of decimal places</param>
		/// <param name="m3BDA1">Base for data</param>
		/// <param name="m3BDA2">Base for data</param>
		/// <param name="m3BDA3">Base for data</param>
		/// <param name="m3BDA4">Base for data</param>
		/// <param name="m3BDA5">Base for data</param>
		/// <param name="m3FLL1">Field length</param>
		/// <param name="m3FLL2">Field length</param>
		/// <param name="m3FLL3">Field length</param>
		/// <param name="m3FLL4">Field length</param>
		/// <param name="m3FLL5">Field length</param>
		/// <param name="m3OB01">Field</param>
		/// <param name="m3OB02">Field</param>
		/// <param name="m3OB03">Field</param>
		/// <param name="m3OB04">Field</param>
		/// <param name="m3OB05">Field</param>
		/// <param name="m3FI01">File</param>
		/// <param name="m3FI02">File</param>
		/// <param name="m3FI03">File</param>
		/// <param name="m3FI04">File</param>
		/// <param name="m3FI05">File</param>
		/// <param name="m3VAL1">Value field</param>
		/// <param name="m3VAL2">Value field</param>
		/// <param name="m3VAL3">Value field</param>
		/// <param name="m3VAL4">Value field</param>
		/// <param name="m3VAL5">Value field</param>
		/// <param name="m3SEP1">Field separator</param>
		/// <param name="m3SEP2">Field separator</param>
		/// <param name="m3SEP3">Field separator</param>
		/// <param name="m3SEP4">Field separator</param>
		/// <param name="m3SEP5">Field separator</param>
		/// <param name="m3BAD1">Add blank</param>
		/// <param name="m3BAD2">Add blank</param>
		/// <param name="m3BAD3">Add blank</param>
		/// <param name="m3BAD4">Add blank</param>
		/// <param name="m3BAD5">Add blank</param>
		/// <param name="m3DFO1">Decimal format</param>
		/// <param name="m3DFO2">Decimal format</param>
		/// <param name="m3DFO3">Decimal format</param>
		/// <param name="m3DFO4">Decimal format</param>
		/// <param name="m3DFO5">Decimal format</param>
		/// <param name="m3TRM1">Trim zeroes</param>
		/// <param name="m3TRM2">Trim zeroes</param>
		/// <param name="m3TRM3">Trim zeroes</param>
		/// <param name="m3TRM4">Trim zeroes</param>
		/// <param name="m3TRM5">Trim zeroes</param>
		/// <param name="m3RPBK">XML section</param>
		/// <param name="m3DTF1">Date format</param>
		/// <param name="m3DTF2">Date format</param>
		/// <param name="m3DTF3">Date format</param>
		/// <param name="m3DTF4">Date format</param>
		/// <param name="m3DTF5">Date format</param>
		/// <param name="m3EDI1">Date editing</param>
		/// <param name="m3EDI2">Date editing</param>
		/// <param name="m3EDI3">Date editing</param>
		/// <param name="m3EDI4">Date editing</param>
		/// <param name="m3EDI5">Date editing</param>
		/// <param name="m3ZES1">Zero supress</param>
		/// <param name="m3ZES2">Zero supress</param>
		/// <param name="m3ZES3">Zero supress</param>
		/// <param name="m3ZES4">Zero supress</param>
		/// <param name="m3ZES5">Zero supress</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> MergeData(
			string m3IBCA = null, 
			string m3VIFL = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3MSID = null, 
			int? m3CASQ = null, 
			string m3FLDT = null, 
			int? m3FLDB = null, 
			int? m3FLDP = null, 
			int? m3BDA1 = null, 
			int? m3BDA2 = null, 
			int? m3BDA3 = null, 
			int? m3BDA4 = null, 
			int? m3BDA5 = null, 
			int? m3FLL1 = null, 
			int? m3FLL2 = null, 
			int? m3FLL3 = null, 
			int? m3FLL4 = null, 
			int? m3FLL5 = null, 
			string m3OB01 = null, 
			string m3OB02 = null, 
			string m3OB03 = null, 
			string m3OB04 = null, 
			string m3OB05 = null, 
			string m3FI01 = null, 
			string m3FI02 = null, 
			string m3FI03 = null, 
			string m3FI04 = null, 
			string m3FI05 = null, 
			string m3VAL1 = null, 
			string m3VAL2 = null, 
			string m3VAL3 = null, 
			string m3VAL4 = null, 
			string m3VAL5 = null, 
			string m3SEP1 = null, 
			string m3SEP2 = null, 
			string m3SEP3 = null, 
			string m3SEP4 = null, 
			string m3SEP5 = null, 
			int? m3BAD1 = null, 
			int? m3BAD2 = null, 
			int? m3BAD3 = null, 
			int? m3BAD4 = null, 
			int? m3BAD5 = null, 
			string m3DFO1 = null, 
			string m3DFO2 = null, 
			string m3DFO3 = null, 
			string m3DFO4 = null, 
			string m3DFO5 = null, 
			int? m3TRM1 = null, 
			int? m3TRM2 = null, 
			int? m3TRM3 = null, 
			int? m3TRM4 = null, 
			int? m3TRM5 = null, 
			int? m3RPBK = null, 
			string m3DTF1 = null, 
			string m3DTF2 = null, 
			string m3DTF3 = null, 
			string m3DTF4 = null, 
			string m3DTF5 = null, 
			string m3EDI1 = null, 
			string m3EDI2 = null, 
			string m3EDI3 = null, 
			string m3EDI4 = null, 
			string m3EDI5 = null, 
			int? m3ZES1 = null, 
			int? m3ZES2 = null, 
			int? m3ZES3 = null, 
			int? m3ZES4 = null, 
			int? m3ZES5 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/MergeData",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3IBCA))
				request.WithQueryParameter("IBCA", m3IBCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3VIFL))
				request.WithQueryParameter("VIFL", m3VIFL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSID))
				request.WithQueryParameter("MSID", m3MSID.Trim());
			if (m3CASQ.HasValue)
				request.WithQueryParameter("CASQ", m3CASQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FLDT))
				request.WithQueryParameter("FLDT", m3FLDT.Trim());
			if (m3FLDB.HasValue)
				request.WithQueryParameter("FLDB", m3FLDB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLDP.HasValue)
				request.WithQueryParameter("FLDP", m3FLDP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BDA1.HasValue)
				request.WithQueryParameter("BDA1", m3BDA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BDA2.HasValue)
				request.WithQueryParameter("BDA2", m3BDA2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BDA3.HasValue)
				request.WithQueryParameter("BDA3", m3BDA3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BDA4.HasValue)
				request.WithQueryParameter("BDA4", m3BDA4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BDA5.HasValue)
				request.WithQueryParameter("BDA5", m3BDA5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLL1.HasValue)
				request.WithQueryParameter("FLL1", m3FLL1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLL2.HasValue)
				request.WithQueryParameter("FLL2", m3FLL2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLL3.HasValue)
				request.WithQueryParameter("FLL3", m3FLL3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLL4.HasValue)
				request.WithQueryParameter("FLL4", m3FLL4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FLL5.HasValue)
				request.WithQueryParameter("FLL5", m3FLL5.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OB01))
				request.WithQueryParameter("OB01", m3OB01.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB02))
				request.WithQueryParameter("OB02", m3OB02.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB03))
				request.WithQueryParameter("OB03", m3OB03.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB04))
				request.WithQueryParameter("OB04", m3OB04.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB05))
				request.WithQueryParameter("OB05", m3OB05.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI01))
				request.WithQueryParameter("FI01", m3FI01.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI02))
				request.WithQueryParameter("FI02", m3FI02.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI03))
				request.WithQueryParameter("FI03", m3FI03.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI04))
				request.WithQueryParameter("FI04", m3FI04.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI05))
				request.WithQueryParameter("FI05", m3FI05.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL1))
				request.WithQueryParameter("VAL1", m3VAL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL2))
				request.WithQueryParameter("VAL2", m3VAL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL3))
				request.WithQueryParameter("VAL3", m3VAL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL4))
				request.WithQueryParameter("VAL4", m3VAL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL5))
				request.WithQueryParameter("VAL5", m3VAL5.Trim());
			if (!string.IsNullOrWhiteSpace(m3SEP1))
				request.WithQueryParameter("SEP1", m3SEP1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SEP2))
				request.WithQueryParameter("SEP2", m3SEP2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SEP3))
				request.WithQueryParameter("SEP3", m3SEP3.Trim());
			if (!string.IsNullOrWhiteSpace(m3SEP4))
				request.WithQueryParameter("SEP4", m3SEP4.Trim());
			if (!string.IsNullOrWhiteSpace(m3SEP5))
				request.WithQueryParameter("SEP5", m3SEP5.Trim());
			if (m3BAD1.HasValue)
				request.WithQueryParameter("BAD1", m3BAD1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BAD2.HasValue)
				request.WithQueryParameter("BAD2", m3BAD2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BAD3.HasValue)
				request.WithQueryParameter("BAD3", m3BAD3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BAD4.HasValue)
				request.WithQueryParameter("BAD4", m3BAD4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BAD5.HasValue)
				request.WithQueryParameter("BAD5", m3BAD5.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DFO1))
				request.WithQueryParameter("DFO1", m3DFO1.Trim());
			if (!string.IsNullOrWhiteSpace(m3DFO2))
				request.WithQueryParameter("DFO2", m3DFO2.Trim());
			if (!string.IsNullOrWhiteSpace(m3DFO3))
				request.WithQueryParameter("DFO3", m3DFO3.Trim());
			if (!string.IsNullOrWhiteSpace(m3DFO4))
				request.WithQueryParameter("DFO4", m3DFO4.Trim());
			if (!string.IsNullOrWhiteSpace(m3DFO5))
				request.WithQueryParameter("DFO5", m3DFO5.Trim());
			if (m3TRM1.HasValue)
				request.WithQueryParameter("TRM1", m3TRM1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRM2.HasValue)
				request.WithQueryParameter("TRM2", m3TRM2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRM3.HasValue)
				request.WithQueryParameter("TRM3", m3TRM3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRM4.HasValue)
				request.WithQueryParameter("TRM4", m3TRM4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRM5.HasValue)
				request.WithQueryParameter("TRM5", m3TRM5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3RPBK.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DTF1))
				request.WithQueryParameter("DTF1", m3DTF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3DTF2))
				request.WithQueryParameter("DTF2", m3DTF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3DTF3))
				request.WithQueryParameter("DTF3", m3DTF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3DTF4))
				request.WithQueryParameter("DTF4", m3DTF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3DTF5))
				request.WithQueryParameter("DTF5", m3DTF5.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDI1))
				request.WithQueryParameter("EDI1", m3EDI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDI2))
				request.WithQueryParameter("EDI2", m3EDI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDI3))
				request.WithQueryParameter("EDI3", m3EDI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDI4))
				request.WithQueryParameter("EDI4", m3EDI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDI5))
				request.WithQueryParameter("EDI5", m3EDI5.Trim());
			if (m3ZES1.HasValue)
				request.WithQueryParameter("ZES1", m3ZES1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ZES2.HasValue)
				request.WithQueryParameter("ZES2", m3ZES2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ZES3.HasValue)
				request.WithQueryParameter("ZES3", m3ZES3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ZES4.HasValue)
				request.WithQueryParameter("ZES4", m3ZES4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ZES5.HasValue)
				request.WithQueryParameter("ZES5", m3ZES5.Value.ToString(CultureInfo.CurrentCulture));

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
