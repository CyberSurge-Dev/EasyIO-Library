using System;
using System.IO.Compression;
using System.IO;
namespace EasyIO {
	public partial class Files {
		public static void Zip (string dir, string edir = "", string name = "") {
			if (edir == "") {
				edir = dir;
			}
			if (name == "") {
				name = "EasyIOZip"+ DateTime.Now.ToString("ddMMyyyy-HHmmssfffff") + ".zip";
			}
			else {
				name += ".zip";
			}
			edir += "/" + name;
			ZipFile.CreateFromDirectory(dir, edir);
		}
	}
}