using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace EasyIO {
	public partial class IO {
		public static void FGcolor(string color) {
	    try {
	      ConsoleColor newFGC = (ConsoleColor) Enum.Parse(typeof (ConsoleColor), color, true);
	      Console.ForegroundColor = newFGC;
	      return;
	    } catch (Exception) {
	      return;
	    }
	  }
	}
}