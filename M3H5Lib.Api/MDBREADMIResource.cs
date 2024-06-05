/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.MDBREADMI;
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
	/// Name: MDBREADMI
	/// Component Name: GenericMI
	/// Description: Generic MI for reading tables
	/// Version Release: 15
	///</summary>
	public partial class MDBREADMIResource : M3BaseResourceEndpoint
	{
		public MDBREADMIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MDBREADMI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetCSHHED20
		/// Description Keys: BJNO DIVI
		/// Version Release: 
		/// </summary>
		/// <param name="m3BJNO">Job no (Required)</param>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCSHHED20Response></returns>
		/// <exception cref="M3Exception<GetCSHHED20Response>"></exception>
		public async Task<M3Response<GetCSHHED20Response>> GetCSHHED20(
			string m3BJNO, 
			string m3DIVI, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetCSHHED20",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BJNO))
				throw new ArgumentNullException(nameof(m3BJNO));
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("BJNO", m3BJNO.Trim())
				.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetCSHHED20Response>(
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
		/// Name GetMITBAL00
		/// Description Keys: WHLO ITNO
		/// Version Release: 
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMITBAL00Response></returns>
		/// <exception cref="M3Exception<GetMITBAL00Response>"></exception>
		public async Task<M3Response<GetMITBAL00Response>> GetMITBAL00(
			string m3WHLO, 
			string m3ITNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetMITBAL00",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<GetMITBAL00Response>(
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
		/// Name GetMITMAS00
		/// Description Keys: ITNO
		/// Version Release: 
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMITMAS00Response></returns>
		/// <exception cref="M3Exception<GetMITMAS00Response>"></exception>
		public async Task<M3Response<GetMITMAS00Response>> GetMITMAS00(
			string m3ITNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetMITMAS00",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<GetMITMAS00Response>(
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
		/// Name GetOCUSAD00
		/// Description Keys: CUNO ADRT ADID
		/// Version Release: 
		/// </summary>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3ADRT">Address type (Required)</param>
		/// <param name="m3ADID">Address no (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOCUSAD00Response></returns>
		/// <exception cref="M3Exception<GetOCUSAD00Response>"></exception>
		public async Task<M3Response<GetOCUSAD00Response>> GetOCUSAD00(
			string m3CUNO, 
			int m3ADRT, 
			string m3ADID, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetOCUSAD00",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));
			if (string.IsNullOrWhiteSpace(m3ADID))
				throw new ArgumentNullException(nameof(m3ADID));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim())
				.WithQueryParameter("ADRT", m3ADRT.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ADID", m3ADID.Trim());

			// Execute the request
			var result = await Execute<GetOCUSAD00Response>(
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
		/// Name GetOCUSMA00
		/// Description Get Customer Data
		/// Version Release: 1
		/// </summary>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOCUSMA00Response></returns>
		/// <exception cref="M3Exception<GetOCUSMA00Response>"></exception>
		public async Task<M3Response<GetOCUSMA00Response>> GetOCUSMA00(
			string m3CUNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetOCUSMA00",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Execute the request
			var result = await Execute<GetOCUSMA00Response>(
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
		/// Name GetODHEAD00
		/// Description Keys: ORNO WHLO DLIX TEPY
		/// Version Release: 
		/// </summary>
		/// <param name="m3ORNO">CO no (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3DLIX">Delivery number (Required)</param>
		/// <param name="m3TEPY">Payment terms (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetODHEAD00Response></returns>
		/// <exception cref="M3Exception<GetODHEAD00Response>"></exception>
		public async Task<M3Response<GetODHEAD00Response>> GetODHEAD00(
			string m3ORNO, 
			string m3WHLO, 
			decimal m3DLIX, 
			string m3TEPY, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetODHEAD00",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3TEPY))
				throw new ArgumentNullException(nameof(m3TEPY));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("DLIX", m3DLIX.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TEPY", m3TEPY.Trim());

			// Execute the request
			var result = await Execute<GetODHEAD00Response>(
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
		/// Name GetOXHEAD00
		/// Description Keys: ORNO
		/// Version Release: 
		/// </summary>
		/// <param name="m3ORNO">CO no (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOXHEAD00Response></returns>
		/// <exception cref="M3Exception<GetOXHEAD00Response>"></exception>
		public async Task<M3Response<GetOXHEAD00Response>> GetOXHEAD00(
			string m3ORNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetOXHEAD00",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORNO))
				throw new ArgumentNullException(nameof(m3ORNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Execute the request
			var result = await Execute<GetOXHEAD00Response>(
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
		/// Name LstARCHLO00
		/// Description Keys: ARCN
		/// Version Release: 
		/// </summary>
		/// <param name="m3ARCN">Arch run number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstARCHLO00Response></returns>
		/// <exception cref="M3Exception<LstARCHLO00Response>"></exception>
		public async Task<M3Response<LstARCHLO00Response>> LstARCHLO00(
			decimal? m3ARCN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstARCHLO00",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3ARCN.HasValue)
				request.WithQueryParameter("ARCN", m3ARCN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstARCHLO00Response>(
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
		/// Name LstARCTLO00
		/// Description Keys: ARCN FILE
		/// Version Release: 
		/// </summary>
		/// <param name="m3ARCN">Arch run number (Required)</param>
		/// <param name="m3FILE">File</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstARCTLO00Response></returns>
		/// <exception cref="M3Exception<LstARCTLO00Response>"></exception>
		public async Task<M3Response<LstARCTLO00Response>> LstARCTLO00(
			decimal m3ARCN, 
			string m3FILE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstARCTLO00",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("ARCN", m3ARCN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());

			// Execute the request
			var result = await Execute<LstARCTLO00Response>(
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
		/// Name LstCAABAL00
		/// Description Keys: DIVI
		/// Version Release: 
		/// </summary>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCAABAL00Response></returns>
		/// <exception cref="M3Exception<LstCAABAL00Response>"></exception>
		public async Task<M3Response<LstCAABAL00Response>> LstCAABAL00(
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstCAABAL00",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<LstCAABAL00Response>(
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
		/// Name LstCEMAIL00
		/// Description Keys: EMTP EMKY
		/// Version Release: 
		/// </summary>
		/// <param name="m3EMTP">E-mail type (Required)</param>
		/// <param name="m3EMKY">E-mail key val</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCEMAIL00Response></returns>
		/// <exception cref="M3Exception<LstCEMAIL00Response>"></exception>
		public async Task<M3Response<LstCEMAIL00Response>> LstCEMAIL00(
			string m3EMTP, 
			string m3EMKY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstCEMAIL00",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3EMTP))
				throw new ArgumentNullException(nameof(m3EMTP));

			// Set mandatory parameters
			request
				.WithQueryParameter("EMTP", m3EMTP.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3EMKY))
				request.WithQueryParameter("EMKY", m3EMKY.Trim());

			// Execute the request
			var result = await Execute<LstCEMAIL00Response>(
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
		/// Name LstCINACC00
		/// Description Keys: DIVI ANBR SENO
		/// Version Release: 
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3ANBR">Accounting no (Required)</param>
		/// <param name="m3SENO">Sequence no</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCINACC00Response></returns>
		/// <exception cref="M3Exception<LstCINACC00Response>"></exception>
		public async Task<M3Response<LstCINACC00Response>> LstCINACC00(
			string m3DIVI, 
			int m3ANBR, 
			int? m3SENO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstCINACC00",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("ANBR", m3ANBR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3SENO.HasValue)
				request.WithQueryParameter("SENO", m3SENO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstCINACC00Response>(
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
		/// Name LstCINACC00_01
		/// Description Keys: DIVI ANBR
		/// Version Release: 
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3ANBR">Accounting no</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCINACC00_01Response></returns>
		/// <exception cref="M3Exception<LstCINACC00_01Response>"></exception>
		public async Task<M3Response<LstCINACC00_01Response>> LstCINACC00_01(
			string m3DIVI, 
			int? m3ANBR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstCINACC00_01",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3ANBR.HasValue)
				request.WithQueryParameter("ANBR", m3ANBR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstCINACC00_01Response>(
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
		/// Name LstFGLEDG10
		/// Description Keys: SQRY
		/// Version Release: 
		/// </summary>
		/// <param name="m3SQRY">Search query</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFGLEDG10Response></returns>
		/// <exception cref="M3Exception<LstFGLEDG10Response>"></exception>
		public async Task<M3Response<LstFGLEDG10Response>> LstFGLEDG10(
			string m3SQRY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstFGLEDG10",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SQRY))
				request.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<LstFGLEDG10Response>(
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
		/// Name LstFGLEDG10_1
		/// Description Keys: DIVI AIT1 AIT2
		/// Version Release: 
		/// </summary>
		/// <param name="m3DIVI">Division (Required)</param>
		/// <param name="m3AIT1">Account dim 1 (Required)</param>
		/// <param name="m3AIT2">Account dim 2</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFGLEDG10_1Response></returns>
		/// <exception cref="M3Exception<LstFGLEDG10_1Response>"></exception>
		public async Task<M3Response<LstFGLEDG10_1Response>> LstFGLEDG10_1(
			string m3DIVI, 
			string m3AIT1, 
			string m3AIT2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstFGLEDG10_1",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3DIVI))
				throw new ArgumentNullException(nameof(m3DIVI));
			if (string.IsNullOrWhiteSpace(m3AIT1))
				throw new ArgumentNullException(nameof(m3AIT1));

			// Set mandatory parameters
			request
				.WithQueryParameter("DIVI", m3DIVI.Trim())
				.WithQueryParameter("AIT1", m3AIT1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AIT2))
				request.WithQueryParameter("AIT2", m3AIT2.Trim());

			// Execute the request
			var result = await Execute<LstFGLEDG10_1Response>(
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
		/// Name LstMIATTR40
		/// Description Keys: ITNO ATID ATVA
		/// Version Release: 
		/// </summary>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3ATID">Attribute ID (Required)</param>
		/// <param name="m3ATVA">Attr value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMIATTR40Response></returns>
		/// <exception cref="M3Exception<LstMIATTR40Response>"></exception>
		public async Task<M3Response<LstMIATTR40Response>> LstMIATTR40(
			string m3ITNO, 
			string m3ATID, 
			string m3ATVA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMIATTR40",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3ATID))
				throw new ArgumentNullException(nameof(m3ATID));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("ATID", m3ATID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ATVA))
				request.WithQueryParameter("ATVA", m3ATVA.Trim());

			// Execute the request
			var result = await Execute<LstMIATTR40Response>(
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
		/// Name LstMIDSCP00
		/// Description Keys: SQRY
		/// Version Release: 
		/// </summary>
		/// <param name="m3SQRY">Search query</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMIDSCP00Response></returns>
		/// <exception cref="M3Exception<LstMIDSCP00Response>"></exception>
		public async Task<M3Response<LstMIDSCP00Response>> LstMIDSCP00(
			string m3SQRY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMIDSCP00",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SQRY))
				request.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<LstMIDSCP00Response>(
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
		/// Name LstMIDSCP10
		/// Description Keys: SQRY
		/// Version Release: 
		/// </summary>
		/// <param name="m3SQRY">Search query</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMIDSCP10Response></returns>
		/// <exception cref="M3Exception<LstMIDSCP10Response>"></exception>
		public async Task<M3Response<LstMIDSCP10Response>> LstMIDSCP10(
			string m3SQRY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMIDSCP10",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SQRY))
				request.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<LstMIDSCP10Response>(
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
		/// Name LstMITBAL00
		/// Description Keys: WHLO
		/// Version Release: 
		/// </summary>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMITBAL00Response></returns>
		/// <exception cref="M3Exception<LstMITBAL00Response>"></exception>
		public async Task<M3Response<LstMITBAL00Response>> LstMITBAL00(
			string m3WHLO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMITBAL00",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Execute the request
			var result = await Execute<LstMITBAL00Response>(
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
		/// Name LstMITBAL00_2
		/// Description Keys: WHLO ITNO
		/// Version Release: 
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMITBAL00_2Response></returns>
		/// <exception cref="M3Exception<LstMITBAL00_2Response>"></exception>
		public async Task<M3Response<LstMITBAL00_2Response>> LstMITBAL00_2(
			string m3WHLO, 
			string m3ITNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMITBAL00_2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<LstMITBAL00_2Response>(
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
		/// Name LstMITFAC00
		/// Description Keys: FACI
		/// Version Release: 
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMITFAC00Response></returns>
		/// <exception cref="M3Exception<LstMITFAC00Response>"></exception>
		public async Task<M3Response<LstMITFAC00Response>> LstMITFAC00(
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMITFAC00",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());

			// Execute the request
			var result = await Execute<LstMITFAC00Response>(
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
		/// Name LstMITFAC00_01
		/// Description Keys: FACI ITNO
		/// Version Release: 
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMITFAC00_01Response></returns>
		/// <exception cref="M3Exception<LstMITFAC00_01Response>"></exception>
		public async Task<M3Response<LstMITFAC00_01Response>> LstMITFAC00_01(
			string m3FACI, 
			string m3ITNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMITFAC00_01",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<LstMITFAC00_01Response>(
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
		/// Name LstMITTRA50
		/// Description Keys: TTYP RFTX WHLO RGDT RGTM TMSX ITNO
		/// Version Release: 
		/// </summary>
		/// <param name="m3TTYP">Trans type (Required)</param>
		/// <param name="m3RFTX">Ref text (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3RGDT">Entry date (Required)</param>
		/// <param name="m3RGTM">Entry time (Required)</param>
		/// <param name="m3TMSX">Time suffix (Required)</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMITTRA50Response></returns>
		/// <exception cref="M3Exception<LstMITTRA50Response>"></exception>
		public async Task<M3Response<LstMITTRA50Response>> LstMITTRA50(
			int m3TTYP, 
			string m3RFTX, 
			string m3WHLO, 
			DateTime m3RGDT, 
			int m3RGTM, 
			int m3TMSX, 
			string m3ITNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMITTRA50",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RFTX))
				throw new ArgumentNullException(nameof(m3RFTX));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));

			// Set mandatory parameters
			request
				.WithQueryParameter("TTYP", m3TTYP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RFTX", m3RFTX.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("RGDT", m3RGDT.ToM3String())
				.WithQueryParameter("RGTM", m3RGTM.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TMSX", m3TMSX.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<LstMITTRA50Response>(
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
		/// Name LstMITTRA50_00
		/// Description Keys: TTYP RFTX WHLO
		/// Version Release: 
		/// </summary>
		/// <param name="m3TTYP">Trans type (Required)</param>
		/// <param name="m3RFTX">Ref text (Required)</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMITTRA50_00Response></returns>
		/// <exception cref="M3Exception<LstMITTRA50_00Response>"></exception>
		public async Task<M3Response<LstMITTRA50_00Response>> LstMITTRA50_00(
			int m3TTYP, 
			string m3RFTX, 
			string m3WHLO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMITTRA50_00",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RFTX))
				throw new ArgumentNullException(nameof(m3RFTX));

			// Set mandatory parameters
			request
				.WithQueryParameter("TTYP", m3TTYP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RFTX", m3RFTX.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());

			// Execute the request
			var result = await Execute<LstMITTRA50_00Response>(
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
		/// Name LstMITVENX1
		/// Description Keys: RTYP
		/// Version Release: 
		/// </summary>
		/// <param name="m3RTYP">Record type (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMITVENX1Response></returns>
		/// <exception cref="M3Exception<LstMITVENX1Response>"></exception>
		public async Task<M3Response<LstMITVENX1Response>> LstMITVENX1(
			string m3RTYP, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMITVENX1",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RTYP))
				throw new ArgumentNullException(nameof(m3RTYP));

			// Set mandatory parameters
			request
				.WithQueryParameter("RTYP", m3RTYP.Trim());

			// Execute the request
			var result = await Execute<LstMITVENX1Response>(
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
		/// Name LstMPOPLP00
		/// Description Keys: PLPN
		/// Version Release: 
		/// </summary>
		/// <param name="m3PLPN">Planned order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMPOPLP00Response></returns>
		/// <exception cref="M3Exception<LstMPOPLP00Response>"></exception>
		public async Task<M3Response<LstMPOPLP00Response>> LstMPOPLP00(
			int? m3PLPN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMPOPLP00",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3PLPN.HasValue)
				request.WithQueryParameter("PLPN", m3PLPN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstMPOPLP00Response>(
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
		/// Name LstMPOPLP00LES
		/// Description Keys: SQRY
		/// Version Release: 
		/// </summary>
		/// <param name="m3SQRY">Search query</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMPOPLP00LESResponse></returns>
		/// <exception cref="M3Exception<LstMPOPLP00LESResponse>"></exception>
		public async Task<M3Response<LstMPOPLP00LESResponse>> LstMPOPLP00LES(
			string m3SQRY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMPOPLP00LES",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SQRY))
				request.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<LstMPOPLP00LESResponse>(
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
		/// Name LstMWOOPE00
		/// Description Keys: FACI PRNO
		/// Version Release: 
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMWOOPE00Response></returns>
		/// <exception cref="M3Exception<LstMWOOPE00Response>"></exception>
		public async Task<M3Response<LstMWOOPE00Response>> LstMWOOPE00(
			string m3FACI, 
			string m3PRNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMWOOPE00",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());

			// Execute the request
			var result = await Execute<LstMWOOPE00Response>(
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
		/// Name LstMWOOPE00Sel
		/// Description Keys: FACI PRNO MFNO
		/// Version Release: 
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="m3MFNO">MO number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMWOOPE00SelResponse></returns>
		/// <exception cref="M3Exception<LstMWOOPE00SelResponse>"></exception>
		public async Task<M3Response<LstMWOOPE00SelResponse>> LstMWOOPE00Sel(
			string m3FACI, 
			string m3PRNO, 
			int? m3MFNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMWOOPE00Sel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3MFNO.HasValue)
				request.WithQueryParameter("MFNO", m3MFNO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstMWOOPE00SelResponse>(
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
		/// Name LstOCUSMA00_LES
		/// Description Keys: SQRY
		/// Version Release: 
		/// </summary>
		/// <param name="m3SQRY">Search query</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOCUSMA00_LESResponse></returns>
		/// <exception cref="M3Exception<LstOCUSMA00_LESResponse>"></exception>
		public async Task<M3Response<LstOCUSMA00_LESResponse>> LstOCUSMA00_LES(
			string m3SQRY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstOCUSMA00_LES",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SQRY))
				request.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<LstOCUSMA00_LESResponse>(
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
		/// Name LstOCUSMA10
		/// Description Keys: SQRY
		/// Version Release: 
		/// </summary>
		/// <param name="m3SQRY">Search query</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOCUSMA10Response></returns>
		/// <exception cref="M3Exception<LstOCUSMA10Response>"></exception>
		public async Task<M3Response<LstOCUSMA10Response>> LstOCUSMA10(
			string m3SQRY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstOCUSMA10",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SQRY))
				request.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<LstOCUSMA10Response>(
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
		/// Name LstOCUSMA10_LES
		/// Description Keys: SQRY
		/// Version Release: 
		/// </summary>
		/// <param name="m3SQRY">Search query</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOCUSMA10_LESResponse></returns>
		/// <exception cref="M3Exception<LstOCUSMA10_LESResponse>"></exception>
		public async Task<M3Response<LstOCUSMA10_LESResponse>> LstOCUSMA10_LES(
			string m3SQRY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstOCUSMA10_LES",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SQRY))
				request.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<LstOCUSMA10_LESResponse>(
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
		/// Name LstOOHEAD00
		/// Description Keys: ORNO
		/// Version Release: 
		/// </summary>
		/// <param name="m3ORNO">CO no</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOOHEAD00Response></returns>
		/// <exception cref="M3Exception<LstOOHEAD00Response>"></exception>
		public async Task<M3Response<LstOOHEAD00Response>> LstOOHEAD00(
			string m3ORNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstOOHEAD00",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());

			// Execute the request
			var result = await Execute<LstOOHEAD00Response>(
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
		/// Name LstOOHEAD00LES
		/// Description Keys: SQRY
		/// Version Release: 
		/// </summary>
		/// <param name="m3SQRY">Search query</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOOHEAD00LESResponse></returns>
		/// <exception cref="M3Exception<LstOOHEAD00LESResponse>"></exception>
		public async Task<M3Response<LstOOHEAD00LESResponse>> LstOOHEAD00LES(
			string m3SQRY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstOOHEAD00LES",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SQRY))
				request.WithQueryParameter("SQRY", m3SQRY.Trim());

			// Execute the request
			var result = await Execute<LstOOHEAD00LESResponse>(
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
		/// Name SelMITBAL00
		/// Description Keys: WHLO ITNO
		/// Version Release: 
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelMITBAL00Response></returns>
		/// <exception cref="M3Exception<SelMITBAL00Response>"></exception>
		public async Task<M3Response<SelMITBAL00Response>> SelMITBAL00(
			string m3WHLO, 
			string m3ITNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelMITBAL00",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<SelMITBAL00Response>(
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
		/// Name SelMWOOPE00
		/// Description Keys: FACI PRNO
		/// Version Release: 
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PRNO">Product (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelMWOOPE00Response></returns>
		/// <exception cref="M3Exception<SelMWOOPE00Response>"></exception>
		public async Task<M3Response<SelMWOOPE00Response>> SelMWOOPE00(
			string m3FACI, 
			string m3PRNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SelMWOOPE00",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PRNO", m3PRNO.Trim());

			// Execute the request
			var result = await Execute<SelMWOOPE00Response>(
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
