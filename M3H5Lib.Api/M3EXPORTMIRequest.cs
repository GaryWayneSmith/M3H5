using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M3H5Lib.Api.M3EXPORTMI
{
	public class M3EXPORTMIRequest
	{
		public string TablePrefix { get; set; }
		public List<M3EXPORTMIFieldDefinition> FieldDefinitions { get; set; } = new List<M3EXPORTMIFieldDefinition>();

		public M3EXPORTMIRequest AddFieldDefinition(string fieldName, int length)
		{
			int rows = FieldDefinitions.Count;
			FieldDefinitions.Add(new M3EXPORTMIFieldDefinition
			{
				Index = rows,
				FieldName = fieldName,
				DataLength = length,
			});
			return this;
		}

		public int RecordLength
		{
			get
			{
				return FieldDefinitions
					.Select(fd => fd.DataLength)
					.DefaultIfEmpty(0)
					.Sum();
			}
		}

		public string GetQueryFields
		{
			get
			{
				return string.Join(",", FieldDefinitions
					.OrderBy(df => df.Index)
					.Select(df => TablePrefix + df.FieldName));
			}
		}
	}
}
