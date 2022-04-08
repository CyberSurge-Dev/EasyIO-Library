using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace EasyIO {
	public partial class Converter {
		public static int[] ToArray ( List < int > input) {
			int[] output = new int[input.Count];
			int i = 0;
			foreach (int items in input) {
				output[i] = items;
				i++;
			}
			return output;
		}
	}
}