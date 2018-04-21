using System;
using System.Collections.Generic;
using System.Linq;

namespace IS_HeMart.Utils
{
	public static class EnumHelper
	{
		public static Dictionary<int, string> GetEnumItems<T>()
		{
			return Enum
					.GetValues(typeof(T))
					.Cast<T>()
					.ToDictionary(i => (int)Convert.ChangeType(i, i.GetType()), t => t.ToString());
		}
	}

	class KeyValue
	{
		public int Key { get; set; }
		public string Name { get; set; }
	}
}
