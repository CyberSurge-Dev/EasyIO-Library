using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace EasyIO {
	public partial class Files {
		public static void Clear(string filename) {
	    System.IO.File.WriteAllText(@filename, string.Empty);
	  }
	}
}