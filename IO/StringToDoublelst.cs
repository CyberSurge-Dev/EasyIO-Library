using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace EasyIO {
	public partial class IO {
		public static double[] StringToDoublelst(string[] input) {
	    double[] output = new double[input.Length];
	    try {
	      int i = 0;
	      foreach(string items in input) {
	        output[i] = Convert.ToDouble(input[i]);
	        i++;
	      }
	    } catch (Exception) {
	      return output;
	    }
	    return output;
	  }
	}
}