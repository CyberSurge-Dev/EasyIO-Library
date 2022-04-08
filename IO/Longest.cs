using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace EasyIO {
	public partial class IO {
		public static string Longest(params string[] input) {
	    string longest = input[0];
	    foreach(string s in input) {
	      if (s.Length > longest.Length) {
	        longest = s;
	      }
	    }
	    return longest;
	  }
	}
}