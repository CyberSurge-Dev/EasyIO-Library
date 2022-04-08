using System;
using System.Collections.Generic;

namespace EasyIO {
	public partial class UI {
		public static void ConsoleWindowLog (string input) {
			Log.Add(input);
			if (Log.Count > Pwidth - 3) {
				Log.RemoveAt(0);
			}	
			string outp = "";
			for (int i = 0; i < Plength-3; i++) {
					outp += " ";
			}
			int x = Pwidth-2;
			foreach (string items in Log) {
				Console.SetCursorPosition(2,x);
				Console.Write(outp);
				x--;
			}
			outp = "";
			for (int i = 0; i < Plength-4; i++) {
					outp += " ";
			}
			Console.SetCursorPosition(3, Pwidth - 1);
			Console.WriteLine(outp);
			
			string outp1 = "";
			x = Pwidth-2;
			foreach (string items in Log) {
				Console.SetCursorPosition(2,x);
				Console.Write(outp);
				x--;			
			}			
			x = Pwidth-2;
			Console.WriteLine(outp1);
			Log.Reverse();
			foreach (string items in Log) {
				Console.SetCursorPosition(2, x);
				Console.Write(items);
				x--;
			}
			Log.Reverse();
		}
	}
}