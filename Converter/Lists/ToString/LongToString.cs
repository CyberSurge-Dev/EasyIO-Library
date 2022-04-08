using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace EasyIO {
	public partial class Converter {
		public static List <string> ToString (List < long > input) {
			List<string> output = new List<string>();
			int i = 0;
			foreach (long items in input) {
				output[i] = Convert.ToString(input[i]);
				i++;
			}
			return output;
		}
	}
}