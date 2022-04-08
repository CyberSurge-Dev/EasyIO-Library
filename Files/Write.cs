using System.IO;
using System.Collections.Generic;
namespace EasyIO {
	public partial class Files {
		public static void Write(string fileName, string newText, int line_to_edit) {
	    string[] arrLine = File.ReadAllLines(fileName);
	    int count = 0;
	    using(var reader = new StreamReader(fileName)) {
	      while (reader.ReadLine() != null) {
	        count++;
	      }
	    }
	    List < string > Countlst = new List < string > ();
	    Countlst.AddRange(arrLine);
	    while (count < line_to_edit) {
	      Countlst.Add("");
	      count++;
	    }
	    arrLine = Countlst.ToArray();
	    arrLine[line_to_edit - 1] = newText;
	    File.WriteAllLines(fileName, arrLine);
	  }
	}
}