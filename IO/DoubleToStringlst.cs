using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace EasyIO {
	public partial class IO {
		public static string[] DoubleToStringlst(double[] input) {
	    string[] output = new string[input.Length];
	    try {
	      int i = 0;
	      foreach(double items in input) {
	        output[i] = Convert.ToString(input[i]);
	        i++;
	      }
	    } catch (Exception) {
	      return output;
	    }
	    return output;
	  }
	}
}