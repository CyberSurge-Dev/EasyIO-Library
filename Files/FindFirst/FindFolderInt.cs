using System.IO;
using System.Collections.Generic;
namespace EasyIO {
	public partial class Files {
		public partial class FindFirst {
			public static int? GetLineNum (string @filename, string input) {
				List<string> current = new List<string>();
				int i = 1;
				foreach (var line in File.ReadAllLines(filename))
				{
				  if (line.Contains(input)) {
				    current.Add(line);
						break;
					}
					i++;
				}
				try {
					return i;
				} catch (System.Exception) {
					return null;
				}
			}
		}
	}
}