// See https://aka.ms/new-console-template for more information
using System.Linq;

string sentence = "Hello, World! The world we live in is Earth. Say hello whenever on world.";
var words = sentence.Split(' ');

Dictionary<string, int> dictionary = new Dictionary<string, int>();
foreach (var orginalWord in words)
{
    var lowercaseOrginalWord = orginalWord.ToLower().Replace(",", "").Replace("!", "");
    int numberOfOccurances = 0;
    foreach (var word in words)
    {
        var lowercaseWord = word.ToLower().Replace(",", "").Replace("!", "");
        if (lowercaseWord == lowercaseOrginalWord)
        {
            numberOfOccurances++;   
        }
    }
    dictionary[lowercaseOrginalWord] = numberOfOccurances;
}
dictionary = dictionary.OrderByDescending(pair => pair.Value).ToDictionary(x => x.Key, y => y.Value);
Console.WriteLine($"Sentence: {sentence}");
Console.WriteLine(String.Concat("Word with the most occurances: " + dictionary.ElementAt(0).Key));
Console.WriteLine(String.Concat("Word with the second most occurances: " + dictionary.ElementAt(1).Key));