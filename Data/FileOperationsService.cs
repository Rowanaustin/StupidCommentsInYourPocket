namespace StupidCommentsInYourPocket.Data
{
	public class FileOperationsService
	{
		private static string quotesFile = "wwwroot/quotes.txt";

		public QuoteData GetRandomQuote()
		{
			if (!FileExists(quotesFile))
				return new QuoteData("No Quotes", Character.None);

			var fileData = ReadLines(quotesFile);

			if (fileData.Length == 0)
				return new QuoteData("No Quotes", Character.None);

			Random r = new();

			var line = fileData[r.Next(fileData.Length)];
			
			var parts = line.Split("++");
			if (parts.Length != 2)
			{
				var bit = "";
				if (parts.Length == 1)
					bit = parts[0];
				return new QuoteData("Couldn't parse line - has " + parts.Length + " parts (" + bit + ")", Character.None);
			}

			var quote = parts[0];
			var character = GetCharacter(parts[1]);

			return new QuoteData(quote, character);
		}

		private Character GetCharacter(string character)
		{
			if (Enum.TryParse<Character>(character, true, out var result))
				return result;

			return Character.None;
		}

		private bool FileExists(string fileName)
		{
			return File.Exists(fileName);
		}

		private string[] ReadLines(string filename)
		{
			return ReadFile(filename).Split("\n");
		}

		private string ReadFile(string filename)
		{
			return File.ReadAllText(filename);
		}
	}
}
