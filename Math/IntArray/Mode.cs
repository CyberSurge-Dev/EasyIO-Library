using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace EasyIO {
	public partial class Math {
		public static int Mode(params int[] numlst) {
	    List < int > list = new List < int > ();
	    list.AddRange(numlst);
	    // Initialize the return value
	    int mode = 0;
	    // Test for a null reference and an empty list
	    if (list != null && list.Count() > 0) {
	      // Store the number of occurences for each element
	      Dictionary < int, int > counts = new Dictionary < int, int > ();
	      // Add one to the count for the occurence of a character
	      foreach(int element in list) {
	        if (counts.ContainsKey(element))
	          counts[element]++;
	        else
	          counts.Add(element, 1);
	      }
	      // Loop through the counts of each element and find the 
	      // element that occurred most often
	      int max = 0;
	      foreach(KeyValuePair < int, int > count in counts) {
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