using System.IO;
using System.Linq;
namespace EasyIO {
	public partial class Files {
		public static string Read(string filename, int line = 0) {
	    string rtn = File.ReadLines(filename).Skip(line - 1).Take(1).First();
	    return rtn;
	  }
	}
}