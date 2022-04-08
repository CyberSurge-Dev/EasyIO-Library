using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace EasyIO {
	public partial class Converter {
		public static List <char> ToChar (List < string > input) {
			List<char> output = new List<char>();
			int i = 0;
			foreach (string items in input) {
				output[i] = Convert.ToChar(input[i][0]);
				i++;
			}
			return output;
		}
	}
}