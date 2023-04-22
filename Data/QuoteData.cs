namespace StupidCommentsInYourPocket.Data
{
	public readonly struct QuoteData
	{
		public string Quote { get; }
		public Character Character { get; }

		public QuoteData(string quote, Character character)
		{
			Quote = quote;
			Character = character;
		}
	}

	public enum Character
	{
		None = 0,
		Johnny = 1,
		Lisa = 2,
		Mark = 3,
		Denny = 4,
		Claudette = 5,
		Michelle = 6,
		Peter = 7,
		Mike = 8,
		Steven = 9,
		ChrisR = 10
	}
}