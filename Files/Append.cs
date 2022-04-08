using System;
using System.IO;
namespace EasyIO {
	public partial class Files {
		public static void Append(string filename, string Text) {
	    //try {
	    File.AppendAllText(@filename, Text + Environment.NewLine);
	    return;
	    //} catch (Exception) {
	      //return;
	    //}
	  }
	}
}