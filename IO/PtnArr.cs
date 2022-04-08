using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace EasyIO {
	public partial class IO {
		public static string PtnArr(int offset = 0, params string[] input) {
	    try {
	      string output = "";
	      string off = "";
	      int g = 0;
	      int length = input.Length;
	      length = length - 1;
	      while (g < offset) {
	        off += " ";
	        g++;
	      }
	      int i = 0;
	      while (i < length) {
	        output += off + input[i] + "\n";
	        i++;
	      }
	      output += off + input[i];
	      return output;
	    } catch (Exception) {
	      return string.Empty;
	    }
	  }
	}
}