using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace EasyIO {
	public partial class Math {
		public static double Median(IEnumerable < double > source) {
	    // Create a copy of the input, and sort the copy
	    double[] temp = source.ToArray();
	    Array.Sort(temp);
	    int count = temp.Length;
	    if (count == 0) {
	      throw new InvalidOperationException("Empty collection");
	    } else if (count % 2 == 0) {
	      // count is even, average two middle elements
	      double a = Convert.ToDouble(temp[count / 2 - 1]);
	      double b = Convert.ToDouble(temp[(count) / 2]);
	      return (a + b) / 2;
	    } else {
	      // count is odd, return the middle element
	      return Convert.ToDouble(temp[count / 2]);
	    }
	  }
	}
}