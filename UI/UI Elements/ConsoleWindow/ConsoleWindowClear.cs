using System;
using System.Collections.Generic;

namespace EasyIO {
	public partial class UI {
		public static void ConsoleWindowClear() {
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
			Log.Clear();
		}
	}
}