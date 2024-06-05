/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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

namespace M3H5Lib.Api
{

	/// <summary>
	/// Name: POS291MI
	/// Component Name: MaterialBudget
	/// Description: Material budget interface
	/// Version Release: 12.0
	///</summary>
	public partial class POS291MIResource : M3BaseResourceEndpoint
	{
		public POS291MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "POS291MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddItem
		/// Description Add Item Number
		/// Version Release: 12.0
		/// </summary>
		/// <param name="m3_PROJ">Project number (Required)</param>
		/// <param name="m3_ELNO">Project element (Required)</param>
		/// <param name="m3_DTUM">Date (Required)</param>
		/// <param name="m3_ITNO">Item no (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_VERS">Version</param>
		/// <param name="m3_PRNO">Product no</param>
		/// <param name="m3_CTIT">Parent item</param>
		/// <param name="m3_BUQT">Budget qty</param>
		/// <param name="m3_BUAP">Budget price</param>
		/// <param name="m3_BUAT">Budget Amount</param>
		/// <param name="m3_PUIT">Acquisition code</param>
		/// <param name="m3_AQEL">Acquisition element</param>
		/// <param name="m3_IDEN">Budget identity - material</param>
		/// <param name="m3_IDEH">Budget identity - hours</param>
		/// <param name="m3_FRE1">Free field 1</param>
		/// <param name="m3_FRE2">Free field 2</param>
		/// <param name="m3_FRE3">Free field 3</param>
		/// <param name="m3_FRE4">Free field 4</param>
		/// <param name="m3_FRE5">Free field 5</param>
		/// <param name="m3_FRE6">Free field 6</param>
		/// <param name="m3_ELN1">Element Purchase</param>
		/// <param name="m3_ELN2">Element Manufacturing</param>
		/// <param name="m3_ELN3">Element GST</param>
		/// <param name="m3_ELN4">Element Delivery Customer</param>
		/// <param name="m3_ELN5">Element Customer order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItem(
			string m3_PROJ, 
			string m3_ELNO, 
			DateTime m3_DTUM, 
			string m3_ITNO, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_VERS = null, 
			string m3_PRNO = null, 
			string m3_CTIT = null, 
			decimal? m3_BUQT = null, 
			decimal? m3_BUAP = null, 
			decimal? m3_BUAT = null, 
			int? m3_PUIT = null, 
			string m3_AQEL = null, 
			string m3_IDEN = null, 
			string m3_IDEH = null, 
			string m3_FRE1 = null, 
			string m3_FRE2 = null, 
			string m3_FRE3 = null, 
			string m3_FRE4 = null, 
			string m3_FRE5 = null, 
			string m3_FRE6 = null, 
			string m3_ELN1 = null, 
			string m3_ELN2 = null, 
			string m3_ELN3 = null, 
			string m3_ELN4 = null, 
			string m3_ELN5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PROJ))
				throw new ArgumentNullException("m3_PROJ");
			if (string.IsNullOrWhiteSpace(m3_ELNO))
				throw new ArgumentNullException("m3_ELNO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PROJ", m3_PROJ.Trim())
				.WithQueryParameter("ELNO", m3_ELNO.Trim())
				.WithQueryParameter("DTUM", m3_DTUM.ToM3String())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_VERS.HasValue)
				request.WithQueryParameter("VERS", m3_VERS.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CTIT))
				request.WithQueryParameter("CTIT", m3_CTIT.Trim());
			if (m3_BUQT.HasValue)
				request.WithQueryParameter("BUQT", m3_BUQT.Value.ToString());
			if (m3_BUAP.HasValue)
				request.WithQueryParameter("BUAP", m3_BUAP.Value.ToString());
			if (m3_BUAT.HasValue)
				request.WithQueryParameter("BUAT", m3_BUAT.Value.ToString());
			if (m3_PUIT.HasValue)
				request.WithQueryParameter("PUIT", m3_PUIT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AQEL))
				request.WithQueryParameter("AQEL", m3_AQEL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IDEN))
				request.WithQueryParameter("IDEN", m3_IDEN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IDEH))
				request.WithQueryParameter("IDEH", m3_IDEH.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE1))
				request.WithQueryParameter("FRE1", m3_FRE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE2))
				request.WithQueryParameter("FRE2", m3_FRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE3))
				request.WithQueryParameter("FRE3", m3_FRE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE4))
				request.WithQueryParameter("FRE4", m3_FRE4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE5))
				request.WithQueryParameter("FRE5", m3_FRE5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRE6))
				request.WithQueryParameter("FRE6", m3_FRE6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELN1))
				request.WithQueryParameter("ELN1", m3_ELN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELN2))
				request.WithQueryParameter("ELN2", m3_ELN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELN3))
				request.WithQueryParameter("ELN3", m3_ELN3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELN4))
				request.WithQueryParameter("ELN4", m3_ELN4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELN5))
				request.WithQueryParameter("ELN5", m3_ELN5.Trim());

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
