/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CMS200MI;
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
	/// Name: CMS200MI
	/// Component Name: CustomerChannel
	/// Description: ICustomer channel
	/// Version Release: 5ea0
	///</summary>
	public partial class CMS200MIResource : M3BaseResourceEndpoint
	{
		public CMS200MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS200MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add Customer Channel
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CUCH">Customer channel id (Required)</param>
		/// <param name="m3_ORCU">Order by customer (Required)</param>
		/// <param name="m3_DECU">Delivery customer (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_GCAC">Activity</param>
		/// <param name="m3_INRC">Invoice recipient</param>
		/// <param name="m3_ADI3">Invoice adress - NOT IN USE (2017-07-17)</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_ORC1">Order by customer</param>
		/// <param name="m3_DEC1">Delivery customer</param>
		/// <param name="m3_ADI1">Delivery adress</param>
		/// <param name="m3_INR1">Invoice recipient</param>
		/// <param name="m3_ADI4">Invoice adress - NOT IN USE (2017-07-17)</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_CCAC">Activity</param>
		/// <param name="m3_CMCU">Commersial customer</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_CUCH, 
			string m3_ORCU, 
			string m3_DECU, 
			DateTime m3_FDAT, 
			string m3_ADID = null, 
			string m3_GCAC = null, 
			string m3_INRC = null, 
			string m3_ADI3 = null, 
			DateTime? m3_TDAT = null, 
			string m3_ORC1 = null, 
			string m3_DEC1 = null, 
			string m3_ADI1 = null, 
			string m3_INR1 = null, 
			string m3_ADI4 = null, 
			string m3_PYNO = null, 
			string m3_CCAC = null, 
			string m3_CMCU = null, 
			decimal? m3_TXID = null, 
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
			if (string.IsNullOrWhiteSpace(m3_CUCH))
				throw new ArgumentNullException("m3_CUCH");
			if (string.IsNullOrWhiteSpace(m3_ORCU))
				throw new ArgumentNullException("m3_ORCU");
			if (string.IsNullOrWhiteSpace(m3_DECU))
				throw new ArgumentNullException("m3_DECU");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUCH", m3_CUCH.Trim())
				.WithQueryParameter("ORCU", m3_ORCU.Trim())
				.WithQueryParameter("DECU", m3_DECU.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GCAC))
				request.WithQueryParameter("GCAC", m3_GCAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INRC))
				request.WithQueryParameter("INRC", m3_INRC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADI3))
				request.WithQueryParameter("ADI3", m3_ADI3.Trim());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ORC1))
				request.WithQueryParameter("ORC1", m3_ORC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEC1))
				request.WithQueryParameter("DEC1", m3_DEC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADI1))
				request.WithQueryParameter("ADI1", m3_ADI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INR1))
				request.WithQueryParameter("INR1", m3_INR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADI4))
				request.WithQueryParameter("ADI4", m3_ADI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CCAC))
				request.WithQueryParameter("CCAC", m3_CCAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CMCU))
				request.WithQueryParameter("CMCU", m3_CMCU.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
		/// Name AddCusActivity
		/// Description Add customer channel activity
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CCAC">Activity</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCusActivity(
			string m3_CCAC = null, 
			string m3_TX15 = null, 
			string m3_TX40 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCusActivity",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CCAC))
				request.WithQueryParameter("CCAC", m3_CCAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());

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
		/// Name AddCusChannelID
		/// Description Add customer channel ID
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CUCH">Customer channel id</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCusChannelID(
			string m3_CUCH = null, 
			string m3_TX15 = null, 
			string m3_TX40 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCusChannelID",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUCH))
				request.WithQueryParameter("CUCH", m3_CUCH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());

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
		/// Name Del
		/// Description Delete Customer Channel
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CUCH">Customer channel id (Required)</param>
		/// <param name="m3_ORCU">Order by customer (Required)</param>
		/// <param name="m3_DECU">Delivery customer (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_GCAC">Activity</param>
		/// <param name="m3_INRC">Invoice recipient</param>
		/// <param name="m3_ADI3">Invoice adress - NOT IN USE (2017-07-17)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			string m3_CUCH, 
			string m3_ORCU, 
			string m3_DECU, 
			DateTime m3_FDAT, 
			string m3_ADID = null, 
			string m3_GCAC = null, 
			string m3_INRC = null, 
			string m3_ADI3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Del",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUCH))
				throw new ArgumentNullException("m3_CUCH");
			if (string.IsNullOrWhiteSpace(m3_ORCU))
				throw new ArgumentNullException("m3_ORCU");
			if (string.IsNullOrWhiteSpace(m3_DECU))
				throw new ArgumentNullException("m3_DECU");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUCH", m3_CUCH.Trim())
				.WithQueryParameter("ORCU", m3_ORCU.Trim())
				.WithQueryParameter("DECU", m3_DECU.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GCAC))
				request.WithQueryParameter("GCAC", m3_GCAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INRC))
				request.WithQueryParameter("INRC", m3_INRC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADI3))
				request.WithQueryParameter("ADI3", m3_ADI3.Trim());

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
		/// Name DelCusActivity
		/// Description Delete customer channel activity
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CCAC">Activity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelCusActivity(
			string m3_CCAC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelCusActivity",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CCAC))
				request.WithQueryParameter("CCAC", m3_CCAC.Trim());

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
		/// Name DelCusChannelID
		/// Description Delete customer channel ID
		/// Version Release: 
		/// </summary>
		/// <param name="m3_CUCH">Customer channel id</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelCusChannelID(
			string m3_CUCH = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelCusChannelID",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUCH))
				request.WithQueryParameter("CUCH", m3_CUCH.Trim());

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
		/// Name Lst
		/// Description List Customer Channel
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_FRCH">Customer channel id</param>
		/// <param name="m3_TOCH">Customer channel id</param>
		/// <param name="m3_FROR">Order by customer</param>
		/// <param name="m3_TOOR">Order by customer</param>
		/// <param name="m3_FRDE">Delivery customer</param>
		/// <param name="m3_TODE">Delivery customer</param>
		/// <param name="m3_FRAC">Activity</param>
		/// <param name="m3_TOAC">Activity</param>
		/// <param name="m3_FRIN">Invoice recipient</param>
		/// <param name="m3_TOIN">Invoice recipient</param>
		/// <param name="m3_FRDA">From date</param>
		/// <param name="m3_TODA">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3_FRCH = null, 
			string m3_TOCH = null, 
			string m3_FROR = null, 
			string m3_TOOR = null, 
			string m3_FRDE = null, 
			string m3_TODE = null, 
			string m3_FRAC = null, 
			string m3_TOAC = null, 
			string m3_FRIN = null, 
			string m3_TOIN = null, 
			DateTime? m3_FRDA = null, 
			DateTime? m3_TODA = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Lst",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FRCH))
				request.WithQueryParameter("FRCH", m3_FRCH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOCH))
				request.WithQueryParameter("TOCH", m3_TOCH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FROR))
				request.WithQueryParameter("FROR", m3_FROR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOOR))
				request.WithQueryParameter("TOOR", m3_TOOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRDE))
				request.WithQueryParameter("FRDE", m3_FRDE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TODE))
				request.WithQueryParameter("TODE", m3_TODE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRAC))
				request.WithQueryParameter("FRAC", m3_FRAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOAC))
				request.WithQueryParameter("TOAC", m3_TOAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRIN))
				request.WithQueryParameter("FRIN", m3_FRIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOIN))
				request.WithQueryParameter("TOIN", m3_TOIN.Trim());
			if (m3_FRDA.HasValue)
				request.WithQueryParameter("FRDA", m3_FRDA.Value.ToM3String());
			if (m3_TODA.HasValue)
				request.WithQueryParameter("TODA", m3_TODA.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstResponse>(
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
		/// Name LstCusActivity
		/// Description List customer channel activity
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FRAC">Activity</param>
		/// <param name="m3_TOAC">Activity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCusActivityResponse></returns>
		/// <exception cref="M3Exception<LstCusActivityResponse>"></exception>
		public async Task<M3Response<LstCusActivityResponse>> LstCusActivity(
			string m3_FRAC = null, 
			string m3_TOAC = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCusActivity",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FRAC))
				request.WithQueryParameter("FRAC", m3_FRAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOAC))
				request.WithQueryParameter("TOAC", m3_TOAC.Trim());

			// Execute the request
			var result = await Execute<LstCusActivityResponse>(
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
		/// Name LstCusChannelID
		/// Description List customer channel ID
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FRCH">Customer channel id</param>
		/// <param name="m3_TOCH">Customer channel id</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCusChannelIDResponse></returns>
		/// <exception cref="M3Exception<LstCusChannelIDResponse>"></exception>
		public async Task<M3Response<LstCusChannelIDResponse>> LstCusChannelID(
			string m3_FRCH = null, 
			string m3_TOCH = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstCusChannelID",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FRCH))
				request.WithQueryParameter("FRCH", m3_FRCH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOCH))
				request.WithQueryParameter("TOCH", m3_TOCH.Trim());

			// Execute the request
			var result = await Execute<LstCusChannelIDResponse>(
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
		/// Name Sel
		/// Description Select Customer Channel
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CUCH">Customer channel id (Required)</param>
		/// <param name="m3_ORCU">Order by customer (Required)</param>
		/// <param name="m3_DECU">Delivery customer (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_GCAC">Activity</param>
		/// <param name="m3_INRC">Invoice recipient</param>
		/// <param name="m3_ADI3">Invoice adress - NOT IN USE (2017-07-17)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelResponse></returns>
		/// <exception cref="M3Exception<SelResponse>"></exception>
		public async Task<M3Response<SelResponse>> Sel(
			string m3_CUCH, 
			string m3_ORCU, 
			string m3_DECU, 
			DateTime m3_FDAT, 
			string m3_ADID = null, 
			string m3_GCAC = null, 
			string m3_INRC = null, 
			string m3_ADI3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Sel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUCH))
				throw new ArgumentNullException("m3_CUCH");
			if (string.IsNullOrWhiteSpace(m3_ORCU))
				throw new ArgumentNullException("m3_ORCU");
			if (string.IsNullOrWhiteSpace(m3_DECU))
				throw new ArgumentNullException("m3_DECU");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUCH", m3_CUCH.Trim())
				.WithQueryParameter("ORCU", m3_ORCU.Trim())
				.WithQueryParameter("DECU", m3_DECU.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GCAC))
				request.WithQueryParameter("GCAC", m3_GCAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INRC))
				request.WithQueryParameter("INRC", m3_INRC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADI3))
				request.WithQueryParameter("ADI3", m3_ADI3.Trim());

			// Execute the request
			var result = await Execute<SelResponse>(
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
		/// Name Upd
		/// Description Add Customer Channel
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_CUCH">Customer channel id (Required)</param>
		/// <param name="m3_ORCU">Order by customer (Required)</param>
		/// <param name="m3_DECU">Delivery customer (Required)</param>
		/// <param name="m3_FDAT">From date (Required)</param>
		/// <param name="m3_ADID">Address number</param>
		/// <param name="m3_INRC">Invoice recipient</param>
		/// <param name="m3_GCAC">Activity</param>
		/// <param name="m3_ADI3">Invoice adress - NOT IN USE (2017-07-17)</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_ORC1">Order by customer</param>
		/// <param name="m3_DEC1">Delivery customer</param>
		/// <param name="m3_ADI1">Delivery adress</param>
		/// <param name="m3_INR1">Invoice recipient</param>
		/// <param name="m3_ADI4">Invoice adress - NOT IN USE (2017-07-17)</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_CCAC">Activity</param>
		/// <param name="m3_CMCU">Commersial customer</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3_CUCH, 
			string m3_ORCU, 
			string m3_DECU, 
			DateTime m3_FDAT, 
			string m3_ADID = null, 
			string m3_INRC = null, 
			string m3_GCAC = null, 
			string m3_ADI3 = null, 
			DateTime? m3_TDAT = null, 
			string m3_ORC1 = null, 
			string m3_DEC1 = null, 
			string m3_ADI1 = null, 
			string m3_INR1 = null, 
			string m3_ADI4 = null, 
			string m3_PYNO = null, 
			string m3_CCAC = null, 
			string m3_CMCU = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Upd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUCH))
				throw new ArgumentNullException("m3_CUCH");
			if (string.IsNullOrWhiteSpace(m3_ORCU))
				throw new ArgumentNullException("m3_ORCU");
			if (string.IsNullOrWhiteSpace(m3_DECU))
				throw new ArgumentNullException("m3_DECU");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUCH", m3_CUCH.Trim())
				.WithQueryParameter("ORCU", m3_ORCU.Trim())
				.WithQueryParameter("DECU", m3_DECU.Trim())
				.WithQueryParameter("FDAT", m3_FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ADID))
				request.WithQueryParameter("ADID", m3_ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INRC))
				request.WithQueryParameter("INRC", m3_INRC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GCAC))
				request.WithQueryParameter("GCAC", m3_GCAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADI3))
				request.WithQueryParameter("ADI3", m3_ADI3.Trim());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ORC1))
				request.WithQueryParameter("ORC1", m3_ORC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DEC1))
				request.WithQueryParameter("DEC1", m3_DEC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADI1))
				request.WithQueryParameter("ADI1", m3_ADI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INR1))
				request.WithQueryParameter("INR1", m3_INR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADI4))
				request.WithQueryParameter("ADI4", m3_ADI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CCAC))
				request.WithQueryParameter("CCAC", m3_CCAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CMCU))
				request.WithQueryParameter("CMCU", m3_CMCU.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
