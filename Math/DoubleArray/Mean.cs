using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace EasyIO {
	public partial class Math {
		public static double Mean(params double[] numlst) {
	    double result = numlst[0];
	    for (int i = 1; i < numlst.Length; i++) {
	      result += numlst[i];
	    }
	    result /= numlst.Length;
	    return result;
	  }
	}
}