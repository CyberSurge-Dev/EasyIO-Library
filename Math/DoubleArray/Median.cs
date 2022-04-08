using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace EasyIO {
	public partial class Math {
		public static double Median(params double[] sourceNumbers) {
	    //Framework 2.0 version of this method. there is an easier way in F4        
	    if (sourceNumbers == null || sourceNumbers.Length == 0)
	      throw new System.Exception("Median of empty array not defined.");
	
	    //make sure the list is sorted, but use a new array
	    double[] sortedPNumbers = (double[]) sourceNumbers.Clone();
	    Array.Sort(sortedPNumbers);
	
	    //get the median
	    int size = sortedPNumbers.Length;
	    int mid = size / 2;
	    double median = (size % 2 != 0) ? (double) sortedPNumbers[mid] : ((double) sortedPNumbers[mid] + (double) sortedPNumbers[mid - 1]) / 2;
	    return median;
	  }
	}
}