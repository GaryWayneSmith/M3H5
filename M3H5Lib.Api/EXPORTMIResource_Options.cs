using M3H5Lib.Api.M3EXPORTMI;
using M3H5Lib.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace M3H5Lib.Api
{
	public partial class EXPORTMIResource
	{

		public static M3Response<T> ProcessM3EXPORTMIResponse<T>(M3EXPORTMIRequest request, M3Response<EXPORTMI.SelectResponse> response,
			bool? skipHeader = null,
			bool? trimResults = null
			) where T : M3BaseRecord, new()
		{
            if (request == null)
                throw new ArgumentNullException(nameof(request));
            if (response == null)
                throw new ArgumentNullException(nameof(response));

            M3RecordList<T> m3Rows = new M3RecordList<T>();

			string trim(string data)
			{
				if (trimResults.GetValueOrDefault(false))
				{
					return data.Trim();
				}
				return data;
			};

            int recordLength = request.RecordLength;
			foreach (EXPORTMI.SelectResponse row in response.Rows)
			{
				if (row.RowIndex == 0
					&& skipHeader.GetValueOrDefault(true))
				{
					continue;
				}

				string repl_field = row["REPL"];

				T m3Row = null;
				if (repl_field.Length != recordLength)
				{
					m3Row = new T
					{
						HasConversionError = true,
						ConversionErrorMessage = $"Record length is incorrect, Index: {row.RowIndex}, Length: {repl_field.Length}, Wanted: {recordLength}, Content: [{repl_field}]",
					};
					m3Rows.Add(m3Row);
					continue;
				}

				List<M3Field> m3Fields = new List<M3Field>();

				int fieldIndexer = 0;
				foreach (var field in request.FieldDefinitions
					.OrderBy(fd => fd.Index))
				{

					M3Field m3Field = new M3Field
					{
						Key = trim(field.FieldName),
						Value = trim(repl_field.Substring(fieldIndexer, field.DataLength)),
					};
					fieldIndexer += field.DataLength;
					m3Fields.Add(m3Field);
				}

				m3Row = new T
				{
					Fields = m3Fields,
					RowIndex = row.RowIndex,
				};
				m3Rows.Add(m3Row);
			}

			return new M3Response<T>
			{
				Code = response.Code,
				ErrorField = response.ErrorField,
				Message = response.Message,
				ReturnCode = response.ReturnCode,
				Rows = m3Rows,
			};
		}
	}
}
