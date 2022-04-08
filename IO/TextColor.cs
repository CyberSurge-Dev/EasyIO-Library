using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace EasyIO {
	public partial class IO {
		public static string TextColor(string color, string input) {
	    System.ConsoleColor ogColor = System.Console.ForegroundColor;
	    try {
	      ConsoleColor newFGC = (ConsoleColor) Enum.Parse(typeof (ConsoleColor), color, true);
	      Console.ForegroundColor = newFGC;
	      Console.WriteLine(input);
	      return input;
	    } catch (Exception) {
	      return "Invalid Input";
	    } finally {
	      Console.ForegroundColor = ogColor;
	    }
	  }
	}
}