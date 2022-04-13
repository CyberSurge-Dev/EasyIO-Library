namespace EasyIO {
	public partial class Files {
		public partial class Create {
			public static void File (string dir, string name) {
				System.IO.Directory.CreateDirectory(dir);
				dir = System.IO.Path.Combine(dir, name);
				if (!System.IO.File.Exists(dir))
        {
          System.IO.File.Create(dir);
        }
      }
		}
	}
}