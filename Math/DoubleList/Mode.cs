using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace EasyIO {
	public partial class Math {
		public static double Mode(IEnumerable < double > list) {
	    // Initialize the return value
	    double mode = 0;
	    // Test for a null reference and an empty list
	    if (list != null && list.Count() > 0) {
	      // Store the number of occurences for each element
	      Dictionary < double, double > counts = new Dictionary < double, double > ();
	      // Add one to the count for the occurence of a character
	      foreach(double element in list) {
	        if (counts.ContainsKey(element))
	          counts[element]++;
	        else
	          counts.Add(element, 1);
	      }
	      // Loop through the counts of each element and find the 
	      // element that occurred most often
	      double max = 0;
	      foreach(KeyValuePair < double, double > count in counts) {
	        if (count.Value > max) {
	          // Update the mode
	          mode = count.Key;
	          max = count.Value;
	        }
	      }
	    }
	    return mode;
	  }
	}
}