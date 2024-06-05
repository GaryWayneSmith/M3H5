/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add Customer Channel
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CUCH">Customer channel id (Required)</param>
		/// <param name="m3ORCU">Order by customer (Required)</param>
		/// <param name="m3DECU">Delivery customer (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3GCAC">Activity</param>
		/// <param name="m3INRC">Invoice recipient</param>
		/// <param name="m3ADI3">Invoice adress - NOT IN USE (2017-07-17)</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3ORC1">Order by customer</param>
		/// <param name="m3DEC1">Delivery customer</param>
		/// <param name="m3ADI1">Delivery adress</param>
		/// <param name="m3INR1">Invoice recipient</param>
		/// <param name="m3ADI4">Invoice adress - NOT IN USE (2017-07-17)</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3CCAC">Activity</param>
		/// <param name="m3CMCU">Commersial customer</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3CUCH, 
			string m3ORCU, 
			string m3DECU, 
			DateTime m3FDAT, 
			string m3ADID = null, 
			string m3GCAC = null, 
			string m3INRC = null, 
			string m3ADI3 = null, 
			DateTime? m3TDAT = null, 
			string m3ORC1 = null, 
			string m3DEC1 = null, 
			string m3ADI1 = null, 
			string m3INR1 = null, 
			string m3ADI4 = null, 
			string m3PYNO = null, 
			string m3CCAC = null, 
			string m3CMCU = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUCH))
				throw new ArgumentNullException(nameof(m3CUCH));
			if (string.IsNullOrWhiteSpace(m3ORCU))
				throw new ArgumentNullException(nameof(m3ORCU));
			if (string.IsNullOrWhiteSpace(m3DECU))
				throw new ArgumentNullException(nameof(m3DECU));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUCH", m3CUCH.Trim())
				.WithQueryParameter("ORCU", m3ORCU.Trim())
				.WithQueryParameter("DECU", m3DECU.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3GCAC))
				request.WithQueryParameter("GCAC", m3GCAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3INRC))
				request.WithQueryParameter("INRC", m3INRC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADI3))
				request.WithQueryParameter("ADI3", m3ADI3.Trim());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ORC1))
				request.WithQueryParameter("ORC1", m3ORC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEC1))
				request.WithQueryParameter("DEC1", m3DEC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADI1))
				request.WithQueryParameter("ADI1", m3ADI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3INR1))
				request.WithQueryParameter("INR1", m3INR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADI4))
				request.WithQueryParameter("ADI4", m3ADI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CCAC))
				request.WithQueryParameter("CCAC", m3CCAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3CMCU))
				request.WithQueryParameter("CMCU", m3CMCU.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddCusActivity
		/// Description Add customer channel activity
		/// Version Release: 
		/// </summary>
		/// <param name="m3CCAC">Activity</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCusActivity(
			string m3CCAC = null, 
			string m3TX15 = null, 
			string m3TX40 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddCusActivity",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CCAC))
				request.WithQueryParameter("CCAC", m3CCAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());

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
		/// Name AddCusChannelID
		/// Description Add customer channel ID
		/// Version Release: 
		/// </summary>
		/// <param name="m3CUCH">Customer channel id</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCusChannelID(
			string m3CUCH = null, 
			string m3TX15 = null, 
			string m3TX40 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddCusChannelID",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUCH))
				request.WithQueryParameter("CUCH", m3CUCH.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());

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
		/// Name Del
		/// Description Delete Customer Channel
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CUCH">Customer channel id (Required)</param>
		/// <param name="m3ORCU">Order by customer (Required)</param>
		/// <param name="m3DECU">Delivery customer (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3GCAC">Activity</param>
		/// <param name="m3INRC">Invoice recipient</param>
		/// <param name="m3ADI3">Invoice adress - NOT IN USE (2017-07-17)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			string m3CUCH, 
			string m3ORCU, 
			string m3DECU, 
			DateTime m3FDAT, 
			string m3ADID = null, 
			string m3GCAC = null, 
			string m3INRC = null, 
			string m3ADI3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Del",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUCH))
				throw new ArgumentNullException(nameof(m3CUCH));
			if (string.IsNullOrWhiteSpace(m3ORCU))
				throw new ArgumentNullException(nameof(m3ORCU));
			if (string.IsNullOrWhiteSpace(m3DECU))
				throw new ArgumentNullException(nameof(m3DECU));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUCH", m3CUCH.Trim())
				.WithQueryParameter("ORCU", m3ORCU.Trim())
				.WithQueryParameter("DECU", m3DECU.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3GCAC))
				request.WithQueryParameter("GCAC", m3GCAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3INRC))
				request.WithQueryParameter("INRC", m3INRC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADI3))
				request.WithQueryParameter("ADI3", m3ADI3.Trim());

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
		/// Name DelCusActivity
		/// Description Delete customer channel activity
		/// Version Release: 
		/// </summary>
		/// <param name="m3CCAC">Activity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelCusActivity(
			string m3CCAC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelCusActivity",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CCAC))
				request.WithQueryParameter("CCAC", m3CCAC.Trim());

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
		/// Name DelCusChannelID
		/// Description Delete customer channel ID
		/// Version Release: 
		/// </summary>
		/// <param name="m3CUCH">Customer channel id</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelCusChannelID(
			string m3CUCH = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelCusChannelID",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUCH))
				request.WithQueryParameter("CUCH", m3CUCH.Trim());

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
		/// Name Lst
		/// Description List Customer Channel
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3FRCH">Customer channel id</param>
		/// <param name="m3TOCH">Customer channel id</param>
		/// <param name="m3FROR">Order by customer</param>
		/// <param name="m3TOOR">Order by customer</param>
		/// <param name="m3FRDE">Delivery customer</param>
		/// <param name="m3TODE">Delivery customer</param>
		/// <param name="m3FRAC">Activity</param>
		/// <param name="m3TOAC">Activity</param>
		/// <param name="m3FRIN">Invoice recipient</param>
		/// <param name="m3TOIN">Invoice recipient</param>
		/// <param name="m3FRDA">From date</param>
		/// <param name="m3TODA">To date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3FRCH = null, 
			string m3TOCH = null, 
			string m3FROR = null, 
			string m3TOOR = null, 
			string m3FRDE = null, 
			string m3TODE = null, 
			string m3FRAC = null, 
			string m3TOAC = null, 
			string m3FRIN = null, 
			string m3TOIN = null, 
			DateTime? m3FRDA = null, 
			DateTime? m3TODA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Lst",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FRCH))
				request.WithQueryParameter("FRCH", m3FRCH.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOCH))
				request.WithQueryParameter("TOCH", m3TOCH.Trim());
			if (!string.IsNullOrWhiteSpace(m3FROR))
				request.WithQueryParameter("FROR", m3FROR.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOOR))
				request.WithQueryParameter("TOOR", m3TOOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRDE))
				request.WithQueryParameter("FRDE", m3FRDE.Trim());
			if (!string.IsNullOrWhiteSpace(m3TODE))
				request.WithQueryParameter("TODE", m3TODE.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRAC))
				request.WithQueryParameter("FRAC", m3FRAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOAC))
				request.WithQueryParameter("TOAC", m3TOAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRIN))
				request.WithQueryParameter("FRIN", m3FRIN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOIN))
				request.WithQueryParameter("TOIN", m3TOIN.Trim());
			if (m3FRDA.HasValue)
				request.WithQueryParameter("FRDA", m3FRDA.Value.ToM3String());
			if (m3TODA.HasValue)
				request.WithQueryParameter("TODA", m3TODA.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstResponse>(
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
		/// Name LstCusActivity
		/// Description List customer channel activity
		/// Version Release: 
		/// </summary>
		/// <param name="m3FRAC">Activity</param>
		/// <param name="m3TOAC">Activity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCusActivityResponse></returns>
		/// <exception cref="M3Exception<LstCusActivityResponse>"></exception>
		public async Task<M3Response<LstCusActivityResponse>> LstCusActivity(
			string m3FRAC = null, 
			string m3TOAC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstCusActivity",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FRAC))
				request.WithQueryParameter("FRAC", m3FRAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOAC))
				request.WithQueryParameter("TOAC", m3TOAC.Trim());

			// Execute the request
			var result = await Execute<LstCusActivityResponse>(
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
		/// Name LstCusChannelID
		/// Description List customer channel ID
		/// Version Release: 
		/// </summary>
		/// <param name="m3FRCH">Customer channel id</param>
		/// <param name="m3TOCH">Customer channel id</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstCusChannelIDResponse></returns>
		/// <exception cref="M3Exception<LstCusChannelIDResponse>"></exception>
		public async Task<M3Response<LstCusChannelIDResponse>> LstCusChannelID(
			string m3FRCH = null, 
			string m3TOCH = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstCusChannelID",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FRCH))
				request.WithQueryParameter("FRCH", m3FRCH.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOCH))
				request.WithQueryParameter("TOCH", m3TOCH.Trim());

			// Execute the request
			var result = await Execute<LstCusChannelIDResponse>(
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
		/// Name Sel
		/// Description Select Customer Channel
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CUCH">Customer channel id (Required)</param>
		/// <param name="m3ORCU">Order by customer (Required)</param>
		/// <param name="m3DECU">Delivery customer (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3GCAC">Activity</param>
		/// <param name="m3INRC">Invoice recipient</param>
		/// <param name="m3ADI3">Invoice adress - NOT IN USE (2017-07-17)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelResponse></returns>
		/// <exception cref="M3Exception<SelResponse>"></exception>
		public async Task<M3Response<SelResponse>> Sel(
			string m3CUCH, 
			string m3ORCU, 
			string m3DECU, 
			DateTime m3FDAT, 
			string m3ADID = null, 
			string m3GCAC = null, 
			string m3INRC = null, 
			string m3ADI3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Sel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUCH))
				throw new ArgumentNullException(nameof(m3CUCH));
			if (string.IsNullOrWhiteSpace(m3ORCU))
				throw new ArgumentNullException(nameof(m3ORCU));
			if (string.IsNullOrWhiteSpace(m3DECU))
				throw new ArgumentNullException(nameof(m3DECU));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUCH", m3CUCH.Trim())
				.WithQueryParameter("ORCU", m3ORCU.Trim())
				.WithQueryParameter("DECU", m3DECU.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3GCAC))
				request.WithQueryParameter("GCAC", m3GCAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3INRC))
				request.WithQueryParameter("INRC", m3INRC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADI3))
				request.WithQueryParameter("ADI3", m3ADI3.Trim());

			// Execute the request
			var result = await Execute<SelResponse>(
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
		/// Name Upd
		/// Description Add Customer Channel
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3CUCH">Customer channel id (Required)</param>
		/// <param name="m3ORCU">Order by customer (Required)</param>
		/// <param name="m3DECU">Delivery customer (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3ADID">Address number</param>
		/// <param name="m3INRC">Invoice recipient</param>
		/// <param name="m3GCAC">Activity</param>
		/// <param name="m3ADI3">Invoice adress - NOT IN USE (2017-07-17)</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3ORC1">Order by customer</param>
		/// <param name="m3DEC1">Delivery customer</param>
		/// <param name="m3ADI1">Delivery adress</param>
		/// <param name="m3INR1">Invoice recipient</param>
		/// <param name="m3ADI4">Invoice adress - NOT IN USE (2017-07-17)</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3CCAC">Activity</param>
		/// <param name="m3CMCU">Commersial customer</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3CUCH, 
			string m3ORCU, 
			string m3DECU, 
			DateTime m3FDAT, 
			string m3ADID = null, 
			string m3INRC = null, 
			string m3GCAC = null, 
			string m3ADI3 = null, 
			DateTime? m3TDAT = null, 
			string m3ORC1 = null, 
			string m3DEC1 = null, 
			string m3ADI1 = null, 
			string m3INR1 = null, 
			string m3ADI4 = null, 
			string m3PYNO = null, 
			string m3CCAC = null, 
			string m3CMCU = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Upd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3CUCH))
				throw new ArgumentNullException(nameof(m3CUCH));
			if (string.IsNullOrWhiteSpace(m3ORCU))
				throw new ArgumentNullException(nameof(m3ORCU));
			if (string.IsNullOrWhiteSpace(m3DECU))
				throw new ArgumentNullException(nameof(m3DECU));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUCH", m3CUCH.Trim())
				.WithQueryParameter("ORCU", m3ORCU.Trim())
				.WithQueryParameter("DECU", m3DECU.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ADID))
				request.WithQueryParameter("ADID", m3ADID.Trim());
			if (!string.IsNullOrWhiteSpace(m3INRC))
				request.WithQueryParameter("INRC", m3INRC.Trim());
			if (!string.IsNullOrWhiteSpace(m3GCAC))
				request.WithQueryParameter("GCAC", m3GCAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADI3))
				request.WithQueryParameter("ADI3", m3ADI3.Trim());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ORC1))
				request.WithQueryParameter("ORC1", m3ORC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEC1))
				request.WithQueryParameter("DEC1", m3DEC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADI1))
				request.WithQueryParameter("ADI1", m3ADI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3INR1))
				request.WithQueryParameter("INR1", m3INR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADI4))
				request.WithQueryParameter("ADI4", m3ADI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CCAC))
				request.WithQueryParameter("CCAC", m3CCAC.Trim());
			if (!string.IsNullOrWhiteSpace(m3CMCU))
				request.WithQueryParameter("CMCU", m3CMCU.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
