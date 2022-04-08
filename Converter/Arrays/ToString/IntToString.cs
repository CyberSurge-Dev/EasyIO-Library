using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace EasyIO {
	public partial class Converter {
		public static string[] ToString (params int[] input) {
			string[] output = new string[input.Length];
			for (int i = 0; i < input.Length; i++) {
				output[i] = Convert.ToString(input[i]);
			}
			return output;
		}
	}
}