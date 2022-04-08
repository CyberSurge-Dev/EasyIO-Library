using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace EasyIO {
	public partial class Converter {
		public static long[] ToArray ( List < long > input) {
			long[] output = new long[input.Count];
			int i = 0;
			foreach (long items in input) {
				output[i] = items;
				i++;
			}
			return output;
		}
	}
}