/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.STS100MI;
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
	/// Name: STS100MI
	/// Component Name: RentalAgreementHead
	/// Description: API: Short term rental
	/// Version Release: 5ea0
	///</summary>
	public partial class STS100MIResource : M3BaseResourceEndpoint
	{
		public STS100MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "STS100MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddRentalAgree
		/// Description Add Rental agreement head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3AGCN">Agreement customer (Required)</param>
		/// <param name="m3AOTP">Agreement order type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3ACNM">Name</param>
		/// <param name="m3CUPL">Customer site</param>
		/// <param name="m3AYRF">Your reference 1</param>
		/// <param name="m3APHN">Telephone number 1</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3TEDA">Termination date</param>
		/// <param name="m3TETM">Termination time</param>
		/// <param name="m3CHSY">Line charge model</param>
		/// <param name="m3ADR1">Address line 1</param>
		/// <param name="m3ADR2">Address line 2</param>
		/// <param name="m3ADR3">Address line 3</param>
		/// <param name="m3ADR4">Address line 4</param>
		/// <param name="m3SMCD">Salesperson</param>
		/// <param name="m3AHLD">Hold code</param>
		/// <param name="m3MRTP">Minimum rental type</param>
		/// <param name="m3MINV">Minimum order value</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3ARCC">Reason code - created agreement</param>
		/// <param name="m3AGSK">Search key</param>
		/// <param name="m3USID">User</param>
		/// <param name="m3MIHP">Minimum hire period</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3PRRF">Price list</param>
		/// <param name="m3ARCT">Reason code - terminated agreement</param>
		/// <param name="m3SAID">Address number</param>
		/// <param name="m3IVAD">Address number</param>
		/// <param name="m3DPOT">Rental depot</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddRentalAgreeResponse></returns>
		/// <exception cref="M3Exception<AddRentalAgreeResponse>"></exception>
		public async Task<M3Response<AddRentalAgreeResponse>> AddRentalAgree(
			string m3FACI, 
			string m3AGCN, 
			string m3AOTP, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3AGNB = null, 
			string m3ACNM = null, 
			string m3CUPL = null, 
			string m3AYRF = null, 
			string m3APHN = null, 
			string m3CUOR = null, 
			DateTime? m3TEDA = null, 
			int? m3TETM = null, 
			string m3CHSY = null, 
			string m3ADR1 = null, 
			string m3ADR2 = null, 
			string m3ADR3 = null, 
			string m3ADR4 = null, 
			string m3SMCD = null, 
			string m3AHLD = null, 
			string m3MRTP = null, 
			decimal? m3MINV = null, 
			string m3CUCD = null, 
			string m3ARCC = null, 
			string m3AGSK = null, 
			string m3USID = null, 
			int? m3MIHP = null, 
			string m3TEPY = null, 
			string m3PRRF = null, 
			string m3ARCT = null, 
			string m3SAID = null, 
			string m3IVAD = null, 
			string m3DPOT = null, 
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddRentalAgree",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3AGCN))
				throw new ArgumentNullException(nameof(m3AGCN));
			if (string.IsNullOrWhiteSpace(m3AOTP))
				throw new ArgumentNullException(nameof(m3AOTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("AGCN", m3AGCN.Trim())
				.WithQueryParameter("AOTP", m3AOTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACNM))
				request.WithQueryParameter("ACNM", m3ACNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUPL))
				request.WithQueryParameter("CUPL", m3CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3AYRF))
				request.WithQueryParameter("AYRF", m3AYRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3APHN))
				request.WithQueryParameter("APHN", m3APHN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (m3TEDA.HasValue)
				request.WithQueryParameter("TEDA", m3TEDA.Value.ToM3String());
			if (m3TETM.HasValue)
				request.WithQueryParameter("TETM", m3TETM.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CHSY))
				request.WithQueryParameter("CHSY", m3CHSY.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR1))
				request.WithQueryParameter("ADR1", m3ADR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR2))
				request.WithQueryParameter("ADR2", m3ADR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR3))
				request.WithQueryParameter("ADR3", m3ADR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR4))
				request.WithQueryParameter("ADR4", m3ADR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCD))
				request.WithQueryParameter("SMCD", m3SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3AHLD))
				request.WithQueryParameter("AHLD", m3AHLD.Trim());
			if (!string.IsNullOrWhiteSpace(m3MRTP))
				request.WithQueryParameter("MRTP", m3MRTP.Trim());
			if (m3MINV.HasValue)
				request.WithQueryParameter("MINV", m3MINV.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARCC))
				request.WithQueryParameter("ARCC", m3ARCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGSK))
				request.WithQueryParameter("AGSK", m3AGSK.Trim());
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());
			if (m3MIHP.HasValue)
				request.WithQueryParameter("MIHP", m3MIHP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRRF))
				request.WithQueryParameter("PRRF", m3PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARCT))
				request.WithQueryParameter("ARCT", m3ARCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SAID))
				request.WithQueryParameter("SAID", m3SAID.Trim());
			if (!string.IsNullOrWhiteSpace(m3IVAD))
				request.WithQueryParameter("IVAD", m3IVAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3DPOT))
				request.WithQueryParameter("DPOT", m3DPOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());

			// Execute the request
			var result = await Execute<AddRentalAgreeResponse>(
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
		/// Name DltRentalAgree
		/// Description Delete Rental Agreement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="m3OT65">Statistics - lost sales</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltRentalAgree(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3FACI = null, 
			string m3AGNB = null, 
			int? m3VERS = null, 
			int? m3OT65 = null, 
			string m3RSCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltRentalAgree",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OT65.HasValue)
				request.WithQueryParameter("OT65", m3OT65.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());

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
		/// Name GetRentalAgree
		/// Description Get Rental Agreement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetRentalAgreeResponse></returns>
		/// <exception cref="M3Exception<GetRentalAgreeResponse>"></exception>
		public async Task<M3Response<GetRentalAgreeResponse>> GetRentalAgree(
			string m3AGNB, 
			int m3VERS, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3FACI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetRentalAgree",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());

			// Execute the request
			var result = await Execute<GetRentalAgreeResponse>(
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
		/// Name LstAgreeByAOTP
		/// Description List Agreement by Order Type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AOTP">Agreement order type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgreeByAOTPResponse></returns>
		/// <exception cref="M3Exception<LstAgreeByAOTPResponse>"></exception>
		public async Task<M3Response<LstAgreeByAOTPResponse>> LstAgreeByAOTP(
			string m3AOTP, 
			int? m3CONO = null, 
			string m3AGNB = null, 
			int? m3VERS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAgreeByAOTP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AOTP))
				throw new ArgumentNullException(nameof(m3AOTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("AOTP", m3AOTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAgreeByAOTPResponse>(
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
		/// Name LstAgreeByCUOR
		/// Description List Agreement by Customers Order Number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CUOR">Customers order number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgreeByCUORResponse></returns>
		/// <exception cref="M3Exception<LstAgreeByCUORResponse>"></exception>
		public async Task<M3Response<LstAgreeByCUORResponse>> LstAgreeByCUOR(
			string m3CUOR, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAgreeByCUOR",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUOR))
				throw new ArgumentNullException(nameof(m3CUOR));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUOR", m3CUOR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstAgreeByCUORResponse>(
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
		/// Name LstAgreeByCusto
		/// Description List Agreement By Customer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGCN">Agreement customer (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgreeByCustoResponse></returns>
		/// <exception cref="M3Exception<LstAgreeByCustoResponse>"></exception>
		public async Task<M3Response<LstAgreeByCustoResponse>> LstAgreeByCusto(
			string m3AGCN, 
			int? m3CONO = null, 
			string m3AGNB = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAgreeByCusto",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGCN))
				throw new ArgumentNullException(nameof(m3AGCN));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGCN", m3AGCN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());

			// Execute the request
			var result = await Execute<LstAgreeByCustoResponse>(
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
		/// Name LstAgreeByStatu
		/// Description List Agreement by Status
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ASTL">Lowest status - agreement line (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3AGCN">Agreement customer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgreeByStatuResponse></returns>
		/// <exception cref="M3Exception<LstAgreeByStatuResponse>"></exception>
		public async Task<M3Response<LstAgreeByStatuResponse>> LstAgreeByStatu(
			string m3ASTL, 
			int? m3CONO = null, 
			string m3AGCN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAgreeByStatu",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ASTL))
				throw new ArgumentNullException(nameof(m3ASTL));

			// Set mandatory parameters
			request
				.WithQueryParameter("ASTL", m3ASTL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AGCN))
				request.WithQueryParameter("AGCN", m3AGCN.Trim());

			// Execute the request
			var result = await Execute<LstAgreeByStatuResponse>(
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
		/// Name LstRentalAgree
		/// Description List Rental agreement head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRentalAgreeResponse></returns>
		/// <exception cref="M3Exception<LstRentalAgreeResponse>"></exception>
		public async Task<M3Response<LstRentalAgreeResponse>> LstRentalAgree(
			string m3AGNB, 
			int? m3CONO = null, 
			int? m3VERS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstRentalAgree",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstRentalAgreeResponse>(
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
		/// Name SearchAgreement
		/// Description Search agreement
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchAgreementResponse></returns>
		/// <exception cref="M3Exception<SearchAgreementResponse>"></exception>
		public async Task<M3Response<SearchAgreementResponse>> SearchAgreement(
			string m3SQRY, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SearchAgreement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SQRY))
				throw new ArgumentNullException(nameof(m3SQRY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchAgreementResponse>(
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
		/// Name UpdInvoice
		/// Description Create interactive invoice of the agreement
		/// Version Release: 
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdInvoice(
			string m3AGNB, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdInvoice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim());

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
		/// Name UpdRentalAgree
		/// Description Update Rental Agreement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3VERS">Version (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3AGCN">Agreement customer</param>
		/// <param name="m3ACNM">Name</param>
		/// <param name="m3CUPL">Customer site</param>
		/// <param name="m3AYRF">Your reference 1</param>
		/// <param name="m3APHN">Telephone number 1</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3CHSY">Line charge model</param>
		/// <param name="m3ADR1">Address line 1</param>
		/// <param name="m3ADR2">Address line 2</param>
		/// <param name="m3ADR3">Address line 3</param>
		/// <param name="m3ADR4">Address line 4</param>
		/// <param name="m3SMCD">Salesperson</param>
		/// <param name="m3AHLD">Hold code</param>
		/// <param name="m3MRTP">Minimum rental type</param>
		/// <param name="m3MINV">Minimum order value</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3ARCC">Reason code - created agreement</param>
		/// <param name="m3USID">User</param>
		/// <param name="m3MIHP">Minimum hire period</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3PRRF">Price list</param>
		/// <param name="m3ARCT">Reason code - terminated agreement</param>
		/// <param name="m3DPOT">Rental depot</param>
		/// <param name="m3TEDA">Termination date</param>
		/// <param name="m3OT65">Statistics - lost sales</param>
		/// <param name="m3RSCD">Transaction reason</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdRentalAgree(
			string m3FACI, 
			string m3AGNB, 
			int m3VERS, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3AGCN = null, 
			string m3ACNM = null, 
			string m3CUPL = null, 
			string m3AYRF = null, 
			string m3APHN = null, 
			string m3CUOR = null, 
			string m3CHSY = null, 
			string m3ADR1 = null, 
			string m3ADR2 = null, 
			string m3ADR3 = null, 
			string m3ADR4 = null, 
			string m3SMCD = null, 
			string m3AHLD = null, 
			string m3MRTP = null, 
			decimal? m3MINV = null, 
			string m3CUCD = null, 
			string m3ARCC = null, 
			string m3USID = null, 
			int? m3MIHP = null, 
			string m3TEPY = null, 
			string m3PRRF = null, 
			string m3ARCT = null, 
			string m3DPOT = null, 
			DateTime? m3TEDA = null, 
			int? m3OT65 = null, 
			string m3RSCD = null, 
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
			M3Request request = new M3Request(Config)
			{
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdRentalAgree",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("AGNB", m3AGNB.Trim())
				.WithQueryParameter("VERS", m3VERS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGCN))
				request.WithQueryParameter("AGCN", m3AGCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACNM))
				request.WithQueryParameter("ACNM", m3ACNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUPL))
				request.WithQueryParameter("CUPL", m3CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3AYRF))
				request.WithQueryParameter("AYRF", m3AYRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3APHN))
				request.WithQueryParameter("APHN", m3APHN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHSY))
				request.WithQueryParameter("CHSY", m3CHSY.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR1))
				request.WithQueryParameter("ADR1", m3ADR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR2))
				request.WithQueryParameter("ADR2", m3ADR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR3))
				request.WithQueryParameter("ADR3", m3ADR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR4))
				request.WithQueryParameter("ADR4", m3ADR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCD))
				request.WithQueryParameter("SMCD", m3SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3AHLD))
				request.WithQueryParameter("AHLD", m3AHLD.Trim());
			if (!string.IsNullOrWhiteSpace(m3MRTP))
				request.WithQueryParameter("MRTP", m3MRTP.Trim());
			if (m3MINV.HasValue)
				request.WithQueryParameter("MINV", m3MINV.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARCC))
				request.WithQueryParameter("ARCC", m3ARCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());
			if (m3MIHP.HasValue)
				request.WithQueryParameter("MIHP", m3MIHP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRRF))
				request.WithQueryParameter("PRRF", m3PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARCT))
				request.WithQueryParameter("ARCT", m3ARCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3DPOT))
				request.WithQueryParameter("DPOT", m3DPOT.Trim());
			if (m3TEDA.HasValue)
				request.WithQueryParameter("TEDA", m3TEDA.Value.ToM3String());
			if (m3OT65.HasValue)
				request.WithQueryParameter("OT65", m3OT65.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RSCD))
				request.WithQueryParameter("RSCD", m3RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());

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
