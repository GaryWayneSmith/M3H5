/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddRentalAgree
		/// Description Add Rental agreement head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_AGCN">Agreement customer (Required)</param>
		/// <param name="m3_AOTP">Agreement order type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_ACNM">Name</param>
		/// <param name="m3_CUPL">Customer site</param>
		/// <param name="m3_AYRF">Your reference 1</param>
		/// <param name="m3_APHN">Telephone number 1</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_TEDA">Termination date</param>
		/// <param name="m3_TETM">Termination time</param>
		/// <param name="m3_CHSY">Line charge model</param>
		/// <param name="m3_ADR1">Address line 1</param>
		/// <param name="m3_ADR2">Address line 2</param>
		/// <param name="m3_ADR3">Address line 3</param>
		/// <param name="m3_ADR4">Address line 4</param>
		/// <param name="m3_SMCD">Salesperson</param>
		/// <param name="m3_AHLD">Hold code</param>
		/// <param name="m3_MRTP">Minimum rental type</param>
		/// <param name="m3_MINV">Minimum order value</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_ARCC">Reason code - created agreement</param>
		/// <param name="m3_AGSK">Search key</param>
		/// <param name="m3_USID">User</param>
		/// <param name="m3_MIHP">Minimum hire period</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_PRRF">Price list</param>
		/// <param name="m3_ARCT">Reason code - terminated agreement</param>
		/// <param name="m3_SAID">Address number</param>
		/// <param name="m3_IVAD">Address number</param>
		/// <param name="m3_DPOT">Rental depot</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddRentalAgreeResponse></returns>
		/// <exception cref="M3Exception<AddRentalAgreeResponse>"></exception>
		public async Task<M3Response<AddRentalAgreeResponse>> AddRentalAgree(
			string m3_FACI, 
			string m3_AGCN, 
			string m3_AOTP, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_AGNB = null, 
			string m3_ACNM = null, 
			string m3_CUPL = null, 
			string m3_AYRF = null, 
			string m3_APHN = null, 
			string m3_CUOR = null, 
			DateTime? m3_TEDA = null, 
			int? m3_TETM = null, 
			string m3_CHSY = null, 
			string m3_ADR1 = null, 
			string m3_ADR2 = null, 
			string m3_ADR3 = null, 
			string m3_ADR4 = null, 
			string m3_SMCD = null, 
			string m3_AHLD = null, 
			string m3_MRTP = null, 
			decimal? m3_MINV = null, 
			string m3_CUCD = null, 
			string m3_ARCC = null, 
			string m3_AGSK = null, 
			string m3_USID = null, 
			int? m3_MIHP = null, 
			string m3_TEPY = null, 
			string m3_PRRF = null, 
			string m3_ARCT = null, 
			string m3_SAID = null, 
			string m3_IVAD = null, 
			string m3_DPOT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddRentalAgree",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_AGCN))
				throw new ArgumentNullException("m3_AGCN");
			if (string.IsNullOrWhiteSpace(m3_AOTP))
				throw new ArgumentNullException("m3_AOTP");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("AGCN", m3_AGCN.Trim())
				.WithQueryParameter("AOTP", m3_AOTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACNM))
				request.WithQueryParameter("ACNM", m3_ACNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUPL))
				request.WithQueryParameter("CUPL", m3_CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AYRF))
				request.WithQueryParameter("AYRF", m3_AYRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APHN))
				request.WithQueryParameter("APHN", m3_APHN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (m3_TEDA.HasValue)
				request.WithQueryParameter("TEDA", m3_TEDA.Value.ToM3String());
			if (m3_TETM.HasValue)
				request.WithQueryParameter("TETM", m3_TETM.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CHSY))
				request.WithQueryParameter("CHSY", m3_CHSY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR1))
				request.WithQueryParameter("ADR1", m3_ADR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR2))
				request.WithQueryParameter("ADR2", m3_ADR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR3))
				request.WithQueryParameter("ADR3", m3_ADR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR4))
				request.WithQueryParameter("ADR4", m3_ADR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AHLD))
				request.WithQueryParameter("AHLD", m3_AHLD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MRTP))
				request.WithQueryParameter("MRTP", m3_MRTP.Trim());
			if (m3_MINV.HasValue)
				request.WithQueryParameter("MINV", m3_MINV.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARCC))
				request.WithQueryParameter("ARCC", m3_ARCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGSK))
				request.WithQueryParameter("AGSK", m3_AGSK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());
			if (m3_MIHP.HasValue)
				request.WithQueryParameter("MIHP", m3_MIHP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRRF))
				request.WithQueryParameter("PRRF", m3_PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARCT))
				request.WithQueryParameter("ARCT", m3_ARCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SAID))
				request.WithQueryParameter("SAID", m3_SAID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IVAD))
				request.WithQueryParameter("IVAD", m3_IVAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DPOT))
				request.WithQueryParameter("DPOT", m3_DPOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());

			// Execute the request
			var result = await Execute<AddRentalAgreeResponse>(
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
		/// Name DltRentalAgree
		/// Description Delete Rental Agreement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="m3_OT65">Statistics - lost sales</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltRentalAgree(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_FACI = null, 
			string m3_AGNB = null, 
			int? m3_VERS = null, 
			int? m3_OT65 = null, 
			string m3_RSCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltRentalAgree",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());
			if (m3_OT65.HasValue)
				request.WithQueryParameter("OT65", m3_OT65.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());

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
		/// Name GetRentalAgree
		/// Description Get Rental Agreement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetRentalAgreeResponse></returns>
		/// <exception cref="M3Exception<GetRentalAgreeResponse>"></exception>
		public async Task<M3Response<GetRentalAgreeResponse>> GetRentalAgree(
			string m3_AGNB, 
			int m3_VERS, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_FACI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetRentalAgree",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());

			// Execute the request
			var result = await Execute<GetRentalAgreeResponse>(
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
		/// Name LstAgreeByAOTP
		/// Description List Agreement by Order Type
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AOTP">Agreement order type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgreeByAOTPResponse></returns>
		/// <exception cref="M3Exception<LstAgreeByAOTPResponse>"></exception>
		public async Task<M3Response<LstAgreeByAOTPResponse>> LstAgreeByAOTP(
			string m3_AOTP, 
			int? m3_CONO = null, 
			string m3_AGNB = null, 
			int? m3_VERS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgreeByAOTP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AOTP))
				throw new ArgumentNullException("m3_AOTP");

			// Set mandatory parameters
			request
				.WithQueryParameter("AOTP", m3_AOTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());

			// Execute the request
			var result = await Execute<LstAgreeByAOTPResponse>(
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
		/// Name LstAgreeByCUOR
		/// Description List Agreement by Customers Order Number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CUOR">Customers order number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgreeByCUORResponse></returns>
		/// <exception cref="M3Exception<LstAgreeByCUORResponse>"></exception>
		public async Task<M3Response<LstAgreeByCUORResponse>> LstAgreeByCUOR(
			string m3_CUOR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgreeByCUOR",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUOR))
				throw new ArgumentNullException("m3_CUOR");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUOR", m3_CUOR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());

			// Execute the request
			var result = await Execute<LstAgreeByCUORResponse>(
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
		/// Name LstAgreeByCusto
		/// Description List Agreement By Customer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGCN">Agreement customer (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgreeByCustoResponse></returns>
		/// <exception cref="M3Exception<LstAgreeByCustoResponse>"></exception>
		public async Task<M3Response<LstAgreeByCustoResponse>> LstAgreeByCusto(
			string m3_AGCN, 
			int? m3_CONO = null, 
			string m3_AGNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgreeByCusto",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AGCN))
				throw new ArgumentNullException("m3_AGCN");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGCN", m3_AGCN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());

			// Execute the request
			var result = await Execute<LstAgreeByCustoResponse>(
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
		/// Name LstAgreeByStatu
		/// Description List Agreement by Status
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ASTL">Lowest status - agreement line (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_AGCN">Agreement customer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAgreeByStatuResponse></returns>
		/// <exception cref="M3Exception<LstAgreeByStatuResponse>"></exception>
		public async Task<M3Response<LstAgreeByStatuResponse>> LstAgreeByStatu(
			string m3_ASTL, 
			int? m3_CONO = null, 
			string m3_AGCN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAgreeByStatu",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ASTL))
				throw new ArgumentNullException("m3_ASTL");

			// Set mandatory parameters
			request
				.WithQueryParameter("ASTL", m3_ASTL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGCN))
				request.WithQueryParameter("AGCN", m3_AGCN.Trim());

			// Execute the request
			var result = await Execute<LstAgreeByStatuResponse>(
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
		/// Name LstRentalAgree
		/// Description List Rental agreement head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRentalAgreeResponse></returns>
		/// <exception cref="M3Exception<LstRentalAgreeResponse>"></exception>
		public async Task<M3Response<LstRentalAgreeResponse>> LstRentalAgree(
			string m3_AGNB, 
			int? m3_CONO = null, 
			int? m3_VERS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstRentalAgree",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());

			// Execute the request
			var result = await Execute<LstRentalAgreeResponse>(
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
		/// Name SearchAgreement
		/// Description Search agreement
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_SQRY">Search query (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SearchAgreementResponse></returns>
		/// <exception cref="M3Exception<SearchAgreementResponse>"></exception>
		public async Task<M3Response<SearchAgreementResponse>> SearchAgreement(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SearchAgreement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SQRY))
				throw new ArgumentNullException("m3_SQRY");

			// Set mandatory parameters
			request
				.WithQueryParameter("SQRY", m3_SQRY.Trim());

			// Execute the request
			var result = await Execute<SearchAgreementResponse>(
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
		/// Name UpdInvoice
		/// Description Create interactive invoice of the agreement
		/// Version Release: 
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdInvoice(
			string m3_AGNB, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdInvoice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim());

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
		/// Name UpdRentalAgree
		/// Description Update Rental Agreement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_VERS">Version (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_AGCN">Agreement customer</param>
		/// <param name="m3_ACNM">Name</param>
		/// <param name="m3_CUPL">Customer site</param>
		/// <param name="m3_AYRF">Your reference 1</param>
		/// <param name="m3_APHN">Telephone number 1</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_CHSY">Line charge model</param>
		/// <param name="m3_ADR1">Address line 1</param>
		/// <param name="m3_ADR2">Address line 2</param>
		/// <param name="m3_ADR3">Address line 3</param>
		/// <param name="m3_ADR4">Address line 4</param>
		/// <param name="m3_SMCD">Salesperson</param>
		/// <param name="m3_AHLD">Hold code</param>
		/// <param name="m3_MRTP">Minimum rental type</param>
		/// <param name="m3_MINV">Minimum order value</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_ARCC">Reason code - created agreement</param>
		/// <param name="m3_USID">User</param>
		/// <param name="m3_MIHP">Minimum hire period</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_PRRF">Price list</param>
		/// <param name="m3_ARCT">Reason code - terminated agreement</param>
		/// <param name="m3_DPOT">Rental depot</param>
		/// <param name="m3_TEDA">Termination date</param>
		/// <param name="m3_OT65">Statistics - lost sales</param>
		/// <param name="m3_RSCD">Transaction reason</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdRentalAgree(
			string m3_FACI, 
			string m3_AGNB, 
			int m3_VERS, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_AGCN = null, 
			string m3_ACNM = null, 
			string m3_CUPL = null, 
			string m3_AYRF = null, 
			string m3_APHN = null, 
			string m3_CUOR = null, 
			string m3_CHSY = null, 
			string m3_ADR1 = null, 
			string m3_ADR2 = null, 
			string m3_ADR3 = null, 
			string m3_ADR4 = null, 
			string m3_SMCD = null, 
			string m3_AHLD = null, 
			string m3_MRTP = null, 
			decimal? m3_MINV = null, 
			string m3_CUCD = null, 
			string m3_ARCC = null, 
			string m3_USID = null, 
			int? m3_MIHP = null, 
			string m3_TEPY = null, 
			string m3_PRRF = null, 
			string m3_ARCT = null, 
			string m3_DPOT = null, 
			DateTime? m3_TEDA = null, 
			int? m3_OT65 = null, 
			string m3_RSCD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdRentalAgree",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("AGNB", m3_AGNB.Trim())
				.WithQueryParameter("VERS", m3_VERS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGCN))
				request.WithQueryParameter("AGCN", m3_AGCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACNM))
				request.WithQueryParameter("ACNM", m3_ACNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUPL))
				request.WithQueryParameter("CUPL", m3_CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AYRF))
				request.WithQueryParameter("AYRF", m3_AYRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_APHN))
				request.WithQueryParameter("APHN", m3_APHN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHSY))
				request.WithQueryParameter("CHSY", m3_CHSY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR1))
				request.WithQueryParameter("ADR1", m3_ADR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR2))
				request.WithQueryParameter("ADR2", m3_ADR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR3))
				request.WithQueryParameter("ADR3", m3_ADR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR4))
				request.WithQueryParameter("ADR4", m3_ADR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AHLD))
				request.WithQueryParameter("AHLD", m3_AHLD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MRTP))
				request.WithQueryParameter("MRTP", m3_MRTP.Trim());
			if (m3_MINV.HasValue)
				request.WithQueryParameter("MINV", m3_MINV.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARCC))
				request.WithQueryParameter("ARCC", m3_ARCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());
			if (m3_MIHP.HasValue)
				request.WithQueryParameter("MIHP", m3_MIHP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRRF))
				request.WithQueryParameter("PRRF", m3_PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARCT))
				request.WithQueryParameter("ARCT", m3_ARCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DPOT))
				request.WithQueryParameter("DPOT", m3_DPOT.Trim());
			if (m3_TEDA.HasValue)
				request.WithQueryParameter("TEDA", m3_TEDA.Value.ToM3String());
			if (m3_OT65.HasValue)
				request.WithQueryParameter("OT65", m3_OT65.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSCD))
				request.WithQueryParameter("RSCD", m3_RSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());

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
