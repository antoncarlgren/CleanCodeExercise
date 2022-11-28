namespace WebsiteGenerator.DataReader
{
	internal class FileReader : IDataReader
	{
		public async Task<string> GetString(string source)
		{
			return await File.ReadAllTextAsync(source);
		}

		public async Task<IEnumerable<string>> GetStringArray(string source)
		{
			return await File.ReadAllLinesAsync(source);
		}
	}
}