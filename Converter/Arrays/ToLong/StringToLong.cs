using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace EasyIO {
	public partial class Converter {
		public static long[] ToLong (params string[] input) {
			long[] output = new long[input.Length];
			for (int i = 0; i < input.Length; i++) {
				output[i] = (long)Convert.ToDouble(input[i]);
			}
			return output;
		}
	}
}