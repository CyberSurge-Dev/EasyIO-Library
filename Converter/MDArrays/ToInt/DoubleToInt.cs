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
        public static int[,] ToInt(double[,] input)
        {
            int width = input.GetLength(0);
            int length = input.GetLength(1);

            int[,] output = new int[width, length];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    output[i, j] = Convert.ToInt32(input[i, j]);
                }
            }
            return output;
        }
    }
}