List<string> words = new List<string>{ "hello", "world", "apple"};
words.Remove("world");
foreach (var item in words)
{
    System.Console.WriteLine(item);
}