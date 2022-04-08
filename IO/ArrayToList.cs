using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace EasyIO {
	public partial class IO {
		public static string[, ] ArrayToList(List < List < string >> inlst) {
	    string[, ] outlst = new string[inlst.Count, inlst[0].Count];
	    for (int i = 0; i < (outlst.GetLength(0)); i++) {
	      for (int f = 0; f < (outlst.GetLength(1)); f++) {
	        outlst[i, f] = inlst[i][f];
	      }
	    }
	    return outlst;
	  }
	}
}