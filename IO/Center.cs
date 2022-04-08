using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace EasyIO {
	public partial class IO {
		public static string Center(string text, int newWidth, string filler = " ")
    {
        int length = text.Length;
        int charactersToPad = newWidth - length;
        if (charactersToPad < 0) throw new ArgumentException("New width must be greater than string length.", "newWidth");
        int padLeft = charactersToPad/2 + charactersToPad%2;
        //add a space to the left if the string is an odd number
        int padRight = charactersToPad/2;

        StringBuilder resultBuilder = new StringBuilder(newWidth);
        for (int i = 0; i < padLeft; i++) resultBuilder.Insert(i, filler); 
        for (int i = 0; i < length; i++) resultBuilder.Insert(i + padLeft, text[i]); 
        for (int i = newWidth - padRight; i < newWidth; i++) resultBuilder.Insert(i, filler);
        return resultBuilder.ToString();
    }
	}
}