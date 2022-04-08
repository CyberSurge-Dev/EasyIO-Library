using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace EasyIO {
	public partial class Converter {
		public static char[] ToArray ( List < char > input) {
			char[] output = new char[input.Count];
			int i = 0;
			foreach (char items in input) {
				output[i] = items;
				i++;
			}
			return output;
		}
	}
}