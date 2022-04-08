using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace EasyIO {
	public partial class Converter {
		public static string[] ToArray ( List < string > input) {
			string[] output = new string[input.Count];
			int i = 0;
			foreach (string items in input) {
				output[i] = items;
				i++;
			}
			return output;
		}
	}
}