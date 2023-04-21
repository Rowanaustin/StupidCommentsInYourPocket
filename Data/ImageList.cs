namespace StupidCommentsInYourPocket.Data
{
	public class ImageList
	{
		public readonly Dictionary<Character, string> ImageDict;

		private static string _folder = "Images/";
		public ImageList()
		{
			ImageDict = new Dictionary<Character, string>
			{
				{ Character.None, _folder + "Default.png" },
				{ Character.Johnny, _folder + "Johnny.png" },
				{ Character.Lisa, _folder + "Lisa.png" },
				{ Character.Mark, _folder + "Mark.png" },
				{ Character.Denny, _folder + "Denny.png" },
				{ Character.Claudette, _folder + "Claudette.png" },
				{ Character.Michelle, _folder + "Michelle.png" },
				{ Character.Peter, _folder + "Peter.png" },
				{ Character.Mike, _folder + "Mike.png" },
				{ Character.Steven, _folder + "Steven.png" },
			};
		}
	}
}
