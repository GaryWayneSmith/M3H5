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
	/// Name: MNS910MI
	/// Component Name: WorkSpaceEntities
	/// Description: Workspace entities
	/// Version Release: 5ea0
	///</summary>
	public partial class MNS910MIResource : M3BaseResourceEndpoint
	{
		public MNS910MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MNS910MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name UpdMenu
		/// Description Mass updata in menu system
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3LN01">Language</param>
		/// <param name="m3OP01">Option</param>
		/// <param name="m3LN02">Language</param>
		/// <param name="m3OP02">Option</param>
		/// <param name="m3LN03">Language</param>
		/// <param name="m3OP03">Option</param>
		/// <param name="m3LN04">Language</param>
		/// <param name="m3OP04">Option</param>
		/// <param name="m3LN05">Language</param>
		/// <param name="m3OP05">Option</param>
		/// <param name="m3LN06">Language</param>
		/// <param name="m3OP06">Option</param>
		/// <param name="m3LN07">Language</param>
		/// <param name="m3OP07">Option</param>
		/// <param name="m3LN08">Language</param>
		/// <param name="m3OP08">Option</param>
		/// <param name="m3LN09">Language</param>
		/// <param name="m3OP09">Option</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdMenu(
			string m3LN01 = null, 
			string m3OP01 = null, 
			string m3LN02 = null, 
			string m3OP02 = null, 
			string m3LN03 = null, 
			string m3OP03 = null, 
			string m3LN04 = null, 
			string m3OP04 = null, 
			string m3LN05 = null, 
			string m3OP05 = null, 
			string m3LN06 = null, 
			string m3OP06 = null, 
			string m3LN07 = null, 
			string m3OP07 = null, 
			string m3LN08 = null, 
			string m3OP08 = null, 
			string m3LN09 = null, 
			string m3OP09 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdMenu",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3LN01))
				request.WithQueryParameter("LN01", m3LN01.Trim());
			if (!string.IsNullOrWhiteSpace(m3OP01))
				request.WithQueryParameter("OP01", m3OP01.Trim());
			if (!string.IsNullOrWhiteSpace(m3LN02))
				request.WithQueryParameter("LN02", m3LN02.Trim());
			if (!string.IsNullOrWhiteSpace(m3OP02))
				request.WithQueryParameter("OP02", m3OP02.Trim());
			if (!string.IsNullOrWhiteSpace(m3LN03))
				request.WithQueryParameter("LN03", m3LN03.Trim());
			if (!string.IsNullOrWhiteSpace(m3OP03))
				request.WithQueryParameter("OP03", m3OP03.Trim());
			if (!string.IsNullOrWhiteSpace(m3LN04))
				request.WithQueryParameter("LN04", m3LN04.Trim());
			if (!string.IsNullOrWhiteSpace(m3OP04))
				request.WithQueryParameter("OP04", m3OP04.Trim());
			if (!string.IsNullOrWhiteSpace(m3LN05))
				request.WithQueryParameter("LN05", m3LN05.Trim());
			if (!string.IsNullOrWhiteSpace(m3OP05))
				request.WithQueryParameter("OP05", m3OP05.Trim());
			if (!string.IsNullOrWhiteSpace(m3LN06))
				request.WithQueryParameter("LN06", m3LN06.Trim());
			if (!string.IsNullOrWhiteSpace(m3OP06))
				request.WithQueryParameter("OP06", m3OP06.Trim());
			if (!string.IsNullOrWhiteSpace(m3LN07))
				request.WithQueryParameter("LN07", m3LN07.Trim());
			if (!string.IsNullOrWhiteSpace(m3OP07))
				request.WithQueryParameter("OP07", m3OP07.Trim());
			if (!string.IsNullOrWhiteSpace(m3LN08))
				request.WithQueryParameter("LN08", m3LN08.Trim());
			if (!string.IsNullOrWhiteSpace(m3OP08))
				request.WithQueryParameter("OP08", m3OP08.Trim());
			if (!string.IsNullOrWhiteSpace(m3LN09))
				request.WithQueryParameter("LN09", m3LN09.Trim());
			if (!string.IsNullOrWhiteSpace(m3OP09))
				request.WithQueryParameter("OP09", m3OP09.Trim());

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
