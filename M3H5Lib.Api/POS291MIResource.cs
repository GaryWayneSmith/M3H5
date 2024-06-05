/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
		/// <param name="m3PROJ">Project number (Required)</param>
		/// <param name="m3ELNO">Project element (Required)</param>
		/// <param name="m3DTUM">Date (Required)</param>
		/// <param name="m3ITNO">Item no (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3VERS">Version</param>
		/// <param name="m3PRNO">Product no</param>
		/// <param name="m3CTIT">Parent item</param>
		/// <param name="m3BUQT">Budget qty</param>
		/// <param name="m3BUAP">Budget price</param>
		/// <param name="m3BUAT">Budget Amount</param>
		/// <param name="m3PUIT">Acquisition code</param>
		/// <param name="m3AQEL">Acquisition element</param>
		/// <param name="m3IDEN">Budget identity - material</param>
		/// <param name="m3IDEH">Budget identity - hours</param>
		/// <param name="m3FRE1">Free field 1</param>
		/// <param name="m3FRE2">Free field 2</param>
		/// <param name="m3FRE3">Free field 3</param>
		/// <param name="m3FRE4">Free field 4</param>
		/// <param name="m3FRE5">Free field 5</param>
		/// <param name="m3FRE6">Free field 6</param>
		/// <param name="m3ELN1">Element Purchase</param>
		/// <param name="m3ELN2">Element Manufacturing</param>
		/// <param name="m3ELN3">Element GST</param>
		/// <param name="m3ELN4">Element Delivery Customer</param>
		/// <param name="m3ELN5">Element Customer order</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddItem(
			string m3PROJ, 
			string m3ELNO, 
			DateTime m3DTUM, 
			string m3ITNO, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			int? m3VERS = null, 
			string m3PRNO = null, 
			string m3CTIT = null, 
			decimal? m3BUQT = null, 
			decimal? m3BUAP = null, 
			decimal? m3BUAT = null, 
			int? m3PUIT = null, 
			string m3AQEL = null, 
			string m3IDEN = null, 
			string m3IDEH = null, 
			string m3FRE1 = null, 
			string m3FRE2 = null, 
			string m3FRE3 = null, 
			string m3FRE4 = null, 
			string m3FRE5 = null, 
			string m3FRE6 = null, 
			string m3ELN1 = null, 
			string m3ELN2 = null, 
			string m3ELN3 = null, 
			string m3ELN4 = null, 
			string m3ELN5 = null, 
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
			if (string.IsNullOrWhiteSpace(m3PROJ))
				throw new ArgumentNullException(nameof(m3PROJ));
			if (string.IsNullOrWhiteSpace(m3ELNO))
				throw new ArgumentNullException(nameof(m3ELNO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PROJ", m3PROJ.Trim())
				.WithQueryParameter("ELNO", m3ELNO.Trim())
				.WithQueryParameter("DTUM", m3DTUM.ToM3String())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3VERS.HasValue)
				request.WithQueryParameter("VERS", m3VERS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CTIT))
				request.WithQueryParameter("CTIT", m3CTIT.Trim());
			if (m3BUQT.HasValue)
				request.WithQueryParameter("BUQT", m3BUQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUAP.HasValue)
				request.WithQueryParameter("BUAP", m3BUAP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BUAT.HasValue)
				request.WithQueryParameter("BUAT", m3BUAT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUIT.HasValue)
				request.WithQueryParameter("PUIT", m3PUIT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AQEL))
				request.WithQueryParameter("AQEL", m3AQEL.Trim());
			if (!string.IsNullOrWhiteSpace(m3IDEN))
				request.WithQueryParameter("IDEN", m3IDEN.Trim());
			if (!string.IsNullOrWhiteSpace(m3IDEH))
				request.WithQueryParameter("IDEH", m3IDEH.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE1))
				request.WithQueryParameter("FRE1", m3FRE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE2))
				request.WithQueryParameter("FRE2", m3FRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE3))
				request.WithQueryParameter("FRE3", m3FRE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE4))
				request.WithQueryParameter("FRE4", m3FRE4.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE5))
				request.WithQueryParameter("FRE5", m3FRE5.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRE6))
				request.WithQueryParameter("FRE6", m3FRE6.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELN1))
				request.WithQueryParameter("ELN1", m3ELN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELN2))
				request.WithQueryParameter("ELN2", m3ELN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELN3))
				request.WithQueryParameter("ELN3", m3ELN3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELN4))
				request.WithQueryParameter("ELN4", m3ELN4.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELN5))
				request.WithQueryParameter("ELN5", m3ELN5.Trim());

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
