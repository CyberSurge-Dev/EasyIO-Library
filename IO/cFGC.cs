using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace EasyIO {
	public partial class IO {
		public static string cFGC() {
	    string CurrentFGC = Convert.ToString(Console.ForegroundColor);
	    return CurrentFGC;
	  }
	}
}