/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.MMS160MI;
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
	/// Name: MMS160MI
	/// Component Name: Location Select
	/// Description: Api: Location Select
	/// Version Release: 14.x
	///</summary>
	public partial class MMS160MIResource : M3BaseResourceEndpoint
	{
		public MMS160MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS160MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstPutAwayLoc
		/// Description List Put Away Location
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3WHSL">Location</param>
		/// <param name="m3SLTP">Stock zone</param>
		/// <param name="m3WHLT">Location type</param>
		/// <param name="m3DEST">Status proposal</param>
		/// <param name="m3SPID">Distribution identity</param>
		/// <param name="m3ABFC">ABC class - frequency</param>
		/// <param name="m3TRFL">Transportation flow</param>
		/// <param name="m3LOCG">Location group</param>
		/// <param name="m3PISE">Warehouse equipment</param>
		/// <param name="m3NBRL">Number of balance identities</param>
		/// <param name="m3NORC">No of records</param>
		/// <param name="m3RPQA">Reported quantity in alternative unit</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ALUN">Alternate U/M</param>
		/// <param name="m3CAMU">Container</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3SELO">Selection option</param>
		/// <param name="m3APQU">Allow Partial Quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPutAwayLocResponse></returns>
		/// <exception cref="M3Exception<LstPutAwayLocResponse>"></exception>
		public async Task<M3Response<LstPutAwayLocResponse>> LstPutAwayLoc(
			string m3WHLO = null, 
			string m3WHSL = null, 
			string m3SLTP = null, 
			string m3WHLT = null, 
			string m3DEST = null, 
			string m3SPID = null, 
			string m3ABFC = null, 
			string m3TRFL = null, 
			string m3LOCG = null, 
			string m3PISE = null, 
			int? m3NBRL = null, 
			long? m3NORC = null, 
			decimal? m3RPQA = null, 
			string m3ITNO = null, 
			string m3ALUN = null, 
			string m3CAMU = null, 
			string m3BANO = null, 
			int? m3SELO = null, 
			int? m3APQU = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPutAwayLoc",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHSL))
				request.WithQueryParameter("WHSL", m3WHSL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLTP))
				request.WithQueryParameter("SLTP", m3SLTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLT))
				request.WithQueryParameter("WHLT", m3WHLT.Trim());
			if (!string.IsNullOrWhiteSpace(m3DEST))
				request.WithQueryParameter("DEST", m3DEST.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPID))
				request.WithQueryParameter("SPID", m3SPID.Trim());
			if (!string.IsNullOrWhiteSpace(m3ABFC))
				request.WithQueryParameter("ABFC", m3ABFC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRFL))
				request.WithQueryParameter("TRFL", m3TRFL.Trim());
			if (!string.IsNullOrWhiteSpace(m3LOCG))
				request.WithQueryParameter("LOCG", m3LOCG.Trim());
			if (!string.IsNullOrWhiteSpace(m3PISE))
				request.WithQueryParameter("PISE", m3PISE.Trim());
			if (m3NBRL.HasValue)
				request.WithQueryParameter("NBRL", m3NBRL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NORC.HasValue)
				request.WithQueryParameter("NORC", m3NORC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RPQA.HasValue)
				request.WithQueryParameter("RPQA", m3RPQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALUN))
				request.WithQueryParameter("ALUN", m3ALUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CAMU))
				request.WithQueryParameter("CAMU", m3CAMU.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3SELO.HasValue)
				request.WithQueryParameter("SELO", m3SELO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3APQU.HasValue)
				request.WithQueryParameter("APQU", m3APQU.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPutAwayLocResponse>(
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
