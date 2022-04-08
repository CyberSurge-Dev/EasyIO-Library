using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace EasyIO {
	public partial class IO {
		public static string Table(
		string[,] list, 
		string intersection = "+", 
		string row = "-", 
		string colum = "|", 
		int cousionside = 1, 
		int cousiontop = 0, 
		bool center = false
		) {
	    //public static string Table(string[,] list, string intersection = "+", string row = "-", string colum = "|", int cousionside = 1, int cousiontop = 0){
	    //TABLE VARS
	    //TABLE VARS
			//Sets the sizeof each colum
	    int width = list.GetLength(0);
	    int length = list.GetLength(1);
			//create lists to find the longest values in each row
	    string[] strlng = new string[width];
	    int[] Coulumsize = new int[length];
			//base variables for loops
	    int f, i, c, r = 0;
	    for (i = 0; i < length; i++) {
	      //add each item in row to a list to find the longest for that colum
				for (f = 0; f < width; f++) {
	        strlng[f] = list[f, i];
	      }
				//store that colums size in this list for future referance
	      Coulumsize[i] = IO.Longest(strlng).Length;
	    }
	    //Console.WriteLine(IO.List(2, IO.IntToStringlst(Coulumsize)));
	    //Draw cells
	    string output = string.Empty;
	    //top of Cell
			//Main loop to draw each row 1 at a time
	    for (r = 0; r < width; r++) {
	      output += "\n";
				//For each colum draw the top row
	      for (i = 0; i < length; i++) {
	        output += intersection;
					//While under colum size fill with designated row symbol \/
	        for (f = 0; f < Coulumsize[i] + (cousionside * 2); f++) {
	          //Console.WriteLine("Coulumsize: " + i + " - " + Coulumsize[i]);
	          //Console.WriteLine("coulumsize + cousion: " + Coulumsize[i] + (cousionside *2));
	          output += row;
	        }
	      }
	      output += intersection;
	      //Cousion top
	      for (c = 0; c < cousiontop; c++) {
	        output += "\n";
	        for (i = 0; i < length; i++) {
	          output += colum;
	          for (f = 0; f < Coulumsize[i] + cousionside * 2; f++) {
	            output += " ";
	          }
	        }
	        output += colum;
	      }
	      //Text Portion
	      //Draw row
	      output += "\n";
	      for (c = 0; c < length; c++) {
	        output += colum;
					if (center == false) {
		        for (f = 0; f < cousionside; f++) {
		          output += " ";
		        }
		        output += list[r, c];
						//loop fills in blank space in table if not centered 
		        for (int x = list[r, c].Length + cousionside; x < Coulumsize[c] + cousionside * 2; x++) {
		          output += " ";
		        }
					} else if (center == true) {
						//output += colum;
						output += Center(list[r,c], ((cousionside*2)+Coulumsize[c]));
					}
	      }
	      output += colum;
	      //Cousion bottom
	      for (c = 0; c < cousiontop; c++) {
	        output += "\n";
	        for (i = 0; i < length; i++) {
	          output += colum;
	          for (f = 0; f < Coulumsize[i] + cousionside * 2; f++) {
	            output += " ";
	          }
	        }
	        output += colum;
	      }
	    }
	    //Draw bottom row
	    output += "\n";
	    for (i = 0; i < length; i++) {
	      output += intersection;
	      for (f = 0; f < Coulumsize[i] + cousionside * 2; f++) {
	        output += row;
	      }
	    }
	    output += intersection;
	    return output;
	  }
	}
}