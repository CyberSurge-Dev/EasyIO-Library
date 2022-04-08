using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace EasyIO {
	public partial class IO {
		public static string Brackets(int offset = 0, params string[] Text) {
	    System.ConsoleColor ogColor = System.Console.ForegroundColor;
	    Console.ForegroundColor = ogColor;
	    try {
	      string longest = Text[0];
	      foreach(string s in Text) {
	        if (s.Length > longest.Length) {
	          longest = s;
	        }
	      }
	      int length = longest.Length;
	      string Brackets = "";
	      for (int i = 0; i < length; i++) {
	        Brackets += "-";
	      }
	      for (int f = 0; f < offset; f++) {
	        Brackets += "-";
	      }
	      string returnstr = "";
	      int j = 0;
	      returnstr += " " + Brackets + "\n ";
	      foreach(string items in Text) {
	        Text[j] += "\n ";
	        returnstr += Text[j];
	        j++;
	      }
	      returnstr += Brackets;
	      return returnstr;
	    } catch (Exception) {
	      return "Invalid Input";
	    }
	  }
		//=================================
		//-----+----------+----------+-----
		//=================================
		public static string Brackets(List < string > inputlst, int offset = 0) {
	    System.ConsoleColor ogColor = System.Console.ForegroundColor;
	    Console.ForegroundColor = ogColor;
	    try {
	      string[] Text = inputlst.ToArray();
	      string longest = Text[0];
	      foreach(string s in Text) {
	        if (s.Length > longest.Length) {
	          longest = s;
	        }
	      }
	      int length = longest.Length;
	      string Brackets = "";
	      for (int i = 0; i < length; i++) {
	        Brackets += "-";
	      }
	      for (int f = 0; f < offset; f++) {
	        Brackets += "-";
	      }
	      string returnstr = "";
	      int j = 0;
	      returnstr += " " + Brackets + "\n ";
	      foreach(string items in Text) {
	        Text[j] += "\n ";
	        returnstr += Text[j];
	        j++;
	      }
	      returnstr += Brackets;
	      return returnstr;
	    } catch (Exception) {
	      return "Invalid Input";
	    }
	  }
	}
}