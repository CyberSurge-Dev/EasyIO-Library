using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace EasyIO {
	public partial class Converter {
		public static List <double> ToDouble (List < char > input) {
			List<double> output = new List<double>();
			int i = 0;
			foreach (char items in input) {
				output[i] = Convert.ToDouble(input[i]);
				i++;
			}
			return output;
		}
	}
}