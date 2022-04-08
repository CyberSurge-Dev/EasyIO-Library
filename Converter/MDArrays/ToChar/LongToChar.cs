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
        public static char[,] ToChar(long[,] input)
        {
            int width = input.GetLength(0);
            int length = input.GetLength(1);

            char[,] output = new char[width, length];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    output[i, j] = Convert.ToChar(Convert.ToString(input[i, j])[0]);
                }
            }
            return output;
        }
    }
}