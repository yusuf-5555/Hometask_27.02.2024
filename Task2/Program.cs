List<string> words = new List<string>{ "hello", "world", "!" };
string concat = string.Join("",words.ToArray());
Console.WriteLine("The concatenated string is: " + concat);
