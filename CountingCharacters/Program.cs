// See https://aka.ms/new-console-template for more information

Dictionary<char, int> characters = new Dictionary<char, int>();

string test = "hello";

foreach (char letter in test)
{
    int count = 0;

    if (!characters.ContainsKey(letter))
    {
        count++;
        characters.Add(letter, count);
    }
    else
    {
        characters[letter] = characters[letter] + 1;
    }
}

foreach (KeyValuePair<char, int> character in characters)
{
    Console.WriteLine(character.Key + ": " + character.Value);
}