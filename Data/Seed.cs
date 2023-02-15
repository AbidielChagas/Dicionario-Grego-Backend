using System;
using System.Text.Json;

namespace api.Data
{
    public class Seed
    {
       public static async Task SeedWords(DataContext context)
       {
            if (await context.Words.AnyAsync()) return;

            var wordData = await File.ReadAllTextAsync(@"C:\Dicionario-Grego-Backend\Data\Data.json");

            var options = new JsonSerializerOptions{PropertyNameCaseInsensitive = true};

            var wordsToload = JsonSerializer.Deserialize<List<Word>>(wordData);

            foreach (var word in wordsToload){
                context.Words.Add(word);
            }

            await context.SaveChangesAsync();
       }
    }
}