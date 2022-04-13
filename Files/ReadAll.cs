using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace EasyIO {
	public partial class Files {
		public static string[] ReadAll(string filename) {
	    string[] arrLine = File.ReadAllLines(@filename);
	    return arrLine;
	  }
	}
}