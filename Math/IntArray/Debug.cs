using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;namespace EasyIO {
	public partial class Math {
		public static string DEBUG(params int[] numlst) {
	    string[, ] Table = {
	      {
	        "",
	        "Output"
	      },
	      {
	        "Add",
	        Convert.ToString(Math.Add(numlst))
	      },
	      {
	        "Subtract",
	        Convert.ToString(Math.Subtract(numlst))
	      },
	      {
	        "Multiply",
	        Convert.ToString(Math.Multiply(numlst))
	      },
	      {
	        "Divide",
	        Convert.ToString(Math.Divide(numlst))
	      },
	      {
	        "Mean",
	        Convert.ToString(Math.Mean(numlst))
	      },
	      {
	        "Median",
	        Convert.ToString(Math.Median(numlst))
	      },
	      {
	        "Mode",
	        Convert.ToString(Math.Mode(numlst))
	      }
	    };
	    return IO.Table(
	      list: Table
	    );
	  }
	}
}