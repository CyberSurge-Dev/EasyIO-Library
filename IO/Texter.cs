using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace EasyIO {
	public partial class IO {
		public static int Texter(string input, int time = 0) {
	    System.ConsoleColor ogColor = System.Console.ForegroundColor;
	    Console.ForegroundColor = ogColor;
	    int i = 0;
	    foreach(char z in input) {
	      Console.Write(input[i]);
	      i++;
	      System.Threading.Thread.Sleep(time);
	    }
	    Console.Write("\n");
	    return 0;
	  }
	}
}