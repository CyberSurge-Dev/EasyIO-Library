namespace EasyIO {
	public partial class UI {
		public (string, int, int) ConsoleWindow (int length, int width, string row = "-", string colum = "|", string intersection = "+") {
			Plength = length;
			Pwidth = width;
			
			string output = "";
			output += intersection;
			for (int i = 0; i < length-2; i++) {
				output += row;
			}
			output += intersection;
			for (int i = 0; i < width-3; i++) {
				output += "\n" + colum;
				for (int l = 0; l < length-2; l++) {
					output += " ";
				}
				output += colum;
			}
			output += "\n| >";
			for (int i = 0; i < length-4; i++) {
				output += " ";
			}
			output += colum;
			output += "\n" + intersection;
			for (int i = 0; i < length-2; i++) {
				output += row;
			}
			output += intersection;
			int x = 4;
			int y = width - 1;
			return (output, x, y);
		}
	}
}