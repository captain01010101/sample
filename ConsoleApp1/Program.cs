using System.Linq;

string sentence = "Hello, World! The world we live in is Earth. Say hello whenever on world.";
sentence = sentence.Replace(",", "").Replace("!", "").ToLower();
var words = sentence.Split(' ');

// used new C# syntax for instantiating the dictionary object
Dictionary<string, int> dictionary = new();
foreach (var word in words)
{
    int numberOfOccurances = 0;
    foreach (var nestedWord in words)
    {
        if (nestedWord == word)
        {
            numberOfOccurances++;   
        }
    }
    dictionary[word] = numberOfOccurances;
}
dictionary = dictionary.OrderByDescending(pair => pair.Value).ToDictionary(x => x.Key, y => y.Value);

Console.WriteLine($"Sentence: {sentence}");
Console.WriteLine(String.Concat("Word with the most occurances: " + dictionary.ElementAt(0).Key));
Console.WriteLine(String.Concat("Word with the second most occurances: " + dictionary.ElementAt(1).Key));