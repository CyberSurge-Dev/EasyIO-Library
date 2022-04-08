using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace EasyIO {
	public partial class Converter {
		public static List <char> ToChar (List < double > input) {
			List<char> output = new List<char>();
			int i = 0;
			foreach (double items in input) {
				output[i] = Convert.ToChar(Convert.ToString(input[i])[0]);
				i++;
			}
			return output;
		}
	}
}