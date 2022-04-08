using System;
using System.IO;
using static System.IO.File;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace EasyIO
{
    public partial class Converter
    {
        public static List<List<char>> ToList (char[,] input)
        {

            List < List<char> > output = new List<List<char>> ();

           int W = input.GetLength (0);
            int L = input.GetLength (1);    

            for (int i = 0; i < W; i++)
            {
                for (int j = 0; j < L; j++)
                {
                    output[W][L] = input [i, j];
                }
            }
            return output;
        }
    }
}