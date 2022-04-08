using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace EasyIO {
	public partial class Converter {
		public static List <int> ToInt (List < string > input) {
			List<int> output = new List<int>();
			int i = 0;
			foreach (string items in input) {
				output[i] = Convert.ToInt32(input[i]);
				i++;
			}
			return output;
		}
	}
}