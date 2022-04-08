using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace EasyIO {
	public partial class IO {
		public static int BGcolor(string color) {
	    try {
	      ConsoleColor newBGC = (ConsoleColor) Enum.Parse(typeof (ConsoleColor), color, true);
	      Console.BackgroundColor = newBGC;
	      return 1;
	    } catch (Exception) {
	      return 0;
	    }
	  }
	}
}