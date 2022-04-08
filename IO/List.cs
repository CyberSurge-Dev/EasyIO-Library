using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace EasyIO {
	public partial class IO {
		public static string List(int offset = 0, params string[] input) {
	    int i = 1;
	    string number = "";
	    foreach(string items in input) {
	      number = Convert.ToString(i) + ". ";
	      input[i - 1] = number + input[i - 1];
	      i++;
	    }
	    int f = 0;
	    int g = 0;
	    string output = "";
	    string off = "";
	    while (g < offset) {
	      off += " ";
	      g++;
	    }
	    while (f < input.Length - 1) {
	      output += off + input[f] + "\n";
	      f++;
	    }
	    output += off + input[f];
	    return output;
	  }
	}
}