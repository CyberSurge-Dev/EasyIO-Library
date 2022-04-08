using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace EasyIO {
	public partial class Converter {
		public static double[] ToArray ( List < double > input) {
			double[] output = new double[input.Count];
			int i = 0;
			foreach (double items in input) {
				output[i] = items;
				i++;
			}
			return output;
		}
	}
}