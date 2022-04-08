using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace EasyIO {
	public partial class Converter {
		public static List <long> ToLong (List < char > input) {
			List<long> output = new List<long>();
			int i = 0;
			foreach (char items in input) {
				output[i] = (long)Convert.ToDouble(input[i]);
				i++;
			}
			return output;
		}
	}
}