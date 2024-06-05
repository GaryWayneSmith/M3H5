using System;
using System.Collections.Generic;
using System.Text;

namespace M3H5Lib.Api.M3EXPORTMI
{
	public class M3EXPORTMIFieldDefinition
	{
		public string FieldName { get; set; }
		public int Index { get; set; }
		// Must match the table definition to exact length
		// Please note, field length is field length plus precision (decimal places).
		public int DataLength { get; set; }
	}
}
