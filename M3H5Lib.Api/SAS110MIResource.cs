/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.SAS110MI;
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
	/// Name: SAS110MI
	/// Component Name: Agreement locations
	/// Description: Api: Agreement locations
	/// Version Release: 14.x
	///</summary>
	public partial class SAS110MIResource : M3BaseResourceEndpoint
	{
		public SAS110MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "SAS110MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAgrmtCusSite
		/// Description This transaction adds agreement customer site
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CTNO">Agreement number (Required)</param>
		/// <param name="m3CUPL">Customer site (Required)</param>
		/// <param name="m3AGTP">Agreement type (Required)</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3SRES">Service manager</param>
		/// <param name="m3WOSC">Work schedule</param>
		/// <param name="m3TEC1">Technician 1</param>
		/// <param name="m3TEC2">Technician 2</param>
		/// <param name="m3DIST">Number of kilometer</param>
		/// <param name="m3LZON">Service zone</param>
		/// <param name="m3TRTI">Planned travel time</param>
		/// <param name="m3TVCD">Travel type</param>
		/// <param name="m3LSCD">Service stop</param>
		/// <param name="m3ILCD">Invoice block</param>
		/// <param name="m3DBCO">Payer control</param>
		/// <param name="m3INCU">Internal customer number</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3VLCD">Validity type</param>
		/// <param name="m3VADF">Valid from</param>
		/// <param name="m3VADT">Valid to</param>
		/// <param name="m3IIDF">Start date - invoicing range</param>
		/// <param name="m3IIDT">End date - invoicing range</param>
		/// <param name="m3IIYR">Invoicing interval - years</param>
		/// <param name="m3IIMO">Invoicing interval - months</param>
		/// <param name="m3IIDA">Invoicing interval - days</param>
		/// <param name="m3NODT">Next order date</param>
		/// <param name="m3INVM">Invoicing method</param>
		/// <param name="m3APTM">Response time</param>
		/// <param name="m3AIT1">Accounting dimension 1</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3CFJ1">User-defined field 1 - serv agreement</param>
		/// <param name="m3CFJ2">User-defined field 2 - serv agreement</param>
		/// <param name="m3CFJ3">User-defined field 3 - serv agreement</param>
		/// <param name="m3CFJ4">User-defined field 4 - serv agreement</param>
		/// <param name="m3CFJ5">User-defined field 5 - serv agreement</param>
		/// <param name="m3CFJ6">User-defined field 6 - serv agreement</param>
		/// <param name="m3CFJ7">User-defined field 7 - serv agreement</param>
		/// <param name="m3CFJ8">User-defined field 8 - serv agreement</param>
		/// <param name="m3CFJ9">User-defined field 9 - serv agreement</param>
		/// <param name="m3CFJ0">User-defined field 10 - serv agreement</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAgrmtCusSite(
			string m3CTNO, 
			string m3CUPL, 
			string m3AGTP, 
			string m3ADID = null, 
			string m3SRES = null, 
			int? m3WOSC = null, 
			string m3TEC1 = null, 
			string m3TEC2 = null, 
			int? m3DIST = null, 
			int? m3LZON = null, 
			int? m3TRTI = null, 
			string m3TVCD = null, 
			int? m3LSCD = null, 
			int? m3ILCD = null, 
			string m3DBCO = null, 
			string m3INCU = null, 
			string m3PYNO = null, 
			string m3VLCD = null, 
			DateTime? m3VADF = null, 
			DateTime? m3VADT = null, 
			DateTime? m3IIDF = null, 
			DateTime? m3IIDT = null, 
			int? m3IIYR = null, 
			int? m3IIMO = null, 
			int? m3IIDA = null, 
			DateTime? m3NODT = null, 
			string m3INVM = null, 
			int? m3APTM = null, 
			string m3AIT1 = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			string m3PROJ = null, 
			string m3RORN = null, 
			string m3ELNO = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3ACRF = null, 
			string m3CFJ1 = null, 
			decimal? m3CFJ2 = null, 
			string m3CFJ3 = null, 
			string m3CFJ4 = null, 
			string m3CFJ5 = null, 
			string m3CFJ6 = null, 
			decimal? m3CFJ7 = null, 
			string m3CFJ8 = null, 
			string m3CFJ9 = null, 
			string m3CFJ0 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddAgrmtCusSite",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CTNO))
				throw new ArgumentNullException(nameof(m3CTNO));
			if (string.IsNullOrWhiteSpace(m3CUPL))
				throw new ArgumentNullException(nameof(m3CUPL));
			if (string.IsNullOrWhiteSpace(m3AGTP))
				throw new ArgumentNullException(nameof(m3AGTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("CTNO", m3CTNO.Trim())
				.WithQueryParameter("CUPL", m3CUPL.Trim())
				.WithQueryParameter("AGTP", m3AGTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());
			if (m3WOSC.HasValue)
				request.WithQueryParameter("WOSC", m3WOSC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEC1))
				request.WithQueryParameter("TEC1", m3TEC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEC2))
				request.WithQueryParameter("TEC2", m3TEC2.Trim());
			if (m3DIST.HasValue)
				request.WithQueryParameter("DIST", m3DIST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LZON.HasValue)
				request.WithQueryParameter("LZON", m3LZON.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRTI.HasValue)
				request.WithQueryParameter("TRTI", m3TRTI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TVCD))
				request.WithQueryParameter("TVCD", m3TVCD.Trim());
			if (m3LSCD.HasValue)
				request.WithQueryParameter("LSCD", m3LSCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ILCD.HasValue)
				request.WithQueryParameter("ILCD", m3ILCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DBCO))
				request.WithQueryParameter("DBCO", m3DBCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3INCU))
				request.WithQueryParameter("INCU", m3INCU.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3VLCD))
				request.WithQueryParameter("VLCD", m3VLCD.Trim());
			if (m3VADF.HasValue)
				request.WithQueryParameter("VADF", m3VADF.Value.ToM3String());
			if (m3VADT.HasValue)
				request.WithQueryParameter("VADT", m3VADT.Value.ToM3String());
			if (m3IIDF.HasValue)
				request.WithQueryParameter("IIDF", m3IIDF.Value.ToM3String());
			if (m3IIDT.HasValue)
				request.WithQueryParameter("IIDT", m3IIDT.Value.ToM3String());
			if (m3IIYR.HasValue)
				request.WithQueryParameter("IIYR", m3IIYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIMO.HasValue)
				request.WithQueryParameter("IIMO", m3IIMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIDA.HasValue)
				request.WithQueryParameter("IIDA", m3IIDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NODT.HasValue)
				request.WithQueryParameter("NODT", m3NODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3INVM))
				request.WithQueryParameter("INVM", m3INVM.Trim());
			if (m3APTM.HasValue)
				request.WithQueryParameter("APTM", m3APTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AIT1))
				request.WithQueryParameter("AIT1", m3AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT2))
				request.WithQueryParameter("AIT2", m3AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT3))
				request.WithQueryParameter("AIT3", m3AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT4))
				request.WithQueryParameter("AIT4", m3AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT5))
				request.WithQueryParameter("AIT5", m3AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT6))
				request.WithQueryParameter("AIT6", m3AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT7))
				request.WithQueryParameter("AIT7", m3AIT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFJ1))
				request.WithQueryParameter("CFJ1", m3CFJ1.Trim());
			if (m3CFJ2.HasValue)
				request.WithQueryParameter("CFJ2", m3CFJ2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFJ3))
				request.WithQueryParameter("CFJ3", m3CFJ3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFJ4))
				request.WithQueryParameter("CFJ4", m3CFJ4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFJ5))
				request.WithQueryParameter("CFJ5", m3CFJ5.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFJ6))
				request.WithQueryParameter("CFJ6", m3CFJ6.Trim());
			if (m3CFJ7.HasValue)
				request.WithQueryParameter("CFJ7", m3CFJ7.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFJ8))
				request.WithQueryParameter("CFJ8", m3CFJ8.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFJ9))
				request.WithQueryParameter("CFJ9", m3CFJ9.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFJ0))
				request.WithQueryParameter("CFJ0", m3CFJ0.Trim());

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
		/// Name DelAgrmtCusSite
		/// Description This transaction deletes agreement customer site
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CTNO">Agreement number (Required)</param>
		/// <param name="m3CUPL">Customer site (Required)</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelAgrmtCusSite(
			string m3CTNO, 
			string m3CUPL, 
			string m3ADID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelAgrmtCusSite",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CTNO))
				throw new ArgumentNullException(nameof(m3CTNO));
			if (string.IsNullOrWhiteSpace(m3CUPL))
				throw new ArgumentNullException(nameof(m3CUPL));

			// Set mandatory parameters
			request
				.WithQueryParameter("CTNO", m3CTNO.Trim())
				.WithQueryParameter("CUPL", m3CUPL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());

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
		/// Name GetAgrmtCusSite
		/// Description This transaction displays agreement customer site
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CTNO">Agreement number (Required)</param>
		/// <param name="m3CUPL">Customer site (Required)</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAgrmtCusSiteResponse></returns>
		/// <exception cref="M3Exception<GetAgrmtCusSiteResponse>"></exception>
		public async Task<M3Response<GetAgrmtCusSiteResponse>> GetAgrmtCusSite(
			string m3CTNO, 
			string m3CUPL, 
			string m3ADID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAgrmtCusSite",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CTNO))
				throw new ArgumentNullException(nameof(m3CTNO));
			if (string.IsNullOrWhiteSpace(m3CUPL))
				throw new ArgumentNullException(nameof(m3CUPL));

			// Set mandatory parameters
			request
				.WithQueryParameter("CTNO", m3CTNO.Trim())
				.WithQueryParameter("CUPL", m3CUPL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());

			// Execute the request
			var result = await Execute<GetAgrmtCusSiteResponse>(
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
		/// Name LstAgrmtCusSite
		/// Description This transaction lists agreement customer site
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CTNO">Agreement number (Required)</param>
		/// <param name="m3AGTP">Agreement type</param>
		/// <param name="m3CUPL">Customer site</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgrmtCusSiteResponse></returns>
		/// <exception cref="M3Exception<LstAgrmtCusSiteResponse>"></exception>
		public async Task<M3Response<LstAgrmtCusSiteResponse>> LstAgrmtCusSite(
			string m3CTNO, 
			string m3AGTP = null, 
			string m3CUPL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAgrmtCusSite",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CTNO))
				throw new ArgumentNullException(nameof(m3CTNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CTNO", m3CTNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AGTP))
				request.WithQueryParameter("AGTP", m3AGTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUPL))
				request.WithQueryParameter("CUPL", m3CUPL.Trim());

			// Execute the request
			var result = await Execute<LstAgrmtCusSiteResponse>(
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
		/// Name UpdAgrmtCusSite
		/// Description This transaction updates agreement customer site
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CTNO">Agreement number (Required)</param>
		/// <param name="m3CUPL">Customer site (Required)</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3AGTP">Agreement type</param>
		/// <param name="m3SRES">Service manager</param>
		/// <param name="m3WOSC">Work schedule</param>
		/// <param name="m3TEC1">Technician 1</param>
		/// <param name="m3TEC2">Technician 2</param>
		/// <param name="m3DIST">Number of kilometer</param>
		/// <param name="m3LZON">Service zone</param>
		/// <param name="m3TRTI">Planned travel time</param>
		/// <param name="m3TVCD">Travel type</param>
		/// <param name="m3LSCD">Service stop</param>
		/// <param name="m3ILCD">Invoice block</param>
		/// <param name="m3DBCO">Payer control</param>
		/// <param name="m3INCU">Internal customer number</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3VLCD">Validity type</param>
		/// <param name="m3VADF">Valid from</param>
		/// <param name="m3VADT">Valid to</param>
		/// <param name="m3IIDF">Start date - invoicing range</param>
		/// <param name="m3IIDT">End date - invoicing range</param>
		/// <param name="m3IIYR">Invoicing interval - years</param>
		/// <param name="m3IIMO">Invoicing interval - months</param>
		/// <param name="m3IIDA">Invoicing interval - days</param>
		/// <param name="m3NODT">Next order date</param>
		/// <param name="m3INVM">Invoicing method</param>
		/// <param name="m3APTM">Response time</param>
		/// <param name="m3AIT1">Accounting dimension 1</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3CFJ1">User-defined field 1 - serv agreement</param>
		/// <param name="m3CFJ2">User-defined field 2 - serv agreement</param>
		/// <param name="m3CFJ3">User-defined field 3 - serv agreement</param>
		/// <param name="m3CFJ4">User-defined field 4 - serv agreement</param>
		/// <param name="m3CFJ5">User-defined field 5 - serv agreement</param>
		/// <param name="m3CFJ6">User-defined field 6 - serv agreement</param>
		/// <param name="m3CFJ7">User-defined field 7 - serv agreement</param>
		/// <param name="m3CFJ8">User-defined field 8 - serv agreement</param>
		/// <param name="m3CFJ9">User-defined field 9 - serv agreement</param>
		/// <param name="m3CFJ0">User-defined field 10 - serv agreement</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdAgrmtCusSite(
			string m3CTNO, 
			string m3CUPL, 
			string m3ADID = null, 
			string m3AGTP = null, 
			string m3SRES = null, 
			int? m3WOSC = null, 
			string m3TEC1 = null, 
			string m3TEC2 = null, 
			int? m3DIST = null, 
			int? m3LZON = null, 
			int? m3TRTI = null, 
			string m3TVCD = null, 
			int? m3LSCD = null, 
			int? m3ILCD = null, 
			string m3DBCO = null, 
			string m3INCU = null, 
			string m3PYNO = null, 
			string m3VLCD = null, 
			DateTime? m3VADF = null, 
			DateTime? m3VADT = null, 
			DateTime? m3IIDF = null, 
			DateTime? m3IIDT = null, 
			int? m3IIYR = null, 
			int? m3IIMO = null, 
			int? m3IIDA = null, 
			DateTime? m3NODT = null, 
			string m3INVM = null, 
			int? m3APTM = null, 
			string m3AIT1 = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
			string m3PROJ = null, 
			string m3RORN = null, 
			string m3ELNO = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3ACRF = null, 
			string m3CFJ1 = null, 
			decimal? m3CFJ2 = null, 
			string m3CFJ3 = null, 
			string m3CFJ4 = null, 
			string m3CFJ5 = null, 
			string m3CFJ6 = null, 
			decimal? m3CFJ7 = null, 
			string m3CFJ8 = null, 
			string m3CFJ9 = null, 
			string m3CFJ0 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdAgrmtCusSite",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CTNO))
				throw new ArgumentNullException(nameof(m3CTNO));
			if (string.IsNullOrWhiteSpace(m3CUPL))
				throw new ArgumentNullException(nameof(m3CUPL));

			// Set mandatory parameters
			request
				.WithQueryParameter("CTNO", m3CTNO.Trim())
				.WithQueryParameter("CUPL", m3CUPL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGTP))
				request.WithQueryParameter("AGTP", m3AGTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());
			if (m3WOSC.HasValue)
				request.WithQueryParameter("WOSC", m3WOSC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEC1))
				request.WithQueryParameter("TEC1", m3TEC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEC2))
				request.WithQueryParameter("TEC2", m3TEC2.Trim());
			if (m3DIST.HasValue)
				request.WithQueryParameter("DIST", m3DIST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LZON.HasValue)
				request.WithQueryParameter("LZON", m3LZON.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRTI.HasValue)
				request.WithQueryParameter("TRTI", m3TRTI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TVCD))
				request.WithQueryParameter("TVCD", m3TVCD.Trim());
			if (m3LSCD.HasValue)
				request.WithQueryParameter("LSCD", m3LSCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ILCD.HasValue)
				request.WithQueryParameter("ILCD", m3ILCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DBCO))
				request.WithQueryParameter("DBCO", m3DBCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3INCU))
				request.WithQueryParameter("INCU", m3INCU.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3VLCD))
				request.WithQueryParameter("VLCD", m3VLCD.Trim());
			if (m3VADF.HasValue)
				request.WithQueryParameter("VADF", m3VADF.Value.ToM3String());
			if (m3VADT.HasValue)
				request.WithQueryParameter("VADT", m3VADT.Value.ToM3String());
			if (m3IIDF.HasValue)
				request.WithQueryParameter("IIDF", m3IIDF.Value.ToM3String());
			if (m3IIDT.HasValue)
				request.WithQueryParameter("IIDT", m3IIDT.Value.ToM3String());
			if (m3IIYR.HasValue)
				request.WithQueryParameter("IIYR", m3IIYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIMO.HasValue)
				request.WithQueryParameter("IIMO", m3IIMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIDA.HasValue)
				request.WithQueryParameter("IIDA", m3IIDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NODT.HasValue)
				request.WithQueryParameter("NODT", m3NODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3INVM))
				request.WithQueryParameter("INVM", m3INVM.Trim());
			if (m3APTM.HasValue)
				request.WithQueryParameter("APTM", m3APTM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AIT1))
				request.WithQueryParameter("AIT1", m3AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT2))
				request.WithQueryParameter("AIT2", m3AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT3))
				request.WithQueryParameter("AIT3", m3AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT4))
				request.WithQueryParameter("AIT4", m3AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT5))
				request.WithQueryParameter("AIT5", m3AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT6))
				request.WithQueryParameter("AIT6", m3AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT7))
				request.WithQueryParameter("AIT7", m3AIT7.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFJ1))
				request.WithQueryParameter("CFJ1", m3CFJ1.Trim());
			if (m3CFJ2.HasValue)
				request.WithQueryParameter("CFJ2", m3CFJ2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFJ3))
				request.WithQueryParameter("CFJ3", m3CFJ3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFJ4))
				request.WithQueryParameter("CFJ4", m3CFJ4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFJ5))
				request.WithQueryParameter("CFJ5", m3CFJ5.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFJ6))
				request.WithQueryParameter("CFJ6", m3CFJ6.Trim());
			if (m3CFJ7.HasValue)
				request.WithQueryParameter("CFJ7", m3CFJ7.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFJ8))
				request.WithQueryParameter("CFJ8", m3CFJ8.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFJ9))
				request.WithQueryParameter("CFJ9", m3CFJ9.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFJ0))
				request.WithQueryParameter("CFJ0", m3CFJ0.Trim());

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
