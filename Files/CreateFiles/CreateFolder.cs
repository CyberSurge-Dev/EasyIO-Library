namespace EasyIO {
	public partial class Files {
		public partial class Create {
			public static void Folder (string dir, string name) {
				string pathString = System.IO.Path.Combine(dir, name);
				System.IO.Directory.CreateDirectory(pathString);
			}
		}
	}
}