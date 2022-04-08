using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace EasyIO {
	public partial class Rnd {
		public static char[] CharArray (int size = 1) {
			int r;
			char[] output = new char[size];
			for (int i = 0; i < size; i++) {
				r = Random.Next(1, 3) == 1 ? Random.Next(65, 91) : Random.Next(97, 123);
				output[i] = Convert.ToChar(r);
			}
			return output;
		}
	}
}