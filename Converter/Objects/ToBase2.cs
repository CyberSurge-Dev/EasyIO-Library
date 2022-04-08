using System;

namespace EasyIO {
	public partial class Converter {
		public static string ToBase2(int n, bool rtnfull = false)
    {
      char[] b = new char[32];
      int pos = 31;
      int i = 0;

      while (i < 32)
      {
      	if ((n & (1 << i)) != 0)
        {
      	  b[pos] = '1';
       	}
        else
				{
        	b[pos] = '0';
        }
        pos--;
        i++;
      }
			string output = new string(b);
			if (rtnfull == false) {
				while (output[0] == '0') {
					output = output.TrimStart('0');
				}
			}
      return output;
    }
	}
}